using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngine
{
    public class WorkFlow : IWorkFlow
    {
        public IList<IActivity> Activities { get; private set; } = new List<IActivity>(); //list of different activities = workflow

        /// <summary>
        /// adding a new activity to a workflow
        /// </summary>
        public void Add(IActivity activity)
        {
            Activities.Add(activity);
        }

        /// <summary>
        /// removes a activity from a workflow
        /// </summary>
        public void Remove(IActivity activity)
        {
            Activities.Remove(activity);
        }

        /// <summary>
        /// returns a Workflow(all activities)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IActivity> GetActivities()
        {
            return Activities;
        }
    }
}
