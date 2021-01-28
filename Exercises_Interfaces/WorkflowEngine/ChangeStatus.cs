using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngine
{
    public class ChangeStatus : IActivity
    {
        public enum StatusInfo
        {
            Processing,
            AvailableForUpload,
            UnavailableForUpload,
        }

        public void Execute()
        {
            Console.WriteLine($"Order status sucesfully changed to: { StatusInfo.Processing }...");
        }
    }
}
