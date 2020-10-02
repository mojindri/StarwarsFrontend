// ***********************************************************************
// Assembly         : StarWarsApiCSharp
// Author           : M.Yankov
// Created          : 02-27-2016
//
// Last Modified By : M.Yankov
// Last Modified On : 04-01-2016
// ***********************************************************************
// <copyright file="DefaultDataService.cs" company="M.Yankov">
//     Copyright ©  2016
// </copyright>
// <summary>Default data service.</summary>
// ***********************************************************************
namespace BlazerMovies.Services
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// This is the default service for consuming data from web.
    /// </summary>
    /// <seealso cref="StarWarsApiCSharp.IDataService" />
    public class DefaultDataService : IDataService
    {
        /// <summary>
        /// The web helper used for retrieve request and response
        /// </summary>
        //private IWebHelper webHelper;
        private HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultDataService"/> class.
        /// </summary>
        /// <param name="webHelper">The web helper.</param>
        public DefaultDataService(HttpClient httpClient)
        {
            
            this._httpClient = httpClient;

        }

        /// <summary>
        /// Gets the result from response helper method.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>System.String or null if there are error while processing the request.</returns>
        public async Task<string> GetDataResult(string url)
        {

            //WebRequest request = this.webHelper.GetRequest(url);

            //WebResponse response = null;
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
      
  

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            try
            {
                //response = this.webHelper.GetResponse(request);

                //  string json = string.Empty;
                // using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                //{
                //    json = reader.ReadToEnd();
                //}
                var json = await response.Content.ReadAsStringAsync();
                return json;
            }
            catch (WebException  ex)
            {
                //// TODO: Check status when there are no Internet connection. 
                return null;
            }
        }
    }
}
