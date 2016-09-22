using System.Data;
using Orchard.Data.Migration;

namespace CustomCK
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            // Creating table  CustomCKSettingsPartRecord
            SchemaBuilder.CreateTable("CustomCKSettingsPartRecord", table => table
                .ContentPartRecord()
                .Column("ConfigString", DbType.String, column => column.Unlimited())
            );

            SchemaBuilder.DropTable("CustomCKSettingsPartRecord");

            return 2;
        }

        public int UpdateFrom1()
        {
            SchemaBuilder.DropTable("CustomCKSettingsPartRecord");

            return 2;
        }
    }
}
