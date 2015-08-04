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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EnableMFADevice Request Marshaller
    /// </summary>       
    public class EnableMFADeviceRequestMarshaller : IMarshaller<IRequest, EnableMFADeviceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EnableMFADeviceRequest)input);
        }
    
        public IRequest Marshall(EnableMFADeviceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.Parameters.Add("Action", "EnableMFADevice");
            request.Parameters.Add("Version", "2010-05-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAuthenticationCode1())
                {
                    request.Parameters.Add("AuthenticationCode1", StringUtils.FromString(publicRequest.AuthenticationCode1));
                }
                if(publicRequest.IsSetAuthenticationCode2())
                {
                    request.Parameters.Add("AuthenticationCode2", StringUtils.FromString(publicRequest.AuthenticationCode2));
                }
                if(publicRequest.IsSetSerialNumber())
                {
                    request.Parameters.Add("SerialNumber", StringUtils.FromString(publicRequest.SerialNumber));
                }
                if(publicRequest.IsSetUserName())
                {
                    request.Parameters.Add("UserName", StringUtils.FromString(publicRequest.UserName));
                }
            }
            return request;
        }
    }
}