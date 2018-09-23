﻿using System.Collections.Generic;
using Nexmo.Api.Request;

namespace Nexmo.Api.ClientMethods
{
    public class ApiSecret
    {
        public Credentials Credentials { get; set; }
        public ApiSecret(Credentials creds)
        {
            Credentials = creds;
        }

        /// <summary>
        /// List the secrets associated with the provided api key.
        /// </summary>
        /// <param name="apiKey">The API key to manage secrets for</param>
        /// <param name="creds">(Optional) Overridden credentials for only this request</param>
        /// <returns>List of secrets</returns>
        public List<Api.ApiSecret.Secret> List(string apiKey, Credentials creds = null)
        {
            return Api.ApiSecret.List(apiKey, creds ?? Credentials);
        }

        /// <summary>
        /// Obtain the details of the secret identified by the provided secret ID.
        /// </summary>
        /// <param name="apiKey">The API key to manage secrets for</param>
        /// <param name="secretId">ID of the API Secret</param>
        /// <param name="creds">(Optional) Overridden credentials for only this request</param>
        /// <returns>The secret</returns>
        public Api.ApiSecret.Secret Get(string apiKey, string secretId, Credentials creds = null)
        {
            return Api.ApiSecret.Get(apiKey, secretId, creds ?? Credentials);
        }

        /// <summary>
        /// Create a secret with the details provided in new secret.
        /// </summary>
        /// <param name="apiKey">The API key to manage secrets for</param>
        /// <param name="newSecret">The new secret must follow these rules:
        ///   minimum 8 characters
        ///   maximum 25 characters
        ///   minimum 1 lower case character
        ///   minimum 1 upper case character
        ///   minimum 1 digit
        /// </param>
        /// <param name="creds">(Optional) Overridden credentials for only this request</param>
        /// <returns>The created secret</returns>
        public Api.ApiSecret.Secret Create(string apiKey, string newSecret, Credentials creds = null)
        {
            return Api.ApiSecret.Create(apiKey, newSecret, creds ?? Credentials);
        }

        /// <summary>
        /// Delete the secret associated with the provided secret ID.
        /// </summary>
        /// <param name="apiKey">The API key to manage secrets for</param>
        /// <param name="secretId">ID of the API Secret</param>
        /// <param name="creds">(Optional) Overridden credentials for only this request</param>
        /// <returns>True/False on delete success/failure</returns>
        public bool Delete(string apiKey, string secretId, Credentials creds = null)
        {
            return Api.ApiSecret.Delete(apiKey, secretId, creds ?? Credentials);
        }
    }
}