using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask
{
    internal class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Project> Projects { get; set; }
        public Project(string Name, string Description, DateTime StartDate, DateTime EndDate)
        {
            this.Name = Name;
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            ID = new Random().Next();
            Projects = new List<Project>();
        }
        public void AddTask(Project task)
        {
            Console.WriteLine($"You added {task}");
            Projects.Add(task);
        }
        public void RemoveTask(Project task)
        {
            Console.WriteLine($"You removed {task}");
            Projects.Remove(task);
        }
        public bool FindTask(Project task)
        {
            if (Projects.Count == 0) return false;

            foreach (var p in Projects)
            {
                if (p.Equals(task)) return true;
            }
            return false;
        }
        public void DisplayTasks()
        {
            Console.WriteLine("Tasks List:");
            foreach (var p in Projects)
                Console.WriteLine(p);
        }
    }
}
