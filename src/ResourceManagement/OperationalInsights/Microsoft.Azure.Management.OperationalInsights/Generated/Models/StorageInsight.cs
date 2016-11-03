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
    /// The top level storage insight resource container.
    /// </summary>
    [JsonTransformation]
    public partial class StorageInsight : Resource
    {
        /// <summary>
        /// Initializes a new instance of the StorageInsight class.
        /// </summary>
        public StorageInsight() { }

        /// <summary>
        /// Initializes a new instance of the StorageInsight class.
        /// </summary>
        public StorageInsight(StorageAccount storageAccount, String id = default(String), String name = default(String), String type = default(String), String location = default(String), IDictionary<string, String> tags = default(IDictionary<string, String>), IList<string> containers = default(IList<string>), IList<string> tables = default(IList<string>), StorageInsightStatus status = default(StorageInsightStatus), string eTag = default(string))
            : base(id, name, type, location, tags)
        {
            Containers = containers;
            Tables = tables;
            StorageAccount = storageAccount;
            Status = status;
            ETag = eTag;
        }

        /// <summary>
        /// Gets or sets the names of the blob containers that the workspace
        /// should read
        /// </summary>
        [JsonProperty(PropertyName = "properties.containers")]
        public IList<string> Containers { get; set; }

        /// <summary>
        /// Gets or sets the names of the Azure tables that the workspace
        /// should read
        /// </summary>
        [JsonProperty(PropertyName = "properties.tables")]
        public IList<string> Tables { get; set; }

        /// <summary>
        /// Gets or sets the storage account connection details
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccount")]
        public StorageAccount StorageAccount { get; set; }

        /// <summary>
        /// Gets or sets the status of the storage insight
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public StorageInsightStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the storage insight.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (StorageAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccount");
            }
        }
    }
}
