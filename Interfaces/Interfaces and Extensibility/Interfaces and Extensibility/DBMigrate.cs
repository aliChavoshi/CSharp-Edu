using System;

namespace Interfaces_and_Extensibility
{
    public class DBMigrate
    {
        private readonly ILogger _logger;

        public DBMigrate(ILogger logger)
        {
            _logger = logger;
        }


        public void Migrate()
        {
            _logger.LogInfo("Migration Started at {0}" + DateTime.Now);

            //Deatial to migrating the database

            _logger.LogInfo("Migration Finished  at {0}" + DateTime.Now);
        }
    }
}
