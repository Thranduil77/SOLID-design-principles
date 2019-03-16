namespace _2__OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Let’s imagine that we have a task where we need to calculate the 
            * total cost of all the developer salaries in a single company. Of course, 
            * we are going to make this example simple and focus on the required topic.
            * */
            var example1Bad = new Example1Bad.Example1Bad();
            example1Bad.Main();

            /*
             * So, all of this is working great, but now our boss comes to our office and says
             * that we need a different calculation for the senior and junior developers. The
             * senior developers should have a bonus of 20% on a salary.
             * 
             * We could use switch-case on devReport.Level, but it's not optimal.
             * 
             * Mainly, because we had to modify our existing class behavior which worked perfectly.
             * Another thing is that if our boss comes again and ask us to modify calculation for the 
             * junior dev’s as well, we would have to change our class again. This is totally against
             * of what OCP stands for.
             *  
             * It is obvious that we need to change something in our solution, so, let’s do it.
             * */

            var example1Good = new Example1Good.Example1Good();
            example1Good.Main();

            //Filtering Computer Monitors Example
            /*  Let’s imagine for a moment that we have a task to write an application which gives us all the required
             *  information about computer monitors in our shop, based on different criteria.We will introduce only 
             *  two criteria here, the type of monitors and the screen size.So let’s start with that:*/

            var example2Bad = new Example2Bad.Example2Bad();
            example2Bad.Start();

            /*
             * Lets see a good example
             * */
            var example2Good = new Example2Good.Example2Good();
            example2Good.Start();
        }
    }
}