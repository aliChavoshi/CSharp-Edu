namespace Compositions
{
    //Class
    public class DBMigrator
    {
        //Field
        private readonly Logger _logger;
        //Ctor
        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }
        //Method
        public void Migrator()
        {
            _logger.Log("Migrator is Logger");
        }
    }
}
