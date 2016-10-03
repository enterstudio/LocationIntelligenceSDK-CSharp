﻿#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.pb.locationintelligence.common.model;

namespace com.pb.locationintelligence.geo911.model
{
    /// <summary>
    /// Public Safety Answering Point (PSAP) details 
    /// </summary>
    public class PsapResponse 
    {


        /// <summary>
        /// FCC ID for PSAP.
        /// </summary>
        /// <value>
        /// The FCC identifier.
        /// </value>
        public String fccId { get; set; }
        /// <summary>
        /// Values: enhanced, basic, military, non-9-1-1.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public String type { get; set; }
        /// <summary>
        /// PSAP name.
        /// </summary>
        /// <value>
        /// The agency.
        /// </value>
        public String agency { get; set; }
        /// <summary>
        /// Emergency number that is answered 24x7.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public String phone { get; set; }
        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        public County county { get; set; }
        /// <summary>
        /// Gets or sets the coverage.
        /// </summary>
        /// <value>
        /// The coverage.
        /// </value>
        public Coverage coverage { get; set; }
        /// <summary>
        /// Gets or sets the contact person.
        /// </summary>
        /// <value>
        /// The contact person.
        /// </value>
        public ContactPerson contactPerson { get; set; }
        /// <summary>
        /// Gets or sets the site details.
        /// </summary>
        /// <value>
        /// The site details.
        /// </value>
        public SiteDetails siteDetails { get; set; }
        /// <summary>
        /// Gets or sets the mailing address.
        /// </summary>
        /// <value>
        /// The mailing address.
        /// </value>
        public Address mailingAddress { get; set; }
       
        
    }
}