using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow workFlow = new WorkFlow();

            workFlow.Add(new UploadVideo { Uri = @"https://www.videosupload.net/Upload" }); //adds a new activities to a workflow
            workFlow.Add(new SendEmail { Email = "antonio.tafra@gmail.com" });
            workFlow.Add(new ChangeStatus());

            WorkflowEngine engine = new WorkflowEngine();

            engine.Run(workFlow); //calling a run method which loops through all activities in a workflow 

            Console.ReadLine();
        }
    }
}
