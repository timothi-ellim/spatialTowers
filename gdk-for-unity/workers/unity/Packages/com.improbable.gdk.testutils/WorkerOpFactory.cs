﻿using System;
using System.Collections;
using System.Collections.Generic;
using Improbable.Worker;
using Improbable.Worker.Core;
using UnityEngine;

namespace Improbable.Gdk.TestUtils
{
    /// <summary>
    ///     A static class that contains helper methods for constructing ops. All ops are empty outside of the required
    ///     information given in the constructor. Underlying schema data can be populated using the return value of
    ///     each function.
    /// </summary>
    public static class WorkerOpFactory
    {
        public static WrappedOp<AddEntityOp> CreateAddEntityOp(long entityId)
        {
            var op = new AddEntityOp
            {
                EntityId = new EntityId(entityId)
            };
            return new WrappedOp<AddEntityOp>(op);
        }

        public static WrappedOp<RemoveEntityOp> CreateRemoveEntityOp(long entityId)
        {
            var op = new RemoveEntityOp
            {
                EntityId = new EntityId(entityId)
            };
            return new WrappedOp<RemoveEntityOp>(op);
        }

        public static WrappedOp<AddComponentOp> CreateAddComponentOp(long entityId, uint componentId)
        {
            var schemaComponentData = new SchemaComponentData(componentId);
            var op = new AddComponentOp
            {
                Data = new ComponentData(schemaComponentData),
                EntityId = new EntityId(entityId)
            };
            return new WrappedOp<AddComponentOp>(op);
        }

        public static WrappedOp<ComponentUpdateOp> CreateComponentUpdateOp(long entityId, uint componentId)
        {
            var schemaComponentUpdate = new SchemaComponentUpdate(componentId);
            var op = new ComponentUpdateOp
            {
                Update = new ComponentUpdate(schemaComponentUpdate),
                EntityId = new EntityId(entityId)
            };

            return new WrappedOp<ComponentUpdateOp>(op);
        }

        public static WrappedOp<RemoveComponentOp> CreateRemoveComponentOp(long entityId, uint componentId)
        {
            var op = new RemoveComponentOp
            {
                EntityId = new EntityId(entityId),
                ComponentId = componentId
            };

            return new WrappedOp<RemoveComponentOp>(op);
        }

        public static WrappedOp<AuthorityChangeOp> CreateAuthorityChangeOp(long entityId, uint componentId)
        {
            var op = new AuthorityChangeOp
            {
                EntityId = new EntityId(entityId),
                ComponentId = componentId
            };

            return new WrappedOp<AuthorityChangeOp>(op);
        }

        public static WrappedOp<CommandRequestOp> CreateCommandRequestOp(uint componentId, uint commandIndex, long requestId)
        {
            var schemaRequest = new SchemaCommandRequest(componentId, commandIndex);
            var op = new CommandRequestOp
            {
                Request = new CommandRequest(schemaRequest),
                RequestId = new RequestId<IncomingCommandRequest>(requestId)
            };

            return new WrappedOp<CommandRequestOp>(op);
        }

        public static WrappedOp<CommandResponseOp> CreateCommandResponseOp(uint componentId, uint commandIndex, long requestId)
        {
            var schemaResponse = new SchemaCommandResponse(componentId, commandIndex);

            var op = new CommandResponseOp
            {
                Response = new CommandResponse(schemaResponse),
                RequestId = new RequestId<OutgoingCommandRequest>(requestId)
            };

            return new WrappedOp<CommandResponseOp>(op);
        }

        public static WrappedOp<DisconnectOp> CreateDisconnectOp(string reason)
        {
            var op = new DisconnectOp { Reason = reason };
            return new WrappedOp<DisconnectOp>(op);
        }

        public static WrappedOp<CreateEntityResponseOp> CreateCreateEntityResponseOp(long requestId)
        {
            var op = new CreateEntityResponseOp
            {
                RequestId = new RequestId<CreateEntityRequest>(requestId)
            };

            return new WrappedOp<CreateEntityResponseOp>(op);
        }

        public static WrappedOp<DeleteEntityResponseOp> CreateDeleteEntityResponseOp(long requestId)
        {
            var op = new DeleteEntityResponseOp
            {
                RequestId = new RequestId<DeleteEntityRequest>(requestId)
            };

            return new WrappedOp<DeleteEntityResponseOp>(op);
        }

        public static WrappedOp<ReserveEntityIdsResponseOp> CreateReserveEntityIdsResponseOp(long requestId)
        {
            var op = new ReserveEntityIdsResponseOp
            {
                RequestId = new RequestId<ReserveEntityIdsRequest>(requestId)
            };

            return new WrappedOp<ReserveEntityIdsResponseOp>(op);
        }

        public static WrappedOp<EntityQueryResponseOp> CreateEntityQueryResponseOp(long requestId)
        {
            var op = new EntityQueryResponseOp
            {
                RequestId = new RequestId<EntityQueryRequest>(requestId),
                Result = new Dictionary<EntityId, Entity>(),
                ResultCount = 0,
            };

            return new WrappedOp<EntityQueryResponseOp>(op);
        }
    }

    /// <summary>
    ///     A wrapped Worker Op that implements Dispose so that the allocated native memory is properly freed.
    ///     Ensure to call Dispose or use WrappedOp with a using scope.
    /// </summary>
    /// <typeparam name="T">The worker op type. E.g. - AddComponentOp</typeparam>
    public struct WrappedOp<T> : IDisposable where T : struct
    {
        public T Op;

        internal WrappedOp(T op)
        {
            Op = op;
        }

        public void Dispose()
        {
            switch (Op)
            {
                case AddComponentOp addComponentOp:
                    addComponentOp.Data.SchemaData?.Dispose();
                    break;
                case ComponentUpdateOp componentUpdateOp:
                    componentUpdateOp.Update.SchemaData?.Dispose();
                    break;
                case CommandRequestOp commandRequestOp:
                    commandRequestOp.Request.SchemaData?.Dispose();
                    break;
                case CommandResponseOp commandResponseOp:
                    commandResponseOp.Response.SchemaData?.Dispose();
                    break;
            }
        }
    }
}
