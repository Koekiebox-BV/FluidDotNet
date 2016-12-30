#region License
/*
 * Koekiebox CONFIDENTIAL
 *
 * [2012] - [2017] Koekiebox (Pty) Ltd
 * All Rights Reserved.
 *
 * NOTICE: All information contained herein is, and remains the property
 * of Koekiebox and its suppliers, if any. The intellectual and
 * technical concepts contained herein are proprietary to Koekiebox
 * and its suppliers and may be covered by South African and Foreign Patents,
 * patents in process, and are protected by trade secret or copyright law.
 * Dissemination of this information or reproduction of this material is strictly
 * forbidden unless prior written permission is obtained from Koekiebox.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json;

/// <summary>
/// Base Fluid class for all value objects.
/// </summary>
/// <remarks>
/// 
/// </remarks>
namespace Com.Fluid.Vo.Ws.Auth
{
    /// <summary>
    /// Base JSON value object for Fluid related objects.
    /// </summary>
    public class AppRequestToken : ABaseFluidJSONObject
    {
        /// <summary>
        /// Get and set the EncryptedDataBase64.
        /// </summary>
        [JsonProperty(PropertyName = "encryptedDataBase64")]
        public string EncryptedDataBase64 { get; set; }

        /// <summary>
        /// Get and set the EncryptedDataHmacBase64.
        /// </summary>
        [JsonProperty(PropertyName = "encryptedDataHmacBase64")]
        public string EncryptedDataHmacBase64 { get; set; }

        /// <summary>
        /// Get and set the IvBase64.
        /// </summary>
        [JsonProperty(PropertyName = "ivBase64")]
        public string IvBase64 { get; set; }

        /// <summary>
        /// Get and set the SeedBase64.
        /// </summary>
        [JsonProperty(PropertyName = "seedBase64")]
        public string SeedBase64 { get; set; }

        /// <summary>
        /// Get and set the PrincipalClient.
        /// </summary>
        [JsonProperty(PropertyName = "principalClient")]
        public string PrincipalClient { get; set; }

        /// <summary>
        /// Get and set the salt.
        /// </summary>
        [JsonProperty(PropertyName = "salt")]
        public string Salt { get; set; }

        /// <summary>
        /// Get and set the roleString.
        /// </summary>
        [JsonProperty(PropertyName = "roleString")]
        public string RoleString { get; set; }

        /// <summary>
        /// Get and set the timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }
    }
}
