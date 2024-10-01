public class Resume 
{
    // Field to store the name of the person.
    public string _name;

    // A list to store multiple jobs (instances of the Job class).
    public List<Job> _jobs = new List<Job>();

    // Method to display the resume details.
    public void DisplayResume()
    {
        // Display the name of the individual.
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through each job in the jobs list and display its details.
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();  // Call the method to display job details.
        }
    }
}
