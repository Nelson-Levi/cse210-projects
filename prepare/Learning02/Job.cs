public class Job
{
    // Fields to store job details
    public string _company;      // The company where the job was held.
    public string _jobTitle;     // The title of the job.
    public int _startYear;       // The year the job started.
    public int _endYear;         // The year the job ended.

    // Method to display job details in a specific format.
    public void DisplayJobDetails()
    {
        // Display the job title, company, and the duration of employment.
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
