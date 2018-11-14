// ===========
// DO NOT EDIT - this file is automatically regenerated.
// ===========

using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Entities;
using UnityEngine.Profiling;
using Improbable.Gdk.Core;
using Improbable.Gdk.GameObjectRepresentation;
using Improbable.Worker.Core;

namespace Improbable.Gdk.Tests
{
    public partial class ExhaustiveSingular
    {
        internal class GameObjectComponentDispatcher : GameObjectComponentDispatcherBase
        {
            public override ComponentType[] ComponentAddedComponentTypes => new ComponentType[]
            {
                ComponentType.ReadOnly<ComponentAdded<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>(), ComponentType.ReadOnly<GameObjectReference>()
            };

            public override ComponentType[] ComponentRemovedComponentTypes => new ComponentType[]
            {
                ComponentType.ReadOnly<ComponentRemoved<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>(), ComponentType.ReadOnly<GameObjectReference>()
            };

            public override ComponentType[] AuthorityGainedComponentTypes => new ComponentType[]
            {
                ComponentType.ReadOnly<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>(), ComponentType.ReadOnly<GameObjectReference>(),
                ComponentType.ReadOnly<Authoritative<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>()
            };

            public override ComponentType[] AuthorityLostComponentTypes => new ComponentType[]
            {
                ComponentType.ReadOnly<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>(), ComponentType.ReadOnly<GameObjectReference>(),
                ComponentType.ReadOnly<NotAuthoritative<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>()
            };

            public override ComponentType[] AuthorityLossImminentComponentTypes => new ComponentType[]
            {
                ComponentType.ReadOnly<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>(), ComponentType.ReadOnly<GameObjectReference>(),
                ComponentType.ReadOnly<AuthorityLossImminent<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>()
            };

            public override ComponentType[] ComponentsUpdatedComponentTypes => new ComponentType[]
            {
                ComponentType.ReadOnly<Improbable.Gdk.Tests.ExhaustiveSingular.ReceivedUpdates>(), ComponentType.ReadOnly<GameObjectReference>()
            };

            public override ComponentType[][] EventsReceivedComponentTypeArrays => new ComponentType[][]
            {
            };

            public override ComponentType[][] CommandRequestsComponentTypeArrays => new ComponentType[][]
            {
            };

            public override ComponentType[][] CommandResponsesComponentTypeArrays => new ComponentType[][]
            {
            };

            private const uint componentId = 197715;
            private static readonly InjectableId readerWriterInjectableId = new InjectableId(InjectableType.ReaderWriter, componentId);

            public override void MarkComponentsAddedForActivation(Dictionary<Unity.Entities.Entity, MonoBehaviourActivationManager> entityToManagers)
            {
                if (ComponentAddedComponentGroup.IsEmptyIgnoreFilter)
                {
                    return;
                }

                Profiler.BeginSample("ExhaustiveSingular");
                var entities = ComponentAddedComponentGroup.GetEntityArray();
                for (var i = 0; i < entities.Length; i++)
                {
                    var activationManager = entityToManagers[entities[i]];
                    activationManager.AddComponent(componentId);
                }

                Profiler.EndSample();
            }

            public override void MarkComponentsRemovedForDeactivation(Dictionary<Unity.Entities.Entity, MonoBehaviourActivationManager> entityToManagers)
            {
                if (ComponentRemovedComponentGroup.IsEmptyIgnoreFilter)
                {
                    return;
                }

                Profiler.BeginSample("ExhaustiveSingular");
                var entities = ComponentRemovedComponentGroup.GetEntityArray();
                for (var i = 0; i < entities.Length; i++)
                {
                    var activationManager = entityToManagers[entities[i]];
                    activationManager.RemoveComponent(componentId);
                }

                Profiler.EndSample();
            }

            public override void MarkAuthorityGainedForActivation(Dictionary<Unity.Entities.Entity, MonoBehaviourActivationManager> entityToManagers)
            {
                if (AuthorityGainedComponentGroup.IsEmptyIgnoreFilter)
                {
                    return;
                }

                Profiler.BeginSample("ExhaustiveSingular");
                var authoritiesChangedTags = AuthorityGainedComponentGroup.GetComponentDataArray<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>();
                var entities = AuthorityGainedComponentGroup.GetEntityArray();
                for (var i = 0; i < entities.Length; i++)
                {
                    var activationManager = entityToManagers[entities[i]];
                    // Call once except if flip-flopped back to starting state
                    if (IsFirstAuthChange(Authority.Authoritative, authoritiesChangedTags[i]))
                    {
                        activationManager.ChangeAuthority(componentId, Authority.Authoritative);
                    }
                }

                Profiler.EndSample();
            }

            public override void MarkAuthorityLostForDeactivation(Dictionary<Unity.Entities.Entity, MonoBehaviourActivationManager> entityToManagers)
            {
                if (AuthorityLostComponentGroup.IsEmptyIgnoreFilter)
                {
                    return;
                }

                Profiler.BeginSample("ExhaustiveSingular");
                var authoritiesChangedTags = AuthorityLostComponentGroup.GetComponentDataArray<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>();
                var entities = AuthorityLostComponentGroup.GetEntityArray();
                for (var i = 0; i < entities.Length; i++)
                {
                    var activationManager = entityToManagers[entities[i]];
                    // Call once except if flip-flopped back to starting state
                    if (IsFirstAuthChange(Authority.NotAuthoritative, authoritiesChangedTags[i]))
                    {
                        activationManager.ChangeAuthority(componentId, Authority.NotAuthoritative);
                    }
                }

                Profiler.EndSample();
            }

            public override void InvokeOnComponentUpdateCallbacks(Dictionary<Unity.Entities.Entity, InjectableStore> entityToInjectableStore)
            {
                if (ComponentsUpdatedComponentGroup.IsEmptyIgnoreFilter)
                {
                    return;
                }

                Profiler.BeginSample("ExhaustiveSingular");
                var entities = ComponentsUpdatedComponentGroup.GetEntityArray();
                var updateLists = ComponentsUpdatedComponentGroup.GetComponentDataArray<Improbable.Gdk.Tests.ExhaustiveSingular.ReceivedUpdates>();
                for (var i = 0; i < entities.Length; i++)
                {
                    var injectableStore = entityToInjectableStore[entities[i]];
                    if (!injectableStore.TryGetInjectablesForComponent(readerWriterInjectableId, out var readersWriters))
                    {
                        continue;
                    }

                    var updateList = updateLists[i];
                    foreach (Requirable.ReaderWriterImpl readerWriter in readersWriters)
                    {
                        foreach (var update in updateList.Updates)
                        {
                            readerWriter.OnComponentUpdate(update);
                        }
                    }
                }

                Profiler.EndSample();
            }

            public override void InvokeOnEventCallbacks(Dictionary<Unity.Entities.Entity, InjectableStore> entityToInjectableStore)
            {
            }

            public override void InvokeOnCommandRequestCallbacks(Dictionary<Unity.Entities.Entity, InjectableStore> entityToInjectableStore)
            {
            }

            public override void InvokeOnCommandResponseCallbacks(Dictionary<Unity.Entities.Entity, InjectableStore> entityToInjectableStore)
            {
            }

            public override void InvokeOnAuthorityGainedCallbacks(Dictionary<Unity.Entities.Entity, InjectableStore> entityToInjectableStore)
            {
                if (AuthorityGainedComponentGroup.IsEmptyIgnoreFilter)
                {
                    return;
                }

                Profiler.BeginSample("ExhaustiveSingular");
                var entities = AuthorityGainedComponentGroup.GetEntityArray();
                var changeOpsLists = AuthorityGainedComponentGroup.GetComponentDataArray<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>();

                // Call once on all entities unless they flip-flopped back into the state they started in
                for (var i = 0; i < entities.Length; i++)
                {
                    var injectableStore = entityToInjectableStore[entities[i]];
                    if (!injectableStore.TryGetInjectablesForComponent(readerWriterInjectableId, out var readersWriters))
                    {
                        continue;
                    }

                    if (IsFirstAuthChange(Authority.Authoritative, changeOpsLists[i]))
                    {
                        foreach (Requirable.ReaderWriterImpl readerWriter in readersWriters)
                        {
                            readerWriter.OnAuthorityChange(Authority.Authoritative);
                        }
                    }
                }

                Profiler.EndSample();
            }

            public override void InvokeOnAuthorityLostCallbacks(Dictionary<Unity.Entities.Entity, InjectableStore> entityToInjectableStore)
            {
                if (AuthorityLostComponentGroup.IsEmptyIgnoreFilter)
                {
                    return;
                }

                Profiler.BeginSample("ExhaustiveSingular");
                var entities = AuthorityLostComponentGroup.GetEntityArray();
                var changeOpsLists = AuthorityLostComponentGroup.GetComponentDataArray<AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveSingular.Component>>();

                // Call once on all entities unless they flip-flopped back into the state they started in
                for (var i = 0; i < entities.Length; i++)
                {
                    var injectableStore = entityToInjectableStore[entities[i]];
                    if (!injectableStore.TryGetInjectablesForComponent(readerWriterInjectableId, out var readersWriters))
                    {
                        continue;
                    }

                    if (IsFirstAuthChange(Authority.NotAuthoritative, changeOpsLists[i]))
                    {
                        foreach (Requirable.ReaderWriterImpl readerWriter in readersWriters)
                        {
                            readerWriter.OnAuthorityChange(Authority.NotAuthoritative);
                        }
                    }
                }

                Profiler.EndSample();
            }

            private bool IsFirstAuthChange(Authority authToMatch, AuthorityChanges<Improbable.Gdk.Tests.ExhaustiveSingular.Component> changeOps)
            {
                foreach (var auth in changeOps.Changes)
                {
                    if (auth != Authority.AuthorityLossImminent) // not relevant
                    {
                        return auth == authToMatch;
                    }
                }

                return false;
            }

            public override void InvokeOnAuthorityLossImminentCallbacks(Dictionary<Unity.Entities.Entity, InjectableStore> entityToInjectableStore)
            {
                if (AuthorityLossImminentComponentGroup.IsEmptyIgnoreFilter)
                {
                    return;
                }

                Profiler.BeginSample("ExhaustiveSingular");
                var entities = AuthorityLossImminentComponentGroup.GetEntityArray();

                // Call once on all entities
                for (var i = 0; i < entities.Length; i++)
                {
                    var injectableStore = entityToInjectableStore[entities[i]];
                    if (!injectableStore.TryGetInjectablesForComponent(readerWriterInjectableId, out var readersWriters))
                    {
                        continue;
                    }

                    foreach (Requirable.ReaderWriterImpl readerWriter in readersWriters)
                    {
                        readerWriter.OnAuthorityChange(Authority.AuthorityLossImminent);
                    }
                }

                Profiler.EndSample();
            }
        }
    }
}
