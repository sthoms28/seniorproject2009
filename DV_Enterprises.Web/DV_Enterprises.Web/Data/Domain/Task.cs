using System;
using System.Linq;
using DV_Enterprises.Web.Data.DataAccess.SqlRepository;
using DV_Enterprises.Web.Data.Domain.Abstract;
using DV_Enterprises.Web.Data.Domain.Interface;
using StructureMap;

namespace DV_Enterprises.Web.Data.Domain
{
    [Pluggable("Default")]
    public class Task : DomainModel, ITask
    {
        #region Static properties

        #endregion

        #region Instance properties

        public int ID { get; set; }
        public int SectionID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Interval { get; set; }
        public int TaskTypeId { get; set; }

        private TaskType _taskType;
        public TaskType TaskType
        {
            get { return _taskType ?? (TaskType = TaskType.Find(TaskTypeId)); }
            set { _taskType = value; }
        }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        #endregion

        # region Static Methods

        /// <summary>
        /// Find all Task's
        /// </summary>
        /// <returns>return an IQueryable collection of Task</returns>
        public static IQueryable<Task> All()
        {
            return All(null);
        }

        /// <summary>
        /// Find all Task's
        /// </summary>
        /// <param name="dc">DataContext</param>
        /// <returns>return an IQueryable collection of Task</returns>
        public static IQueryable<Task> All(DataContext dc)
        {
            dc = dc ?? Conn.GetContext();
            var r = from t in dc.Tasks
                    select new Task
                               {
                                   ID = t.TaskID,
                                   SectionID = t.SectionID,
                                   StartTime = t.StartTime,
                                   EndTime = t.EndTime,
                                   Interval = (t.EndTime.TimeOfDay - t.StartTime.TimeOfDay).TotalMinutes,
                                   TaskTypeId = t.TaskTypeID,
                                   DateCreated = t.DateCreated,
                                   DateUpdated = t.DateUpdated
                               };
            return r;
        }


        /// <summary>
        /// Find an Task by it's id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>returns a Task</returns>
        public static Task Find(int id)
        {
            return Find(null, id);
        }

        /// <summary>
        /// Find an Task by it's id.
        /// </summary>
        /// <param name="dc"></param>
        /// <param name="id"></param>
        /// <returns>returns a Task</returns>
        public static Task Find(DataContext dc, int id)
        {
            return All(dc).Where(t => t.ID == id).SingleOrDefault();
        }

        /// <summary>
        /// Save a Task
        /// </summary>
        /// <param name="task"></param>
        /// <returns>returns the id of the saved task</returns>
        public static int Save(Task task)
        {
            return Save(null, task);
        }

        /// <summary>
        /// Save a Task
        /// </summary>
        /// <param name="dc">DataContext</param>
        /// <param name="task"></param>
        /// <returns>returns the id of the saved task</returns>
        public static int Save(DataContext dc, Task task)
        {
            dc = dc ?? Conn.GetContext();
            var dbTask = dc.Tasks.Where(t => t.TaskID == task.ID).SingleOrDefault();
            var isNew = false;
            if (dbTask == null)
            {
                dbTask = new DataAccess.SqlRepository.Task();
                isNew = true;
            }

            dbTask.SectionID = task.SectionID;
            dbTask.StartTime = task.StartTime;
            dbTask.EndTime = task.StartTime.AddMinutes(task.Interval);
            dbTask.TaskTypeID = task.TaskTypeId;
            dbTask.DateUpdated = DateTime.Now;

            if (isNew)
            {
                dbTask.DateCreated = DateTime.Now;
                dc.Tasks.InsertOnSubmit(dbTask);
            }
            dc.SubmitChanges();
            return dbTask.TaskID;
        }

        /// <summary>
        /// Delete a single Task
        /// </summary>
        /// <param name="task"></param>
        public static void Delete(Task task)
        {
            Delete(null, task);
        }

        /// <summary>
        /// Delete a single Task
        /// </summary>
        /// <param name="dc">DataContext</param>
        /// <param name="task"></param>
        public static void Delete(DataContext dc, Task task)
        {
            dc = dc ?? Conn.GetContext();
            var dbTask = dc.Tasks.Where(t => t.TaskID == task.ID).SingleOrDefault();
            if (dbTask == null) return;
            //dc.Tasks.Attach(dbTask, true);
            dc.Tasks.DeleteOnSubmit(dbTask);
            dc.SubmitChanges();
        }
         

        #endregion

        #region Instance Methods

        /// <summary>
        /// Save Task
        /// </summary>
        /// <returns>returns the id of the saved task</returns>
        public int Save()
        {
            return Save(this);
        }

        /// <summary>
        /// Save Task
        /// </summary>
        /// <param name="dc"></param>
        /// <returns>returns the id of the saved task</returns>
        public int Save(DataContext dc)
        {
            return Save(dc, this);
        }

        /// <summary>
        /// Delete Task
        /// </summary>
        public void Delete()
        {
            Delete(this);
        }

        /// <summary>
        /// Delete Task
        /// </summary>
        /// <param name="dc"></param>
        public void Delete(DataContext dc)
        {
            Delete(dc, this);
        }

        #endregion
    }
}