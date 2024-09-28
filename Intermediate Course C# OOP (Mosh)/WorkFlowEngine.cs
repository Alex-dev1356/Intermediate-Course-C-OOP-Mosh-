using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    //public interface IActivity
    //{
    //    void Execute(string activity)
    //    {
    //        Console.WriteLine(activity);
    //    }

    //}

    //public class WorkFlowEngine
    //{
    //    private readonly IActivity _activity;

    //    //private readonly WorkFlowEngine _workFlowEngine;
    //    public WorkFlowEngine(IActivity activity)
    //    {
    //        _activity = activity;
    //    }

    //    public void Run()
    //    {
    //        _activity.Execute("This is the first activity.");
    //        _activity.Execute("This is the second activity.");
    //    }
    //}

    //public class SecondImplementationWorkflow : IActivity
    //{
    //    public void SecondActivity(string activity)
    //    {
    //        Console.WriteLine(activity);
    //    }
    //}

    public class WorkFlowEngine
    {
        private readonly IWorkFlow _workFlow;
        public WorkFlowEngine(IWorkFlow workFlow)
        {
            _workFlow = workFlow;
        }

        public void Run(IWorkFlow workFlow)
        {

            foreach (var task in workFlow.GetTasksObjexts())
            {
                task.Execute();
            }
        }
    }

    public class Workflow : IWorkFlow
    {
        private readonly List<ITasks> _tasks;

        public Workflow()
        {
            _tasks = new List<ITasks>();
        }

        public void Add(ITasks activities)
        {
            _tasks.Add(activities);
        }

        public void Remove(ITasks activities)
        {
            _tasks.Remove(activities);
        }

        public IEnumerable<ITasks> GetTasksObjexts()
        {
            return _tasks;
        }
    }

    public interface IWorkFlow
    {
        void Add(ITasks activities);
        void Remove(ITasks activities);

        IEnumerable<ITasks> GetTasksObjexts();
    }

    public interface ITasks
    {
        void Execute();
    }

    public class SendEmail : ITasks
    {
        public void Execute()
        {
            Console.WriteLine("The email has successfully sent. Thank you!");
        }
    }

    public class EditVideo : ITasks
    {
        public void Execute()
        {
            Console.WriteLine("The video is successfully edited. Thank you!");
        }
    }

    public class UploadVideo: ITasks
    {
        public void Execute()
        {
            Console.WriteLine("The video is successfully uploaded. Thank you!");
        }
    }
}