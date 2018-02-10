// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.XmsErrorResponses.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PetSadError : PetActionError
    {
        /// <summary>
        /// Initializes a new instance of the PetSadError class.
        /// </summary>
        public PetSadError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PetSadError class.
        /// </summary>
        /// <param name="errorMessage">the error message</param>
        /// <param name="reason">why is the pet sad</param>
        public PetSadError(string errorMessage = default(string), string reason = default(string))
            : base(errorMessage)
        {
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets why is the pet sad
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

    }
}
