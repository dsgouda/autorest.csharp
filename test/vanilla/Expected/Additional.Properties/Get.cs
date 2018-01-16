// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AdditionalProperties
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Get operations.
    /// </summary>
    public partial class Get : IServiceOperations<PetStoreonHeroku>, IGet
    {
        /// <summary>
        /// Initializes a new instance of the Get class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Get(PetStoreonHeroku client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the PetStoreonHeroku
        /// </summary>
        public PetStoreonHeroku Client { get; private set; }

        /// <param name='limit'>
        /// number of pets to return
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="T:Microsoft.Rest.RestException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<IList<Pet>>> PetsWithHttpMessagesAsync(int? limit = 11, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (limit > 10000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "limit", 10000);
            }
            if (limit < 11)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "limit", 11);
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("limit", limit);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Pets", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "").ToString();
            List<string> _queryParameters = new List<string>();
            if (limit != null)
            {
                _queryParameters.Add(string.Format("limit={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(limit, Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            if ((int)_statusCode != 200)
            {
                try
                {
                    await HandleDefaultErrorResponseForPets(_httpRequest, _httpResponse, (int)_statusCode);
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                catch(RestExceptionBase ex)
                {
                    if (_shouldTrace)
                    {
                        ServiceClientTracing.Error(_invocationId, ex);
                    }
                    throw ex;
                }
            }
            // Create Result
            var _result = new HttpOperationResponse<IList<Pet>>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                string _responseContent = null;
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<IList<Pet>>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Handle other unhandled status codes
        /// </summary>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleDefaultErrorResponseForPets(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            await HandleErrorResponseWithKnownTypeForPets<string>(_httpRequest, _httpResponse, statusCode);
        }

        /// <summary>
        /// Method that generates error message for status code
        /// </summary>
        private string GetErrorMessageForPets(int statusCode)
        {
            return string.Format("Operation Pets returned status code: '{0}'", statusCode);
        }

        /// <summary>
        /// Handle responses where error model is a known primary type
        /// Creates a RestException object and throws it
        /// </summary>
        /// <exception cref="T:Microsoft.Rest.RestException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleErrorResponseWithKnownTypeForPets<T>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            string _responseContent = null;
            var ex = new RestException<T>(GetErrorMessageForPets(statusCode));
            if (_httpResponse.Content != null)
            {
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<T>(_responseContent);
                    ex.ErrorBody = errorResponseModel;
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
            }
            else
            {
                _responseContent = string.Empty;
            }

            ex.Request = new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString());
            ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
            _httpRequest.Dispose();
            if (_httpResponse != null)
            {
                _httpResponse.Dispose();
            }
            throw ex;
        }

    }
}
