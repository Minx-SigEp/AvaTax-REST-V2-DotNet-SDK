using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Worksheet Checkup Report Suggested Form Model
    /// </summary>
    public class FilingsCheckupSuggestedFormModel
    {
        /// <summary>
        /// Tax Authority ID of the suggested form returned
        /// </summary>
        public Int32? taxAuthorityId { get; set; }

        /// <summary>
        /// Country of the suggested form returned
        /// </summary>
        public String country { get; set; }

        /// <summary>
        /// Region of the suggested form returned
        /// </summary>
        public String region { get; set; }

        /// <summary>
        /// Name of the suggested form returned
        /// </summary>
        public String returnName { get; set; }


        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }
    }
}