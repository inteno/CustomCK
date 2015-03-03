using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace CustomCK {
    public class Migrations : DataMigrationImpl {
        public int Create() {
			// Creating table CustomCKSettingsPartRecord
			SchemaBuilder.CreateTable("CustomCKSettingsPartRecord", table => table
				.ContentPartRecord()
				.Column("ConfigString", DbType.String, column => column.Unlimited())
			);
            return 1;
        }
    }
}