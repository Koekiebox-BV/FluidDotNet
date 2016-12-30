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

using FluidAPI.Com.Fluid.Vo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Base Fluid class for all value objects.
/// </summary>
/// <remarks>
/// 
/// </remarks>
namespace FluidWSDotNetClient.Com.Fluid.Ws.Client.V1
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ABaseClientWS
    {


        public ABaseFluidJSONObject PostJSONWebRequest(ABaseFluidJSONObject objectToPostParam)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://url");

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = ABaseFluidJSONObject.ObjectToString(objectToPostParam);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string responseJson = null;

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                responseJson = streamReader.ReadToEnd();
            }

            if(responseJson == null)
            {
                return null;
            }

            return (ABaseFluidJSONObject)ABaseFluidJSONObject.StringToObject(responseJson);
        }

    }
}
