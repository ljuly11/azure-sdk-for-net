// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters specifying the search query and range.
    /// </summary>
    public partial class SearchGetSearchResultsParameters
    {
        /// <summary>
        /// Initializes a new instance of the SearchGetSearchResultsParameters
        /// class.
        /// </summary>
        public SearchGetSearchResultsParameters() { }

        /// <summary>
        /// Initializes a new instance of the SearchGetSearchResultsParameters
        /// class.
        /// </summary>
        public SearchGetSearchResultsParameters(long? top = default(long?), Highlight highlight = default(Highlight), string query = default(string), DateTime? start = default(DateTime?), DateTime? end = default(DateTime?))
        {
            Top = top;
            Highlight = highlight;
            Query = query;
            Start = start;
            End = end;
        }

        /// <summary>
        /// Gets or sets the number to get from the top.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public long? Top { get; set; }

        /// <summary>
        /// Gets or sets the highlight that looks for all occurences of a
        /// string.
        /// </summary>
        [JsonProperty(PropertyName = "highlight")]
        public Highlight Highlight { get; set; }

        /// <summary>
        /// Gets or sets the query to search.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the start date filter, so the only query results
        /// returned are after this date.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public DateTime? Start { get; set; }

        /// <summary>
        /// Gets or sets the end date filter, so the only query results
        /// returned are before this date.
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public DateTime? End { get; set; }

    }
}
