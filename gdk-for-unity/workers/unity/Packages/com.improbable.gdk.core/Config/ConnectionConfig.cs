using Improbable.Worker;
using Improbable.Worker.Core;

namespace Improbable.Gdk.Core
{
    public abstract class ConnectionConfig
    {
        /// <summary>
        ///     The type of networking that should be used. Either RakNet or TCP.
        /// </summary>
        /// <remarks>
        ///    Default is RakNet.
        /// </remarks>
        public NetworkConnectionType LinkProtocol = NetworkConnectionType.RakNet;

        /// <summary>
        ///     Denotes whether protocol logging should be enabled.
        /// </summary>
        /// <remarks>
        ///    Default is false.
        /// </remarks>
        public bool EnableProtocolLoggingAtStartup = false;

        /// <summary>
        ///     Denotes whether the worker uses the local IP to connect to the SpatiaLOS runtime.
        /// </summary>
        /// <remarks>
        ///     Default is false.
        /// </remarks>
        /// <remarks>
        ///     This should be true if connecting workers to a cloud deployment via "spatial cloud connect external"
        ///     or if connecting via the locator.
        /// </remarks>
        public bool UseExternalIp = false;

        /// <summary>
        ///     The ID of the worker.
        /// </summary>
        public string WorkerId;

        /// <summary>
        ///     The type of the worker.
        /// </summary>
        public string WorkerType;

        protected const string MissingConfigError = "Config validation failed with: No valid {0} has been provided.";

        /// <summary>
        ///    Checks that the connection configuration is valid. This does not guarantee a successful connection.
        /// </summary>
        /// <param name="errorMessage">Reason for failing the validation in case false is returned.</param>
        /// <returns>True, if the connection configuration is valid.</returns>
        public abstract bool Validate(out string errorMessage);

        /// <summary>
        ///     Creates the <see cref="Improbable.Worker.Core.ConnectionParameters"/> corresponding to this
        ///     <see cref="ConnectionConfig"/> instance.
        /// </summary>
        /// <returns></returns>
        public ConnectionParameters CreateConnectionParameters()
        {
            var connectionParameters = new ConnectionParameters
            {
                WorkerType = WorkerType,
                Network =
                {
                    ConnectionType = LinkProtocol,
                    UseExternalIp = UseExternalIp,
                },
                EnableProtocolLoggingAtStartup = EnableProtocolLoggingAtStartup,
                DefaultComponentVtable = new PassthroughComponentVtable()
            };
            return connectionParameters;
        }
    }
}
