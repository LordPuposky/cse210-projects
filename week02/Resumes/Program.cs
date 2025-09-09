using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Yesid Augusto Romero Ruiz";

        Job job1 = new Job();
        job1._jobTitle = "Sales Coordinator";
        job1._company = "AJE Colombia";
        job1._startYear = 2015;
        job1._endYear = 2019;
        job1._description =
            "Plan and supervise sales activities.\n" +
            "Set goals for the team.\n" +
            "Maintain communication with clients.\n" +
            "Motivate and coordinate the sales team.\n" +
            "Resolve problems and provide customer support.";

        Job job2 = new Job();
        job2._jobTitle = "App-based Driver";
        job2._company = "Independent";
        job2._startYear = 2019;
        job2._endYear = 2025; // Present year
        job2._description =
            "Drive for various apps.\n" +
            "Manage routes and schedules.\n" +
            "Attend to customers during service.";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
