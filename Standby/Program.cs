using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Standby
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerState state = PowerState.Suspend;
            bool force = false;
            bool disableWakeEvent = false;

            foreach (string arg in Environment.GetCommandLineArgs())
            {
                switch (arg)
                {
                    case "--force":
                        force = true;
                        break;
                    case "--disableWakeEvent":
                        disableWakeEvent = true;
                        break;
                    case "--hibernate":
                        state = PowerState.Hibernate;
                        break;
                }
            }
            Application.SetSuspendState(state, force, disableWakeEvent);
        }
    }
}
