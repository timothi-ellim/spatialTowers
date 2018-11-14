
// ===========
// DO NOT EDIT - this file is automatically regenerated.
// ===========

using System;
using System.Collections.Generic;
using Unity.Entities;
using Improbable.Gdk.Core;
using Improbable.Gdk.GameObjectRepresentation;
using Entity = Unity.Entities.Entity;

namespace Improbable.Gdk.Tests
{
    public partial class ExhaustiveOptional
    {
        public partial class Requirable
        {
            [InjectableId(InjectableType.ReaderWriter, 197716)]
            internal class ReaderWriterCreator : IInjectableCreator
            {
                public IInjectable CreateInjectable(Entity entity, EntityManager entityManager, ILogDispatcher logDispatcher)
                {
                    return new ReaderWriterImpl(entity, entityManager, logDispatcher);
                }
            }

            [InjectableId(InjectableType.ReaderWriter, 197716)]
            [InjectionCondition(InjectionCondition.RequireComponentPresent)]
            public interface Reader : IReader<Improbable.Gdk.Tests.ExhaustiveOptional.Component, Improbable.Gdk.Tests.ExhaustiveOptional.Update>
            {
                event Action<BlittableBool?> Field1Updated;
                event Action<float?> Field2Updated;
                event Action<global::Improbable.Gdk.Core.Option<byte[]>> Field3Updated;
                event Action<int?> Field4Updated;
                event Action<long?> Field5Updated;
                event Action<double?> Field6Updated;
                event Action<global::Improbable.Gdk.Core.Option<string>> Field7Updated;
                event Action<uint?> Field8Updated;
                event Action<ulong?> Field9Updated;
                event Action<int?> Field10Updated;
                event Action<long?> Field11Updated;
                event Action<uint?> Field12Updated;
                event Action<ulong?> Field13Updated;
                event Action<int?> Field14Updated;
                event Action<long?> Field15Updated;
                event Action<global::Improbable.Worker.EntityId?> Field16Updated;
                event Action<global::Improbable.Gdk.Tests.SomeType?> Field17Updated;
            }

            [InjectableId(InjectableType.ReaderWriter, 197716)]
            [InjectionCondition(InjectionCondition.RequireComponentWithAuthority)]
            public interface Writer : Reader, IWriter<Improbable.Gdk.Tests.ExhaustiveOptional.Component, Improbable.Gdk.Tests.ExhaustiveOptional.Update>
            {
            }

            internal class ReaderWriterImpl :
                ReaderWriterBase<Improbable.Gdk.Tests.ExhaustiveOptional.Component, Improbable.Gdk.Tests.ExhaustiveOptional.Update>, Reader, Writer
            {
                public ReaderWriterImpl(Entity entity, EntityManager entityManager, ILogDispatcher logDispatcher)
                    : base(entity, entityManager, logDispatcher)
                {
                }

                private readonly List<Action<BlittableBool?>> field1Delegates = new List<Action<BlittableBool?>>();

                public event Action<BlittableBool?> Field1Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field1Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field1Delegates.Remove(value);
                    }
                }

                private readonly List<Action<float?>> field2Delegates = new List<Action<float?>>();

                public event Action<float?> Field2Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field2Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field2Delegates.Remove(value);
                    }
                }

                private readonly List<Action<global::Improbable.Gdk.Core.Option<byte[]>>> field3Delegates = new List<Action<global::Improbable.Gdk.Core.Option<byte[]>>>();

                public event Action<global::Improbable.Gdk.Core.Option<byte[]>> Field3Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field3Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field3Delegates.Remove(value);
                    }
                }

                private readonly List<Action<int?>> field4Delegates = new List<Action<int?>>();

                public event Action<int?> Field4Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field4Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field4Delegates.Remove(value);
                    }
                }

                private readonly List<Action<long?>> field5Delegates = new List<Action<long?>>();

                public event Action<long?> Field5Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field5Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field5Delegates.Remove(value);
                    }
                }

                private readonly List<Action<double?>> field6Delegates = new List<Action<double?>>();

                public event Action<double?> Field6Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field6Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field6Delegates.Remove(value);
                    }
                }

                private readonly List<Action<global::Improbable.Gdk.Core.Option<string>>> field7Delegates = new List<Action<global::Improbable.Gdk.Core.Option<string>>>();

                public event Action<global::Improbable.Gdk.Core.Option<string>> Field7Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field7Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field7Delegates.Remove(value);
                    }
                }

                private readonly List<Action<uint?>> field8Delegates = new List<Action<uint?>>();

                public event Action<uint?> Field8Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field8Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field8Delegates.Remove(value);
                    }
                }

                private readonly List<Action<ulong?>> field9Delegates = new List<Action<ulong?>>();

                public event Action<ulong?> Field9Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field9Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field9Delegates.Remove(value);
                    }
                }

                private readonly List<Action<int?>> field10Delegates = new List<Action<int?>>();

                public event Action<int?> Field10Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field10Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field10Delegates.Remove(value);
                    }
                }

                private readonly List<Action<long?>> field11Delegates = new List<Action<long?>>();

                public event Action<long?> Field11Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field11Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field11Delegates.Remove(value);
                    }
                }

                private readonly List<Action<uint?>> field12Delegates = new List<Action<uint?>>();

                public event Action<uint?> Field12Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field12Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field12Delegates.Remove(value);
                    }
                }

                private readonly List<Action<ulong?>> field13Delegates = new List<Action<ulong?>>();

                public event Action<ulong?> Field13Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field13Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field13Delegates.Remove(value);
                    }
                }

                private readonly List<Action<int?>> field14Delegates = new List<Action<int?>>();

                public event Action<int?> Field14Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field14Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field14Delegates.Remove(value);
                    }
                }

                private readonly List<Action<long?>> field15Delegates = new List<Action<long?>>();

                public event Action<long?> Field15Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field15Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field15Delegates.Remove(value);
                    }
                }

                private readonly List<Action<global::Improbable.Worker.EntityId?>> field16Delegates = new List<Action<global::Improbable.Worker.EntityId?>>();

                public event Action<global::Improbable.Worker.EntityId?> Field16Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field16Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field16Delegates.Remove(value);
                    }
                }

                private readonly List<Action<global::Improbable.Gdk.Tests.SomeType?>> field17Delegates = new List<Action<global::Improbable.Gdk.Tests.SomeType?>>();

                public event Action<global::Improbable.Gdk.Tests.SomeType?> Field17Updated
                {
                    add
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field17Delegates.Add(value);
                    }
                    remove
                    {
                        if (!IsValid())
                        {
                            return;
                        }

                        field17Delegates.Remove(value);
                    }
                }

                protected override void TriggerFieldCallbacks(Improbable.Gdk.Tests.ExhaustiveOptional.Update update)
                {
                    DispatchWithErrorHandling(update.Field1, field1Delegates);
                    DispatchWithErrorHandling(update.Field2, field2Delegates);
                    DispatchWithErrorHandling(update.Field3, field3Delegates);
                    DispatchWithErrorHandling(update.Field4, field4Delegates);
                    DispatchWithErrorHandling(update.Field5, field5Delegates);
                    DispatchWithErrorHandling(update.Field6, field6Delegates);
                    DispatchWithErrorHandling(update.Field7, field7Delegates);
                    DispatchWithErrorHandling(update.Field8, field8Delegates);
                    DispatchWithErrorHandling(update.Field9, field9Delegates);
                    DispatchWithErrorHandling(update.Field10, field10Delegates);
                    DispatchWithErrorHandling(update.Field11, field11Delegates);
                    DispatchWithErrorHandling(update.Field12, field12Delegates);
                    DispatchWithErrorHandling(update.Field13, field13Delegates);
                    DispatchWithErrorHandling(update.Field14, field14Delegates);
                    DispatchWithErrorHandling(update.Field15, field15Delegates);
                    DispatchWithErrorHandling(update.Field16, field16Delegates);
                    DispatchWithErrorHandling(update.Field17, field17Delegates);
                }

                protected override void ApplyUpdate(Improbable.Gdk.Tests.ExhaustiveOptional.Update update, ref Improbable.Gdk.Tests.ExhaustiveOptional.Component data)
                {
                    if (update.Field1.HasValue)
                    {
                        data.Field1 = update.Field1.Value;
                    }
                    if (update.Field2.HasValue)
                    {
                        data.Field2 = update.Field2.Value;
                    }
                    if (update.Field3.HasValue)
                    {
                        data.Field3 = update.Field3.Value;
                    }
                    if (update.Field4.HasValue)
                    {
                        data.Field4 = update.Field4.Value;
                    }
                    if (update.Field5.HasValue)
                    {
                        data.Field5 = update.Field5.Value;
                    }
                    if (update.Field6.HasValue)
                    {
                        data.Field6 = update.Field6.Value;
                    }
                    if (update.Field7.HasValue)
                    {
                        data.Field7 = update.Field7.Value;
                    }
                    if (update.Field8.HasValue)
                    {
                        data.Field8 = update.Field8.Value;
                    }
                    if (update.Field9.HasValue)
                    {
                        data.Field9 = update.Field9.Value;
                    }
                    if (update.Field10.HasValue)
                    {
                        data.Field10 = update.Field10.Value;
                    }
                    if (update.Field11.HasValue)
                    {
                        data.Field11 = update.Field11.Value;
                    }
                    if (update.Field12.HasValue)
                    {
                        data.Field12 = update.Field12.Value;
                    }
                    if (update.Field13.HasValue)
                    {
                        data.Field13 = update.Field13.Value;
                    }
                    if (update.Field14.HasValue)
                    {
                        data.Field14 = update.Field14.Value;
                    }
                    if (update.Field15.HasValue)
                    {
                        data.Field15 = update.Field15.Value;
                    }
                    if (update.Field16.HasValue)
                    {
                        data.Field16 = update.Field16.Value;
                    }
                    if (update.Field17.HasValue)
                    {
                        data.Field17 = update.Field17.Value;
                    }
                }
            }
        }
    }
}
