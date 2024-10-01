using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first job instance and set its details.
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Complete Solar Solutions";
        job1._startYear = 2020;
        job1._endYear = 2021;

        // Create the second job instance and set its details.
        Job job2 = new Job();
        job2._jobTitle = "Tree Salesman";
        job2._company = "Nature Nursery";
        job2._startYear = 2021;
        job2._endYear = 2023;

        // Create a new resume and set the name.
        Resume myResume = new Resume();
        myResume._name = "Levi Nelson";

        // Add both jobs to the resume.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Call the method to display the resume details, including the jobs.
        myResume.DisplayResume();
    }
}
