/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// MessageResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account
{

    public class MessageResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Queued = new StatusEnum("queued");
            public static readonly StatusEnum Sending = new StatusEnum("sending");
            public static readonly StatusEnum Sent = new StatusEnum("sent");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum Delivered = new StatusEnum("delivered");
            public static readonly StatusEnum Undelivered = new StatusEnum("undelivered");
            public static readonly StatusEnum Receiving = new StatusEnum("receiving");
            public static readonly StatusEnum Received = new StatusEnum("received");
            public static readonly StatusEnum Accepted = new StatusEnum("accepted");
            public static readonly StatusEnum Scheduled = new StatusEnum("scheduled");
            public static readonly StatusEnum Read = new StatusEnum("read");
            public static readonly StatusEnum PartiallyDelivered = new StatusEnum("partially_delivered");
        }

        public sealed class DirectionEnum : StringEnum
        {
            private DirectionEnum(string value) : base(value) {}
            public DirectionEnum() {}
            public static implicit operator DirectionEnum(string value)
            {
                return new DirectionEnum(value);
            }

            public static readonly DirectionEnum Inbound = new DirectionEnum("inbound");
            public static readonly DirectionEnum OutboundApi = new DirectionEnum("outbound-api");
            public static readonly DirectionEnum OutboundCall = new DirectionEnum("outbound-call");
            public static readonly DirectionEnum OutboundReply = new DirectionEnum("outbound-reply");
        }

        public sealed class ContentRetentionEnum : StringEnum
        {
            private ContentRetentionEnum(string value) : base(value) {}
            public ContentRetentionEnum() {}
            public static implicit operator ContentRetentionEnum(string value)
            {
                return new ContentRetentionEnum(value);
            }

            public static readonly ContentRetentionEnum Retain = new ContentRetentionEnum("retain");
        }

        public sealed class AddressRetentionEnum : StringEnum
        {
            private AddressRetentionEnum(string value) : base(value) {}
            public AddressRetentionEnum() {}
            public static implicit operator AddressRetentionEnum(string value)
            {
                return new AddressRetentionEnum(value);
            }

            public static readonly AddressRetentionEnum Retain = new AddressRetentionEnum("retain");
        }

        public sealed class TrafficTypeEnum : StringEnum
        {
            private TrafficTypeEnum(string value) : base(value) {}
            public TrafficTypeEnum() {}
            public static implicit operator TrafficTypeEnum(string value)
            {
                return new TrafficTypeEnum(value);
            }

            public static readonly TrafficTypeEnum Free = new TrafficTypeEnum("free");
        }

        private static Request BuildCreateRequest(CreateMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Messages.json",
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Send a message from the account used to make the request
        /// </summary>
        /// <param name="options"> Create Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Create(CreateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Send a message from the account used to make the request
        /// </summary>
        /// <param name="options"> Create Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(CreateMessageOptions options,
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Send a message from the account used to make the request
        /// </summary>
        /// <param name="to"> The destination phone number </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="from"> The phone number that initiated the message </param>
        /// <param name="messagingServiceSid"> The SID of the Messaging Service you want to associate with the message. </param>
        /// <param name="body"> The text of the message you want to send. Can be up to 1,600 characters in length. </param>
        /// <param name="mediaUrl"> The URL of the media to send with the message </param>
        /// <param name="statusCallback"> The URL we should call to send status information to your application </param>
        /// <param name="applicationSid"> The application to use for callbacks </param>
        /// <param name="maxPrice"> The total maximum price up to 4 decimal places in US dollars acceptable for the message to
        ///                be delivered. </param>
        /// <param name="provideFeedback"> Whether to confirm delivery of the message </param>
        /// <param name="attempt"> Total numer of attempts made , this inclusive to send out the message </param>
        /// <param name="validityPeriod"> The number of seconds that the message can remain in our outgoing queue. </param>
        /// <param name="forceDelivery"> Reserved </param>
        /// <param name="contentRetention"> Determines if the message content can be stored or redacted based on privacy
        ///                        settings </param>
        /// <param name="addressRetention"> Determines if the address can be stored or obfuscated based on privacy settings
        ///                        </param>
        /// <param name="smartEncoded"> Whether to detect Unicode characters that have a similar GSM-7 character and replace
        ///                    them </param>
        /// <param name="persistentAction"> Rich actions for Channels Messages. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Create(Types.PhoneNumber to,
                                             string pathAccountSid = null,
                                             Types.PhoneNumber from = null,
                                             string messagingServiceSid = null,
                                             string body = null,
                                             List<Uri> mediaUrl = null,
                                             Uri statusCallback = null,
                                             string applicationSid = null,
                                             decimal? maxPrice = null,
                                             bool? provideFeedback = null,
                                             int? attempt = null,
                                             int? validityPeriod = null,
                                             bool? forceDelivery = null,
                                             MessageResource.ContentRetentionEnum contentRetention = null,
                                             MessageResource.AddressRetentionEnum addressRetention = null,
                                             bool? smartEncoded = null,
                                             List<string> persistentAction = null,
                                             ITwilioRestClient client = null)
        {
            var options = new CreateMessageOptions(to){PathAccountSid = pathAccountSid, From = from, MessagingServiceSid = messagingServiceSid, Body = body, MediaUrl = mediaUrl, StatusCallback = statusCallback, ApplicationSid = applicationSid, MaxPrice = maxPrice, ProvideFeedback = provideFeedback, Attempt = attempt, ValidityPeriod = validityPeriod, ForceDelivery = forceDelivery, ContentRetention = contentRetention, AddressRetention = addressRetention, SmartEncoded = smartEncoded, PersistentAction = persistentAction};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Send a message from the account used to make the request
        /// </summary>
        /// <param name="to"> The destination phone number </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="from"> The phone number that initiated the message </param>
        /// <param name="messagingServiceSid"> The SID of the Messaging Service you want to associate with the message. </param>
        /// <param name="body"> The text of the message you want to send. Can be up to 1,600 characters in length. </param>
        /// <param name="mediaUrl"> The URL of the media to send with the message </param>
        /// <param name="statusCallback"> The URL we should call to send status information to your application </param>
        /// <param name="applicationSid"> The application to use for callbacks </param>
        /// <param name="maxPrice"> The total maximum price up to 4 decimal places in US dollars acceptable for the message to
        ///                be delivered. </param>
        /// <param name="provideFeedback"> Whether to confirm delivery of the message </param>
        /// <param name="attempt"> Total numer of attempts made , this inclusive to send out the message </param>
        /// <param name="validityPeriod"> The number of seconds that the message can remain in our outgoing queue. </param>
        /// <param name="forceDelivery"> Reserved </param>
        /// <param name="contentRetention"> Determines if the message content can be stored or redacted based on privacy
        ///                        settings </param>
        /// <param name="addressRetention"> Determines if the address can be stored or obfuscated based on privacy settings
        ///                        </param>
        /// <param name="smartEncoded"> Whether to detect Unicode characters that have a similar GSM-7 character and replace
        ///                    them </param>
        /// <param name="persistentAction"> Rich actions for Channels Messages. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(Types.PhoneNumber to,
                                                                                     string pathAccountSid = null,
                                                                                     Types.PhoneNumber from = null,
                                                                                     string messagingServiceSid = null,
                                                                                     string body = null,
                                                                                     List<Uri> mediaUrl = null,
                                                                                     Uri statusCallback = null,
                                                                                     string applicationSid = null,
                                                                                     decimal? maxPrice = null,
                                                                                     bool? provideFeedback = null,
                                                                                     int? attempt = null,
                                                                                     int? validityPeriod = null,
                                                                                     bool? forceDelivery = null,
                                                                                     MessageResource.ContentRetentionEnum contentRetention = null,
                                                                                     MessageResource.AddressRetentionEnum addressRetention = null,
                                                                                     bool? smartEncoded = null,
                                                                                     List<string> persistentAction = null,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new CreateMessageOptions(to){PathAccountSid = pathAccountSid, From = from, MessagingServiceSid = messagingServiceSid, Body = body, MediaUrl = mediaUrl, StatusCallback = statusCallback, ApplicationSid = applicationSid, MaxPrice = maxPrice, ProvideFeedback = provideFeedback, Attempt = attempt, ValidityPeriod = validityPeriod, ForceDelivery = forceDelivery, ContentRetention = contentRetention, AddressRetention = addressRetention, SmartEncoded = smartEncoded, PersistentAction = persistentAction};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Messages/" + options.PathSid + ".json",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Deletes a message record from your account
        /// </summary>
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static bool Delete(DeleteMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Deletes a message record from your account
        /// </summary>
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMessageOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Deletes a message record from your account
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Deletes a message record from your account
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid,
                                                                          string pathAccountSid = null,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Messages/" + options.PathSid + ".json",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a message belonging to the account used to make the request
        /// </summary>
        /// <param name="options"> Fetch Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Fetch(FetchMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a message belonging to the account used to make the request
        /// </summary>
        /// <param name="options"> Fetch Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(FetchMessageOptions options,
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a message belonging to the account used to make the request
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Fetch(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a message belonging to the account used to make the request
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(string pathSid,
                                                                                    string pathAccountSid = null,
                                                                                    ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Messages.json",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of messages belonging to the account used to make the request
        /// </summary>
        /// <param name="options"> Read Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static ResourceSet<MessageResource> Read(ReadMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<MessageResource>.FromJson("messages", response.Content);
            return new ResourceSet<MessageResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of messages belonging to the account used to make the request
        /// </summary>
        /// <param name="options"> Read Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(ReadMessageOptions options,
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MessageResource>.FromJson("messages", response.Content);
            return new ResourceSet<MessageResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of messages belonging to the account used to make the request
        /// </summary>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to read </param>
        /// <param name="to"> Filter by messages sent to this number </param>
        /// <param name="from"> Filter by from number </param>
        /// <param name="dateSentBefore"> Filter by date sent </param>
        /// <param name="dateSent"> Filter by date sent </param>
        /// <param name="dateSentAfter"> Filter by date sent </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static ResourceSet<MessageResource> Read(string pathAccountSid = null,
                                                        Types.PhoneNumber to = null,
                                                        Types.PhoneNumber from = null,
                                                        DateTime? dateSentBefore = null,
                                                        DateTime? dateSent = null,
                                                        DateTime? dateSentAfter = null,
                                                        int? pageSize = null,
                                                        long? limit = null,
                                                        ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions(){PathAccountSid = pathAccountSid, To = to, From = from, DateSentBefore = dateSentBefore, DateSent = dateSent, DateSentAfter = dateSentAfter, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of messages belonging to the account used to make the request
        /// </summary>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to read </param>
        /// <param name="to"> Filter by messages sent to this number </param>
        /// <param name="from"> Filter by from number </param>
        /// <param name="dateSentBefore"> Filter by date sent </param>
        /// <param name="dateSent"> Filter by date sent </param>
        /// <param name="dateSentAfter"> Filter by date sent </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(string pathAccountSid = null,
                                                                                                Types.PhoneNumber to = null,
                                                                                                Types.PhoneNumber from = null,
                                                                                                DateTime? dateSentBefore = null,
                                                                                                DateTime? dateSent = null,
                                                                                                DateTime? dateSentAfter = null,
                                                                                                int? pageSize = null,
                                                                                                long? limit = null,
                                                                                                ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions(){PathAccountSid = pathAccountSid, To = to, From = from, DateSentBefore = dateSentBefore, DateSent = dateSent, DateSentAfter = dateSentAfter, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<MessageResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<MessageResource> NextPage(Page<MessageResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<MessageResource> PreviousPage(Page<MessageResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Messages/" + options.PathSid + ".json",
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// To redact a message-body from a post-flight message record, post to the message instance resource with an empty body
        /// </summary>
        /// <param name="options"> Update Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Update(UpdateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// To redact a message-body from a post-flight message record, post to the message instance resource with an empty body
        /// </summary>
        /// <param name="options"> Update Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(UpdateMessageOptions options,
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// To redact a message-body from a post-flight message record, post to the message instance resource with an empty body
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="body"> The text of the message you want to send </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to update </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Update(string pathSid,
                                             string body,
                                             string pathAccountSid = null,
                                             ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(pathSid, body){PathAccountSid = pathAccountSid};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// To redact a message-body from a post-flight message record, post to the message instance resource with an empty body
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="body"> The text of the message you want to send </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to update </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(string pathSid,
                                                                                     string body,
                                                                                     string pathAccountSid = null,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(pathSid, body){PathAccountSid = pathAccountSid};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a MessageResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MessageResource object represented by the provided JSON </returns>
        public static MessageResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MessageResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The message text
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; private set; }
        /// <summary>
        /// The number of messages used to deliver the message body
        /// </summary>
        [JsonProperty("num_segments")]
        public string NumSegments { get; private set; }
        /// <summary>
        /// The direction of the message
        /// </summary>
        [JsonProperty("direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageResource.DirectionEnum Direction { get; private set; }
        /// <summary>
        /// The phone number that initiated the message
        /// </summary>
        [JsonProperty("from")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber From { get; private set; }
        /// <summary>
        /// The phone number that received the message
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The amount billed for the message
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; private set; }
        /// <summary>
        /// The description of the error_code
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; private set; }
        /// <summary>
        /// The URI of the resource, relative to `https://api.twilio.com`
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The number of media files associated with the message
        /// </summary>
        [JsonProperty("num_media")]
        public string NumMedia { get; private set; }
        /// <summary>
        /// The status of the message
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The SID of the Messaging Service used with the message.
        /// </summary>
        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the message was sent
        /// </summary>
        [JsonProperty("date_sent")]
        public DateTime? DateSent { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The error code associated with the message
        /// </summary>
        [JsonProperty("error_code")]
        public int? ErrorCode { get; private set; }
        /// <summary>
        /// The currency in which price is measured
        /// </summary>
        [JsonProperty("price_unit")]
        public string PriceUnit { get; private set; }
        /// <summary>
        /// The API version used to process the message
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// A list of related resources identified by their relative URIs
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }

        private MessageResource()
        {

        }
    }

}