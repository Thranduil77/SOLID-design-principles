namespace _2__OpenClosedPrinciple.Example2Good
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Example2Bad;

    #endregion

    public class Example2Good
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

            var filter = new MonitorFilterGood();

            var lcdMonitors = filter.Filter(monitors, new MonitorTypeSpecification(MonitorType.Lcd));
            Console.WriteLine("All LCD monitors");
            foreach (var monitor in lcdMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }


            /*
             * Right now, we are perfectly able to extend our MonitorFilter class without any further
             * modification. So, if now we have to implement the filter by screen feature, for example
             * only widescreen monitors, we can do it with a new class:
             * */
            var wideScreenMonitors = filter.Filter(lcdMonitors, new ScreenFilterSpecification(Screen.WideScreen));
            foreach (var monitor in wideScreenMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }

            /*
             * With this project structure, we can even extend our filtering criterion to, for example, only OLED and widescreen monitors. 
             * All we have to do is to create another specification class.
             * */
        }
    }
}