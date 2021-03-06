// ===========
// DO NOT EDIT - this file is automatically regenerated.
// ===========

using Improbable.Gdk.Core;
using Improbable.Worker.Core;
using System;
using System.Collections.Generic;
using Unity.Entities;

namespace Improbable.Gdk.Tests.AlternateSchemaSyntax
{
    public partial class Connection
    {
        public const uint ComponentId = 1105;

        public struct Component : IComponentData, ISpatialComponentData
        {
            public uint ComponentId => 1105;

            // Bit masks for tracking which component properties were changed locally and need to be synced.
            // Each byte tracks 8 component properties.
            private byte dirtyBits0;

            public bool IsDataDirty()
            {
                var isDataDirty = false;
                isDataDirty |= (dirtyBits0 != 0x0);
                return isDataDirty;
            }

            /*
            The propertyIndex argument counts up from 0 in the order defined in your schema component.
            It is not the schema field number itself. For example:
            component MyComponent
            {
                id = 1337;
                bool val_a = 1;
                bool val_b = 3;
            }
            In that case, val_a corresponds to propertyIndex 0 and val_b corresponds to propertyIndex 1 in this method.
            This method throws an InvalidOperationException in case your component doesn't contain properties.
            */
            public bool IsDataDirty(int propertyIndex)
            {
                throw new InvalidOperationException("IsDataDirty(int propertyIndex) may not be called on components with no properties.");
            }

            // Like the IsDataDirty() method above, the propertyIndex arguments starts counting from 0.
            // This method throws an InvalidOperationException in case your component doesn't contain properties.
            public void MarkDataDirty(int propertyIndex)
            {
                throw new InvalidOperationException("MarkDataDirty(int propertyIndex) may not be called on components with no properties.");
            }

            public void MarkDataClean()
            {
                dirtyBits0 = 0x0;
            }

            public static global::Improbable.Worker.Core.ComponentData CreateSchemaComponentData(
            )
            {
                var schemaComponentData = new global::Improbable.Worker.Core.SchemaComponentData(1105);
                var obj = schemaComponentData.GetFields();
                return new global::Improbable.Worker.Core.ComponentData(schemaComponentData);
            }
        }

        public struct Snapshot : ISpatialComponentSnapshot
        {
            public uint ComponentId => 1105;

        }

        public static class Serialization
        {
            public static void SerializeUpdate(Improbable.Gdk.Tests.AlternateSchemaSyntax.Connection.Component component, global::Improbable.Worker.Core.SchemaComponentUpdate updateObj)
            {
                var obj = updateObj.GetFields();
            }

            public static Improbable.Gdk.Tests.AlternateSchemaSyntax.Connection.Component Deserialize(global::Improbable.Worker.Core.SchemaObject obj, global::Unity.Entities.World world)
            {
                var component = new Improbable.Gdk.Tests.AlternateSchemaSyntax.Connection.Component();

                return component;
            }

            public static Improbable.Gdk.Tests.AlternateSchemaSyntax.Connection.Update DeserializeUpdate(global::Improbable.Worker.Core.SchemaComponentUpdate updateObj)
            {
                var update = new Improbable.Gdk.Tests.AlternateSchemaSyntax.Connection.Update();
                var obj = updateObj.GetFields();

                return update;
            }

            public static Improbable.Gdk.Tests.AlternateSchemaSyntax.Connection.Snapshot DeserializeSnapshot(global::Improbable.Worker.Core.SchemaObject obj, global::Unity.Entities.World world)
            {
                var component = new Improbable.Gdk.Tests.AlternateSchemaSyntax.Connection.Snapshot();

                return component;
            }

            public static void ApplyUpdate(global::Improbable.Worker.Core.SchemaComponentUpdate updateObj, ref Improbable.Gdk.Tests.AlternateSchemaSyntax.Connection.Component component)
            {
                var obj = updateObj.GetFields();

            }
        }

        public struct Update : ISpatialComponentUpdate
        {
            internal static Stack<List<Update>> Pool = new Stack<List<Update>>();

        }

        public struct ReceivedUpdates : IComponentData
        {
            internal uint handle;
            public global::System.Collections.Generic.List<Update> Updates
            {
                get => Improbable.Gdk.Tests.AlternateSchemaSyntax.Connection.ReferenceTypeProviders.UpdatesProvider.Get(handle);
            }
        }

        internal class ConnectionDynamic : IDynamicInvokable
        {
            public uint ComponentId => Connection.ComponentId;

            private static Component DeserializeData(ComponentData data, World world)
            {
                var schemaDataOpt = data.SchemaData;
                if (!schemaDataOpt.HasValue)
                {
                    throw new ArgumentException($"Can not deserialize an empty {nameof(ComponentData)}");
                }

                return Serialization.Deserialize(schemaDataOpt.Value.GetFields(), world);
            }

            private static Update DeserializeUpdate(ComponentUpdate update, World world)
            {
                var schemaDataOpt = update.SchemaData;
                if (!schemaDataOpt.HasValue)
                {
                    throw new ArgumentException($"Can not deserialize an empty {nameof(ComponentUpdate)}");
                }

                return Serialization.DeserializeUpdate(schemaDataOpt.Value);
            }

            private static Snapshot DeserializeSnapshot(ComponentData snapshot, World world)
            {
                var schemaDataOpt = snapshot.SchemaData;
                if (!schemaDataOpt.HasValue)
                {
                    throw new ArgumentException($"Can not deserialize an empty {nameof(ComponentData)}");
                }

                return Serialization.DeserializeSnapshot(schemaDataOpt.Value.GetFields(), world);
            }

            public void InvokeHandler(Dynamic.IHandler handler)
            {
                handler.Accept<Component, Update>(Connection.ComponentId, DeserializeData, DeserializeUpdate);
            }

            public void InvokeSnapshotHandler(DynamicSnapshot.ISnapshotHandler handler)
            {
                handler.Accept<Snapshot>(Connection.ComponentId, DeserializeSnapshot);
            }
        }
    }
}
