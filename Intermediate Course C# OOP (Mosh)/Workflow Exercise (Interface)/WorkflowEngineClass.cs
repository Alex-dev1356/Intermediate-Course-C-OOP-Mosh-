using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_.Workflow_Exercise__Interface_
{
    public class WorkflowEngineClass
    {
        public void Run(WorkflowBaseClass activityWorkflow)
        {
            var ListOfActivities = activityWorkflow.GetListExercises();
            foreach (var activity in ListOfActivities)
            {
                activity.Execute();
            }
        }
    }
}
