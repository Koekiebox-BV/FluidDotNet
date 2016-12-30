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
    public class AuthRequest : ABaseFluidJSONObject
    {
        /// <summary>
        /// Get and set the username.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Get and set the lifetime.
        /// </summary>
        [JsonProperty(PropertyName = "lifetime")]
        public long Lifetime { get; set; }
    }
}
