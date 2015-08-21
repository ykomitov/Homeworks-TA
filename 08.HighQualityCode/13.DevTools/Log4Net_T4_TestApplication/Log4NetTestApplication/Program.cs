namespace Log4NetTestApplication
{
    using System;
    using System.Linq;
    using log4net;
    using log4net.Config;

    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        static void Main()
        {
            //BasicConfigurator.Configure(); // for logging on the console
            XmlConfigurator.Configure(); // reads settings from App.config file

            for (int i = 0; i < 10; i++)
            {
                Log.Debug("Debug Msg!");
                Log.Error("Error Msg!");
            }
        }
    }
}
