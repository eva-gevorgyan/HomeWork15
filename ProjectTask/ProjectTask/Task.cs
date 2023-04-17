using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask
{
    enum Statuses
    {
        Now,
        End,
        Chancel
    }
    internal class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public Statuses Status { get; set; }
        public Task(string Name, string Description, DateTime EndDate)
        {
            this.Name = Name;
            this.Description = Description;
            this.EndDate = EndDate;
            ID=new Random().Next();
        }
        public void GiveToUser(User user,Task task)
        {
            user.Tasks.Add(task);
        }
        public void ChangeStatus(Task task)
        {
            if (task.Status == Statuses.Now)
                Console.WriteLine("Your task is in process");
            else if(task.Status==Statuses.End)
                Console.WriteLine("You have finished your task");
            else if(task.Status==Statuses.Chancel)
                Console.WriteLine("You have chanceled your task");
        }
    }
}
