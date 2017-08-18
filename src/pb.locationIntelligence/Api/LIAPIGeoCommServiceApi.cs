/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 3.6.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace pb.locationIntelligence.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILIAPIGeoCommServiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Rate Center By Address.
        /// </summary>
        /// <remarks>
        /// Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched.</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional, default to USA)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>RateCenterResponse</returns>
        RateCenterResponse GetRateCenterByAddress (string address, string country = null, string areaCodeInfo = null, string level = null);

        /// <summary>
        /// Rate Center By Address.
        /// </summary>
        /// <remarks>
        /// Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched.</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional, default to USA)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>ApiResponse of RateCenterResponse</returns>
        ApiResponse<RateCenterResponse> GetRateCenterByAddressWithHttpInfo (string address, string country = null, string areaCodeInfo = null, string level = null);
        /// <summary>
        /// Rate Center By Location.
        /// </summary>
        /// <remarks>
        /// Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>RateCenterResponse</returns>
        RateCenterResponse GetRateCenterByLocation (string longitude, string latitude, string areaCodeInfo = null, string level = null);

        /// <summary>
        /// Rate Center By Location.
        /// </summary>
        /// <remarks>
        /// Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>ApiResponse of RateCenterResponse</returns>
        ApiResponse<RateCenterResponse> GetRateCenterByLocationWithHttpInfo (string longitude, string latitude, string areaCodeInfo = null, string level = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Rate Center By Address.
        /// </summary>
        /// <remarks>
        /// Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched.</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional, default to USA)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>Task of RateCenterResponse</returns>
        System.Threading.Tasks.Task<RateCenterResponse> GetRateCenterByAddressAsync (string address, string country = null, string areaCodeInfo = null, string level = null);

        /// <summary>
        /// Rate Center By Address.
        /// </summary>
        /// <remarks>
        /// Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched.</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional, default to USA)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>Task of ApiResponse (RateCenterResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RateCenterResponse>> GetRateCenterByAddressAsyncWithHttpInfo (string address, string country = null, string areaCodeInfo = null, string level = null);
        /// <summary>
        /// Rate Center By Location.
        /// </summary>
        /// <remarks>
        /// Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>Task of RateCenterResponse</returns>
        System.Threading.Tasks.Task<RateCenterResponse> GetRateCenterByLocationAsync (string longitude, string latitude, string areaCodeInfo = null, string level = null);

        /// <summary>
        /// Rate Center By Location.
        /// </summary>
        /// <remarks>
        /// Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </remarks>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>Task of ApiResponse (RateCenterResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RateCenterResponse>> GetRateCenterByLocationAsyncWithHttpInfo (string longitude, string latitude, string areaCodeInfo = null, string level = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LIAPIGeoCommServiceApi : ILIAPIGeoCommServiceApi
    {
        private pb.locationIntelligence.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LIAPIGeoCommServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LIAPIGeoCommServiceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = pb.locationIntelligence.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LIAPIGeoCommServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LIAPIGeoCommServiceApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = pb.locationIntelligence.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public pb.locationIntelligence.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Rate Center By Address. Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched.</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional, default to USA)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>RateCenterResponse</returns>
        public RateCenterResponse GetRateCenterByAddress (string address, string country = null, string areaCodeInfo = null, string level = null)
        {
             ApiResponse<RateCenterResponse> localVarResponse = GetRateCenterByAddressWithHttpInfo(address, country, areaCodeInfo, level);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Rate Center By Address. Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched.</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional, default to USA)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>ApiResponse of RateCenterResponse</returns>
        public ApiResponse< RateCenterResponse > GetRateCenterByAddressWithHttpInfo (string address, string country = null, string areaCodeInfo = null, string level = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling LIAPIGeoCommServiceApi->GetRateCenterByAddress");

            var localVarPath = "/geocomm/v1/ratecenter/byaddress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (address != null) localVarQueryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
            if (country != null) localVarQueryParams.Add("country", Configuration.ApiClient.ParameterToString(country)); // query parameter
            if (areaCodeInfo != null) localVarQueryParams.Add("areaCodeInfo", Configuration.ApiClient.ParameterToString(areaCodeInfo)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRateCenterByAddress", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RateCenterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (RateCenterResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RateCenterResponse)));
            
        }

        /// <summary>
        /// Rate Center By Address. Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched.</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional, default to USA)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>Task of RateCenterResponse</returns>
        public async System.Threading.Tasks.Task<RateCenterResponse> GetRateCenterByAddressAsync (string address, string country = null, string areaCodeInfo = null, string level = null)
        {
             ApiResponse<RateCenterResponse> localVarResponse = await GetRateCenterByAddressAsyncWithHttpInfo(address, country, areaCodeInfo, level);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Rate Center By Address. Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">The address to be searched.</param>
        /// <param name="country">3 letter ISO code of the country to be searched. Allowed values USA,CAN (optional, default to USA)</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>Task of ApiResponse (RateCenterResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RateCenterResponse>> GetRateCenterByAddressAsyncWithHttpInfo (string address, string country = null, string areaCodeInfo = null, string level = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling LIAPIGeoCommServiceApi->GetRateCenterByAddress");

            var localVarPath = "/geocomm/v1/ratecenter/byaddress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (address != null) localVarQueryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
            if (country != null) localVarQueryParams.Add("country", Configuration.ApiClient.ParameterToString(country)); // query parameter
            if (areaCodeInfo != null) localVarQueryParams.Add("areaCodeInfo", Configuration.ApiClient.ParameterToString(areaCodeInfo)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRateCenterByAddress", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RateCenterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (RateCenterResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RateCenterResponse)));
            
        }

        /// <summary>
        /// Rate Center By Location. Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>RateCenterResponse</returns>
        public RateCenterResponse GetRateCenterByLocation (string longitude, string latitude, string areaCodeInfo = null, string level = null)
        {
             ApiResponse<RateCenterResponse> localVarResponse = GetRateCenterByLocationWithHttpInfo(longitude, latitude, areaCodeInfo, level);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Rate Center By Location. Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>ApiResponse of RateCenterResponse</returns>
        public ApiResponse< RateCenterResponse > GetRateCenterByLocationWithHttpInfo (string longitude, string latitude, string areaCodeInfo = null, string level = null)
        {
            // verify the required parameter 'longitude' is set
            if (longitude == null)
                throw new ApiException(400, "Missing required parameter 'longitude' when calling LIAPIGeoCommServiceApi->GetRateCenterByLocation");
            // verify the required parameter 'latitude' is set
            if (latitude == null)
                throw new ApiException(400, "Missing required parameter 'latitude' when calling LIAPIGeoCommServiceApi->GetRateCenterByLocation");

            var localVarPath = "/geocomm/v1/ratecenter/bylocation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (longitude != null) localVarQueryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (latitude != null) localVarQueryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (areaCodeInfo != null) localVarQueryParams.Add("areaCodeInfo", Configuration.ApiClient.ParameterToString(areaCodeInfo)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRateCenterByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RateCenterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (RateCenterResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RateCenterResponse)));
            
        }

        /// <summary>
        /// Rate Center By Location. Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>Task of RateCenterResponse</returns>
        public async System.Threading.Tasks.Task<RateCenterResponse> GetRateCenterByLocationAsync (string longitude, string latitude, string areaCodeInfo = null, string level = null)
        {
             ApiResponse<RateCenterResponse> localVarResponse = await GetRateCenterByLocationAsyncWithHttpInfo(longitude, latitude, areaCodeInfo, level);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Rate Center By Location. Accepts latitude &amp; longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.
        /// </summary>
        /// <exception cref="pb.locationIntelligence.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="areaCodeInfo">Specifies whether area code information will be part of response.Allowed values True,False. (optional, default to False)</param>
        /// <param name="level">Level (basic/detail).Allowed values detail,basic. (optional, default to basic)</param>
        /// <returns>Task of ApiResponse (RateCenterResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RateCenterResponse>> GetRateCenterByLocationAsyncWithHttpInfo (string longitude, string latitude, string areaCodeInfo = null, string level = null)
        {
            // verify the required parameter 'longitude' is set
            if (longitude == null)
                throw new ApiException(400, "Missing required parameter 'longitude' when calling LIAPIGeoCommServiceApi->GetRateCenterByLocation");
            // verify the required parameter 'latitude' is set
            if (latitude == null)
                throw new ApiException(400, "Missing required parameter 'latitude' when calling LIAPIGeoCommServiceApi->GetRateCenterByLocation");

            var localVarPath = "/geocomm/v1/ratecenter/bylocation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (longitude != null) localVarQueryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (latitude != null) localVarQueryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (areaCodeInfo != null) localVarQueryParams.Add("areaCodeInfo", Configuration.ApiClient.ParameterToString(areaCodeInfo)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRateCenterByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RateCenterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (RateCenterResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RateCenterResponse)));
            
        }

    }
}
