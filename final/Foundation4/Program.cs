using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024,11,3),30,5),
            new StationaryBicycle(new DateTime(2024,11,3),45,15),
            new Swimming(new DateTime(2024,11,6),30,20),
        };
        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}