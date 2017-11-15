// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsXmsErrorResponses.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NotFoundErrorBase : BaseError
    {
        /// <summary>
        /// Initializes a new instance of the NotFoundErrorBase class.
        /// </summary>
        public NotFoundErrorBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotFoundErrorBase class.
        /// </summary>
        public NotFoundErrorBase(string someBaseProp = default(string), string reason = default(string))
            : base(someBaseProp)
        {
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }


    }
}
