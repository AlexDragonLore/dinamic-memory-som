using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_kw
{
    class DinamicMemory
    {
        public const int allMemory = 512;
        public bool[] memory = new bool[allMemory];
        public List<int> tasks = new List<int>();
        public List<int[]> activeTasks = new List<int[]>();

        Random rnd = new Random();
        public void initializeMemory()
        {
            for(int i = 0; i < allMemory; i++)
            {
                memory[i] = false;
            }
        }
        private void addTask()
        {
            tasks.Add(rnd.Next(30, 100));
        }
        public void generateTask()
        {
            tasks.Clear();
            for (int i = 0; i < rnd.Next(50, 55); i++)
            {
                addTask();
            }
        }
        public bool doOneTask()
        {
            if (tasks.Count == 0)
            {
                return false;
            }
            int[] activeTask = new int[2];
            int count = 0;
            int taskNeeded = tasks[0]; 
            for (int i = 0; i< allMemory; i++)
            {
                if (memory[i] == false)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > taskNeeded)
                {
                    for(int j = i - count; j < i; j++)
                    {
                        memory[j+1] = true;
                    }
                    activeTask[0] = i - count + 1;
                    activeTask[1] = count;
                    findPlaceForActiveTask(activeTask);
                    tasks.RemoveAt(0);
                    return true;
                }

            }
            return false;
        }
        private void findPlaceForActiveTask(int[] task)
        {
            int count = 0;
            if (activeTasks.Count > 0)
            {
                foreach (int[] activeTask in activeTasks)
                {
                    if (task[0] < activeTask[0])
                    {
                        activeTasks.Insert(count, task);
                        return;
                    }
                    count++;
                }
                activeTasks.Add(task);
            }
            else
            {
                activeTasks.Add(task);
            }
        }

        public bool readonlyDoFewTasks()
        {

            for (int i = 0; i < rnd.Next(2, 4); i++)
            {
                if (activeTasks.Count > 0)
                {
                    int indexOfTask = rnd.Next(0, activeTasks.Count);
                    for (int j = activeTasks[indexOfTask][0]; j < activeTasks[indexOfTask][0] + activeTasks[indexOfTask][1]; j++)
                    {
                        memory[j] = false;
                    }
                    activeTasks.RemoveAt(indexOfTask);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public void addFewTasks(int n)
        {
            for (int i = 0; i < n; i++)
            {
                addTask();
            }
        }
    }
}
