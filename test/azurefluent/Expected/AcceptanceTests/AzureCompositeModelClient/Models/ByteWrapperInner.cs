// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsAzureCompositeModelClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ByteWrapperInner
    {
        /// <summary>
        /// Initializes a new instance of the ByteWrapperInner class.
        /// </summary>
        public ByteWrapperInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ByteWrapperInner class.
        /// </summary>
        public ByteWrapperInner(byte[] field = default(byte[]))
        {
            Field = field;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "field")]
        public byte[] Field { get; set; }

    }
}
