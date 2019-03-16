namespace Single_responsibility_principle.Example2
{
    #region Using

    using System;

    #endregion

    /// <summary>
    /// Tutorial to follow: https://code-maze.com/single-responsibility-principle/
    /// </summary>
    public class Example2
    {
        //We are going to start with a simple console application.
        //Imagine if we have a task to create a WorkReport feature 
        //that, once created, can be saved to a file and perhaps uploaded to 
        //the cloud or used for some other purpose.
        public void StartExample()
        {
            //Example of bad coding practice
            BadCodeMain();

            //Example of good coding practice
            GoodCodeMain();
        }

        private void BadCodeMain()
        {
            var workReport = new WorkReportBad();
            /*
                 * Problems With This Code
                    We can add even more features in this class, like the Load or UploadToCloud methods because they are all related to our WorkReport, but, just because we can doesn’t mean we have to do it.

                    Right now, there is one issue with the WorkReport class.

                    It has more than one responsibility.

                    Its job is not only to keep track of our work report entries but to save the entire work report to a file. This means that we are violating the SRP and our class has more than one reason to change in the future.

                    The first reason to change this class is if we want to modify the way we keep track of our entries. But if we want to save a file in a different way, that is entirely a new reason to change our class. And imagine what this class would look like if we added additional functionalities to it. We would have so many unrelated code parts in a single class.

                    So, in order to avoid that, let’s refactor the code.
             * */
        }

        private void GoodCodeMain()
        {
            var report = new WorkReportGood();

            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });

            Console.WriteLine(report.ToString());

            //what if we want to create a Scheduler class that keeps track of its scheduled tasks? We would still like to 
            //save it to a file.
            var scheduler = new Scheduler();
            scheduler.AddEntry(new ScheduleTask { TaskId = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
            scheduler.AddEntry(new ScheduleTask { TaskId = 2, Content = "Don't forget to...", ExecuteOn = DateTime.Now.AddDays(2) });
            Console.WriteLine(scheduler.ToString());

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
            saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);
        }
    }
}