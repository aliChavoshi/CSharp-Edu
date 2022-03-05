using System;
using System.Reflection.Metadata;
using System.Xml.Serialization;

namespace Interfaces_and_Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DBMigrate(new FileLogger(@"C:\HPLJP1000_P1500_Series.log"));
            dbMigrator.Migrate();
        }
    }
}
