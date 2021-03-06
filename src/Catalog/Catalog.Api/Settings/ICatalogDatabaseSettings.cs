using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Settings
{
    public interface ICatalogDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
        public string CollectionName { get; set; }
    }
}
