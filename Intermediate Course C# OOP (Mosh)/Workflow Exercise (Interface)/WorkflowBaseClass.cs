using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_.Workflow_Exercise__Interface_
{
    public class WorkflowBaseClass
    {
        private readonly List<IActivityExercise> _activityExercises = new List<IActivityExercise>();
        private IActivityExercise _activityExercise;
        public void AddActivity(IActivityExercise activity)
        {
            _activityExercises.Add(activity);
        }

        public void Execute()
        {
            _activityExercise.Execute();
        }

        public List<IActivityExercise> GetListExercises()
        {
            return _activityExercises;
        }

    }
}
