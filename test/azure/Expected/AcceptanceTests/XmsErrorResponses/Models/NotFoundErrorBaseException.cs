// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsXmsErrorResponses.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with NotFoundErrorBase
    /// information.
    /// </summary>
    public partial class NotFoundErrorBaseException : HttpRestExceptionBase<NotFoundErrorBase>
    {

        /// <summary>
        /// Initializes a new instance of the NotFoundErrorBaseException class.
        /// </summary>
        public NotFoundErrorBaseException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotFoundErrorBaseException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public NotFoundErrorBaseException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotFoundErrorBaseException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public NotFoundErrorBaseException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// </summary>
        public string Reason => Body.Reason;

        /// <summary>
        /// </summary>
        public string SomeBaseProp => Body.SomeBaseProp;

    }
}
