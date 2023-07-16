using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        string currentDate = date.ToString("dd MMM yyyy");

        // create some activities (Activity 'id' = new Activity(DATE, DURATION, DISTANCE/SPEED/LAPS))
        RunningActivity running = new RunningActivity(currentDate, 30, 3.0);
        CyclingActivity cycling = new CyclingActivity(currentDate, 45, 12.5);
        SwimmingActivity swimming = new SwimmingActivity(currentDate, 60, 40);

        // add the activities to a list
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // print out the summaries for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
} 