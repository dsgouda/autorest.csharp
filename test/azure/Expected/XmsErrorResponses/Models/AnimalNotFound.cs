// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.XmsErrorResponses.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AnimalNotFound : NotFoundErrorBase
    {
        /// <summary>
        /// Initializes a new instance of the AnimalNotFound class.
        /// </summary>
        public AnimalNotFound()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AnimalNotFound class.
        /// </summary>
        public AnimalNotFound(string someBaseProp = default(string), string reason = default(string), string name = default(string))
            : base(someBaseProp, reason)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
