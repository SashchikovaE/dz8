using System;
using System.Collections.Generic;
using System.Globalization;
using static dz8.Project;
using static dz8.Tasks;

namespace dz8
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Project project = new Project();
                project.description = "разработка мобильной игры";
                project.teamleader = Random(project.teamleader);
                project.customer = "дядя толя";
                project.status = Status.Project;
                project.deadlines = new DateTime(2023, 12, 23);
                Console.WriteLine(project);

                List<Tasks> taskss = new List<Tasks>();

                Tasks tasks = new Tasks();
                Console.WriteLine(tasks);
                tasks.initiator = project.teamleader;
                Console.WriteLine("введите дату дедлайна в формате дд.мм.гггг");
                string temp = Console.ReadLine();
                DateTime a = DateTime.ParseExact(temp, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                tasks.deadlinest = a;
                Console.WriteLine("инициатор, введите задачу");
                tasks.descriptiont = Console.ReadLine();
                tasks.exsecutor = Random(tasks.exsecutor);
                tasks.statust = Statust.Assigned;
                tasks.TakeTask();

                Tasks tasks2 = new Tasks();
                tasks2.initiator = project.teamleader;
                Console.WriteLine("Введите дату дедлайна в формате дд.мм.гггг");
                string temp2 = Console.ReadLine();
                DateTime b = DateTime.ParseExact(temp2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                tasks2.deadlinest = b;
                Console.WriteLine("инициатор, введите 2 задачу");
                tasks2.descriptiont = Console.ReadLine();
                //do
                //{
                tasks2.exsecutor = Random(tasks2.exsecutor);
                //}
                //while (tasks2.exsecutor == tasks.exsecutor);
                //{
                // цикл для того, чтобы каждый работник выполнял только одну задачу, но он не работает((((
                //}
                tasks2.statust = Statust.Assigned;
                //while (tasks2.exsecutor == tasks.exsecutor)
                //{
                tasks2.DelegateTask();
                //}

                Tasks tasks3 = new Tasks();
                tasks3.initiator = project.teamleader;
                Console.WriteLine("Введите дату дедлайна в формате дд.мм.гггг");
                string temp3 = Console.ReadLine();
                DateTime c = DateTime.ParseExact(temp3, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                tasks3.deadlinest = c;
                Console.WriteLine("инициатор, введите 3 задачу");
                tasks3.descriptiont = Console.ReadLine();
                //do
                //{
                tasks3.exsecutor = Random(tasks3.exsecutor);
                //}
                //while (tasks3.exsecutor == tasks.exsecutor || tasks3.exsecutor == tasks2.exsecutor);
                //{

                //}
                tasks3.statust = Statust.Assigned;
                tasks3.RejectTask();

                Tasks tasks4 = new Tasks();
                tasks4.initiator = project.teamleader;
                Console.WriteLine("введите дату дедлайна в формате дд.мм.гггг");
                string temp4 = Console.ReadLine();
                DateTime d = DateTime.ParseExact(temp4, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                tasks4.deadlinest = d;
                Console.WriteLine("инициатор, введите 4 задачу");
                tasks4.descriptiont = Console.ReadLine();
                //do
                //{
                tasks4.exsecutor = Random(tasks4.exsecutor);
                //}
                //while (tasks4.exsecutor == tasks.exsecutor || tasks4.exsecutor == tasks2.exsecutor || tasks4.exsecutor == tasks3.exsecutor);
                //{

                //}
                tasks4.statust = Statust.Assigned;
                //while (tasks4.exsecutor == tasks.exsecutor || tasks4.exsecutor == tasks2.exsecutor || tasks4.exsecutor == tasks3.exsecutor)
                //{
                tasks4.DelegateTask();
                //}

                Tasks tasks5 = new Tasks();
                tasks5.initiator = project.teamleader;
                Console.WriteLine("введите дату дедлайна в формате дд.мм.гггг");
                string temp5 = Console.ReadLine();
                DateTime e = DateTime.ParseExact(temp5, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                tasks5.deadlinest = e;
                Console.WriteLine("инициатор, введите 5 задачу");
                tasks5.descriptiont = Console.ReadLine();
                //do
                //{
                tasks5.exsecutor = Random(tasks5.exsecutor);
                //}
                //while (tasks5.exsecutor == tasks.exsecutor || tasks5.exsecutor == tasks2.exsecutor || tasks5.exsecutor == tasks3.exsecutor || tasks5.exsecutor == tasks4.exsecutor);
                //{

                //}
                tasks5.statust = Statust.Assigned;
                tasks5.TakeTask();

                Tasks tasks6 = new Tasks();
                tasks6.initiator = project.teamleader;  
                Console.WriteLine("введите дату дедлайна в формате дд.мм.гггг");
                string temp6 = Console.ReadLine();
                DateTime f = DateTime.ParseExact(temp6, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                tasks6.deadlinest = f;
                Console.WriteLine("инициатор, введите 6 задачу");
                tasks6.descriptiont = Console.ReadLine();
                //do
                //{
                tasks6.exsecutor = Random(tasks6.exsecutor);
                //}
                //while (tasks6.exsecutor == tasks.exsecutor || tasks6.exsecutor == tasks2.exsecutor || tasks6.exsecutor == tasks3.exsecutor || tasks6.exsecutor == tasks4.exsecutor || tasks6.exsecutor == tasks5.exsecutor);
                //{

                //}
                tasks6.statust = Statust.Assigned;
                tasks6.TakeTask();

                Tasks tasks7 = new Tasks();
                tasks7.initiator = project.teamleader;
                Console.WriteLine("введите дату дедлайна в формате дд.мм.гггг");
                string temp7 = Console.ReadLine();
                DateTime g = DateTime.ParseExact(temp7, "dd.MM.yyyy ", CultureInfo.InvariantCulture);
                tasks7.deadlinest = g;
                Console.WriteLine("инициатор, введите 7 задачу");
                tasks7.descriptiont = Console.ReadLine();
                //do
                //{
                tasks7.exsecutor = Random(tasks7.exsecutor);
                //}
                //while (tasks7.exsecutor == tasks.exsecutor || tasks7.exsecutor == tasks2.exsecutor || tasks7.exsecutor == tasks3.exsecutor || tasks7.exsecutor == tasks4.exsecutor || tasks7.exsecutor == tasks5.exsecutor || tasks7.exsecutor == tasks6.exsecutor);
                //{

                //}
                tasks7.statust = Statust.Assigned;
                tasks7.TakeTask();

                Tasks tasks8 = new Tasks();
                tasks8.initiator = project.teamleader;
                Console.WriteLine("введите дату дедлайна в формате дд.мм.гггг");
                string temp8 = Console.ReadLine();
                DateTime h = DateTime.ParseExact(temp8, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                tasks8.deadlinest = h;
                Console.WriteLine("инициатор, введите 8 задачу");
                tasks8.descriptiont = Console.ReadLine();
                //do
                //{
                tasks8.exsecutor = Random(tasks8.exsecutor);
                //}
                //while (tasks8.exsecutor == tasks.exsecutor || tasks8.exsecutor == tasks2.exsecutor || tasks8.exsecutor == tasks3.exsecutor || tasks8.exsecutor == tasks4.exsecutor || tasks8.exsecutor == tasks5.exsecutor || tasks8.exsecutor == tasks6.exsecutor || tasks8.exsecutor == tasks7.exsecutor);
                //{

                //}
                tasks8.statust = Statust.Assigned;
                tasks8.TakeTask();

                Tasks tasks9 = new Tasks();
                tasks9.initiator = project.teamleader;
                Console.WriteLine("введите дату дедлайна в формате дд.мм.гггг");
                string temp9 = Console.ReadLine();
                DateTime i = DateTime.ParseExact(temp9, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                tasks9.deadlinest = i;
                Console.WriteLine("инициатор, введите 9 задачу");
                tasks9.descriptiont = Console.ReadLine();
                //do
                //{
                tasks9.exsecutor = Random(tasks9.exsecutor);
                //}
                //while (tasks9.exsecutor == tasks.exsecutor || tasks9.exsecutor == tasks2.exsecutor || tasks9.exsecutor == tasks3.exsecutor || tasks9.exsecutor == tasks4.exsecutor || tasks9.exsecutor == tasks5.exsecutor || tasks9.exsecutor == tasks6.exsecutor || tasks9.exsecutor == tasks7.exsecutor || tasks9.exsecutor == tasks8.exsecutor);
                //{

                //}
                tasks9.statust = Statust.Assigned;
                tasks9.TakeTask();

                Tasks tasks10 = new Tasks();
                tasks10.initiator = project.teamleader;
                Console.WriteLine("введите дату дедлайна в формате дд.мм.гггг");
                string temp10 = Console.ReadLine();
                DateTime j = DateTime.ParseExact(temp10, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                tasks10.deadlinest = j;
                Console.WriteLine("инициатор, введите 10 задачу");
                tasks10.descriptiont = Console.ReadLine();
                //do
                //{
                tasks10.exsecutor = Random(tasks10.exsecutor);
                //}
                //while (tasks10.exsecutor == tasks.exsecutor || tasks10.exsecutor == tasks2.exsecutor || tasks10.exsecutor == tasks3.exsecutor || tasks10.exsecutor == tasks4.exsecutor || tasks10.exsecutor == tasks5.exsecutor || tasks10.exsecutor == tasks6.exsecutor || tasks10.exsecutor == tasks7.exsecutor || tasks10.exsecutor == tasks8.exsecutor || tasks10.exsecutor == tasks9.exsecutor);
                //{

                //}
                tasks10.statust = Statust.Assigned;
                tasks10.RejectTask();

                project.ChangeExecutionStatus();

                Reports reports = new Reports();
                reports.executorr = tasks.exsecutor;
                Console.WriteLine("исполнитель 1 задачи, напишите отчёт о проделанной работе");
                reports.text = Console.ReadLine();
                Console.WriteLine("введите дату в формате дд.мм.гггг");
                string tem = Console.ReadLine();
                DateTime k = DateTime.ParseExact(tem, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                reports.dateOfCompletion = k;
                if (tasks.deadlinest >= reports.dateOfCompletion)
                {
                    tasks.reports = reports.text;
                    tasks.Check();
                }
                else
                {
                    Console.WriteLine($"{reports.executorr}, ты уволен");
                }

                Reports reports2 = new Reports();
                reports2.executorr = tasks2.exsecutor;
                Console.WriteLine("исполнитель 2 задачи, напишите отчёт о проделанной работе");
                reports2.text = Console.ReadLine();
                Console.WriteLine("введите дату в формате дд.мм.гггг");
                string tem2 = Console.ReadLine();
                DateTime l = DateTime.ParseExact(tem2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                reports2.dateOfCompletion = l;
                if (tasks2.deadlinest >= reports2.dateOfCompletion)
                {
                    tasks2.Check();
                    tasks2.reports = reports2.text;
                }
                else
                {
                    Console.WriteLine($"{reports2.executorr}, ты уволен");
                }

                Reports reports3 = new Reports();
                reports3.executorr = tasks3.exsecutor;
                Console.WriteLine("исполнитель 3 задачи, напишите отчёт о проделанной работе");
                reports3.text = Console.ReadLine();
                Console.WriteLine("введите дату в формате дд.мм.гггг");
                string tem3 = Console.ReadLine();
                DateTime m = DateTime.ParseExact(tem3, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                reports3.dateOfCompletion = k;
                if (tasks3.deadlinest >= reports3.dateOfCompletion)
                {
                    tasks3.reports = reports3.text;
                    tasks3.Check();
                }
                else
                {
                    Console.WriteLine($"{reports3.executorr}, ты уволен");
                }

                Reports reports4 = new Reports();
                reports4.executorr = tasks4.exsecutor;
                Console.WriteLine("исполнитель 4 задачи, напишите отчёт о проделанной работе");
                reports4.text = Console.ReadLine();
                Console.WriteLine("введите дату в формате дд.мм.гггг");
                string tem4 = Console.ReadLine();
                DateTime n = DateTime.ParseExact(tem4, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                reports4.dateOfCompletion = n;
                if (tasks4.deadlinest >= reports4.dateOfCompletion)
                {
                    tasks4.reports = reports4.text;
                    tasks4.Check();
                }
                else
                {
                    Console.WriteLine($"{reports4.executorr}, ты уволен");
                }

                Reports reports5 = new Reports();
                reports5.executorr = tasks5.exsecutor;
                Console.WriteLine("исполнитель 5 задачи, напишите отчёт о проделанной работе");
                reports5.text = Console.ReadLine();
                Console.WriteLine("введите дату в формате дд.мм.гггг");
                string tem5 = Console.ReadLine();
                DateTime o = DateTime.ParseExact(tem5, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                reports5.dateOfCompletion = o;
                if (tasks5.deadlinest >= reports5.dateOfCompletion)
                {
                    tasks5.reports = reports5.text;
                    tasks5.Check();
                }
                else
                {
                    Console.WriteLine($"{reports5.executorr}, ты уволен");
                }

                Reports reports6 = new Reports();
                reports6.executorr = tasks6.exsecutor;
                Console.WriteLine("исполнитель 6 задачи, напишите отчёт о проделанной работе");
                reports6.text = Console.ReadLine();
                Console.WriteLine("введите дату в формате дд.мм.гггг");
                string tem6 = Console.ReadLine();
                DateTime p = DateTime.ParseExact(tem6, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                reports6.dateOfCompletion = p;
                if (tasks6.deadlinest >= reports6.dateOfCompletion)
                {
                    tasks6.reports = reports6.text;
                    tasks6.Check();
                }
                else
                {
                    Console.WriteLine($"{reports6.executorr}, ты уволен");
                }

                Reports reports7 = new Reports();
                reports7.executorr = tasks7.exsecutor;
                Console.WriteLine("исполнитель 7 задачи, напишите отчёт о проделанной работе");
                reports7.text = Console.ReadLine();
                Console.WriteLine("введите дату в формате дд.мм.гггг");
                string tem7 = Console.ReadLine();
                DateTime r = DateTime.ParseExact(tem7, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                reports7.dateOfCompletion = r;
                if (tasks7.deadlinest >= reports7.dateOfCompletion)
                {
                    tasks7.reports = reports7.text;
                    tasks7.Check();
                }
                else
                {
                    Console.WriteLine($"{reports7.executorr}, ты уволен");
                }

                Reports reports8 = new Reports();
                reports8.executorr = tasks8.exsecutor;
                Console.WriteLine("исполнитель 8 задачи, напишите отчёт о проделанной работе");
                reports8.text = Console.ReadLine();
                Console.WriteLine("введите дату в формате дд.мм.гггг");
                string tem8 = Console.ReadLine();
                DateTime s = DateTime.ParseExact(tem8, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                reports8.dateOfCompletion = s;
                if (tasks8.deadlinest >= reports8.dateOfCompletion)
                {
                    tasks8.reports = reports8.text;
                    tasks8.Check();
                }
                else
                {
                    Console.WriteLine($"{reports8.executorr}, ты уволен");
                }

                Reports reports9 = new Reports();
                reports9.executorr = tasks9.exsecutor;
                Console.WriteLine("исполнитель 9 задачи, напишите отчёт о проделанной работе");
                reports9.text = Console.ReadLine();
                Console.WriteLine("введите дату в формате дд.мм.гггг");
                string tem9 = Console.ReadLine();
                DateTime t = DateTime.ParseExact(tem9, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                reports9.dateOfCompletion = t;
                if (tasks9.deadlinest >= reports9.dateOfCompletion)
                {
                    tasks9.reports = reports9.text;
                    tasks9.Check();
                }
                else
                {
                    Console.WriteLine($"{reports9.executorr}, ты уволен");
                }

                Reports reports10 = new Reports();
                reports10.executorr = tasks10.exsecutor;
                Console.WriteLine("исполнитель 10 задачи, напишите отчёт о проделанной работе");
                reports10.text = Console.ReadLine();
                Console.WriteLine("введите дату в формате дд.мм.гггг");
                string tem10 = Console.ReadLine();
                DateTime u = DateTime.ParseExact(tem10, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                reports10.dateOfCompletion = u;
                if (tasks10.deadlinest >= reports10.dateOfCompletion)
                {
                    tasks10.reports = reports10.text;
                    tasks10.Check();
                }
                else
                {
                    Console.WriteLine($"{reports10.executorr}, ты уволен") ;
                }

                project.status = Status.Closed;
            }
            catch (FormatException)
            {
                Console.WriteLine("НЕВЕРНЫЙ ФОРМАТ");
            }
            Console.ReadKey();
        }
    }
}
