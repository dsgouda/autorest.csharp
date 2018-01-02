// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AzureSpecials
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
    /// ApiVersionLocalOperations operations.
    /// </summary>
    internal partial class ApiVersionLocalOperations : IServiceOperations<AutoRestAzureSpecialParametersTestClient>, IApiVersionLocalOperations
    {
        /// <summary>
        /// Initializes a new instance of the ApiVersionLocalOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        internal ApiVersionLocalOperations(AutoRestAzureSpecialParametersTestClient client)
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
        /// Get method with api-version modeled in the method.  pass in api-version =
        /// '2.0' to succeed
        /// </summary>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse> GetMethodLocalValidWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            string apiVersion = "2.0";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("apiVersion", apiVersion);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetMethodLocalValid", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "azurespecials/apiVersion/method/string/none/query/local/2.0").ToString();
            List<string> _queryParameters = new List<string>();
            if (apiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(apiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
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
                               await HandleDefaultErrorResponseForGetMethodLocalValid(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new AzureOperationResponse();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
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
            private async Task HandleDefaultErrorResponseForGetMethodLocalValid(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
            {
                await HandleErrorResponseForGetMethodLocalValid<Error>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
            }

            /// <summary>
            /// Method that generates error message for status code
            /// </summary>
            private string GetErrorMessageForGetMethodLocalValid(int statusCode)
            {
                return string.Format("Operation GetMethodLocalValid returned status code: '{0}'", statusCode);
            }

            /// <summary>
            /// Handle error responses, deserialize errors of types V and throw exceptions of type T
            /// </summary>
            private async Task HandleErrorResponseForGetMethodLocalValid<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
                where V : IHttpRestErrorModel
            {
                string errorMessage = GetErrorMessageForGetMethodLocalValid(statusCode);
                string _responseContent = null;
                if (_httpResponse.Content != null)
                {
                    try
                    {
                        _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<V>(_responseContent, deserializationSettings);
                        if(errorResponseModel!=null)
                        {
                            errorResponseModel.CreateAndThrowException(new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                        }
                        else
                        {
                            throw new CloudException(errorMessage, new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                        }
                    }
                    catch (JsonException)
                    {
                        throw new CloudException(errorMessage, new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                    }
                    catch(RestException ex)
                    {
                        // set the request id to exception
                        if (_httpResponse.Headers.Contains("x-ms-request-id"))
                        {
                            ex.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                        }
                        throw ex;
                    }
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
            }


        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version =
        /// null to succeed
        /// </summary>
        /// <param name='apiVersion'>
        /// This should appear as a method parameter, use value null, this should
        /// result in no serialized parameter
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
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse> GetMethodLocalNullWithHttpMessagesAsync(string apiVersion = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("apiVersion", apiVersion);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetMethodLocalNull", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "azurespecials/apiVersion/method/string/none/query/local/null").ToString();
            List<string> _queryParameters = new List<string>();
            if (apiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(apiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
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
                               await HandleDefaultErrorResponseForGetMethodLocalNull(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new AzureOperationResponse();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
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
            private async Task HandleDefaultErrorResponseForGetMethodLocalNull(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
            {
                await HandleErrorResponseForGetMethodLocalNull<Error>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
            }

            /// <summary>
            /// Method that generates error message for status code
            /// </summary>
            private string GetErrorMessageForGetMethodLocalNull(int statusCode)
            {
                return string.Format("Operation GetMethodLocalNull returned status code: '{0}'", statusCode);
            }

            /// <summary>
            /// Handle error responses, deserialize errors of types V and throw exceptions of type T
            /// </summary>
            private async Task HandleErrorResponseForGetMethodLocalNull<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
                where V : IHttpRestErrorModel
            {
                string errorMessage = GetErrorMessageForGetMethodLocalNull(statusCode);
                string _responseContent = null;
                if (_httpResponse.Content != null)
                {
                    try
                    {
                        _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<V>(_responseContent, deserializationSettings);
                        if(errorResponseModel!=null)
                        {
                            errorResponseModel.CreateAndThrowException(new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                        }
                        else
                        {
                            throw new CloudException(errorMessage, new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                        }
                    }
                    catch (JsonException)
                    {
                        throw new CloudException(errorMessage, new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                    }
                    catch(RestException ex)
                    {
                        // set the request id to exception
                        if (_httpResponse.Headers.Contains("x-ms-request-id"))
                        {
                            ex.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                        }
                        throw ex;
                    }
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
            }


        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version =
        /// '2.0' to succeed
        /// </summary>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse> GetPathLocalValidWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            string apiVersion = "2.0";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("apiVersion", apiVersion);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetPathLocalValid", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "azurespecials/apiVersion/path/string/none/query/local/2.0").ToString();
            List<string> _queryParameters = new List<string>();
            if (apiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(apiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
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
                               await HandleDefaultErrorResponseForGetPathLocalValid(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new AzureOperationResponse();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
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
            private async Task HandleDefaultErrorResponseForGetPathLocalValid(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
            {
                await HandleErrorResponseForGetPathLocalValid<Error>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
            }

            /// <summary>
            /// Method that generates error message for status code
            /// </summary>
            private string GetErrorMessageForGetPathLocalValid(int statusCode)
            {
                return string.Format("Operation GetPathLocalValid returned status code: '{0}'", statusCode);
            }

            /// <summary>
            /// Handle error responses, deserialize errors of types V and throw exceptions of type T
            /// </summary>
            private async Task HandleErrorResponseForGetPathLocalValid<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
                where V : IHttpRestErrorModel
            {
                string errorMessage = GetErrorMessageForGetPathLocalValid(statusCode);
                string _responseContent = null;
                if (_httpResponse.Content != null)
                {
                    try
                    {
                        _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<V>(_responseContent, deserializationSettings);
                        if(errorResponseModel!=null)
                        {
                            errorResponseModel.CreateAndThrowException(new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                        }
                        else
                        {
                            throw new CloudException(errorMessage, new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                        }
                    }
                    catch (JsonException)
                    {
                        throw new CloudException(errorMessage, new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                    }
                    catch(RestException ex)
                    {
                        // set the request id to exception
                        if (_httpResponse.Headers.Contains("x-ms-request-id"))
                        {
                            ex.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                        }
                        throw ex;
                    }
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
            }


        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version =
        /// '2.0' to succeed
        /// </summary>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse> GetSwaggerLocalValidWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            string apiVersion = "2.0";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("apiVersion", apiVersion);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetSwaggerLocalValid", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "azurespecials/apiVersion/swagger/string/none/query/local/2.0").ToString();
            List<string> _queryParameters = new List<string>();
            if (apiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(apiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
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
                               await HandleDefaultErrorResponseForGetSwaggerLocalValid(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new AzureOperationResponse();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
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
            private async Task HandleDefaultErrorResponseForGetSwaggerLocalValid(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
            {
                await HandleErrorResponseForGetSwaggerLocalValid<Error>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
            }

            /// <summary>
            /// Method that generates error message for status code
            /// </summary>
            private string GetErrorMessageForGetSwaggerLocalValid(int statusCode)
            {
                return string.Format("Operation GetSwaggerLocalValid returned status code: '{0}'", statusCode);
            }

            /// <summary>
            /// Handle error responses, deserialize errors of types V and throw exceptions of type T
            /// </summary>
            private async Task HandleErrorResponseForGetSwaggerLocalValid<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
                where V : IHttpRestErrorModel
            {
                string errorMessage = GetErrorMessageForGetSwaggerLocalValid(statusCode);
                string _responseContent = null;
                if (_httpResponse.Content != null)
                {
                    try
                    {
                        _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<V>(_responseContent, deserializationSettings);
                        if(errorResponseModel!=null)
                        {
                            errorResponseModel.CreateAndThrowException(new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                        }
                        else
                        {
                            throw new CloudException(errorMessage, new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                        }
                    }
                    catch (JsonException)
                    {
                        throw new CloudException(errorMessage, new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent));
                    }
                    catch(RestException ex)
                    {
                        // set the request id to exception
                        if (_httpResponse.Headers.Contains("x-ms-request-id"))
                        {
                            ex.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                        }
                        throw ex;
                    }
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
            }


    }
}
