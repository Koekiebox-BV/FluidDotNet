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
namespace FluidAPI.Com.Fluid.Vo
{
    /// <summary>
    /// Base JSON value object for Fluid related objects.
    /// </summary>
    public abstract class ABaseFluidJSONObject
    {
        

        /// <summary>
        /// Get and set the id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }


        /// <summary>
        /// Get and set the service ticket.
        /// </summary>
        [JsonProperty(PropertyName = "serviceTicket")]
        public string ServiceTicket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseFluidJsonObjParam"></param>
        /// <returns></returns>
        public static string ObjectToString(ABaseFluidJSONObject baseFluidJsonObjParam)
        {
            return JsonConvert.SerializeObject(baseFluidJsonObjParam);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="jsonStringParam">The JSON text to parse.</param>
        /// <returns></returns>
        public static object StringToObject(string jsonStringParam)
        {
            return JsonConvert.DeserializeObject(jsonStringParam);
        }




    }
}
