/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Events.V1.Subscription;

namespace Twilio.Tests.Rest.Events.V1.Subscription
{

    [TestFixture]
    public class SubscribedEventTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Events,
                "/v1/Subscriptions/DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SubscribedEvents",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SubscribedEventResource.Read("DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"types\": [],\"meta\": {\"page\": 0,\"page_size\": 10,\"first_page_url\": \"https://events.twilio.com/v1/Subscriptions/DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedEvents?PageSize=10&Page=0\",\"previous_page_url\": null,\"url\": \"https://events.twilio.com/v1/Subscriptions/DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedEvents?PageSize=10&Page=0\",\"next_page_url\": null,\"key\": \"types\"}}"
                                     ));

            var response = SubscribedEventResource.Read("DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadResultsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"types\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"Voice.Calls\",\"version\": 2,\"subscription_sid\": \"DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://events.twilio.com/v1/Subscriptions/DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedEvents/Voice.Calls\"},{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"Video.Rooms\",\"version\": 15,\"subscription_sid\": \"DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://events.twilio.com/v1/Subscriptions/DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedEvents/Video.Rooms\"}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://events.twilio.com/v1/Subscriptions/DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedEvents?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://events.twilio.com/v1/Subscriptions/DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedEvents?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"types\"}}"
                                     ));

            var response = SubscribedEventResource.Read("DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Events,
                "/v1/Subscriptions/DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SubscribedEvents",
                ""
            );
            request.AddPostParam("Type", Serialize("type"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SubscribedEventResource.Create("DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "type", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateAllFieldsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"com.twilio.voice.call.initiated\",\"version\": 5,\"subscription_sid\": \"DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://events.twilio.com/v1/Subscriptions/DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedEvents/com.twilio.voice.call.initiated\"}"
                                     ));

            var response = SubscribedEventResource.Create("DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "type", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateNoVersionResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"com.twilio.voice.call.recorded\",\"version\": 2,\"subscription_sid\": \"DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://events.twilio.com/v1/Subscriptions/DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedEvents/com.twilio.voice.call.recorded\"}"
                                     ));

            var response = SubscribedEventResource.Create("DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "type", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Events,
                "/v1/Subscriptions/DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SubscribedEvents/type",
                ""
            );
            request.AddPostParam("Version", Serialize(1));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SubscribedEventResource.Update("DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "type", 1, client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"com.twilio.voice.call.initiated\",\"version\": 6,\"subscription_sid\": \"DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://events.twilio.com/v1/Subscriptions/DFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedEvents/com.twilio.voice.call.initiated\"}"
                                     ));

            var response = SubscribedEventResource.Update("DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "type", 1, client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Events,
                "/v1/Subscriptions/DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SubscribedEvents/type",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SubscribedEventResource.Delete("DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "type", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = SubscribedEventResource.Delete("DFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "type", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}