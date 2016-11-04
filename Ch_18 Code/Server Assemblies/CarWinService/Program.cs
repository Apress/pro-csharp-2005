using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;

namespace CarWinService
{
    static class Program
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] { new CarService() };
            ServiceBase.Run(ServicesToRun);
        }
    }
}