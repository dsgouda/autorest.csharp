// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsAzureSpecials
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// HeaderOperations operations.
    /// </summary>
    internal partial class HeaderOperations : IServiceOperations<AutoRestAzureSpecialParametersTestClient>, IHeaderOperations
    {
        /// <summary>
        /// Initializes a new instance of the HeaderOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        internal HeaderOperations(AutoRestAzureSpecialParametersTestClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the AutoRestAzureSpecialParametersTestClient
        /// </summary>
        public AutoRestAzureSpecialParametersTestClient Client { get; private set; }

        /// <summary>
        /// Handle other unhandled status codes
        /// </summary>
        /// <exception cref="ErrorException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleDefaultErrorResponseForCustomNamedRequestId(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            await HandleErrorResponseForCustomNamedRequestId<Error>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
        }

        /// <summary>
        /// Method that generates error message for status code
        /// </summary>
        private string GetErrorMessageForCustomNamedRequestId(int statusCode)
        {
            return string.Format("Operation CustomNamedRequestId returned status code: '{0}'", statusCode);
        }

        /// <summary>
        /// Handle error responses, deserialize errors of types V and throw exceptions of type T
        /// </summary>
        private async Task HandleErrorResponseForCustomNamedRequestId<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
            where V : IHttpRestErrorModel
        {
            string errorMessage = GetErrorMessageForCustomNamedRequestId(statusCode);
            string _responseContent = null;
            if (_httpResponse.Content != null)
            {
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<V>(_responseContent, deserializationSettings);
                    if(errorResponseModel!=null)
                    {
                        errorResponseModel.CreateAndThrowException(new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()),
                                                                    new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                    }
                    else
                    {
                        throw new RestException(errorMessage);
                    }
                }
                catch (JsonException)
                {
                    throw new RestException(errorMessage);
                }
                catch(RestException ex)
                {
                    // set the request id to exception
                    if (_httpResponse.Headers.Contains("foo-request-id"))
                    {
                        ex.RequestId = _httpResponse.Headers.GetValues("foo-request-id").FirstOrDefault();
                    }
                    throw;
                }
            }
            _httpRequest.Dispose();
            if (_httpResponse != null)
            {
                _httpResponse.Dispose();
            }
        }

        /// <summary>
        /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the
        /// header of the request
        /// </summary>
        /// <param name='fooClientRequestId'>
        /// The fooRequestId
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
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
        public async Task<AzureOperationHeaderResponse<HeaderCustomNamedRequestIdHeadersInner>> CustomNamedRequestIdWithHttpMessagesAsync(string fooClientRequestId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (fooClientRequestId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "fooClientRequestId");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("fooClientRequestId", fooClientRequestId);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "CustomNamedRequestId", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "azurespecials/customNamedRequestId").ToString();
            List<string> _queryParameters = new List<string>();
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("foo-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (fooClientRequestId != null)
            {
                if (_httpRequest.Headers.Contains("foo-client-request-id"))
                {
                    _httpRequest.Headers.Remove("foo-client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("foo-client-request-id", fooClientRequestId);
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


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
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
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
                            await HandleDefaultErrorResponseForCustomNamedRequestId(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new AzureOperationHeaderResponse<HeaderCustomNamedRequestIdHeadersInner>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("foo-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("foo-request-id").FirstOrDefault();
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<HeaderCustomNamedRequestIdHeadersInner>(JsonSerializer.Create(Client.DeserializationSettings));
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
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
        /// <exception cref="ErrorException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleDefaultErrorResponseForCustomNamedRequestIdParamGrouping(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            await HandleErrorResponseForCustomNamedRequestIdParamGrouping<Error>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
        }

        /// <summary>
        /// Method that generates error message for status code
        /// </summary>
        private string GetErrorMessageForCustomNamedRequestIdParamGrouping(int statusCode)
        {
            return string.Format("Operation CustomNamedRequestIdParamGrouping returned status code: '{0}'", statusCode);
        }

        /// <summary>
        /// Handle error responses, deserialize errors of types V and throw exceptions of type T
        /// </summary>
        private async Task HandleErrorResponseForCustomNamedRequestIdParamGrouping<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
            where V : IHttpRestErrorModel
        {
            string errorMessage = GetErrorMessageForCustomNamedRequestIdParamGrouping(statusCode);
            string _responseContent = null;
            if (_httpResponse.Content != null)
            {
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<V>(_responseContent, deserializationSettings);
                    if(errorResponseModel!=null)
                    {
                        errorResponseModel.CreateAndThrowException(new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()),
                                                                    new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                    }
                    else
                    {
                        throw new RestException(errorMessage);
                    }
                }
                catch (JsonException)
                {
                    throw new RestException(errorMessage);
                }
                catch(RestException ex)
                {
                    // set the request id to exception
                    if (_httpResponse.Headers.Contains("foo-request-id"))
                    {
                        ex.RequestId = _httpResponse.Headers.GetValues("foo-request-id").FirstOrDefault();
                    }
                    throw;
                }
            }
            _httpRequest.Dispose();
            if (_httpResponse != null)
            {
                _httpResponse.Dispose();
            }
        }

        /// <summary>
        /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the
        /// header of the request, via a parameter group
        /// </summary>
        /// <param name='headerCustomNamedRequestIdParamGroupingParameters'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
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
        public async Task<AzureOperationHeaderResponse<HeaderCustomNamedRequestIdParamGroupingHeadersInner>> CustomNamedRequestIdParamGroupingWithHttpMessagesAsync(HeaderCustomNamedRequestIdParamGroupingParametersInner headerCustomNamedRequestIdParamGroupingParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (headerCustomNamedRequestIdParamGroupingParameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "headerCustomNamedRequestIdParamGroupingParameters");
            }
            if (headerCustomNamedRequestIdParamGroupingParameters != null)
            {
                headerCustomNamedRequestIdParamGroupingParameters.Validate();
            }
            string fooClientRequestId = default(string);
            if (headerCustomNamedRequestIdParamGroupingParameters != null)
            {
                fooClientRequestId = headerCustomNamedRequestIdParamGroupingParameters.FooClientRequestId;
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("fooClientRequestId", fooClientRequestId);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "CustomNamedRequestIdParamGrouping", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "azurespecials/customNamedRequestIdParamGrouping").ToString();
            List<string> _queryParameters = new List<string>();
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("foo-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }
            if (fooClientRequestId != null)
            {
                if (_httpRequest.Headers.Contains("foo-client-request-id"))
                {
                    _httpRequest.Headers.Remove("foo-client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("foo-client-request-id", fooClientRequestId);
            }


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
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
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
                            await HandleDefaultErrorResponseForCustomNamedRequestIdParamGrouping(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new AzureOperationHeaderResponse<HeaderCustomNamedRequestIdParamGroupingHeadersInner>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("foo-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("foo-request-id").FirstOrDefault();
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<HeaderCustomNamedRequestIdParamGroupingHeadersInner>(JsonSerializer.Create(Client.DeserializationSettings));
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
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
        /// <exception cref="ErrorException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleDefaultErrorResponseForCustomNamedRequestIdHead(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            await HandleErrorResponseForCustomNamedRequestIdHead<Error>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
        }

        /// <summary>
        /// Method that generates error message for status code
        /// </summary>
        private string GetErrorMessageForCustomNamedRequestIdHead(int statusCode)
        {
            return string.Format("Operation CustomNamedRequestIdHead returned status code: '{0}'", statusCode);
        }

        /// <summary>
        /// Handle error responses, deserialize errors of types V and throw exceptions of type T
        /// </summary>
        private async Task HandleErrorResponseForCustomNamedRequestIdHead<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
            where V : IHttpRestErrorModel
        {
            string errorMessage = GetErrorMessageForCustomNamedRequestIdHead(statusCode);
            string _responseContent = null;
            if (_httpResponse.Content != null)
            {
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<V>(_responseContent, deserializationSettings);
                    if(errorResponseModel!=null)
                    {
                        errorResponseModel.CreateAndThrowException(new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()),
                                                                    new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                    }
                    else
                    {
                        throw new RestException(errorMessage);
                    }
                }
                catch (JsonException)
                {
                    throw new RestException(errorMessage);
                }
                catch(RestException ex)
                {
                    // set the request id to exception
                    if (_httpResponse.Headers.Contains("foo-request-id"))
                    {
                        ex.RequestId = _httpResponse.Headers.GetValues("foo-request-id").FirstOrDefault();
                    }
                    throw;
                }
            }
            _httpRequest.Dispose();
            if (_httpResponse != null)
            {
                _httpResponse.Dispose();
            }
        }

        /// <summary>
        /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the
        /// header of the request
        /// </summary>
        /// <param name='fooClientRequestId'>
        /// The fooRequestId
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
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
        public async Task<AzureOperationResponse<bool,HeaderCustomNamedRequestIdHeadHeadersInner>> CustomNamedRequestIdHeadWithHttpMessagesAsync(string fooClientRequestId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (fooClientRequestId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "fooClientRequestId");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("fooClientRequestId", fooClientRequestId);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "CustomNamedRequestIdHead", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "azurespecials/customNamedRequestIdHead").ToString();
            List<string> _queryParameters = new List<string>();
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("HEAD");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("foo-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (fooClientRequestId != null)
            {
                if (_httpRequest.Headers.Contains("foo-client-request-id"))
                {
                    _httpRequest.Headers.Remove("foo-client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("foo-client-request-id", fooClientRequestId);
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


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
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            if ((int)_statusCode != 200 && (int)_statusCode != 404)
            {
                try
                {
                    switch(_statusCode)
                    {
                        default:
                            await HandleDefaultErrorResponseForCustomNamedRequestIdHead(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new AzureOperationResponse<bool,HeaderCustomNamedRequestIdHeadHeadersInner>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            _result.Body = _statusCode == System.Net.HttpStatusCode.OK;
            if (_httpResponse.Headers.Contains("foo-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("foo-request-id").FirstOrDefault();
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<HeaderCustomNamedRequestIdHeadHeadersInner>(JsonSerializer.Create(Client.DeserializationSettings));
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
