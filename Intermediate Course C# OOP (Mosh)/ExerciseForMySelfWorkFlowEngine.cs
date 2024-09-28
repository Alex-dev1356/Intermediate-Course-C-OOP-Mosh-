using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    public class ExerciseForMySelfWorkFlowEngine
    { 
        public void Run(ReplicatedWorkflow workflow)
        {
            foreach (var activities in workflow._tasks)
            {
                activities.Execute();
            }
        }
    }

    public class ReplicatedWorkflow : IReplicatedWorkflow
    {
        public readonly List<IActivity> _tasks;
        public ReplicatedWorkflow()
        {
            _tasks = new List<IActivity>();
        }
        public void Add(IActivity activity)
        {
            _tasks.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _tasks.Remove(activity);
        }

        public IEnumerable<IActivity> GetTasksLists()
        {
            return _tasks;
        }
    }

    public interface IReplicatedWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
    }

    public interface IActivity
    {
        void Execute();
    }

    //Here we create classes that will implement the IActivity Interface that we created.
    public class ReplicatedUploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("The video is successfully uploaded. Thank you!");
        }
    }

    public class VideoEncoding : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("The video is successfully encoded. Thank you!");
        }
    }

    public class VideoStarted : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("The video has been started. Thank you!");
        }
    }

    public class ChangeVideoStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("The video status is successfully changed. Thank you!");
        }
    }
}
