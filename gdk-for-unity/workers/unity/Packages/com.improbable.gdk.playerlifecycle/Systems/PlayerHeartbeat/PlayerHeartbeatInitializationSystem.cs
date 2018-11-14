using System;
using Improbable.Gdk.Core;
using Improbable.PlayerLifecycle;
using Unity.Collections;
using Unity.Entities;

namespace Improbable.Gdk.PlayerLifecycle
{
    [DisableAutoCreation]
    [UpdateInGroup(typeof(SpatialOSUpdateGroup))]
    [UpdateBefore(typeof(HandlePlayerHeartbeatResponseSystem))]
    public class PlayerHeartbeatInitializationSystem : ComponentSystem
    {
        private ComponentGroup initializerGroup;

        protected override void OnCreateManager()
        {
            base.OnCreateManager();

            var initializerQuery = new EntityArchetypeQuery
            {
                All = new[]
                {
                    ComponentType.ReadOnly<PlayerHeartbeatClient.Component>(),
                },
                Any = Array.Empty<ComponentType>(),
                None = new[]
                {
                    ComponentType.Subtractive<HeartbeatData>(),
                },
            };

            initializerGroup = GetComponentGroup(initializerQuery);
        }

        protected override void OnUpdate()
        {
            var entityType = GetArchetypeChunkEntityType();
            var chunkArray = initializerGroup.CreateArchetypeChunkArray(Allocator.TempJob);

            foreach (var chunk in chunkArray)
            {
                var entities = chunk.GetNativeArray(entityType);
                for (int i = 0; i < entities.Length; i++)
                {
                    PostUpdateCommands.AddComponent(entities[i], new HeartbeatData());
                }
            }

            chunkArray.Dispose();
        }
    }
}
