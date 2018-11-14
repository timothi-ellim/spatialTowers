// ===========
// DO NOT EDIT - this file is automatically regenerated.
// ===========

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Profiling;
using Unity.Mathematics;
using Unity.Entities;
using Unity.Collections;
using Improbable.Worker.Core;
using Improbable.Gdk.Core;
using Improbable.Gdk.Core.CodegenAdapters;
using Improbable.Gdk.Core.Commands;

namespace Improbable.Gdk.Tests
{
    public partial class ExhaustiveMapKey
    {
        internal class DispatcherHandler : ComponentDispatcherHandler
        {
            public override uint ComponentId => 197719;

            private readonly EntityManager entityManager;

            private const string LoggerName = "ExhaustiveMapKey.DispatcherHandler";


            public DispatcherHandler(WorkerSystem worker, World world) : base(worker, world)
            {
                entityManager = world.GetOrCreateManager<EntityManager>();
                var bookkeepingSystem = world.GetOrCreateManager<CommandRequestTrackerSystem>();
            }

            public override void Dispose()
            {
                ExhaustiveMapKey.ReferenceTypeProviders.UpdatesProvider.CleanDataInWorld(World);

                ExhaustiveMapKey.ReferenceTypeProviders.Field1Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field2Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field3Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field4Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field5Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field6Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field7Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field8Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field9Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field10Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field11Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field12Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field13Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field14Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field15Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field16Provider.CleanDataInWorld(World);
                ExhaustiveMapKey.ReferenceTypeProviders.Field17Provider.CleanDataInWorld(World);
            }

            public override void OnAddComponent(AddComponentOp op)
            {
                var entity = TryGetEntityFromEntityId(op.EntityId);

                Profiler.BeginSample("ExhaustiveMapKey");
                var data = Improbable.Gdk.Tests.ExhaustiveMapKey.Serialization.Deserialize(op.Data.SchemaData.Value.GetFields(), World);
                data.MarkDataClean();
                entityManager.AddComponentData(entity, data);
                entityManager.AddComponent(entity, ComponentType.Create<NotAuthoritative<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>());

                var update = new Improbable.Gdk.Tests.ExhaustiveMapKey.Update
                {
                    Field1 = data.Field1,
                    Field2 = data.Field2,
                    Field3 = data.Field3,
                    Field4 = data.Field4,
                    Field5 = data.Field5,
                    Field6 = data.Field6,
                    Field7 = data.Field7,
                    Field8 = data.Field8,
                    Field9 = data.Field9,
                    Field10 = data.Field10,
                    Field11 = data.Field11,
                    Field12 = data.Field12,
                    Field13 = data.Field13,
                    Field14 = data.Field14,
                    Field15 = data.Field15,
                    Field16 = data.Field16,
                    Field17 = data.Field17,
                };

                var updates = new List<Improbable.Gdk.Tests.ExhaustiveMapKey.Update>
                {
                    update
                };

                var updatesComponent = new Improbable.Gdk.Tests.ExhaustiveMapKey.ReceivedUpdates
                {
                    handle = ReferenceTypeProviders.UpdatesProvider.Allocate(World)
                };

                ReferenceTypeProviders.UpdatesProvider.Set(updatesComponent.handle, updates);
                entityManager.AddComponentData(entity, updatesComponent);

                if (entityManager.HasComponent<ComponentRemoved<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity))
                {
                    entityManager.RemoveComponent<ComponentRemoved<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity);
                }
                else if (!entityManager.HasComponent<ComponentAdded<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity))
                {
                    entityManager.AddComponent(entity, ComponentType.Create<ComponentAdded<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>());
                }
                else
                {
                    LogDispatcher.HandleLog(LogType.Error, new LogEvent(ReceivedDuplicateComponentAdded)
                        .WithField(LoggingUtils.LoggerName, LoggerName)
                        .WithField(LoggingUtils.EntityId, op.EntityId.Id)
                        .WithField("Component", "Improbable.Gdk.Tests.ExhaustiveMapKey")
                    );
                }

                Profiler.EndSample();
            }

            public override void OnRemoveComponent(RemoveComponentOp op)
            {
                var entity = TryGetEntityFromEntityId(op.EntityId);

                Profiler.BeginSample("ExhaustiveMapKey");

                var data = entityManager.GetComponentData<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>(entity);
                ExhaustiveMapKey.ReferenceTypeProviders.Field1Provider.Free(data.field1Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field2Provider.Free(data.field2Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field3Provider.Free(data.field3Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field4Provider.Free(data.field4Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field5Provider.Free(data.field5Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field6Provider.Free(data.field6Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field7Provider.Free(data.field7Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field8Provider.Free(data.field8Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field9Provider.Free(data.field9Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field10Provider.Free(data.field10Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field11Provider.Free(data.field11Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field12Provider.Free(data.field12Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field13Provider.Free(data.field13Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field14Provider.Free(data.field14Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field15Provider.Free(data.field15Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field16Provider.Free(data.field16Handle);
                ExhaustiveMapKey.ReferenceTypeProviders.Field17Provider.Free(data.field17Handle);

                entityManager.RemoveComponent<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>(entity);

                if (entityManager.HasComponent<ComponentAdded<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity))
                {
                    entityManager.RemoveComponent<ComponentAdded<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity);
                }
                else if (!entityManager.HasComponent<ComponentRemoved<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity))
                {
                    entityManager.AddComponent(entity, ComponentType.Create<ComponentRemoved<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>());
                }
                else
                {
                    LogDispatcher.HandleLog(LogType.Error, new LogEvent(ReceivedDuplicateComponentRemoved)
                        .WithField(LoggingUtils.LoggerName, LoggerName)
                        .WithField(LoggingUtils.EntityId, op.EntityId.Id)
                        .WithField("Component", "Improbable.Gdk.Tests.ExhaustiveMapKey")
                    );
                }

                Profiler.EndSample();
            }

            public override void OnComponentUpdate(ComponentUpdateOp op)
            {
                var entity = TryGetEntityFromEntityId(op.EntityId);

                Profiler.BeginSample("ExhaustiveMapKey");
                if (entityManager.HasComponent<NotAuthoritative<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity))
                {
                    var data = entityManager.GetComponentData<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>(entity);
                    Improbable.Gdk.Tests.ExhaustiveMapKey.Serialization.ApplyUpdate(op.Update.SchemaData.Value, ref data);
                    data.MarkDataClean();
                    entityManager.SetComponentData(entity, data);
                }

                var update = Improbable.Gdk.Tests.ExhaustiveMapKey.Serialization.DeserializeUpdate(op.Update.SchemaData.Value);

                List<Improbable.Gdk.Tests.ExhaustiveMapKey.Update> updates;
                if (entityManager.HasComponent<Improbable.Gdk.Tests.ExhaustiveMapKey.ReceivedUpdates>(entity))
                {
                    updates = entityManager.GetComponentData<Improbable.Gdk.Tests.ExhaustiveMapKey.ReceivedUpdates>(entity).Updates;
                }
                else
                {
                    updates = Improbable.Gdk.Tests.ExhaustiveMapKey.Update.Pool.Count > 0 ? Improbable.Gdk.Tests.ExhaustiveMapKey.Update.Pool.Pop() : new List<Improbable.Gdk.Tests.ExhaustiveMapKey.Update>();
                    var updatesComponent = new Improbable.Gdk.Tests.ExhaustiveMapKey.ReceivedUpdates
                    {
                        handle = ReferenceTypeProviders.UpdatesProvider.Allocate(World)
                    };
                    ReferenceTypeProviders.UpdatesProvider.Set(updatesComponent.handle, updates);
                    entityManager.AddComponentData(entity, updatesComponent);
                }

                updates.Add(update);

                Profiler.EndSample();
            }

            public override void OnAuthorityChange(AuthorityChangeOp op)
            {
                var entity = TryGetEntityFromEntityId(op.EntityId);

                Profiler.BeginSample("ExhaustiveMapKey");
                ApplyAuthorityChange(entity, op.Authority, op.EntityId);
                Profiler.EndSample();
            }

            public override void OnCommandRequest(CommandRequestOp op)
            {
                var commandIndex = op.Request.SchemaData.Value.GetCommandIndex();
                throw new UnknownCommandIndexException(commandIndex, "ExhaustiveMapKey");
            }

            public override void OnCommandResponse(CommandResponseOp op)
            {
                var commandIndex = op.Response.CommandIndex;
                throw new UnknownCommandIndexException(commandIndex, "ExhaustiveMapKey");
            }

            public override void AddCommandComponents(Unity.Entities.Entity entity)
            {
            }

            private void ApplyAuthorityChange(Unity.Entities.Entity entity, Authority authority, global::Improbable.Worker.EntityId entityId)
            {
                switch (authority)
                {
                    case Authority.Authoritative:
                        if (!entityManager.HasComponent<NotAuthoritative<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity))
                        {
                            LogInvalidAuthorityTransition(Authority.Authoritative, Authority.NotAuthoritative, entityId);
                            return;
                        }

                        entityManager.RemoveComponent<NotAuthoritative<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity);
                        entityManager.AddComponent(entity, ComponentType.Create<Authoritative<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>());

                        // Add event senders
                        break;
                    case Authority.AuthorityLossImminent:
                        if (!entityManager.HasComponent<Authoritative<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity))
                        {
                            LogInvalidAuthorityTransition(Authority.AuthorityLossImminent, Authority.Authoritative, entityId);
                            return;
                        }

                        entityManager.AddComponent(entity, ComponentType.Create<AuthorityLossImminent<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>());
                        break;
                    case Authority.NotAuthoritative:
                        if (!entityManager.HasComponent<Authoritative<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity))
                        {
                            LogInvalidAuthorityTransition(Authority.NotAuthoritative, Authority.Authoritative, entityId);
                            return;
                        }

                        if (entityManager.HasComponent<AuthorityLossImminent<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity))
                        {
                            entityManager.RemoveComponent<AuthorityLossImminent<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity);
                        }

                        entityManager.RemoveComponent<Authoritative<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity);
                        entityManager.AddComponent(entity, ComponentType.Create<NotAuthoritative<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>());

                        // Remove event senders
                        break;
                }

                List<Authority> authorityChanges;
                if (entityManager.HasComponent<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity))
                {
                    authorityChanges = entityManager.GetComponentData<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entity).Changes;

                }
                else
                {
                    var changes = new AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>
                    {
                        Handle = AuthorityChangesProvider.Allocate(World)
                    };
                    AuthorityChangesProvider.Set(changes.Handle, new List<Authority>());
                    authorityChanges = changes.Changes;
                    entityManager.AddComponentData(entity, changes);
                }

                authorityChanges.Add(authority);
            }

            private void LogInvalidAuthorityTransition(Authority newAuthority, Authority expectedOldAuthority, global::Improbable.Worker.EntityId entityId)
            {
                LogDispatcher.HandleLog(LogType.Error, new LogEvent(InvalidAuthorityChange)
                    .WithField(LoggingUtils.LoggerName, LoggerName)
                    .WithField(LoggingUtils.EntityId, entityId.Id)
                    .WithField("New Authority", newAuthority)
                    .WithField("Expected Old Authority", expectedOldAuthority)
                    .WithField("Component", "Improbable.Gdk.Tests.ExhaustiveMapKey")
                );
            }
        }

        internal class ComponentReplicator : ComponentReplicationHandler
        {
            public override uint ComponentId => 197719;

            public override EntityArchetypeQuery ComponentUpdateQuery => new EntityArchetypeQuery
            {
                All = new[]
                {
                    ComponentType.Create<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>(),
                    ComponentType.ReadOnly<Authoritative<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(),
                    ComponentType.ReadOnly<SpatialEntityId>()
                },
                Any = Array.Empty<ComponentType>(),
                None = Array.Empty<ComponentType>(),
            };

            public override EntityArchetypeQuery[] CommandQueries => new EntityArchetypeQuery[]
            {
            };


            public ComponentReplicator(EntityManager entityManager, Unity.Entities.World world) : base(entityManager)
            {
                var bookkeepingSystem = world.GetOrCreateManager<CommandRequestTrackerSystem>();
            }

            public override void ExecuteReplication(ComponentGroup replicationGroup, ComponentSystemBase system, global::Improbable.Worker.Core.Connection connection)
            {
                Profiler.BeginSample("ExhaustiveMapKey");

                var chunkArray = replicationGroup.CreateArchetypeChunkArray(Allocator.TempJob);
                var spatialOSEntityType = system.GetArchetypeChunkComponentType<SpatialEntityId>(true);
                var componentType = system.GetArchetypeChunkComponentType<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>();
                foreach (var chunk in chunkArray)
                {
                    var entityIdArray = chunk.GetNativeArray(spatialOSEntityType);
                    var componentArray = chunk.GetNativeArray(componentType);
                    for (var i = 0; i < componentArray.Length; i++)
                    {
                        var data = componentArray[i];
                        var eventsToSend = 0;

                        if (data.IsDataDirty() || eventsToSend > 0)
                        {
                            var update = new global::Improbable.Worker.Core.SchemaComponentUpdate(197719);
                            Improbable.Gdk.Tests.ExhaustiveMapKey.Serialization.SerializeUpdate(data, update);

                            // Send serialized update over the wire
                            connection.SendComponentUpdate(entityIdArray[i].EntityId, new global::Improbable.Worker.Core.ComponentUpdate(update));

                            data.MarkDataClean();
                            componentArray[i] = data;
                        }
                    }
                }

                chunkArray.Dispose();
                Profiler.EndSample();
            }

            public override void SendCommands(ComponentGroup commandGroup, ComponentSystemBase system, global::Improbable.Worker.Core.Connection connection)
            {
            }
        }

        internal class ComponentCleanup : ComponentCleanupHandler
        {
            public override EntityArchetypeQuery CleanupArchetypeQuery => new EntityArchetypeQuery
            {
                All = Array.Empty<ComponentType>(),
                Any = new ComponentType[]
                {
                    ComponentType.Create<ComponentAdded<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(),
                    ComponentType.Create<ComponentRemoved<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(),
                    ComponentType.Create<Improbable.Gdk.Tests.ExhaustiveMapKey.ReceivedUpdates>(),
                    ComponentType.Create<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(),
                },
                None = Array.Empty<ComponentType>(),
            };

            public override void CleanComponents(ComponentGroup group, ComponentSystemBase system,
                EntityCommandBuffer buffer)
            {
                var entityType = system.GetArchetypeChunkEntityType();
                var componentAddedType = system.GetArchetypeChunkComponentType<ComponentAdded<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>();
                var componentRemovedType = system.GetArchetypeChunkComponentType<ComponentRemoved<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>();
                var receivedUpdateType = system.GetArchetypeChunkComponentType<Improbable.Gdk.Tests.ExhaustiveMapKey.ReceivedUpdates>();
                var authorityChangeType = system.GetArchetypeChunkComponentType<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>();

                var chunkArray = group.CreateArchetypeChunkArray(Allocator.TempJob);

                foreach (var chunk in chunkArray)
                {
                    var entities = chunk.GetNativeArray(entityType);

                    // Updates
                    if (chunk.Has(receivedUpdateType))
                    {
                        var updateArray = chunk.GetNativeArray(receivedUpdateType);
                        for (int i = 0; i < entities.Length; ++i)
                        {
                            buffer.RemoveComponent<Improbable.Gdk.Tests.ExhaustiveMapKey.ReceivedUpdates>(entities[i]);
                            var updateList = updateArray[i].Updates;

                            // Pool update lists to avoid excessive allocation
                            updateList.Clear();
                            Improbable.Gdk.Tests.ExhaustiveMapKey.Update.Pool.Push(updateList);

                            ReferenceTypeProviders.UpdatesProvider.Free(updateArray[i].handle);
                        }
                    }

                    // Component Added
                    if (chunk.Has(componentAddedType))
                    {
                        for (int i = 0; i < entities.Length; ++i)
                        {
                            buffer.RemoveComponent<ComponentAdded<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entities[i]);
                        }
                    }

                    // Component Removed
                    if (chunk.Has(componentRemovedType))
                    {
                        for (int i = 0; i < entities.Length; ++i)
                        {
                            buffer.RemoveComponent<ComponentRemoved<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entities[i]);
                        }
                    }

                    // Authority
                    if (chunk.Has(authorityChangeType))
                    {
                        var authorityChangeArray = chunk.GetNativeArray(authorityChangeType);
                        for (int i = 0; i < entities.Length; ++i)
                        {
                            buffer.RemoveComponent<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(entities[i]);
                            AuthorityChangesProvider.Free(authorityChangeArray[i].Handle);
                        }
                    }

                }

                chunkArray.Dispose();
            }
        }

        internal class AcknowledgeAuthorityLossHandler : AbstractAcknowledgeAuthorityLossHandler
        {
            public override EntityArchetypeQuery Query => new EntityArchetypeQuery
            {
                All = new ComponentType[]
                {
                    ComponentType.ReadOnly<AuthorityLossImminent<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>(),
                    ComponentType.ReadOnly<SpatialEntityId>()
                },
                Any = Array.Empty<ComponentType>(),
                None = Array.Empty<ComponentType>()
            };

            public override void AcknowledgeAuthorityLoss(ComponentGroup group, ComponentSystemBase system,
                Improbable.Worker.Core.Connection connection)
            {
                var authorityLossType = system.GetArchetypeChunkComponentType<AuthorityLossImminent<Improbable.Gdk.Tests.ExhaustiveMapKey.Component>>();
                var spatialEntityType = system.GetArchetypeChunkComponentType<SpatialEntityId>();

                var chunkArray = group.CreateArchetypeChunkArray(Allocator.TempJob);

                foreach (var chunk in chunkArray)
                {
                    var authorityArray = chunk.GetNativeArray(authorityLossType);
                    var spatialEntityIdArray = chunk.GetNativeArray(spatialEntityType);

                    for (int i = 0; i < authorityArray.Length; ++i)
                    {
                        if (authorityArray[i].AcknowledgeAuthorityLoss)
                        {
                            connection.SendAuthorityLossImminentAcknowledgement(spatialEntityIdArray[i].EntityId,
                                197719);
                        }
                    }
                }

                chunkArray.Dispose();
            }
        }
    }
}
