using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkflowEngine_Exercise
{
    

    #region Services
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }

    public class WorkFlow : IWorkFlow
    {
        private readonly List<ITask> _tasks;
        public WorkFlow()
        {
            _tasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }
    }
    #endregion

    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (ITask task in workFlow.GetTasks())
            {
                task.Execute();
            }
        }

    }

    public interface ITask
    {
        void Execute();
    }

    public class ChangeState : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Status Changed ....");
        }
    }

    public class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Vodeo Uploader");
        }
    }

    public class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Call Web Service");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            //Add To list
            //Polymorphism
            workFlow.Add(new VideoUploader());
            workFlow.Add(new ChangeState());
            workFlow.Add(new CallWebService());

            //Get List
            var engine = new WorkFlowEngine();
            engine.Run(workFlow);
        }
    }
}
