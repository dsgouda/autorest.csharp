// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsParameterFlattening
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
    /// AvailabilitySets operations.
    /// </summary>
    public partial class AvailabilitySets : IServiceOperations<AutoRestParameterFlattening>, IAvailabilitySets
    {
        /// <summary>
        /// Initializes a new instance of the AvailabilitySets class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AvailabilitySets(AutoRestParameterFlattening client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the AutoRestParameterFlattening
        /// </summary>
        public AutoRestParameterFlattening Client { get; private set; }


        /// <summary>
        /// Handle other unhandled status codes
        /// </summary>
        /// <exception cref="Microsoft.Rest.Azure.HttpRestCloudException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleDefaultErrorResponseForUpdate(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            await HandleErrorResponseWithKnownTypeForUpdate<string>(_httpRequest, _httpResponse, statusCode);
        }


        /// <summary>
        /// Method that generates error message for status code
        /// </summary>
        private string GetErrorMessageForUpdate(int statusCode)
        {
            return string.Format("Operation Update returned status code: '{0}'", statusCode);
        }


        /// <summary>
        /// Handle responses where error model is a known primary type
        /// Creates a HttpRestException object and throws it
        /// </summary>
        /// <exception cref="T:Microsoft.Rest.HttpRestException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleErrorResponseWithKnownTypeForUpdate<T>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            string _responseContent = null;
            var ex = new HttpRestException<T>(GetErrorMessageForUpdate(statusCode));
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


        /// <summary>
        /// Updates the tags for an availability set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='avset'>
        /// The name of the storage availability set.
        /// </param>
        /// <param name='tags'>
        /// A set of tags. A description about the set of tags.
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
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse> UpdateWithHttpMessagesAsync(string resourceGroupName, string avset, IDictionary<string, string> tags, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            if (avset == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "avset");
            }
            if (avset != null)
            {
                if (avset.Length > 80)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "avset", 80);
                }
            }
            if (tags == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "tags");
            }
            AvailabilitySetUpdateParameters tags1 = new AvailabilitySetUpdateParameters();
            if (tags != null)
            {
                tags1.Tags = tags;
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("avset", avset);
                tracingParameters.Add("tags1", tags1);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Update", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "parameterFlattening/{resourceGroupName}/{availabilitySetName}").ToString();
            _url = _url.Replace("{resourceGroupName}", System.Uri.EscapeDataString(resourceGroupName));
            _url = _url.Replace("{availabilitySetName}", System.Uri.EscapeDataString(avset));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("PATCH");
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

            // Serialize Request
            string _requestContent = null;
            if(tags1 != null)
            {
                _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(tags1, Client.SerializationSettings);
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
                            await HandleDefaultErrorResponseForUpdate(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new HttpOperationResponse();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
