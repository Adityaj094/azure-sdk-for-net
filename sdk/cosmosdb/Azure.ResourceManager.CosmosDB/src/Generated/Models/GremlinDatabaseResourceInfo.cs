// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Gremlin database resource object. </summary>
    public partial class GremlinDatabaseResourceInfo
    {
        /// <summary> Initializes a new instance of GremlinDatabaseResourceInfo. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB Gremlin database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public GremlinDatabaseResourceInfo(string databaseName)
        {
            Argument.AssertNotNull(databaseName, nameof(databaseName));

            DatabaseName = databaseName;
        }

        /// <summary> Name of the Cosmos DB Gremlin database. </summary>
        public string DatabaseName { get; set; }
    }
}
