using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Accounts.V1.Credential 
{

    /// <summary>
    /// ReadPublicKeyOptions
    /// </summary>
    public class ReadPublicKeyOptions : ReadOptions<PublicKeyResource> 
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
    /// CreatePublicKeyOptions
    /// </summary>
    public class CreatePublicKeyOptions : IOptions<PublicKeyResource> 
    {
        /// <summary>
        /// The public_key
        /// </summary>
        public string PublicKey { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
    
        /// <summary>
        /// Construct a new CreatePublicKeyOptions
        /// </summary>
        ///
        /// <param name="publicKey"> The public_key </param>
        public CreatePublicKeyOptions(string publicKey)
        {
            PublicKey = publicKey;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PublicKey != null)
            {
                p.Add(new KeyValuePair<string, string>("PublicKey", PublicKey.ToString()));
            }
            
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (AccountSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AccountSid", AccountSid.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// FetchPublicKeyOptions
    /// </summary>
    public class FetchPublicKeyOptions : IOptions<PublicKeyResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchPublicKeyOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public FetchPublicKeyOptions(string pathSid)
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
    /// UpdatePublicKeyOptions
    /// </summary>
    public class UpdatePublicKeyOptions : IOptions<PublicKeyResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
    
        /// <summary>
        /// Construct a new UpdatePublicKeyOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public UpdatePublicKeyOptions(string pathSid)
        {
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            return p;
        }
    }

    /// <summary>
    /// DeletePublicKeyOptions
    /// </summary>
    public class DeletePublicKeyOptions : IOptions<PublicKeyResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new DeletePublicKeyOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public DeletePublicKeyOptions(string pathSid)
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