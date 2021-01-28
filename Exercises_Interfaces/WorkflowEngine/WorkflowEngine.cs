using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        /// <summary>
        ///  // executing each activity in a workflow
        /// </summary>
        public void Run(IWorkFlow workFlow)
        {        
            foreach (var activity in workFlow.GetActivities())
            {
                Console.WriteLine($"Preparing to execute { activity }");
                activity.Execute();
            }
        }
    }
}
