using System;

namespace dz8
{
    internal class Tasks
    {
        public enum Statust
        {
            NotAssigned,
            Assigned, 
            InProgress, 
            UnderReview, 
            Completed
        }
        public string descriptiont;
        public DateTime deadlinest;
        public string initiator;
        public string exsecutor;
        public Statust statust;
        public string reports;
        public static string Random(string a)
        {
            string[] emplo = { "иришка", "егор", "нести", "борис", "илюша", "камиля", "дарья", "айгуль", "самат", "маратик" };
            Random random = new Random();
            int index = random.Next(emplo.Length);
            string b = emplo[index];
            Console.WriteLine(b);
            return a;
        }
        public void Check()
        {
            statust = Statust.UnderReview;
            if (reports == null) 
            {
                Console.WriteLine("уволен");
            }
            else
            {
                Console.WriteLine("молодец жди премию");

            }
        }
        public void TakeTask()
        {
            statust = Statust.InProgress;
        }
        public void RejectTask()
        {
            exsecutor = null;
            statust = Statust.NotAssigned;
        }
        public void DelegateTask()
        {
            RejectTask();
            exsecutor = Random(exsecutor);   
        }
    }
}
