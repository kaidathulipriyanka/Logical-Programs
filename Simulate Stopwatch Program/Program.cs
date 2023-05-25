namespace Simulate_Stopwatch_Program
{
    public class Stopwatch
    {
        private DateTime startTime;
        private DateTime endTime;
        public void Start()
        {
            this.startTime = DateTime.Now;
            Console.WriteLine("Stopwatch started");
        }
        public void Stop()
        {
            this.endTime = DateTime.Now;
            Console.WriteLine("Stopwatch stopped");
        }
        public TimeSpan GetElapsedTime()
        {
            return this.endTime - this.startTime;
        }
        static void Main(String[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Enter 1 to start the stopwatch");
            int Start = Int32.Parse(Console.ReadLine());
            if (Start == 1)
            {
                stopwatch.Start();
            }
            Console.WriteLine("Enter 0 to stop the stopwatch");
            int Stop = Int32.Parse(Console.ReadLine());
            if (Stop == 0)
            {
                stopwatch.Stop();
            }
            Console.WriteLine("The elapsed time is {0}",
            stopwatch.GetElapsedTime());
            Console.ReadLine();
        }
    }
}