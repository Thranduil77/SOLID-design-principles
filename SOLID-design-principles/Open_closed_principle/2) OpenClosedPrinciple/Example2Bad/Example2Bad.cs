namespace _2__OpenClosedPrinciple.Example2Bad
{
    #region Using

    using System;
    using System.Collections.Generic;

    #endregion

    public class Example2Bad
    {
        public void Start()
        {
            var monitors = new List<ComputerMonitor>
                           {
                               new ComputerMonitor { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.Oled },
                               new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.Lcd },
                               new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.Led },
                               new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.Oled },
                               new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.Lcd }
                           };

            var filter = new MonitorFilter();

            var lcdMonitors = filter.FilterByType(monitors, MonitorType.Lcd);
            Console.WriteLine("All LCD monitors");
            foreach (var monitor in lcdMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }
            /*
             * This is going to work just fine. But, after a couple of days, we receive a request that our customers want to have 
             * the filter by Screen functionality as well.
             * 
             * We could modify MonitorFilter and add FilterByScreen method, but it's not Open-closed principle
             *  we have a problem because we have to modify our existing class. And what if we receive another request to 
             *  filter all the monitors by type and screen together? We all see where this lead us, towards breaking the OCP.
             *  We are not extending our MonitorFilter class but modifying it.
             * */
        }
    }
}