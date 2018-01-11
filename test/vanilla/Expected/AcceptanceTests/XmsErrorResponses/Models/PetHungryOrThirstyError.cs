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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PetHungryOrThirstyError : PetSadError, IRestErrorModel
    {
        /// <summary>
        /// Initializes a new instance of the PetHungryOrThirstyError class.
        /// </summary>
        public PetHungryOrThirstyError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PetHungryOrThirstyError class.
        /// </summary>
        /// <param name="errorMessage">the error message</param>
        /// <param name="reason">why is the pet sad</param>
        /// <param name="hungryOrThirsty">is the pet hungry or thirsty or
        /// both</param>
        public PetHungryOrThirstyError(string errorMessage = default(string), string reason = default(string), string hungryOrThirsty = default(string))
            : base(errorMessage, reason)
        {
            HungryOrThirsty = hungryOrThirsty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets is the pet hungry or thirsty or both
        /// </summary>
        [JsonProperty(PropertyName = "hungryOrThirsty")]
        public string HungryOrThirsty { get; set; }

        /// <summary>
        /// Method that creates an exception of PetHungryOrThirstyErrorException
        /// </summary>
        public override void CreateAndThrowException(string errorMessage, HttpRequestMessageWrapper requestMessage, HttpResponseMessageWrapper responseMessage)
        {
            var ex = new PetHungryOrThirstyErrorException(errorMessage)
            {
                Request = requestMessage,
                Response = responseMessage
            };
            ex.ErrorBody = this;
            throw ex;
        }
    }
}
