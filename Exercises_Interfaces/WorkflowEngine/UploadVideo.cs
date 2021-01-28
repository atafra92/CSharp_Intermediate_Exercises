using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngine
{
    public class UploadVideo : IActivity
    {
        public string Uri { get; set; }
        public void Execute()
        {
            Console.WriteLine($"Video uploaded to cloud storage: { Uri }");
        }
    }
}
