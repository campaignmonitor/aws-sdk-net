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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeEvents Request Marshaller
    /// </summary>       
    public class DescribeEventsRequestMarshaller : IMarshaller<IRequest, DescribeEventsRequest>
    {
        public IRequest Marshall(DescribeEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "DescribeEvents");
            request.Parameters.Add("Version", "2014-07-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDuration())
                {
                    request.Parameters.Add("Duration", StringUtils.FromInt(publicRequest.Duration));
                }
                if(publicRequest.IsSetEndTime())
                {
                    request.Parameters.Add("EndTime", StringUtils.FromDateTime(publicRequest.EndTime));
                }
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetSourceIdentifier())
                {
                    request.Parameters.Add("SourceIdentifier", StringUtils.FromString(publicRequest.SourceIdentifier));
                }
                if(publicRequest.IsSetSourceType())
                {
                    request.Parameters.Add("SourceType", StringUtils.FromString(publicRequest.SourceType));
                }
                if(publicRequest.IsSetStartTime())
                {
                    request.Parameters.Add("StartTime", StringUtils.FromDateTime(publicRequest.StartTime));
                }
            }
            return request;
        }
    }
}