using System;
using System.Collections.Generic;
using System.Text;

namespace GetItDoneList
{
    class GetItDone
    {
        string taskToGetDone;
        string details;                     //variables
        string priorityLevel;
        int date;

        public GetItDone(string taskToGetDone, string details, string priorityLevel, int date)
        {
            this.taskToGetDone = taskToGetDone;
            this.details = details;                     //constructors
            this.priorityLevel = priorityLevel;
            this.date = date;
        }

        public string TaskToGetDone { get => taskToGetDone; set => taskToGetDone = value; }
        public string Details { get => details; set => details = value; }                           //gets and sets
        public string PriorityLevel { get => priorityLevel; set => priorityLevel = value; }
        public int Date { get => date; set => date = value; }
    }
}
