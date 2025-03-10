// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.CallAutomation
{
    internal partial class CallMediaRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of CallMediaRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public CallMediaRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2023-01-15-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreatePlayRequest(string callConnectionId, PlayRequestInternal playRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":play", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(playRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Plays audio to participants in the call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="playRequest"> play request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="playRequest"/> is null. </exception>
        public async Task<Response> PlayAsync(string callConnectionId, PlayRequestInternal playRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (playRequest == null)
            {
                throw new ArgumentNullException(nameof(playRequest));
            }

            using var message = CreatePlayRequest(callConnectionId, playRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Plays audio to participants in the call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="playRequest"> play request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="playRequest"/> is null. </exception>
        public Response Play(string callConnectionId, PlayRequestInternal playRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (playRequest == null)
            {
                throw new ArgumentNullException(nameof(playRequest));
            }

            using var message = CreatePlayRequest(callConnectionId, playRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelAllMediaOperationsRequest(string callConnectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":cancelAllMediaOperations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Cancel all media operations in a call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public async Task<Response> CancelAllMediaOperationsAsync(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateCancelAllMediaOperationsRequest(callConnectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Cancel all media operations in a call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public Response CancelAllMediaOperations(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateCancelAllMediaOperationsRequest(callConnectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRecognizeRequest(string callConnectionId, RecognizeRequestInternal recognizeRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":recognize", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(recognizeRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Recognize media from call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="recognizeRequest"> The media recognize request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="recognizeRequest"/> is null. </exception>
        public async Task<Response> RecognizeAsync(string callConnectionId, RecognizeRequestInternal recognizeRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (recognizeRequest == null)
            {
                throw new ArgumentNullException(nameof(recognizeRequest));
            }

            using var message = CreateRecognizeRequest(callConnectionId, recognizeRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Recognize media from call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="recognizeRequest"> The media recognize request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="recognizeRequest"/> is null. </exception>
        public Response Recognize(string callConnectionId, RecognizeRequestInternal recognizeRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (recognizeRequest == null)
            {
                throw new ArgumentNullException(nameof(recognizeRequest));
            }

            using var message = CreateRecognizeRequest(callConnectionId, recognizeRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
