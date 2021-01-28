using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngine
{
    public class SendEmail : IActivity
    {
        public string Email { get; set; }
        public void Execute()
        {
            Console.WriteLine($"Notification email send to: { Email }");
        }
    }
}
