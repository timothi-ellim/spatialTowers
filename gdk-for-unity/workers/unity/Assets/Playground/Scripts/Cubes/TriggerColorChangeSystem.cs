using System;
using Improbable.Gdk.Core;
using Unity.Entities;
using UnityEngine;

#region Diagnostic control

#pragma warning disable 649
// ReSharper disable UnassignedReadonlyField
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global

#endregion

namespace Playground
{
    [UpdateInGroup(typeof(SpatialOSUpdateGroup))]
    public class TriggerColorChangeSystem : ComponentSystem
    {
        private struct CubeColorData
        {
            public readonly int Length;
            public ComponentDataArray<CubeColor.EventSender.ChangeColor> EventSenders;
        }

        [Inject] private CubeColorData cubeColorData;

        private Array colorValues;
        private int colorIndex;
        private float nextColorChange;

        protected override void OnCreateManager()
        {
            base.OnCreateManager();

            colorValues = Enum.GetValues(typeof(Color));
        }

        protected override void OnUpdate()
        {
            if (Time.time < nextColorChange)
            {
                return;
            }

            nextColorChange = Time.time + 2;

            var colorEventData = new ColorData
            {
                Color = (Color) colorValues.GetValue(colorIndex),
            };

            for (var i = 0; i < cubeColorData.Length; i++)
            {
                var eventSender = cubeColorData.EventSenders[i];

                eventSender.Events.Add(colorEventData);
                cubeColorData.EventSenders[i] = eventSender;
            }

            colorIndex = (colorIndex + 1) % colorValues.Length;
        }
    }
}
