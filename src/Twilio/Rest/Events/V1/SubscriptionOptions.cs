/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Events.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// ReadSubscriptionOptions
    /// </summary>
    public class ReadSubscriptionOptions : ReadOptions<SubscriptionResource>
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// FetchSubscriptionOptions
    /// </summary>
    public class FetchSubscriptionOptions : IOptions<SubscriptionResource>
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSubscriptionOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public FetchSubscriptionOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// CreateSubscriptionOptions
    /// </summary>
    public class CreateSubscriptionOptions : IOptions<SubscriptionResource>
    {
        /// <summary>
        /// The description
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// The sink_sid
        /// </summary>
        public string SinkSid { get; }
        /// <summary>
        /// The types
        /// </summary>
        public List<object> Types { get; }

        /// <summary>
        /// Construct a new CreateSubscriptionOptions
        /// </summary>
        /// <param name="description"> The description </param>
        /// <param name="sinkSid"> The sink_sid </param>
        /// <param name="types"> The types </param>
        public CreateSubscriptionOptions(string description, string sinkSid, List<object> types)
        {
            Description = description;
            SinkSid = sinkSid;
            Types = types;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Description != null)
            {
                p.Add(new KeyValuePair<string, string>("Description", Description));
            }

            if (SinkSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SinkSid", SinkSid.ToString()));
            }

            if (Types != null)
            {
                p.AddRange(Types.Select(prop => new KeyValuePair<string, string>("Types", Serializers.JsonObject(prop))));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// DeleteSubscriptionOptions
    /// </summary>
    public class DeleteSubscriptionOptions : IOptions<SubscriptionResource>
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteSubscriptionOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public DeleteSubscriptionOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}