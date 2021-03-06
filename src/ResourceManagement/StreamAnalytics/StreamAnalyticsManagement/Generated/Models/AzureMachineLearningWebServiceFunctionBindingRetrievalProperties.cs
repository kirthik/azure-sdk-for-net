// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The properties of the Azure Machine Learning web service function
    /// binding.
    /// </summary>
    public partial class AzureMachineLearningWebServiceFunctionBindingRetrievalProperties
    {
        private string _executeEndpoint;
        
        /// <summary>
        /// Optional. Gets or sets the execute endpoint of the Azure Machine
        /// Learning web service.
        /// </summary>
        public string ExecuteEndpoint
        {
            get { return this._executeEndpoint; }
            set { this._executeEndpoint = value; }
        }
        
        private string _udfType;
        
        /// <summary>
        /// Optional. Gets or sets the Azure Stream Analytics function type.
        /// </summary>
        public string UdfType
        {
            get { return this._udfType; }
            set { this._udfType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// AzureMachineLearningWebServiceFunctionBindingRetrievalProperties
        /// class.
        /// </summary>
        public AzureMachineLearningWebServiceFunctionBindingRetrievalProperties()
        {
        }
    }
}
