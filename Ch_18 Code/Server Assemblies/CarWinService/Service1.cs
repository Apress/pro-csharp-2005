using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

namespace CarWinService
{
    public partial class CarService : ServiceBase
    {
        public CarService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Create a new HttpChannel
            HttpChannel c = new HttpChannel(32469);
            ChannelServices.RegisterChannel(c);

            // Register as single call WKO.
            RemotingConfiguration.RegisterWellKnownServiceType(
                 typeof(CarGeneralAsm.CarProvider),
                 "CarProvider.soap",
                 WellKnownObjectMode.SingleCall);

            // Log our successful startup.
            EventLog.WriteEntry("CarWinService",
                 "CarWinService started successfully!",
                 EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("CarWinService",
                "CarWinService stopped",
                EventLogEntryType.Information);
        }
    }
}
