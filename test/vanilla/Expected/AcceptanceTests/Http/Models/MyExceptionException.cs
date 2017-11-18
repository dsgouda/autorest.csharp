// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsHttp.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with A information.
    /// </summary>
    public partial class MyExceptionException : HttpRestExceptionBase<A>
    {

        /// <summary>
        /// Initializes a new instance of the MyExceptionException class.
        /// </summary>
        public MyExceptionException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MyExceptionException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public MyExceptionException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MyExceptionException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public MyExceptionException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// </summary>
        public string StatusCode => Body.StatusCode;

    }
}