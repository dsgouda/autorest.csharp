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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Cat : Pet
    {
        /// <summary>
        /// Initializes a new instance of the Cat class.
        /// </summary>
        public Cat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cat class.
        /// </summary>
        public Cat(int? id = default(int?), string name = default(string), string color = default(string), IList<Dog> hates = default(IList<Dog>))
            : base(id, name)
        {
            Color = color;
            Hates = hates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hates")]
        public IList<Dog> Hates { get; set; }

    }
}
