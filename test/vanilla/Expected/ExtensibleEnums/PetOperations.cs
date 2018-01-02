// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.ExtensibleEnums
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
    /// PetOperations operations.
    /// </summary>
    public partial class PetOperations : IServiceOperations<PetStoreInc>, IPetOperations
    {
        /// <summary>
        /// Initializes a new instance of the PetOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public PetOperations(PetStoreInc client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the PetStoreInc
        /// </summary>
        public PetStoreInc Client { get; private set; }

        /// <param name='petId'>
        /// Pet id
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="T:Microsoft.Rest.HttpRestException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Pet>> GetByPetIdWithHttpMessagesAsync(string petId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (petId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "petId");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("petId", petId);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetByPetId", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "extensibleenums/pet/{petId}").ToString();
            _url = _url.Replace("{petId}", System.Uri.EscapeDataString(petId));
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
                    switch(_statusCode)
                    {
                            default:
                               await HandleDefaultErrorResponseForGetByPetId(_httpRequest, _httpResponse, (int)_statusCode);
                               break;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                catch(RestException ex)
                {
                    if (_shouldTrace)
                    {
                        ServiceClientTracing.Error(_invocationId, ex);
                    }
                    throw ex;
                }
            }
            // Create Result
            var _result = new HttpOperationResponse<Pet>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                string _responseContent = null;
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Pet>(_responseContent, Client.DeserializationSettings);
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
            private async Task HandleDefaultErrorResponseForGetByPetId(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
            {
                await HandleErrorResponseWithKnownTypeForGetByPetId<string>(_httpRequest, _httpResponse, statusCode);
            }

            /// <summary>
            /// Method that generates error message for status code
            /// </summary>
            private string GetErrorMessageForGetByPetId(int statusCode)
            {
                return string.Format("Operation GetByPetId returned status code: '{0}'", statusCode);
            }

            /// <summary>
            /// Handle responses where error model is a known primary type
            /// Creates a HttpRestException object and throws it
            /// </summary>
            /// <exception cref="T:Microsoft.Rest.HttpRestException">
            /// Deserialize error body returned by the operation
            /// </exception>
            private async Task HandleErrorResponseWithKnownTypeForGetByPetId<T>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
            {
                string _responseContent = null;
                var ex = new HttpRestException<T>(GetErrorMessageForGetByPetId(statusCode));
                if (_httpResponse.Content != null)
                {
                    try
                    {
                        _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<T>(_responseContent);
                        ex.SetErrorModel(errorResponseModel);
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


        /// <param name='petParam'>
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="T:Microsoft.Rest.HttpRestException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Pet>> AddPetWithHttpMessagesAsync(Pet petParam = default(Pet), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (petParam != null)
            {
                petParam.Validate();
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("petParam", petParam);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "AddPet", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "extensibleenums/pet/addPet").ToString();
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
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

                    string _requestContent = null;
            if(petParam != null)
            {
                _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(petParam, Client.SerializationSettings);
                _httpRequest.Content = new StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
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
                    switch(_statusCode)
                    {
                            default:
                               await HandleDefaultErrorResponseForAddPet(_httpRequest, _httpResponse, (int)_statusCode);
                               break;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                catch(RestException ex)
                {
                    if (_shouldTrace)
                    {
                        ServiceClientTracing.Error(_invocationId, ex);
                    }
                    throw ex;
                }
            }
            // Create Result
            var _result = new HttpOperationResponse<Pet>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                string _responseContent = null;
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Pet>(_responseContent, Client.DeserializationSettings);
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
            private async Task HandleDefaultErrorResponseForAddPet(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
            {
                await HandleErrorResponseWithKnownTypeForAddPet<string>(_httpRequest, _httpResponse, statusCode);
            }

            /// <summary>
            /// Method that generates error message for status code
            /// </summary>
            private string GetErrorMessageForAddPet(int statusCode)
            {
                return string.Format("Operation AddPet returned status code: '{0}'", statusCode);
            }

            /// <summary>
            /// Handle responses where error model is a known primary type
            /// Creates a HttpRestException object and throws it
            /// </summary>
            /// <exception cref="T:Microsoft.Rest.HttpRestException">
            /// Deserialize error body returned by the operation
            /// </exception>
            private async Task HandleErrorResponseWithKnownTypeForAddPet<T>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
            {
                string _responseContent = null;
                var ex = new HttpRestException<T>(GetErrorMessageForAddPet(statusCode));
                if (_httpResponse.Content != null)
                {
                    try
                    {
                        _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<T>(_responseContent);
                        ex.SetErrorModel(errorResponseModel);
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
