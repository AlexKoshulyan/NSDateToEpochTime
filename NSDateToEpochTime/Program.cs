using System;

namespace NSDateToEpochTime
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    throw new ArgumentException("One argument expected");
                }

                double nsTime = System.Convert.ToDouble(args[0]);
                var dt = new DateTime(2001, 1, 1);
                dt = dt.AddSeconds(nsTime);
                Console.WriteLine(dt);
            }
            catch(Exception ex)
            {
                System.Console.Error.WriteLine(ex.Message);
                System.Console.Error.WriteLine("\nSYNAPSIS: NSDateToEpochTime.exe value_to_convert\n");
            }
        }
    }
}
