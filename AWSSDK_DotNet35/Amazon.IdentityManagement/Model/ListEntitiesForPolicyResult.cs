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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the response to a successful <a>ListEntitiesForPolicy</a> request.
    /// </summary>
    public partial class ListEntitiesForPolicyResult : AmazonWebServiceResponse
    {
        private bool? _isTruncated;
        private string _marker;
        private List<PolicyGroup> _policyGroups = new List<PolicyGroup>();
        private List<PolicyRole> _policyRoles = new List<PolicyRole>();
        private List<PolicyUser> _policyUsers = new List<PolicyUser>();

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more entities to list. If your results were
        /// truncated, you can make a subsequent pagination request using the <code>Marker</code>
        /// request parameter to retrieve more entities in the list.
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, this element is present and contains
        /// the value to use for the <code>Marker</code> parameter in a subsequent pagination
        /// request.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyGroups. 
        /// <para>
        /// A list of groups that the policy is attached to.
        /// </para>
        /// </summary>
        public List<PolicyGroup> PolicyGroups
        {
            get { return this._policyGroups; }
            set { this._policyGroups = value; }
        }

        // Check to see if PolicyGroups property is set
        internal bool IsSetPolicyGroups()
        {
            return this._policyGroups != null && this._policyGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyRoles. 
        /// <para>
        /// A list of roles that the policy is attached to.
        /// </para>
        /// </summary>
        public List<PolicyRole> PolicyRoles
        {
            get { return this._policyRoles; }
            set { this._policyRoles = value; }
        }

        // Check to see if PolicyRoles property is set
        internal bool IsSetPolicyRoles()
        {
            return this._policyRoles != null && this._policyRoles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyUsers. 
        /// <para>
        /// A list of users that the policy is attached to.
        /// </para>
        /// </summary>
        public List<PolicyUser> PolicyUsers
        {
            get { return this._policyUsers; }
            set { this._policyUsers = value; }
        }

        // Check to see if PolicyUsers property is set
        internal bool IsSetPolicyUsers()
        {
            return this._policyUsers != null && this._policyUsers.Count > 0; 
        }

    }
}