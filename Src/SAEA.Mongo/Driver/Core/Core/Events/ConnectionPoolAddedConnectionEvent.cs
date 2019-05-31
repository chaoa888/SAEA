/* Copyright 2013-present MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using SAEA.Mongo.Driver.Core.Clusters;
using SAEA.Mongo.Driver.Core.Connections;
using SAEA.Mongo.Driver.Core.Servers;

namespace SAEA.Mongo.Driver.Core.Events
{
    /// <preliminary/>
    /// <summary>
    /// Occurs after a connection is added to the pool.
    /// </summary>
    public struct ConnectionPoolAddedConnectionEvent
    {
        private readonly ConnectionId _connectionId;
        private readonly TimeSpan _duration;
        private readonly long? _operationId;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionPoolAddedConnectionEvent" /> struct.
        /// </summary>
        /// <param name="connectionId">The connection identifier.</param>
        /// <param name="duration">The duration of time it took to add the connection to the pool.</param>
        /// <param name="operationId">The operation identifier.</param>
        public ConnectionPoolAddedConnectionEvent(ConnectionId connectionId, TimeSpan duration, long? operationId)
        {
            _connectionId = connectionId;
            _duration = duration;
            _operationId = operationId;
        }

        /// <summary>
        /// Gets the cluster identifier.
        /// </summary>
        public ClusterId ClusterId
        {
            get { return _connectionId.ServerId.ClusterId; }
        }

        /// <summary>
        /// Gets the connection identifier.
        /// </summary>
        public ConnectionId ConnectionId
        {
            get { return _connectionId; }
        }

        /// <summary>
        /// Gets the duration of time it took to add the server to the pool.
        /// </summary>
        public TimeSpan Duration
        {
            get { return _duration; }
        }

        /// <summary>
        /// Gets the operation identifier.
        /// </summary>
        public long? OperationId
        {
            get { return _operationId; }
        }

        /// <summary>
        /// Gets the server identifier.
        /// </summary>
        public ServerId ServerId
        {
            get { return _connectionId.ServerId; }
        }
    }
}