namespace ProjectTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Belly", "Smith", "bellysmith@gmail.com");
            Console.WriteLine(user.ID+" "+user.Name+" "+user.SName);

            Task task = new Task("Task1", "Desc",new DateTime(2023,4,24));
            task.GiveToUser(user, task);
            task.Status = Statuses.Now;
            task.ChangeStatus(task);

            Console.WriteLine("Your projects");
            Project project = new Project("Project1", "Desc", new DateTime(2023, 4, 14), new DateTime(2023, 5, 16));
            project.AddTask(project);
            project.FindTask(project);
            project.DisplayTasks();
        }
    }
}