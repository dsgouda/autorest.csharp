// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsBodyFile
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
    /// Files operations.
    /// </summary>
    public partial class Files : IServiceOperations<AutoRestSwaggerBATFileService>, IFiles
    {
        /// <summary>
        /// Initializes a new instance of the Files class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Files(AutoRestSwaggerBATFileService client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the AutoRestSwaggerBATFileService
        /// </summary>
        public AutoRestSwaggerBATFileService Client { get; private set; }

        /// <summary>
        /// Handle other unhandled status codes
        /// </summary>
        /// <exception cref="ErrorException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleDefaultErrorResponseForGetFile(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            await HandleErrorResponseForGetFile<Error>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
        }

        /// <summary>
        /// Method that generates error message for status code
        /// </summary>
        private string GetErrorMessageForGetFile(int statusCode)
        {
            return string.Format("Operation GetFile returned status code: '{0}'", statusCode);
        }

        /// <summary>
        /// Handle error responses, deserialize errors of types V and throw exceptions of type T
        /// </summary>
        private async Task HandleErrorResponseForGetFile<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
            where V : IHttpRestErrorModel
        {
            string errorMessage = GetErrorMessageForGetFile(statusCode);
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
            }
            _httpRequest.Dispose();
            if (_httpResponse != null)
            {
                _httpResponse.Dispose();
            }
        }

        /// <summary>
        /// Get file
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
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Stream>> GetFileWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetFile", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "files/stream/nonempty").ToString();
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

            // Serialize Request
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
            if ((int)_statusCode != 200)
            {
                try
                {
                    switch(_statusCode)
                    {
                        default:
                            await HandleDefaultErrorResponseForGetFile(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new HttpOperationResponse<Stream>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _result.Body = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);
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
        private async Task HandleDefaultErrorResponseForGetFileLarge(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            await HandleErrorResponseForGetFileLarge<Error>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
        }

        /// <summary>
        /// Method that generates error message for status code
        /// </summary>
        private string GetErrorMessageForGetFileLarge(int statusCode)
        {
            return string.Format("Operation GetFileLarge returned status code: '{0}'", statusCode);
        }

        /// <summary>
        /// Handle error responses, deserialize errors of types V and throw exceptions of type T
        /// </summary>
        private async Task HandleErrorResponseForGetFileLarge<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
            where V : IHttpRestErrorModel
        {
            string errorMessage = GetErrorMessageForGetFileLarge(statusCode);
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
            }
            _httpRequest.Dispose();
            if (_httpResponse != null)
            {
                _httpResponse.Dispose();
            }
        }

        /// <summary>
        /// Get a large file
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
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Stream>> GetFileLargeWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetFileLarge", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "files/stream/verylarge").ToString();
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

            // Serialize Request
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
            if ((int)_statusCode != 200)
            {
                try
                {
                    switch(_statusCode)
                    {
                        default:
                            await HandleDefaultErrorResponseForGetFileLarge(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new HttpOperationResponse<Stream>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _result.Body = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);
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
        private async Task HandleDefaultErrorResponseForGetEmptyFile(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            await HandleErrorResponseForGetEmptyFile<Error>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
        }

        /// <summary>
        /// Method that generates error message for status code
        /// </summary>
        private string GetErrorMessageForGetEmptyFile(int statusCode)
        {
            return string.Format("Operation GetEmptyFile returned status code: '{0}'", statusCode);
        }

        /// <summary>
        /// Handle error responses, deserialize errors of types V and throw exceptions of type T
        /// </summary>
        private async Task HandleErrorResponseForGetEmptyFile<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
            where V : IHttpRestErrorModel
        {
            string errorMessage = GetErrorMessageForGetEmptyFile(statusCode);
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
            }
            _httpRequest.Dispose();
            if (_httpResponse != null)
            {
                _httpResponse.Dispose();
            }
        }

        /// <summary>
        /// Get empty file
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
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Stream>> GetEmptyFileWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetEmptyFile", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "files/stream/empty").ToString();
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

            // Serialize Request
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
            if ((int)_statusCode != 200)
            {
                try
                {
                    switch(_statusCode)
                    {
                        default:
                            await HandleDefaultErrorResponseForGetEmptyFile(_httpRequest, _httpResponse, (int)_statusCode);
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
            var _result = new HttpOperationResponse<Stream>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _result.Body = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
