using System;

namespace dz8
{
    internal class Reports
    {
        public string text;
        public DateTime dateOfCompletion;
        public string executorr;
        public void AddReportDateOfCompletion(DateTime date)
        {
            dateOfCompletion = date;
        }
    }
}
