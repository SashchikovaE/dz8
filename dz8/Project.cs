using System;

namespace dz8
{
    internal class Project
    {
        public enum Status
        {
           Project,
           Execution,
           Closed
        }
        public string description;
        public DateTime deadlines;
        public string customer;
        public string teamleader;
        public string tasks;
        public Status status;
       public void ChangeExecutionStatus()
        {
            if (description != null && teamleader != null && customer != null && deadlines != null)
            {
                status = Status.Execution;
            }
        }
    }
}
