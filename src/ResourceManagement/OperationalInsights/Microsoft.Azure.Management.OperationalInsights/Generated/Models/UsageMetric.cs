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
    /// A metric describing the usage of a resource.
    /// </summary>
    public partial class UsageMetric
    {
        /// <summary>
        /// Initializes a new instance of the UsageMetric class.
        /// </summary>
        public UsageMetric() { }

        /// <summary>
        /// Initializes a new instance of the UsageMetric class.
        /// </summary>
        public UsageMetric(MetricName name = default(MetricName), string unit = default(string), double? currentValue = default(double?), double? limit = default(double?), DateTime? nextResetTime = default(DateTime?), string quotaPeriod = default(string))
        {
            Name = name;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            NextResetTime = nextResetTime;
            QuotaPeriod = quotaPeriod;
        }

        /// <summary>
        /// Gets or sets the name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public MetricName Name { get; set; }

        /// <summary>
        /// Gets or sets the units used for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the current value of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public double? CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets the quota limit for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Gets or sets the time that the metric's value will reset.
        /// </summary>
        [JsonProperty(PropertyName = "nextResetTime")]
        public DateTime? NextResetTime { get; set; }

        /// <summary>
        /// Gets or sets the quota period that determines the length of time
        /// between value resets.
        /// </summary>
        [JsonProperty(PropertyName = "quotaPeriod")]
        public string QuotaPeriod { get; set; }

    }
}
