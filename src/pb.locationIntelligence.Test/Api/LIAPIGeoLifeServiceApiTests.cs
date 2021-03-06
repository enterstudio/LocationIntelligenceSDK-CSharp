/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 4.6.0
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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using pb.locationIntelligence.Client;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Model;

namespace pb.locationIntelligence.Test
{
    /// <summary>
    ///  Class for testing LIAPIGeoLifeServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LIAPIGeoLifeServiceApiTests
    {
        private LIAPIGeoLifeServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LIAPIGeoLifeServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LIAPIGeoLifeServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' LIAPIGeoLifeServiceApi
            Assert.IsInstanceOf(typeof(LIAPIGeoLifeServiceApi), instance, "instance is a LIAPIGeoLifeServiceApi");
        }

        
        /// <summary>
        /// Test GetDemographicsByAddress
        /// </summary>
        [Test]
        public void GetDemographicsByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string profile = null;
            //string filter = null;
            //string country = null;
            //var response = instance.GetDemographicsByAddress(address, profile, filter, country);
            //Assert.IsInstanceOf<Demographics> (response, "response is Demographics");
        }
        
        /// <summary>
        /// Test GetDemographicsByLocation
        /// </summary>
        [Test]
        public void GetDemographicsByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string profile = null;
            //string filter = null;
            //var response = instance.GetDemographicsByLocation(longitude, latitude, profile, filter);
            //Assert.IsInstanceOf<Demographics> (response, "response is Demographics");
        }
        
        /// <summary>
        /// Test GetSegmentationByAddress
        /// </summary>
        [Test]
        public void GetSegmentationByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //var response = instance.GetSegmentationByAddress(address, country);
            //Assert.IsInstanceOf<Segmentation> (response, "response is Segmentation");
        }
        
        /// <summary>
        /// Test GetSegmentationByLocation
        /// </summary>
        [Test]
        public void GetSegmentationByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //var response = instance.GetSegmentationByLocation(longitude, latitude);
            //Assert.IsInstanceOf<Segmentation> (response, "response is Segmentation");
        }
        
    }

}
