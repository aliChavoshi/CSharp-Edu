using System;

namespace Compositions
{

    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            var installer = new Installer(logger);
            installer.Install();

            var migrator = new DBMigrator(logger);
            migrator.Migrator();
        }
    }
}
