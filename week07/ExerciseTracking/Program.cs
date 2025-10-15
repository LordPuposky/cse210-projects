using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create at least one of each activity
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),          // 4.8 km in 30 min
            new Cycling(new DateTime(2022, 11, 3), 45, 20.0),         // avg speed 20 kph for 45 min
            new Swimming(new DateTime(2022, 11, 3), 40, 30)           // 30 laps in 40 min
        };

        // Loop through the list and display summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
