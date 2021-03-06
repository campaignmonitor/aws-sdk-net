/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Port mappings allow containers to access ports on the host container instance to send
    /// or receive traffic. Port mappings are specified as part of the container definition.
    /// After a task reaches the <code>RUNNING</code> status, manual and automatic host and
    /// container port assignments are visible in the <code>networkBindings</code> section
    /// of <a>DescribeTasks</a> API responses.
    /// </summary>
    public partial class PortMapping
    {
        private int? _containerPort;
        private int? _hostPort;
        private TransportProtocol _protocol;

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port number on the container that is bound to the user-specified or automatically
        /// assigned host port. If you specify a container port and not a host port, your container
        /// automatically receives a host port in the ephemeral port range (for more information,
        /// see <code>hostPort</code>).
        /// </para>
        /// </summary>
        public int ContainerPort
        {
            get { return this._containerPort.GetValueOrDefault(); }
            set { this._containerPort = value; }
        }

        // Check to see if ContainerPort property is set
        internal bool IsSetContainerPort()
        {
            return this._containerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostPort. 
        /// <para>
        /// The port number on the container instance to reserve for your container. You can specify
        /// a non-reserved host port for your container port mapping, or you can omit the <code>hostPort</code>
        /// (or set it to <code>0</code>) while specifying a <code>containerPort</code> and your
        /// container automatically receives a port in the ephemeral port range for your container
        /// instance operating system and Docker version.
        /// </para>
        ///  
        /// <para>
        /// The default ephemeral port range is 49153 to 65535, and this range is used for Docker
        /// versions prior to 1.6.0. For Docker version 1.6.0 and later, the Docker daemon tries
        /// to read the ephemeral port range from <code>/proc/sys/net/ipv4/ip_local_port_range</code>;
        /// if this kernel parameter is unavailable, the default ephemeral port range is used.
        /// You should not attempt to specify a host port in the ephemeral port range, because
        /// these are reserved for automatic assignment. In general, ports below 32768 are outside
        /// of the ephemeral port range.
        /// </para>
        ///  
        /// <para>
        /// The default reserved ports are 22 for SSH, the Docker ports 2375 and 2376, and the
        /// Amazon ECS container agent port 51678. Any host port that was previously specified
        /// in a running task is also reserved while the task is running (after a task stops,
        /// the host port is released).The current reserved ports are displayed in the <code>remainingResources</code>
        /// of <a>DescribeContainerInstances</a> output, and a container instance may have up
        /// to 50 reserved ports at a time, including the default reserved ports (automatically
        /// assigned ports do not count toward this limit).
        /// </para>
        /// </summary>
        public int HostPort
        {
            get { return this._hostPort.GetValueOrDefault(); }
            set { this._hostPort = value; }
        }

        // Check to see if HostPort property is set
        internal bool IsSetHostPort()
        {
            return this._hostPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used for the port mapping. Valid values are <code>tcp</code> and <code>udp</code>.
        /// The default is <code>tcp</code>.
        /// </para>
        /// </summary>
        public TransportProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

    }
}