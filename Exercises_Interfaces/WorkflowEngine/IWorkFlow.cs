using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngine
{
    public interface IWorkFlow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}
