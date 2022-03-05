namespace Compositions
{
    //Class
    public class Installer
    {
        //Field
        private readonly Logger _logger;
        //Ctor
        public Installer(Logger logger)
        {
            _logger = logger;
        }
        //Method
        public void Install()
        {
            _logger.Log("Installer is log");
        }

    }
}
