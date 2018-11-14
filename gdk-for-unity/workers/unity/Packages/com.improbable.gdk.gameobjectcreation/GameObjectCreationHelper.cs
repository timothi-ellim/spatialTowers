using System;
using Improbable.Gdk.Core;
using Unity.Entities;
using UnityEngine;

namespace Improbable.Gdk.GameObjectCreation
{
    public static class GameObjectCreationHelper
    {
        private static readonly string WorkerNotCreatedErrorMessage = $"{nameof(EnableStandardGameObjectCreation)} should be called only after a worker has been initialised for the world.";

        public static void EnableStandardGameObjectCreation(World world, GameObject workerGameObject = null)
        {
            var workerSystem = world.GetExistingManager<WorkerSystem>();
            if (workerSystem == null)
            {
                throw new InvalidOperationException(WorkerNotCreatedErrorMessage);
            }

            var creator = new GameObjectCreatorFromMetadata(workerSystem.WorkerType, workerSystem.Origin,
                workerSystem.LogDispatcher);
            EnableStandardGameObjectCreation(world, creator, workerGameObject);
        }

        public static void EnableStandardGameObjectCreation(World world, IEntityGameObjectCreator creator,
            GameObject workerGameObject = null)
        {
            var workerSystem = world.GetExistingManager<WorkerSystem>();
            if (workerSystem == null)
            {
                throw new InvalidOperationException(WorkerNotCreatedErrorMessage);
            }

            var entityManager = world.GetOrCreateManager<EntityManager>();

            if (world.GetExistingManager<GameObjectInitializationSystem>() != null)
            {
                workerSystem.LogDispatcher.HandleLog(LogType.Error, new LogEvent(
                        "You should only call EnableStandardGameobjectCreation() once on worker setup")
                    .WithField(LoggingUtils.LoggerName, nameof(GameObjectCreationHelper)));
                return;
            }

            world.CreateManager<GameObjectInitializationSystem>(creator);

            if (workerGameObject != null)
            {
                if (!entityManager.HasComponent<OnConnected>(workerSystem.WorkerEntity))
                {
                    workerSystem.LogDispatcher.HandleLog(LogType.Error, new LogEvent("You cannot set the Worker " +
                            "GameObject once the World has already started running")
                        .WithField(LoggingUtils.LoggerName, nameof(GameObjectCreationHelper)));
                }
                else
                {
                    world.CreateManager<WorkerEntityGameObjectLinkerSystem>(workerGameObject);
                }
            }
        }
    }
}
