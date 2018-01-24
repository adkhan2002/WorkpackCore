﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Data;
using iTextSharp.text;

namespace BusinessLibrary
{
    public class BLTaskListRepository_Contract : IBLTaskListRepository_Contract
    {


     


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectTaskList_Contract> _taskListRepository_Contract;

        public BLTaskListRepository_Contract(WorkpackDBContext context, IGenericDataRepository<ProjectTaskList_Contract> taskListRepository_Contract)
        {
            _context = context;
            _taskListRepository_Contract = taskListRepository_Contract;
        }


        public IList<ProjectTaskList_Contract> GetAllTaskList()
        {
            return _taskListRepository_Contract.GetAll();
        }
        public ProjectTaskList_Contract GetTaskListByID(Int32 TaskID)
        {
            return _taskListRepository_Contract.GetSingle(d => d.ProjectTaskID == TaskID);
        }
        public void AddTaskList(params ProjectTaskList_Contract[] TaskList)
        {
            _taskListRepository_Contract.Add(TaskList);
        }
        public void UpdateTaskList(params ProjectTaskList_Contract[] TaskList)
        {
            _taskListRepository_Contract.Update(TaskList);
        }
        public void RemoveTaskList(params ProjectTaskList_Contract[] TaskList)
        {
            try
            {
                _taskListRepository_Contract.Remove(TaskList);
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }

        public List<ProjectTaskList_Contract> GetAllTaskListByProjectID(int ProjectID)
        {
            return _taskListRepository_Contract.GetAll().Where(a => a.ProjectID == ProjectID).ToList<ProjectTaskList_Contract>();
        }
        public List<ProjectTaskList_Contract> GetAllTaskListExcludingSysTaskByProjectID(int ProjectID)
        {
            return _taskListRepository_Contract.GetAll().Where(a => a.ProjectID == ProjectID && (a.SysGen == null || a.SysGen == "N")).ToList<ProjectTaskList_Contract>();
        }



        public static IList<ProjectTaskList_Contract> GetAllTaskLists()
        {
            IList<ProjectTaskList_Contract> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    //list = (from a in db.Projects where a.ProjectStatus!="1" select a).ToList();
                //    list = (from a in db.ProjectTaskList_Contract select a).ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;

        }
        public bool TaskUnderScopeChange(string PrimaryId, string ProjectID, string UserID, Dictionary<string, string[]> item, string mode, string ScopeChangeID)
        {
            bool res = false;
            ////try
            ////{
            ////    Dictionary<string, string> dictTask = new Dictionary<string, string>();
            ////    CultureInfo ci = new CultureInfo("en-Gb");
            ////    var p = item
            ////           .Where(i => i.Value[0] == "TASK").Select(a => a.Value);
            ////    foreach (var t in p)
            ////    {
            ////        dictTask.Add(t[1], t[2]);
            ////    }
            ////    var AllottedHours = item.Where(i => i.Value[1] == "TOTALHRS").Select(a => a.Value[2]).SingleOrDefault();
            ////    var NormsID = dictTask.ContainsKey("Norm") ? Convert.ToInt32(dictTask["Norm"]) : 0;
            ////    var DepatmentID = Convert.ToInt32(dictTask["Dept"]);
            ////    var TaskName = Convert.ToString(dictTask["TaskName"]);
            ////    var TaskTypeID = dictTask.ContainsKey("Type") ? Convert.ToInt32(dictTask["Type"]) : 0;
            ////    var Duration = dictTask.ContainsKey("Duration") ? Convert.ToInt32(dictTask["Duration"]) : 1;
            ////    var WBSID = dictTask.ContainsKey("WBSCode") ? Convert.ToString(dictTask["WBSCode"]) : null;
            ////    var Priority = Convert.ToInt32(dictTask["Priority"]);
            ////    var StartDate = Convert.ToDateTime(dictTask["StartDate"], ci);
            ////    var EndDate = Convert.ToDateTime(dictTask["EndDate"], ci);
            ////    var Remarks = dictTask.ContainsKey("Remarks") ? Convert.ToString(dictTask["Remarks"]) : "";
            ////    var TaskID = Convert.ToInt32(PrimaryId);
            ////    var sendToFPTaskStatus = Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint);
            ////    var cancelledTaskStatus = Convert.ToInt32(Common.TaskStatusID.Cancelled);
            ////    var DraftStatus = Convert.ToInt32(Common.TaskStatusID.Draft);
            ////    var DesignationID = 0;
            ////    var ParentTaskId = 0;
            ////    var TaskOwner = 0;
            ////    var statusID = 0;
            ////    var ResourceRequestID = 0;
            ////    var FocalPoint = 0;

            ////    DataTable dt = new DataTable("Table1");
            ////    dt.Columns.Add("TaskTypeID");
            ////    dt.Columns.Add("MileStoneID");
            ////    dt.Columns.Add("TargetDate");
            ////    var q = item
            ////           .Where(i => i.Value[0] == "PROGRESS");
            ////    foreach (var t in q)
            ////    {
            ////        DataRow dr = dt.NewRow();
            ////        dr["TaskTypeID"] = Convert.ToInt32(dictTask["Type"]);
            ////        dr["MileStoneID"] = Convert.ToInt32(t.Key);
            ////        dr["TargetDate"] = Convert.ToDateTime(t.Value[2], ci);
            ////        dt.Rows.Add(dr);
            ////    }
            ////    string xmlTargetDates = string.Empty;
            ////    using (StringWriter sw = new StringWriter())
            ////    {
            ////        dt.WriteXml(sw);
            ////        xmlTargetDates = sw.ToString();
            ////    }
            ////    using (var db = new Cubicle_EntityEntities())
            ////    {
            ////        int lst = db.usp_TaskListScopeChange(Convert.ToDecimal(AllottedHours), DepatmentID, DesignationID, EndDate, Priority,
            ////                                                    Convert.ToInt32(ProjectID), Remarks, StartDate, TaskName,
            ////                                                    TaskTypeID, xmlTargetDates, TaskID, ParentTaskId, TaskOwner, statusID, ResourceRequestID, FocalPoint,
            ////                                                    Convert.ToInt32(ScopeChangeID), Convert.ToInt32(UserID),
            ////                                                    sendToFPTaskStatus, cancelledTaskStatus, DraftStatus, Convert.ToInt32(WBSID), Duration, NormsID, mode,
            ////                                                    0, false, "", "N", 0);
            ////        if (lst > 0)
            ////        {
            ////            res = true;
            ////        }

            ////    }
            ////}
            ////catch (Exception ex)
            ////{
            ////    res = false;
            ////}
            return res;

        }

        public static IList<ProjectTaskList_Contract> GetAllTaskByDept(int ProjectID, int dept, int desg)
        {
            IList<ProjectTaskList_Contract> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from a in db.ProjectTaskList_Contract
                //            where
                //                a.ProjectID == (ProjectID == 0 ? a.ProjectID : ProjectID)
                //                && a.DepatmentID == (dept == 0 ? a.DepatmentID : dept)
                //                && a.DesignationID == (desg == 0 ? a.DesignationID : desg)
                //            select a).ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }


        public DataTable GetTaskListSummary(DataTable taskList, int projectid)
        {
            DataTable dt = null; ;
            //var varTask = taskList;
            //List<DateTime> levelmin = varTask.AsEnumerable().Select(al => al.Field<DateTime>("StartDate")).Distinct().ToList();
            //List<DateTime> levelMax = varTask.AsEnumerable().Select(al => al.Field<DateTime>("EndDate")).Distinct().ToList();
            //DateTime min = levelmin.Min();
            //DateTime max = levelMax.Max();
            //DataTable dtDesignation = GetTaskDesignationSummary(projectid, taskList);
            //DataTable dtnew = new DataTable();
            //if (dtDesignation.Rows.Count > 0)
            //{

            //    DataRow dr;
            //    dtnew.Columns.Add("Aggregate");
            //    dtnew.Columns.Add("From");
            //    dtnew.Columns.Add("To");
            //    for (int i = 0; i < dtDesignation.Rows.Count; i++)
            //    {
            //        dtnew.Columns.Add(dtDesignation.Rows[i]["DesignationName"].ToString() + " Hours");
            //    }
            //    dtnew.Columns.Add("Total Hours");
            //    dr = dtnew.NewRow();
            //    decimal tothours = 0;
            //    for (int i = 0; i < dtDesignation.Rows.Count; i++)
            //    {
            //        dr[dtDesignation.Rows[i]["DesignationName"].ToString() + " Hours"] = dtDesignation.Rows[i]["Hours"].ToString();
            //        tothours = tothours + Convert.ToDecimal(dtDesignation.Rows[i]["Hours"].ToString());
            //    }
            //    dtnew.Rows.Add(dr);
            //    for (int i = 0; i < dtDesignation.Rows.Count; i++)
            //    {
            //        dr["From"] = min;
            //        dr["To"] = max;
            //        dr["Total Hours"] = tothours;
            //        dr["Aggregate"] = "Aggregate";
            //    }
            //}
            return dt;
        }

        public DataTable GetTaskDesignationSummary(int projectId, DataTable taskList)
        {
            DataTable dtList = null;// new DataTable();
            //try
            //{

            //    List<int> TaskIds = new List<int>();
            //    for (int k = 0; k < taskList.Rows.Count; k++)
            //    {
            //        TaskIds.Add(Convert.ToInt32(taskList.Rows[k]["ProjectTaskID"]));
            //    }
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        var gvList = from t in
            //                         (from td in context.TaskDesignation_Contract
            //                          join dg in context.Designations
            //                          on td.DesignationID equals dg.DesignationID
            //                          where td.ProjectID == projectId
            //                          && TaskIds.Contains(td.ProjectTaskID)
            //                          select new { td, dg })
            //                     group t by new { DesignationName = t.dg.DesignationName } into g
            //                     select new
            //                     {
            //                         hours = g.Sum(c => c.td.Hours),
            //                         Designationname = g.Key.DesignationName
            //                     };
            //        dtList = Common.GeneralFuntions.ConvertToDataTable(gvList.ToList());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return dtList;
        }




        public void BackUpTaskListDetailAtEstimationPhase(int projectId)
        {

            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{

                //    context.BAckUPTaskListDetailAtEstimationPhase(projectId);
                //}
            }
            catch (Exception ex)
            {

            }

        }





        public List<ProjectTaskList_Contract> GetEstimationTaskListByProjectID(int ProjectID)
        {
            List<ProjectTaskList_Contract> lst = null;
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    lst = context.ProjectTaskList_Contract.Where(a => a.ProjectID == ProjectID).ToList<ProjectTaskList_Contract>();
            ////}
            return lst;
        }



        public DataTable GetEstimationTaskListSummary(DataTable taskList, int projectid)
        {

            DataTable dt = null;
            DataTable dtnew = null;
            //var varTask = taskList;
            //List<DateTime> levelmin = varTask.AsEnumerable().Select(al => al.Field<DateTime>("StartDate")).Distinct().ToList();
            //List<DateTime> levelMax = varTask.AsEnumerable().Select(al => al.Field<DateTime>("EndDate")).Distinct().ToList();
            //DateTime min = levelmin.Min();
            //DateTime max = levelMax.Max();
            //DataTable dtDesignation = GetEstimationTaskDesignationSummary(projectid, taskList);

            //if (dtDesignation.Rows.Count > 0)
            //{

            //    DataRow dr;
            //    dtnew.Columns.Add("Aggregate");
            //    dtnew.Columns.Add("From");
            //    dtnew.Columns.Add("To");
            //    for (int i = 0; i < dtDesignation.Rows.Count; i++)
            //    {
            //        dtnew.Columns.Add(dtDesignation.Rows[i]["DesignationName"].ToString() + " Hours");
            //    }
            //    dtnew.Columns.Add("Total Hours");
            //    dr = dtnew.NewRow();
            //    decimal tothours = 0;
            //    for (int i = 0; i < dtDesignation.Rows.Count; i++)
            //    {
            //        dr[dtDesignation.Rows[i]["DesignationName"].ToString() + " Hours"] = dtDesignation.Rows[i]["Hours"].ToString();
            //        tothours = tothours + Convert.ToDecimal(dtDesignation.Rows[i]["Hours"].ToString());
            //    }
            //    dtnew.Rows.Add(dr);
            //    for (int i = 0; i < dtDesignation.Rows.Count; i++)
            //    {
            //        dr["From"] = min;
            //        dr["To"] = max;
            //        dr["Total Hours"] = tothours;
            //        dr["Aggregate"] = "Aggregate";
            //    }
            //}
            return dtnew;

        }

        public DataTable GetEstimationTaskDesignationSummary(int projectId, DataTable taskList)
        {
            DataTable dtList = null;
            //try
            //{

            //    List<int?> TaskIds = new List<int?>();

            //    for (int k = 0; k < taskList.Rows.Count; k++)
            //    {
            //        TaskIds.Add(Convert.ToInt32(taskList.Rows[k]["EstimationTaskID"]));
            //    }


            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        var gvList = (from tt in


            //                          (from t in
            //                               (
            //                                from ECM in context.EstimationTaskColumnsMasters
            //                                join dg in context.TaskDesignations
            //                                on new { DBColPkID = ECM.DBColPkID.Value, ProjectID = ECM.ProjectID } equals new { DBColPkID = dg.DesignationID, ProjectID = dg.ProjectID }
            //                                into joinData
            //                                from k in joinData.Where(c => TaskIds.Contains(c.EstimationTaskID)).DefaultIfEmpty()
            //                                select new
            //                                {
            //                                    DisplayColName = ECM.DisplayColName,
            //                                    Hours = k.Hours,
            //                                    EstimationTaskID = k.EstimationTaskID,
            //                                    ProjectID = ECM.ProjectID,
            //                                    DBColPkID = ECM.DBColPkID
            //                                })

            //                           select new
            //                           {
            //                               DisplayColName = t.DisplayColName,
            //                               EstimationTaskID = t.EstimationTaskID,
            //                               ProjectID = t.ProjectID,
            //                               DBColPkID = t.DBColPkID,
            //                               Hours = (t.Hours == null ? 0 : t.Hours)
            //                           })
            //                      where tt.ProjectID == projectId && tt.DBColPkID > 0

            //                      group tt by new { DisplayColName = tt.DisplayColName } into g

            //                      select new
            //                      {
            //                          hours = g.Sum(c => c.Hours),
            //                          Designationname = g.Key.DisplayColName

            //                      }

            //                         ).ToList();

            //        dtList = Common.GeneralFuntions.ConvertToDataTable(gvList.ToList());



            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return dtList;
        }



        public static bool UpdateTaskStatusByRequestID(int RequestID, int StatusID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var ProjectTasklist = from a in context.ProjectTaskList_Contract where a.ResourceRequestID == RequestID select a;
                //    foreach (var val in ProjectTasklist)
                //    {
                //        val.TaskStatus = StatusID;
                //        context.Entry(val).State = System.Data.EntityState.Modified;
                //    }
                //    context.SaveChanges();
                //    res = true;
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }


        public bool IsAllTaskScheduled(int ProjectID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var ProjectTasklist = from a in context.ProjectTaskList_Contract where a.ProjectID == ProjectID && a.IsScheduled == "N" select a;

                //    if (ProjectTasklist.ToList().Count == 0)
                //    {
                //        res = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }





        public static bool IsEstimatatedTasksTransferred(int RequestID, int projectID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var ProjectTasklist = from a in context.ProjectTaskList_Contract where a.RequestID == RequestID && a.ProjectID == projectID select a;
                //    foreach (var val in ProjectTasklist)
                //    {
                //        res = true;
                //        break;
                //    }
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }

        public static bool IsAllTaskCompletted(int ProjectID, int TaskStatusCancelled, int TaskStatusClosed, int ProjectStatusAwarded)
        {
            Boolean res = false;
            //try
            //{
            //    string ProjectStatusAwardedID = ProjectStatusAwarded.ToString();
            //    int[] TaskStatusIDs = { TaskStatusCancelled, TaskStatusClosed };

            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        int ProjectStatus = context.Projects.Where(p => p.ProjectID == ProjectID && p.ProjectStatus == ProjectStatusAwardedID).Count();
            //        int TaskCount = context.ProjectTaskList_Contract.Where(p => p.ProjectID == ProjectID).Select(p => p.ProjectTaskID).Count();
            //        List<ProjectTaskList_Contract> lstTasklist = context.ProjectTaskList_Contract.Where(p => p.ProjectID == ProjectID).ToList<ProjectTaskList_Contract>();

            //        if (ProjectStatus > 0 && TaskCount > 0)
            //        {
            //            int RecordCount = (from u in lstTasklist
            //                               where !TaskStatusIDs.Contains(u.TaskStatus.Value)
            //                               select u).Count();


            //            if (RecordCount == 0)
            //            {
            //                res = true;
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return res;
        }






        public int GetLockCountForProjectList(int ProjectID)
        {
            int res = 0;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        res = (from a in context.ProjectTaskLists where a.ProjectID == ProjectID && a.LOCK == 1 && (a.SysGen == "N" || a.SysGen == null) select a).Count();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return res;
        }
        public bool deleteTaskById(int ProjectTaskID)
        {
            Boolean res = false;
            ////try
            ////{
            ////    using (var context = new Cubicle_EntityEntities())
            ////    {
            ////        var val = context.usp_deleteTaskListByID(ProjectTaskID).FirstOrDefault();
            ////        if (val == 0)
            ////            res = true;
            ////    }
            ////}
            ////catch (Exception ex)
            ////{
            ////    res = false;
            ////    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            ////    if (false)
            ////    {
            ////        throw ex;
            ////    }
            ////}
            return res;

        }

        public bool deleteTaskByTaskId(int ProjectTaskID)
        {
            Boolean res = false;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        var val = context.usp_deleteTaskListByTaskID_Contract(ProjectTaskID).FirstOrDefault();
            //        if (val == 0)
            //            res = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    res = false;
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return res;

        }





        public Boolean saveProjectTaskList(string xmlTargetDates, ProjectTaskList obj, int ProjectTaskID, string xmlTaskDependency, int statusID, int ScopeChangeID, out int VPojectTaskID1)
        {
            Boolean res = false;
            VPojectTaskID1 = 0;
            //System.Data.Objects.ObjectParameter VPojectTaskID = new System.Data.Objects.ObjectParameter("VPojectTaskID", typeof(int));
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {

            //        var val = context.usp_saveProjectTaskList(obj.AllottedHours,
            //                                                  obj.Deliverables,
            //                                                  obj.DepatmentID,
            //                                                  obj.DesignationID,
            //                                                  obj.EndDate,
            //                                                  obj.PrerequisiteInformation,
            //                                                  obj.Priority,
            //                                                  obj.ProjectID,
            //                                                  obj.Remarks,
            //                                                  obj.StartDate,
            //                                                  obj.TaskName,
            //                                                  obj.TaskTypeID,
            //                                                  xmlTargetDates,
            //                                                  ProjectTaskID,
            //                                                  obj.ParentTaskID,
            //                                                  obj.TaskOwner,
            //                                                  xmlTaskDependency,
            //                                                  statusID,
            //                                                  obj.ResourceRequestID,
            //                                                  obj.FocalPoint,
            //                                                  ScopeChangeID,
            //                                                  Convert.ToInt32(HttpContext.Current.Session["UserId"]),
            //                                                  Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint),
            //                                                  Convert.ToInt32(Common.TaskStatusID.Cancelled),
            //                                                  Convert.ToInt32(Common.TaskStatusID.Draft),
            //                                                  obj.WBSID,
            //                                                  obj.RequestID,
            //                                                  obj.NormsID,
            //                                                  VPojectTaskID,
            //                                                  obj.Duration
            //                                                  );
            //        if (val > 0)
            //        {
            //            res = true;
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    res = false;
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}

            //VPojectTaskID1 = Convert.ToInt32(VPojectTaskID.Value);
            return res;
        }

     
        public static Boolean UpdateTaskStatus(int TaskID, int StatusID)
        {
            Boolean res = false;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    ProjectTaskList ptl = (from a in context.ProjectTaskLists where a.ProjectTaskID == TaskID select a).FirstOrDefault();
                ////    ptl.TaskStatus = StatusID;
                ////    context.Entry(ptl).State = System.Data.EntityState.Modified;
                ////    context.SaveChanges();
                ////    res = true;
                ////}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public static Boolean AcceptTaskList(int TaskID, int StatusID)
        {
            Boolean res = false;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    var val = context.usp_AcceptTaskByUser(StatusID, TaskID);
                ////    if (val > 0)
                ////    {
                ////        res = true;
                ////    }
                ////}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public IList<usp_getTaskCreationSummary_Result> getTaskCreationSummary(int projectID)
        {
            IList<usp_getTaskCreationSummary_Result> List = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List = context.usp_getTaskCreationSummary(projectID).ToList<usp_getTaskCreationSummary_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return List;
        }


        public IList<object> getTaskCreationSummaryLock(int projectID)
        {
            IList<object> List = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List = context.usp_getTaskCreationSummary(projectID).ToList<object>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return List;

        }


        public IList<object> getLockTaskCreationSummaryLock(int projectID)
        {
            IList<object> List = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List = context.usp_getLockTaskCreationSummary(projectID).ToList<object>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return List;

        }





        public static IList<ScopeChange> getProjectScopeChanges()
        {
            IList<ScopeChange> List = null;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////   // List = context.ScopeChanges.ToList();
                ////}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return List;
        }

        public int GetTaskIDByTaskObjectID(int TaskObjectID, int ProjectID)
        {
            int res = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    res = (from a in context.ProjectTaskLists where a.ProjectID == ProjectID && a.TaskObjectID == TaskObjectID select a.ProjectTaskID).FirstOrDefault();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public static Boolean SaveTaskDependencyList(List<DomainModelLibrary.TaskDependency> list)
        {
            Boolean res = false;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    foreach (var a in list)
                //    {
                //        db.Entry(a).State = System.Data.EntityState.Added;
                //    }
                //    db.SaveChanges();
                //    res = true;
                //}
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }


        public static int saveProjectTaskListfromXMLFile(string xmlTasks, int ProjectID, string xmlTaskDependency, int statusID, string xmlWBSList)
        {
            int res = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{

                //    res = context.usp_saveProjectTaskListFromXmlFile(xmlTasks, ProjectID, xmlTaskDependency, statusID, xmlWBSList);
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }








        public static IList<usp_getProjectByFocalPtDeptID_Result> getProjectByFocalPtDeptID(int userID, int DeptID)
        {
            IList<usp_getProjectByFocalPtDeptID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getProjectByFocalPtDeptID(userID, DeptID, Convert.ToInt32(Common.ResourceRequestStatusID.Closed),
                //        Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint), Convert.ToInt32(Common.TaskStatusID.TaskAssigned), Convert.ToInt32(Common.ProjectStatus.Archived)).ToList<usp_getProjectByFocalPtDeptID_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static List<usp_getEmployeeByProjectIDRequestIDAndDeptID_Result> getEmployeeByProjectIDRequestIDAndDeptID(int ProjectID, int RequestID, int DeptID)
        {
            List<usp_getEmployeeByProjectIDRequestIDAndDeptID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getEmployeeByProjectIDRequestIDAndDeptID(ProjectID, RequestID, DeptID).ToList<usp_getEmployeeByProjectIDRequestIDAndDeptID_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public static List<usp_getEmployeeByProjectIDRequestIDAndDeptID_Integrated_Result> getEmployeeByProjectIDRequestIDAndDeptID_Integrated(int ProjectID, int RequestID, int TaskId, int DeptID,int EstimationStatusID,int AwatedStatusID)
        {
            List<usp_getEmployeeByProjectIDRequestIDAndDeptID_Integrated_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getEmployeeByProjectIDRequestIDAndDeptID_Integrated(ProjectID, RequestID, TaskId, DeptID, EstimationStatusID, AwatedStatusID).ToList<usp_getEmployeeByProjectIDRequestIDAndDeptID_Integrated_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }


        public static IList<usp_getTaskByFocalPtDeptID_Result> getTaskDetailsByFocalPtDeptID(int UserID, int ProjectID)
        {
            IList<usp_getTaskByFocalPtDeptID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getTaskByFocalPtDeptID(UserID, ProjectID, Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint), Convert.ToInt32(Common.TaskStatusID.TaskAssigned)).ToList<usp_getTaskByFocalPtDeptID_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public static IList<usp_getTaskByFocalPtDeptID_Integrated_Result> getTaskDetailsByFocalPtDeptID_Integrated(int UserID, int ProjectID)
        {
            IList<usp_getTaskByFocalPtDeptID_Integrated_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getTaskByFocalPtDeptID_Integrated(UserID, ProjectID, Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint), Convert.ToInt32(Common.TaskStatusID.TaskAssigned)).ToList<usp_getTaskByFocalPtDeptID_Integrated_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public static IList<usp_getMileStoneDetailsAsignTask_Result> getMileStoneDetailsAsignTask(int ProjectID)
        {
            IList<usp_getMileStoneDetailsAsignTask_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getMileStoneDetailsAsignTask(ProjectID, Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint), Convert.ToInt32(Common.TaskStatusID.TaskAssigned)).ToList<usp_getMileStoneDetailsAsignTask_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static IList<usp_TaskMilestoneTargetDates_AsignTask_Result> getTaskMilestoneTargetDatesAsignTask(int ProjectID)
        {
            IList<usp_TaskMilestoneTargetDates_AsignTask_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_TaskMilestoneTargetDates_AsignTask(ProjectID, Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint), Convert.ToInt32(Common.TaskStatusID.TaskAssigned)).ToList<usp_TaskMilestoneTargetDates_AsignTask_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<usp_getTaskStatusReportByProjectID_Result> getTaskStatusReportByProjectID(int ProjectID)
        {
            IList<usp_getTaskStatusReportByProjectID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getTaskStatusReportByProjectID(ProjectID, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner), Convert.ToInt32(Common.TaskStatusID.Closed)).ToList<usp_getTaskStatusReportByProjectID_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public ProjectTaskList_Contract getTaskDetailsByTaskId(int ProjectTaskID)
        {
            ProjectTaskList_Contract objTask = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    objTask = context.ProjectTaskList_Contract.FirstOrDefault(p => p.ProjectTaskID == ProjectTaskID);
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return objTask;
        }
        public IList<usp_TaskMilestoneTargetDatesByProjectTaskID_Result> getTaskMilestoneTargetDatesByTask(int ProjectTaskID)
        {
            IList<usp_TaskMilestoneTargetDatesByProjectTaskID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_TaskMilestoneTargetDatesByProjectTaskID(ProjectTaskID).ToList<usp_TaskMilestoneTargetDatesByProjectTaskID_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public static bool AssignResourceToTask(int ProjectTaskID, int TaskOwnerID, int StatusID, int RequestID, int CreatedBy, int ProjectID, int DeptID, int ResourceRequestID, int OldOwner)
        {
            Boolean res = false;
            //int? ResourceAllocationDesId = 0;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var context = new Cubicle_EntityEntities())
            //        {
            //            var ProjectTaskList = context.ProjectTaskLists.FirstOrDefault(p => p.ProjectTaskID == ProjectTaskID);

            //            if (ResourceRequestID == 0 || TaskOwnerID != OldOwner)
            //            {
            //                getResourceRequestIDAndDesnID(TaskOwnerID, RequestID, ProjectID, DeptID, out ResourceRequestID, out ResourceAllocationDesId);
            //            }

            //            if (ProjectTaskList != null)
            //            {

            //                // int TaskOwner = ResourceRequestID == 0 ?TaskOwnerID: OldOwner ;

            //                var ResourceAllocationList = (from r in context.ResourceAllocations where r.ResourceRequestID == ResourceRequestID select r);

            //                var ResourceAllocationDes = ResourceAllocationList.Where(a => a.UserID == TaskOwnerID).FirstOrDefault();
            //                int oldtaskOwner = ProjectTaskList.TaskOwner.GetValueOrDefault();
            //                ProjectTaskList.TaskOwner = TaskOwnerID;
            //                ProjectTaskList.TaskStatus = StatusID;
            //                ProjectTaskList.Status = "Accepted";
            //                ProjectTaskList.ResourceRequestID = ResourceRequestID;
            //                ProjectTaskList.DesignationID = ResourceAllocationDesId == 0 ? Convert.ToInt32(ResourceAllocationDes.RoleID) : Convert.ToInt32(ResourceAllocationDesId);
            //                context.Entry(ProjectTaskList).State = System.Data.EntityState.Modified;
            //                context.SaveChanges();
            //                var ResourceAllocation = ResourceAllocationList.FirstOrDefault();
            //                if (ResourceAllocation != null)
            //                {
            //                    if (ResourceAllocation.DepartmentChange == 1)
            //                    {
            //                        var TaskList = (from a in context.ProjectTaskLists where a.TaskOwner == TaskOwnerID && a.ResourceRequestID == ResourceRequestID select new { a.AllottedHours, a.StartDate, a.EndDate });

            //                        decimal TotAllottedHrs = TaskList.Sum(p => p.AllottedHours);
            //                        DateTime? MinDate = TaskList.Min(p => p.StartDate);
            //                        DateTime? MaxDate = TaskList.Max(p => p.EndDate);


            //                        if ((context.ResourceAllocations.Count(p => p.ResourceRequestID == ResourceRequestID && p.UserID == oldtaskOwner) == 0))
            //                        {
            //                            ResourceAllocation r = new ResourceAllocation();
            //                            r.ResourceRequestID = ResourceRequestID;
            //                            r.UserID = TaskOwnerID;
            //                            r.IsFocalPoint = "N";
            //                            r.allocatedFromDate = MinDate;
            //                            r.allocatedToDate = MaxDate;
            //                            r.AllocatedManHrs = TotAllottedHrs;
            //                            r.RoleID = ResourceAllocation.RoleID;
            //                            r.DepartmentChange = 1;
            //                            r.CreatedBy = CreatedBy;
            //                            r.CreatedOn = DateTime.Now;
            //                            context.Entry(r).State = System.Data.EntityState.Added;
            //                            context.SaveChanges();
            //                        }
            //                        else
            //                        {
            //                            var UserResourceAllocation = (from r in context.ResourceAllocations where r.ResourceRequestID == ResourceRequestID && r.UserID == oldtaskOwner select r).FirstOrDefault();

            //                            ResourceAllocation r_U = UserResourceAllocation;
            //                            r_U.ResourceRequestID = ResourceRequestID;
            //                            r_U.UserID = TaskOwnerID;
            //                            r_U.allocatedFromDate = MinDate;
            //                            r_U.allocatedToDate = MaxDate;
            //                            r_U.ModifiedBy = CreatedBy;
            //                            r_U.ModifiedOn = DateTime.Now;
            //                            context.Entry(r_U).State = System.Data.EntityState.Modified;
            //                            context.SaveChanges();
            //                        }
            //                    }
            //                    res = true;
            //                    ts.Complete();
            //                }
            //            }

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        ts.Dispose();
            //        if (false)
            //        {
            //            throw ex;
            //        }

            //    }
            //}
            return res;
        }

        public static void getResourceRequestIDAndDesnID(int TaskOwnerID, int RequestID, int ProjectID, int DeptID, out int ResourceRequestID, out int? ResourceAllocationDesId)
        {
            ResourceAllocationDesId = 0;
            ResourceRequestID = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    BLResourceRequestRepository blResReq = new BLResourceRequestRepository();
            //    List<ResourceRequest> lstResourceRequests = blResReq.GetResourceRequestByProjectIDRequestIDAndDeptID(ProjectID, RequestID, DeptID);
            //    List<int> lstInt = lstResourceRequests.Select(a => a.ResourceRequestID).ToList<int>();
            //    List<ResourceAllocation> VResourceAllocation = (from r in context.ResourceAllocations where lstInt.Contains(r.ResourceRequestID) && r.UserID == TaskOwnerID select r).ToList<ResourceAllocation>();
            //    int? TaskOwnerDesnID = (from r in context.Users where r.UserID == TaskOwnerID select r.DesignationID).Single();

            //    if (VResourceAllocation.Count() > 1)
            //    {
            //        List<ResourceAllocation> VResAlloc = (from q in VResourceAllocation where q.RoleID == TaskOwnerDesnID select q).ToList<ResourceAllocation>();
            //        if (VResAlloc.Count() != 0)
            //        {
            //            ResourceRequestID = VResAlloc.FirstOrDefault().ResourceRequestID;
            //            ResourceAllocationDesId = Convert.ToInt32(VResAlloc.FirstOrDefault().RoleID);
            //        }
            //        else
            //        {
            //            ResourceRequestID = VResourceAllocation.FirstOrDefault().ResourceRequestID;
            //            ResourceAllocationDesId = Convert.ToInt32(VResourceAllocation.FirstOrDefault().RoleID);
            //        }
            //    }
            //    else if (VResourceAllocation.Count() != 0)
            //    {
            //        ResourceRequestID = VResourceAllocation.FirstOrDefault().ResourceRequestID;
            //        ResourceAllocationDesId = Convert.ToInt32(VResourceAllocation.FirstOrDefault().RoleID);
            //    }
            //    else
            //    {
            //        ResourceRequestID = lstResourceRequests.FirstOrDefault().ResourceRequestID;
            //        ResourceAllocationDesId = Convert.ToInt32(TaskOwnerDesnID);
            //    }
            //}
        }

        public static List<ListItem> EstimatedHrs_DesgByTaskID(int TaskID)
        {
            List<ListItem> list = new List<ListItem>();
            //try
            //{
            //    using (var db = new Cubicle_EntityEntities())
            //    {
            //        var EstimatedId = (from t in db.ProjectTaskLists where t.ProjectTaskID == TaskID select t.EstimationTaskID).FirstOrDefault();
            //        int eid = EstimatedId.GetValueOrDefault(0);
            //        //var listval = (from ncm in db.NormsColumnsMasters
            //        //              join ecm in db.EstimationTaskColumnsMasters on
            //        //                  ncm.NormsColumnID equals ecm.NormsColumnID
            //        //              where ecm.ProjectTaskListColumn.Contains("AllottedHours")
            //        //              join etd in db.EstimationTaskDetails on ecm.EstimationTaskColumnID equals etd.EstimationTaskColumnID
            //        //               where etd.EstimationTaskID == EstimatedId
            //        //              join d in db.Designations on ncm.DBColPkID equals d.DesignationID
            //        //              select new { d.DesignationName, etd.ColValue });

            //        var listval = (from pt in db.ProjectTaskLists
            //                       join td in db.TaskDesignations on
            //                           pt.ProjectTaskID equals td.ProjectTaskID
            //                       join d in db.Designations on td.DesignationID equals d.DesignationID
            //                       where pt.ProjectTaskID == TaskID
            //                       select new { d.DesignationName, td.Hours });

            //        foreach (var l in listval.ToList())
            //        {
            //            list.Add(new ListItem(l.DesignationName, l.Hours.ToString()));
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
            return list;
        }



        public static List<ListItem> GetTaskScheduleDetailByTaskID(int TaskID)
        {
            List<ListItem> list = new List<ListItem>();
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{


                //    var listval = (from pt in db.TaskMilestoneTargetDates
                //                   join td in db.ProjectMilestones on
                //                       pt.MileStoneID equals td.ProjectMilestoneID

                //                   where pt.TaskID == TaskID
                //                   select new { td.MileStone, pt.TaskMilestoneTargetDates, Weightage = td.Weightage });

                //    foreach (var l in listval.ToList())
                //    {
                //        list.Add(new ListItem(l.MileStone+" ("+Convert.ToInt32(l.Weightage).ToString()+" %)", l.TaskMilestoneTargetDates.ToString()));
                //    }
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }




        public static bool AssignResourceToSubTask(int ParentTaskID, int ResourceRequestID, int CreatedBy)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var context = new Cubicle_EntityEntities())
            //        {

            //            var ResourceAllocation = (from r in context.ResourceAllocations where r.ResourceRequestID == ResourceRequestID select r).FirstOrDefault();
            //            if (ResourceAllocation != null)
            //            {
            //                if (ResourceAllocation.DepartmentChange == 1)
            //                {
            //                    int TaskOwner = (from a in context.ProjectTaskLists where a.ParentTaskID == ParentTaskID select a.TaskOwner).FirstOrDefault().GetValueOrDefault();
            //                    if (TaskOwner != 0)
            //                    {
            //                        var TaskList = (from a in context.ProjectTaskLists where a.TaskOwner == TaskOwner && a.ResourceRequestID == ResourceRequestID select new { a.AllottedHours, a.StartDate, a.EndDate });

            //                        decimal TotAllottedHrs = TaskList.Sum(p => p.AllottedHours);
            //                        DateTime? MinDate = TaskList.Min(p => p.StartDate);
            //                        DateTime? MaxDate = TaskList.Max(p => p.EndDate);


            //                        if ((context.ResourceAllocations.Count(p => p.ResourceRequestID == ResourceRequestID && p.UserID == TaskOwner) == 0))
            //                        {
            //                            ResourceAllocation r = new DominModel.ResourceAllocation();
            //                            r.ResourceRequestID = ResourceRequestID;
            //                            r.UserID = TaskOwner;
            //                            r.IsFocalPoint = "N";
            //                            r.allocatedFromDate = MinDate;
            //                            r.allocatedToDate = MaxDate;
            //                            r.AllocatedManHrs = TotAllottedHrs;
            //                            r.RoleID = ResourceAllocation.RoleID;
            //                            r.DepartmentChange = 1;
            //                            r.CreatedBy = CreatedBy;
            //                            r.CreatedOn = DateTime.Now;
            //                            context.Entry(r).State = System.Data.EntityState.Added;
            //                            context.SaveChanges();
            //                            //select TaskOwner,ProjectTaskID,TaskStatus from ProjectTaskList Where ProjectTaskID=@proje

            //                        }
            //                        else
            //                        {
            //                            var UserResourceAllocation = (from r in context.ResourceAllocations where r.ResourceRequestID == ResourceRequestID && r.UserID == TaskOwner select r).FirstOrDefault();

            //                            ResourceAllocation r_U = UserResourceAllocation;
            //                            r_U.ResourceRequestID = ResourceRequestID;
            //                            r_U.UserID = TaskOwner;
            //                            r_U.allocatedFromDate = MinDate;
            //                            r_U.allocatedToDate = MaxDate;
            //                            r_U.AllocatedManHrs = TotAllottedHrs;
            //                            r_U.ModifiedBy = CreatedBy;
            //                            r_U.ModifiedOn = DateTime.Now;
            //                            context.Entry(r_U).State = System.Data.EntityState.Modified;
            //                            context.SaveChanges();
            //                        }
            //                        var ObjTask = (from t in context.ProjectTaskLists where t.ProjectTaskID == ParentTaskID select new { t.ProjectTaskID, t.TaskOwner, t.TaskStatus, t.RequestID, t.ProjectID, t.DepatmentID, t.DesignationID }).FirstOrDefault();
            //                        AssignResourceToTask(ObjTask.ProjectTaskID, ObjTask.TaskOwner.GetValueOrDefault(), ObjTask.TaskStatus.GetValueOrDefault(), ObjTask.RequestID.GetValueOrDefault(), CreatedBy, ObjTask.ProjectID, ObjTask.DepatmentID, ResourceRequestID, Convert.ToInt32(ObjTask.TaskOwner));

            //                    }
            //                    else
            //                    {
            //                        res = false;
            //                        ts.Dispose();
            //                        return res;

            //                    }
            //                }
            //                res = true;
            //                ts.Complete();
            //            }
            //        }


            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        ts.Dispose();
            //        if (false)
            //        {
            //            throw ex;
            //        }

            //    }
            //}
            return res;
        }

        public IList<VW_MYTASK> GetMyTask(VW_MYTASK objTask, int ProjectId)
        {
            IList<VW_MYTASK> list = null;
            //int TaskStatusID = Convert.ToInt32(Common.TaskStatusID.Cancelled);
            //int AcceptID = Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner);
            //int TaskAssigned = Convert.ToInt32(Common.TaskStatusID.TaskAssigned);
            //int TaskOwnerId = Convert.ToInt32(HttpContext.Current.Session["UserId"]);

            //try
            //{//DateTime.MinValue
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        IQueryable<VW_MYTASK> query = context.VW_MYTASK;
            //        query = query.Where(p => p.ProjectID == ProjectId && p.TaskStatusID != TaskStatusID && p.TaskStatusID >= TaskAssigned && p.TaskOwner == TaskOwnerId);
            //        if (objTask.ProjectName != string.Empty)
            //            query = query.Where(p => p.ProjectName.ToUpper().Contains(objTask.ProjectName.ToUpper()));
            //        //if (objTask.TaskStatus != "0")
            //        //    query = query.Where(p => p.TaskStatus.Equals(objTask.TaskStatus));
            //        if (objTask.StartDate != DateTime.MinValue && objTask.EndDate != DateTime.MinValue)
            //            query = query.Where(p => p.StartDate >= objTask.StartDate && p.EndDate <= objTask.EndDate);
            //        list = query.ToList();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return list;
        }
        //public static IList<usp_getMyMileStoneDetails_Result> getMyMileStoneDetailsByProjectID(int ProjectID)
        //{
        //    IList<usp_getMyMileStoneDetails_Result> list = null;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            list = context.usp_getMyMileStoneDetails(ProjectID, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner)).ToList<usp_getMyMileStoneDetails_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return list;
        //}
        public static IList<usp_getMyTaskMilestoneTargetDates_Result> getMyTaskMilestoneTargetDates(int ProjectID)
        {
            IList<usp_getMyTaskMilestoneTargetDates_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getMyTaskMilestoneTargetDates(ProjectID, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner)).ToList<usp_getMyTaskMilestoneTargetDates_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static IList<usp_getMileStoneDetailsByProjectID_Result> getMileStoneDetailsByProjectID(int ProjectID)
        {
            IList<usp_getMileStoneDetailsByProjectID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getMileStoneDetailsByProjectID(ProjectID).ToList<usp_getMileStoneDetailsByProjectID_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<usp_getMileStoneDetails_Report_Result> getMileStoneDetailsByProjectID_Report(int ProjectID)
        {
            IList<usp_getMileStoneDetails_Report_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.usp_getMileStoneDetails_Report(ProjectID).ToList<usp_getMileStoneDetails_Report_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<usp_getMileStoneTargetDatesDetails_Report_Result> getMileStoneTargetDatesDetails_Report(int ProjectID)
        {
            IList<usp_getMileStoneTargetDatesDetails_Report_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.usp_getMileStoneTargetDatesDetails_Report(ProjectID).ToList<usp_getMileStoneTargetDatesDetails_Report_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<usp_getOnGoingMyTaskList_Result> getOnGoingTaskList(int UserID)
        {
            IList<usp_getOnGoingMyTaskList_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.usp_getOnGoingMyTaskList(UserID, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner)).ToList<usp_getOnGoingMyTaskList_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<usp_getDelayTaskLit_Result> GetDelayTaskList(int userID, DateTime PresentDate)
        {
            IList<usp_getDelayTaskLit_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.usp_getDelayTaskLit(PresentDate, userID, Convert.ToInt32(Common.TaskStatusID.TaskStarted), Convert.ToInt32(Common.TaskStatusID.Closed), Convert.ToInt32(Common.ProjectStatus.Archived)).ToList<usp_getDelayTaskLit_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        //public static IList<usp_getMyOnGoingScheduleGantt_Result> getMyOnGoingScheduleGantt(int UserID)
        //{
        //    IList<usp_getMyOnGoingScheduleGantt_Result> list = null;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            list = context.usp_getMyOnGoingScheduleGantt(UserID, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner)).ToList<usp_getMyOnGoingScheduleGantt_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return list;
        //}
        public static string getTaskScheduleHealth(int TaskID, string HealthType)
        {
            decimal result = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    result = context.usp_getTaskScheduleHealth(TaskID).FirstOrDefault().GetValueOrDefault();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return BLProjectCreationRepository.GetHealthColort(HealthType, result) + "#" + (100 - result).ToString(); ;
        }
        public static string getTaskCostHealth(int TaskID, string HealthType)
        {
            decimal result = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    result = context.usp_getTaskCostHealth(TaskID).FirstOrDefault().GetValueOrDefault();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return BLProjectCreationRepository.GetHealthColort(HealthType, result) + "#" + (100 - result).ToString(); ;
        }
        public static IList<usp_getMyScheduleGanttTaskProjectWise_Result> getMyScheduleGanttTaskProjectWise(int UserID, DateTime startDate, DateTime endDate, int ProjectStatusArchived)
        {
            IList<usp_getMyScheduleGanttTaskProjectWise_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getMyScheduleGanttTaskProjectWise(UserID, startDate, endDate, ProjectStatusArchived).ToList<usp_getMyScheduleGanttTaskProjectWise_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static IList<usp_getProjectForMySchedule_Result> getProjectForMySchedule(int userID, int DeptID)
        {
            IList<usp_getProjectForMySchedule_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getProjectForMySchedule(userID, DeptID, Convert.ToInt32(Common.ResourceRequestStatusID.Closed),
                //         Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint), Convert.ToInt32(Common.TaskStatusID.TaskAssigned), Convert.ToInt32(Common.ProjectStatus.Archived)).ToList<usp_getProjectForMySchedule_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public static IList<usp_getTaskDetails_Handover_Result> getTaskDetails(string ProjectTaskID)
        {
            IList<usp_getTaskDetails_Handover_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_getTaskDetails_Handover(Convert.ToInt32(ProjectTaskID)).ToList<usp_getTaskDetails_Handover_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static IList<usp_getTaskTaskDependency_Handover_Result> getTaskDependencyList(string ProjectTaskID)
        {
            IList<usp_getTaskTaskDependency_Handover_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_getTaskTaskDependency_Handover(Convert.ToInt32(ProjectTaskID)).ToList<usp_getTaskTaskDependency_Handover_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public static IList<usp_getTaskOwnerLeaderFocalPoint_Result> GetTaskOwner_ProjectLeader_FocalPoint(int TaskID)
        {
            IList<usp_getTaskOwnerLeaderFocalPoint_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_getTaskOwnerLeaderFocalPoint(TaskID).ToList<usp_getTaskOwnerLeaderFocalPoint_Result>();
                //}

            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public static string GetProjectCode(int taskID)
        {

            string res = "";
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var val = from p in db.Projects where p.ProjectID == (from t in db.ProjectTaskLists where t.ProjectTaskID == taskID select t.ProjectID).FirstOrDefault() select p.ProjectCode;
                //    res = val.FirstOrDefault().ToString();
                //}
            }
            catch (Exception ex)
            {
            }
            return res;

        }

        public static Int32 GetFocalPointUserIDByProjectIDDepartmentID(int projectID, int DeptID)
        {
            int res = 0;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var val = (from ra in db.ResourceAllocations
                //               where ra.ResourceRequestID == (from r in db.ResourceRequests where r.ProjectID == projectID && r.DepartmentID == DeptID select r.ResourceRequestID).FirstOrDefault()
                //                   && ra.IsFocalPoint == "Y"
                //               select ra.UserID).FirstOrDefault();
                //    res = val;
                //}
            }
            catch (Exception ex)
            {
            }
            return res;

        }

        public static Int32 GetMaxID(int projectID)
        {
            Int32 iMaxTaskID = 0;
            try
            {
                ////using (var db = new Cubicle_EntityEntities())
                ////{
                ////    var val = db.ProjectTaskLists.Max(p => p.ProjectTaskID);
                ////    iMaxTaskID = val;
                ////}

            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return iMaxTaskID;
        }

        public static IList<ProjectTaskList> GetProjectTaskList(DateTime Month, int DeptID, int DesigID, int ProjectID)
        {
            IList<ProjectTaskList> list = null;
            DateTime fDate = new DateTime(Month.Year, Month.Month, 1);
            DateTime eDate = fDate.AddMonths(1).AddDays(-1);
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from pt in db.ProjectTaskLists
                //            where pt.StartDate >= fDate.Date && pt.EndDate <= eDate.Date
                //               && pt.DepatmentID == (DeptID == 0 ? pt.DepatmentID : DeptID)
                //               && pt.DesignationID == (DesigID == 0 ? pt.DesignationID : DesigID)
                //               && pt.ProjectID == (ProjectID == 0 ? pt.ProjectID : ProjectID)
                //            select pt).ToList<ProjectTaskList>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static Decimal GetRequiredMilestoneHrsByPeriod(ProjectTaskList Task, DateTime Month)
        {
            DataTable dt = null;
            DateTime StartDate = new DateTime(Month.Year, Month.Month, 1).Date;
            DateTime EndDate = StartDate.AddMonths(1).AddDays(-1).Date;
            decimal TotalHrsInPeriodPerTask = 0.00M;
            ////try
            ////{
            ////    dt = new DataTable();
            ////    dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            ////    dt.Columns.Add(new DataColumn("ProgressLevel", typeof(string)));
            ////    dt.Columns.Add(new DataColumn("Weightage", typeof(decimal)));
            ////    dt.Columns.Add(new DataColumn("WorkingDays", typeof(int)));
            ////    dt.Columns.Add(new DataColumn("WDayPrgressPerDay", typeof(decimal)));
            ////    dt.Columns.Add(new DataColumn("HrsRequiredPerDay", typeof(decimal)));
            ////    dt.Columns.Add(new DataColumn("HrsRequiredPerPeriod", typeof(decimal)));
            ////    dt.Columns["HrsRequiredPerPeriod"].DefaultValue = 0.0;
            ////    using (var db = new Cubicle_EntityEntities())
            ////    {
            ////        var FirstMilestone = (from tt in
            ////                                  (
            ////                                      ((
            ////                                      from PT in db.ProjectTaskLists
            ////                                      where
            ////                                        PT.ProjectTaskID == Task.ProjectTaskID
            ////                                      select new
            ////                                      {
            ////                                          dat = (DateTime?)PT.StartDate,
            ////                                          MileStone = "Start",
            ////                                          Weightage = (Decimal?)0
            ////                                      }
            ////                                      )
            ////                                      .Union
            ////                                      (
            ////                                      from PT in db.ProjectTaskLists
            ////                                      join TMT in db.TaskMilestoneTargetDates on new { ProjectTaskID = PT.ProjectTaskID } equals new { ProjectTaskID = TMT.TaskID }
            ////                                      join PM in db.ProjectMilestones on new { MileStoneID = TMT.MileStoneID } equals new { MileStoneID = PM.ProjectMilestoneID }
            ////                                      where
            ////                                        PT.ProjectTaskID == Task.ProjectTaskID
            ////                                      select new
            ////                                      {
            ////                                          dat = (DateTime?)TMT.TaskMilestoneTargetDates,
            ////                                          MileStone = PM.MileStone,
            ////                                          Weightage = (Decimal?)PM.Weightage
            ////                                      }
            ////                                      )
            ////                                      .Union
            ////                                      (
            ////                                      from PT in db.ProjectTaskLists
            ////                                      where
            ////                                        PT.ProjectTaskID == Task.ProjectTaskID
            ////                                      select new
            ////                                      {
            ////                                          dat = (DateTime?)PT.EndDate,
            ////                                          MileStone = "End",
            ////                                          Weightage = (Decimal?)100
            ////                                      }
            ////                                      )))
            ////                              where
            ////                                tt.dat < StartDate
            ////                              orderby
            ////                                tt.dat descending
            ////                              select new
            ////                              {
            ////                                  tt.dat,
            ////                                  tt.MileStone,
            ////                                  tt.Weightage
            ////                              }).Take(1);

            ////        var SecondMilestoneList = from tt in
            ////                                      (
            ////                                          ((
            ////                                          from PT in db.ProjectTaskLists
            ////                                          where
            ////                                            PT.ProjectTaskID == Task.ProjectTaskID
            ////                                          select new
            ////                                          {
            ////                                              dat = (DateTime?)PT.StartDate,
            ////                                              MileStone = "Start",
            ////                                              Weightage = (Decimal?)0
            ////                                          }
            ////                                          ).Union
            ////                                          (
            ////                                          from PT in db.ProjectTaskLists
            ////                                          join TMT in db.TaskMilestoneTargetDates on new { ProjectTaskID = PT.ProjectTaskID } equals new { ProjectTaskID = TMT.TaskID }
            ////                                          join PM in db.ProjectMilestones on new { MileStoneID = TMT.MileStoneID } equals new { MileStoneID = PM.ProjectMilestoneID }
            ////                                          where
            ////                                            PT.ProjectTaskID == Task.ProjectTaskID
            ////                                          select new
            ////                                          {
            ////                                              dat = (DateTime?)TMT.TaskMilestoneTargetDates,
            ////                                              MileStone = PM.MileStone,
            ////                                              Weightage = (Decimal?)PM.Weightage
            ////                                          }
            ////                                          ).Union
            ////                                          (
            ////                                          from PT in db.ProjectTaskLists
            ////                                          where
            ////                                            PT.ProjectTaskID == Task.ProjectTaskID
            ////                                          select new
            ////                                          {
            ////                                              dat = (DateTime?)PT.EndDate,
            ////                                              MileStone = "End",
            ////                                              Weightage = (Decimal?)100
            ////                                          }
            ////                                          )))
            ////                                  where
            ////                                    tt.dat >= StartDate && tt.dat <= EndDate
            ////                                  orderby
            ////                                    tt.dat
            ////                                  select new
            ////                                  {
            ////                                      tt.dat,
            ////                                      tt.MileStone,
            ////                                      tt.Weightage
            ////                                  };


            ////        var ThiredMileStoneList = (from tt in
            ////                                       (
            ////                                           ((
            ////                                           from PT in db.ProjectTaskLists
            ////                                           where
            ////                                             PT.ProjectTaskID == Task.ProjectTaskID
            ////                                           select new
            ////                                           {
            ////                                               dat = (DateTime?)PT.StartDate,
            ////                                               MileStone = "Start",
            ////                                               Weightage = (Decimal?)0
            ////                                           }
            ////                                           ).Union
            ////                                           (
            ////                                           from PT in db.ProjectTaskLists
            ////                                           join TMT in db.TaskMilestoneTargetDates on new { ProjectTaskID = PT.ProjectTaskID } equals new { ProjectTaskID = TMT.TaskID }
            ////                                           join PM in db.ProjectMilestones on new { MileStoneID = TMT.MileStoneID } equals new { MileStoneID = PM.ProjectMilestoneID }
            ////                                           where
            ////                                             PT.ProjectTaskID == 485
            ////                                           select new
            ////                                           {
            ////                                               dat = (DateTime?)TMT.TaskMilestoneTargetDates,
            ////                                               MileStone = PM.MileStone,
            ////                                               Weightage = (Decimal?)PM.Weightage
            ////                                           }
            ////                                           ).Union
            ////                                           (
            ////                                           from PT in db.ProjectTaskLists
            ////                                           where
            ////                                             PT.ProjectTaskID == Task.ProjectTaskID
            ////                                           select new
            ////                                           {
            ////                                               dat = (DateTime?)PT.EndDate,
            ////                                               MileStone = "End",
            ////                                               Weightage = (Decimal?)100
            ////                                           }
            ////                                           )))
            ////                                   where
            ////                                     tt.dat > EndDate
            ////                                   orderby
            ////                                     tt.dat
            ////                                   select new
            ////                                   {
            ////                                       tt.dat,
            ////                                       tt.MileStone,
            ////                                       tt.Weightage
            ////                                   }).Take(1);
            ////        foreach (var a in FirstMilestone)
            ////        {
            ////            DataRow dr = dt.NewRow();
            ////            dr[0] = a.dat;
            ////            dr[1] = a.MileStone;
            ////            dr[2] = a.Weightage;
            ////            dt.Rows.Add(dr);
            ////        }
            ////        foreach (var a in SecondMilestoneList)
            ////        {
            ////            DataRow dr = dt.NewRow();
            ////            dr[0] = a.dat;
            ////            dr[1] = a.MileStone;
            ////            dr[2] = a.Weightage;
            ////            dt.Rows.Add(dr);
            ////        }
            ////        foreach (var a in ThiredMileStoneList)
            ////        {
            ////            DataRow dr = dt.NewRow();
            ////            dr[0] = a.dat;
            ////            dr[1] = a.MileStone;
            ////            dr[2] = a.Weightage;
            ////            dt.Rows.Add(dr);
            ////        }

            ////        for (int i = 1; i < dt.Rows.Count; i++)
            ////        {
            ////            int HrsRequiredPerPeriod = BLDailyWorkingHrRepository.NormalWorkingDaysPerPeriod(Convert.ToDateTime(dt.Rows[i - 1][0]), Convert.ToDateTime(dt.Rows[i][0]));
            ////            dt.Rows[i][3] = HrsRequiredPerPeriod;
            ////            if (HrsRequiredPerPeriod == 0)
            ////            {
            ////                dt.Rows[i][4] = 0;
            ////                dt.Rows[i][5] = 0;
            ////            }
            ////            else
            ////            {

            ////                //Per working day progress=(diff of progress level/No of working days
            ////                dt.Rows[i][4] = ((Convert.ToDecimal(dt.Rows[i][2]) - Convert.ToDecimal(dt.Rows[i - 1][2])) / Convert.ToDecimal(HrsRequiredPerPeriod));
            ////                //Hours required per day=(Per working day progress*Task Allotted hrs)/100
            ////                dt.Rows[i][5] = (Convert.ToDecimal(dt.Rows[i][4]) * Task.AllottedHours) / 100;
            ////            }
            ////            if (i == 1)
            ////            {
            ////                if (Convert.ToString(dt.Rows[i - 1]["ProgressLevel"]).ToUpper() == "START")
            ////                {
            ////                    if (Convert.ToDateTime(dt.Rows[i - 1]["Date"]).Month != StartDate.Month)
            ////                    {
            ////                        dt.Rows[i - 1]["Date"] = StartDate;
            ////                    }
            ////                }
            ////                else
            ////                {
            ////                    dt.Rows[i - 1]["Date"] = StartDate;
            ////                }
            ////                HrsRequiredPerPeriod = BLDailyWorkingHrRepository.NormalWorkingDaysPerPeriod(Convert.ToDateTime(dt.Rows[i - 1][0]), Convert.ToDateTime(dt.Rows[i][0]));
            ////            }
            ////            if (i == dt.Rows.Count - 1)
            ////            {
            ////                if (Convert.ToString(dt.Rows[i]["ProgressLevel"]).ToUpper() == "END")
            ////                {
            ////                    if (Convert.ToDateTime(dt.Rows[i]["Date"]).Month != EndDate.Month)
            ////                    {
            ////                        dt.Rows[i]["Date"] = EndDate;
            ////                    }
            ////                }
            ////                else
            ////                {
            ////                    dt.Rows[i]["Date"] = EndDate;
            ////                }
            ////                HrsRequiredPerPeriod = BLDailyWorkingHrRepository.NormalWorkingDaysPerPeriod(Convert.ToDateTime(dt.Rows[i - 1][0]), Convert.ToDateTime(dt.Rows[i][0]));
            ////            }
            ////            dt.Rows[i]["HrsRequiredPerPeriod"] = Convert.ToDecimal(HrsRequiredPerPeriod) * Convert.ToDecimal(dt.Rows[i]["HrsRequiredPerDay"]);
            ////        }

            ////    }

            ////    TotalHrsInPeriodPerTask = dt.AsEnumerable().Sum(x => x.Field<decimal>("HrsRequiredPerPeriod"));
            ////}
            ////catch (Exception ex)
            ////{
            ////}
            ////finally
            ////{
            ////    if ((dt == null) == false)
            ////        dt = null;
            ////}
            return TotalHrsInPeriodPerTask;
        }

        public static IList<Department> GetDepartmentsByProject(int ProjectID)
        {
            IList<Department> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from pt in db.ProjectTaskLists
                //            join
                //                d in db.Departments on pt.DepatmentID equals d.DepartmentID
                //            where pt.ProjectID == ProjectID
                //            select d).Distinct().ToList<Department>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static IList<Designation> GetDesignationByProject(int ProjectID, int Dept)
        {
            IList<Designation> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from pt in db.ProjectTaskLists
                //            join
                //                d in db.Designations on pt.DesignationID equals d.DesignationID
                //            where pt.ProjectID == ProjectID && pt.DepatmentID == (Dept == 0 ? pt.DepatmentID : Dept)
                //            select d).Distinct().ToList<Designation>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static IList<ProjectTaskList> GetTaskListByProjectID(int ProjectID, int Dept, int Desig)
        {
            IList<ProjectTaskList> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from t in db.ProjectTaskLists where t.ProjectID == ProjectID && t.DepatmentID == (Dept == 0 ? t.DepatmentID : Dept) && t.DesignationID == (Desig == 0 ? t.DesignationID : Desig) select t).ToList<ProjectTaskList>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        //Project Burn chart Planced Progress in period

        public static List<DateTime> GetProjectStartEndDates(int ProjectID, int Dept, int Desig, int TaskId)
        {
            List<DateTime> list = null;
            try
            {
                list = new List<DateTime>();
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var val = (from pt in
                //                   (from ptl in db.ProjectTaskLists
                //                    where
                //                      ptl.ProjectID == ProjectID && ptl.DepatmentID == (Dept == 0 ? ptl.DepatmentID : Dept)
                //                      && ptl.DesignationID == (Desig == 0 ? ptl.DesignationID : Desig)
                //                      && ptl.ProjectTaskID == (TaskId == 0 ? ptl.ProjectTaskID : TaskId)
                //                    select new
                //                    {
                //                        ptl.StartDate,
                //                        ptl.EndDate,
                //                        Dummy = "x"
                //                    })
                //               group pt by new { pt.Dummy } into g
                //               select new
                //               {
                //                   Column1 = (DateTime?)g.Min(p => p.StartDate),
                //                   Column2 = (DateTime?)g.Max(p => p.EndDate)
                //               });
                //    foreach (var a in val)
                //    {
                //        list.Add(a.Column1.GetValueOrDefault());
                //        list.Add(a.Column2.GetValueOrDefault());
                //    }
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public static IList<ProjectTaskList> GetTaskListByProjectID_Date(int ProjectID, int Dept, int Desig, int Taskid, DateTime period)
        {
            IList<ProjectTaskList> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from pt in db.ProjectTaskLists
                //            where pt.ProjectID == ProjectID
                //            && (pt.StartDate <= period && pt.EndDate >= period)
                //            && pt.DepatmentID == (Dept == 0 ? pt.DepatmentID : Dept)
                //                     && pt.DesignationID == (Desig == 0 ? pt.DesignationID : Desig)
                //                     && pt.ProjectTaskID == (Taskid == 0 ? pt.ProjectTaskID : Taskid)
                //            select pt).ToList<ProjectTaskList>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }


        //public static List<decimal> GetProjectPlanced_Actual_AManHrsByPeriod(int ProjectId, int Dept, int Desig, int Taskid, DateTime Period)
        //{
        //    List<decimal> res = new List<decimal>() { 0.0M, 0.0M, 0.0M };
        //    List<u_TaskProgress> list = new List<u_TaskProgress>();
        //    try
        //    {
        //        List<ProjectTaskList> val = GetTaskListByProjectID_Date(ProjectId, Dept, Desig, Taskid, Period).ToList();
        //        using (var db = new Cubicle_EntityEntities())
        //        {
        //            foreach (var t in val)
        //            {
        //                //Planed
        //                var Plist = from tt in
        //                                (
        //                                    ((
        //                                    from pt in db.ProjectTaskLists
        //                                    where
        //                                      pt.ProjectTaskID == t.ProjectTaskID
        //                                    select new
        //                                    {
        //                                        ProgressDate = (DateTime?)pt.StartDate,
        //                                        progressLevel = "Start",
        //                                        progress = (Decimal?)0
        //                                    }
        //                                    ).Union
        //                                    (
        //                                    from ttd in db.TaskMilestoneTargetDates
        //                                    where
        //                                      ttd.TaskID == t.ProjectTaskID
        //                                    select new
        //                                    {
        //                                        ProgressDate = (DateTime?)ttd.TaskMilestoneTargetDates,
        //                                        progressLevel =
        //                                          ((from P in db.ProjectMilestones
        //                                            where
        //                                              P.ProjectMilestoneID == ttd.MileStoneID
        //                                            select new
        //                                            {
        //                                                P.ProjectMilestone1
        //                                            }).FirstOrDefault().ProjectMilestone1),
        //                                        progress = (Decimal?)
        //                                          ((from P in db.ProjectMilestones
        //                                            where
        //                                              P.ProjectMilestoneID == ttd.MileStoneID
        //                                            select new
        //                                            {
        //                                                P.Weightage
        //                                            }).FirstOrDefault().Weightage)
        //                                    }
        //                                    ).Union
        //                                    (
        //                                    from pt in db.ProjectTaskLists
        //                                    where
        //                                      pt.ProjectTaskID == t.ProjectTaskID
        //                                    select new
        //                                    {
        //                                        ProgressDate = (DateTime?)pt.EndDate,
        //                                        progressLevel = "End",
        //                                        progress = (Decimal?)100
        //                                    }
        //                                    )))
        //                            where
        //                              tt.ProgressDate <= Period
        //                            group tt by new
        //                            {
        //                                tt.progress
        //                            } into g
        //                            select new
        //                            {
        //                                Column1 = (DateTime?)g.Max(p => p.ProgressDate),
        //                                progress = (System.Decimal?)g.Key.progress
        //                            };
        //                foreach (var a in Plist)
        //                {
        //                    u_TaskProgress utp = new u_TaskProgress();
        //                    utp.Tid = t.ProjectTaskID;
        //                    utp.AllottedHrs = t.AllottedHours;
        //                    utp.ProgressType = 'P';
        //                    utp.Weight = a.progress.GetValueOrDefault();
        //                    list.Add(utp);
        //                }

        //                //Actual

        //                var Alist = from tt in
        //                                (
        //                                    ((
        //                                    from pt in db.ProjectTaskLists
        //                                    where
        //                                      pt.ProjectTaskID == t.ProjectTaskID
        //                                    select new
        //                                    {
        //                                        ProgressDate = (DateTime?)pt.ActualStartDate,
        //                                        progressLevel = "Start",
        //                                        progress = (Decimal?)0
        //                                    }
        //                                    ).Union
        //                                    (
        //                                    from ttd in db.TaskMilestoneTargetDates
        //                                    where
        //                                      ttd.TaskID == t.ProjectTaskID
        //                                    select new
        //                                    {
        //                                        ProgressDate = (DateTime?)ttd.ActualTaskMilestoneTargetDates,
        //                                        progressLevel =
        //                                          ((from P in db.ProjectMilestones
        //                                            where
        //                                              P.ProjectMilestoneID == ttd.MileStoneID
        //                                            select new
        //                                            {
        //                                                P.ProjectMilestone1
        //                                            }).FirstOrDefault().ProjectMilestone1),
        //                                        progress = (Decimal?)
        //                                          ((from P in db.ProjectMilestones
        //                                            where
        //                                              P.ProjectMilestoneID == ttd.MileStoneID
        //                                            select new
        //                                            {
        //                                                P.Weightage
        //                                            }).FirstOrDefault().Weightage)
        //                                    }
        //                                    ).Union
        //                                    (
        //                                    from pt in db.ProjectTaskLists
        //                                    where
        //                                      pt.ProjectTaskID == t.ProjectTaskID
        //                                    select new
        //                                    {
        //                                        ProgressDate = (DateTime?)pt.ActualEndDate,
        //                                        progressLevel = "End",
        //                                        progress = (Decimal?)100
        //                                    }
        //                                    )))
        //                            where
        //                              tt.ProgressDate <= Period
        //                            group tt by new
        //                            {
        //                                tt.progress
        //                            } into g
        //                            select new
        //                            {
        //                                Column1 = (DateTime?)g.Max(p => p.ProgressDate),
        //                                progress = (System.Decimal?)g.Key.progress
        //                            };
        //                foreach (var a in Plist)
        //                {
        //                    u_TaskProgress utp = new u_TaskProgress();
        //                    utp.Tid = t.ProjectTaskID;
        //                    utp.AllottedHrs = t.AllottedHours;
        //                    utp.ProgressType = 'A';
        //                    utp.Weight = a.progress.GetValueOrDefault();
        //                    list.Add(utp);
        //                }


        //                //Actual MHrs

        //                var AMlist = from tw in db.TimeSheetWeeklies
        //                             join twd in db.TimeSheetWeeklyDetails on tw.TimeSheetWeeklyID equals twd.TimeSheetWeeklyID
        //                             join pt in db.ProjectTaskLists on new { TaskID = twd.TaskID } equals new { TaskID = pt.ProjectTaskID }
        //                             where
        //                               twd.TaskID == t.ProjectTaskID &&
        //                               (twd.TimesheetDate <= Period)
        //                             group new { pt, twd } by new
        //                             {
        //                                 pt.AllottedHours
        //                             } into g
        //                             select new
        //                             {
        //                                 Progress = (System.Decimal?)(((g.Sum(p => p.twd.NorHrs) + g.Sum(p => p.twd.OTHrs)) / g.Key.AllottedHours) * 100),
        //                                 AllottedHours = (Decimal?)g.Key.AllottedHours
        //                             };

        //                foreach (var a in AMlist)
        //                {
        //                    u_TaskProgress utp = new u_TaskProgress();
        //                    utp.Tid = t.ProjectTaskID;
        //                    utp.AllottedHrs = t.AllottedHours;
        //                    utp.ProgressType = 'M';
        //                    utp.Weight = a.Progress.GetValueOrDefault();
        //                    list.Add(utp);
        //                }
        //            }

        //            decimal sumMH = (from c in list select new { c.Tid, c.AllottedHrs }).Distinct().Sum(p => p.AllottedHrs);

        //            decimal sumMH_p_p = (from c in list where c.ProgressType == 'P' select new { x = c.Weight * c.AllottedHrs }).Sum(p => p.x);
        //            res[0] = sumMH_p_p == 0 ? 0 : (sumMH_p_p / sumMH);

        //            decimal sumMH_p_A = (from c in list where c.ProgressType == 'A' select new { x = c.Weight * c.AllottedHrs }).Sum(p => p.x);
        //            res[1] = sumMH_p_A == 0 ? 0 : (sumMH_p_A / sumMH);

        //            decimal sumMH_p_M = (from c in list where c.ProgressType == 'M' select new { x = c.Weight * c.AllottedHrs }).Sum(p => p.x);
        //            res[2] = sumMH_p_M == 0 ? 0 : (sumMH_p_M / sumMH);


        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return res;
        //}

        public static IList<usp_ProjectBurnChart_Result> GetProjectPlanced_Actual_AManHrsByPeriod(int ProjectId, int Dept, int Desig, int Taskid, int projectStatusAwaited, int projectStatusEstimatopn)
        {
            List<usp_ProjectBurnChart_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_ProjectBurnChart(ProjectId, Dept, Desig, Taskid, projectStatusAwaited, projectStatusEstimatopn).ToList<usp_ProjectBurnChart_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public IList<Department> GetAllInvolvedDepartments(string ClientId, int ClientAsset, int ProjectID)
        {
            IList<Department> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = ((from pt in db.ProjectTaskLists
                //             join p in db.Projects on pt.ProjectID equals p.ProjectID
                //             join d in db.Departments on pt.DepatmentID equals d.DepartmentID
                //             where p.ClientCode == (ClientId == "0" ? p.ClientCode : ClientId) && p.ClientAssetID == (ClientAsset == 0 ? p.ClientAssetID : ClientAsset) && pt.ProjectID == (ProjectID == 0 ? pt.ProjectID : ProjectID)
                //             select d).Distinct()).ToList<Department>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public IList<Designation> GetAllInvolvedDesignations(string ClientId, int ClientAsset, int ProjectID, int Dept)
        {
            IList<Designation> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = ((from pt in db.ProjectTaskLists
                //             join p in db.Projects on pt.ProjectID equals p.ProjectID
                //             join d in db.Designations on pt.DesignationID equals d.DesignationID
                //             where p.ClientCode == (ClientId == "0" ? p.ClientCode : ClientId) && p.ClientAssetID == (ClientAsset == 0 ? p.ClientAssetID : ClientAsset) && pt.ProjectID == (ProjectID == 0 ? pt.ProjectID : ProjectID)
                //            && pt.DepatmentID == (Dept == 0 ? pt.DepatmentID : Dept)
                //             select d).Distinct()).ToList<Designation>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public IList<User> GetAllInvolvedUser(string ClientId, int ClientAsset, int ProjectID, int Dept, int Desig)
        {
            IList<User> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from pt in db.ProjectTaskLists
                //            join p in db.Projects on pt.ProjectID equals p.ProjectID
                //            join u in db.Users on pt.TaskOwner equals u.UserID
                //            where p.ClientCode == (ClientId == "0" ? p.ClientCode : ClientId) && p.ClientAssetID == (ClientAsset == 0 ? p.ClientAssetID : ClientAsset) && p.ProjectID == (ProjectID == 0 ? p.ProjectID : ProjectID)
                //            && pt.DepatmentID == (Dept == 0 ? pt.DepatmentID : Dept) && pt.DesignationID == (Desig == 0 ? pt.DesignationID : Desig)
                //            select u).Distinct().ToList<User>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }


        public static IList<usp_ManpowerLoadingChart_Result> GetManpowerLoadingChartData(DateTime FromDate, DateTime ToDate, int Dept, int Desig, int ClientAsset, int Project,int ProjectEstimationStatusID,int ProjectAwaitedStatusID)
        {
            IList<usp_ManpowerLoadingChart_Result> List = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    List = db.usp_ManpowerLoadingChart(FromDate, ToDate, Dept, Desig, ClientAsset, Project, ProjectEstimationStatusID, ProjectAwaitedStatusID).ToList<usp_ManpowerLoadingChart_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return List;
        }


        public static Boolean DateExistsinHolidayCalendar(DateTime Date)
        {
            Boolean res = false;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var count = (from t in db.HolidayCalendars where t.WorkingDate >= Date select t).Count();
                //    if (count > 0)
                //        res = true;
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }







        public List<ProjectTaskList> GetXmlImportTask(int ProjectID)
        {
            List<ProjectTaskList> list = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    IQueryable<ProjectTaskList> lst = Context.ProjectTaskLists.Include("TaskDependencies").Where(a => a.ProjectID == ProjectID);
            //    list = lst.ToList<ProjectTaskList>();
            //}
            return list;
        }

        public static List<TaskDependency> getTaskDependencyListByProjectID(int ProjectID)
        {
            List<TaskDependency> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from q in db.TaskDependencies
                //            join
                //                r in db.ProjectTaskLists on q.TaskID equals r.ProjectTaskID
                //            where r.ProjectID == ProjectID
                //            select q).ToList<TaskDependency>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static Boolean TaskAcceptedByUser(int UserID, int ProjectId, int TaskStatus, int ResourceRequestID)
        {
            Boolean res = false;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var count = (from t in db.ProjectTaskLists where t.ProjectID == ProjectId && t.TaskOwner == UserID && t.TaskStatus > TaskStatus && t.ResourceRequestID == ResourceRequestID select t).Count();
                //    if (count > 0)
                //        res = true;
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }
        public static List<USP_getExportXMLTaskList_Result> getExportXMLTaskList(int ProjectID)
        {
            List<USP_getExportXMLTaskList_Result> list = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    list = Context.USP_getExportXMLTaskList(ProjectID).ToList<USP_getExportXMLTaskList_Result>();
            //}
            return list;
        }

        public List<ProjectTaskList> getProjectTaskByDeptIdProjectIDAndRequestID(int ProjectID, int DeptID, int RequestID)
        {
            List<ProjectTaskList> list = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    list = Context.ProjectTaskLists.Where(a => a.ProjectID == ProjectID && a.DepatmentID == DeptID && a.RequestID == RequestID
            //        //&& a.SysGen!="Y"
            //        ).ToList<ProjectTaskList>();
            //}
            return list;
        }
        public int GetTaskCountByProjectIDAndNormSetID(int ProjectID, int NormSetID)
        {
            int recCount = 0;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    recCount = (from a in db.ProjectTaskLists
                //                join n in db.Norms on a.NormsID equals n.NormsID
                //                where
                //            a.ProjectID == (ProjectID == 0 ? a.ProjectID : ProjectID)
                //            && n.NormSetID == (NormSetID == 0 ? n.NormSetID : NormSetID)
                //                select a.ProjectTaskID).Count();

                //}
            }
            catch (Exception ex)
            {
            }
            return recCount;
        }

        public IEnumerable<ProjectTaskListSlickGrid> getProjectTaskByProjectID(int ProjectID)
        {
            IEnumerable<ProjectTaskListSlickGrid> list = null;
           // BLUserRepository bluserrepository = new BLUserRepository();
            ////using (var Context = new Cubicle_EntityEntities())
            ////{
            ////    list = (from q in Context.ProjectTaskLists.ToList()
            ////            join s in Context.ProjectWBS.ToList() on q.WBSID equals s.WBSID.ToString()
            ////            join u in Context.TaskTypes on q.TaskTypeID equals u.TaskTypeID
            ////            join v in Context.Priorities on q.Priority equals v.PriorityID
            ////            from r in Context.Norms.Where(d => d.NormsID == q.NormsID).DefaultIfEmpty()
            ////            from t in Context.Departments.Where(d => d.DepartmentID == q.DepatmentID).DefaultIfEmpty()
            ////            from user in Context.Users.Where(d => d.UserID == q.CreatedBy).DefaultIfEmpty()
            ////            where q.ProjectID == ProjectID && (q.SysGen == null || q.SysGen == "N")
            ////            select new ProjectTaskListSlickGrid
            ////            {
            ////                id = q.ProjectTaskID,
            ////                NormsID = q.NormsID,
            ////                NormName = r != null ? r.NormsName : "",
            ////                DepatmentID = q.DepatmentID,
            ////                DepatmentName = t != null ? t.DepartmentName : "",
            ////                TaskName = q.TaskName,
            ////                TaskTypeID = q.TaskTypeID,
            ////                TaskTypeName = u.TaskType1,
            ////                Duration = q.Duration,
            ////                AllottedHours = q.AllottedHours,
            ////                WBSID = q.WBSID,
            ////                WBSName = s.WBSCode,
            ////                Priority = q.Priority,
            ////                PriorityName = v.PriorityName,
            ////                StartDate = Convert.ToDateTime(q.StartDate).ToString("dd/MM/yyyy"),
            ////                EndDate = Convert.ToDateTime(q.EndDate).ToString("dd/MM/yyyy"),
            ////                Remarks = q.Remarks,
            ////                NormDeptID = r != null ? r.DepartmentID : 0,
            ////                TaskNo = Convert.ToString(q.SubTaskNo) != "" ? (Convert.ToString(q.TaskNo) + "." + Convert.ToString(q.SubTaskNo)) : Convert.ToString(q.TaskNo),
            ////                TaskStatus = q.TaskStatus,
            ////                TaskStatusName = Convert.ToString(Common.GeneralFuntions.GetEnumDescription((Common.TaskStatusID)Convert.ToInt32(q.TaskStatus))),
            ////                Lock = Convert.ToString(q.LOCK as object) == "" ? 0 : 1,
            ////                LastEditedBy = user.FirstName + " " + user.LastName//bluserrepository.GetUserFullName(Convert.ToInt32(q.CreatedBy))//

            ////            }).ToList<ProjectTaskListSlickGrid>();

            ////}
            return list;
        }

        public List<usp_getProjectTaskByProjectID_Result> getProjectTaskByProjectID1(int ProjectID, int UserID, string IsOtherClient, int MasterTaskTypeID)
        {
            List<usp_getProjectTaskByProjectID_Result> lst = null;
           
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.usp_getProjectTaskByProjectID(ProjectID, UserID, IsOtherClient, MasterTaskTypeID).ToList<usp_getProjectTaskByProjectID_Result>();
            //}
            return lst;
        }

        public IEnumerable<ProjectTaskListSlickGrid> getSubmittedProjectTaskByProjectID(int ProjectID)
        {
            IEnumerable<ProjectTaskListSlickGrid> list = null;
            ////using (var Context = new Cubicle_EntityEntities())
            ////{
            ////    list = (from q in Context.ProjectTaskLists.ToList()
            ////            join r in Context.Norms on q.NormsID equals r.NormsID into tasks
            ////            join s in Context.ProjectWBS.ToList() on q.WBSID equals s.WBSID.ToString()
            ////            join t in Context.Departments on q.DepatmentID equals t.DepartmentID
            ////            join u in Context.TaskTypes on q.TaskTypeID equals u.TaskTypeID
            ////            join v in Context.Priorities on q.Priority equals v.PriorityID
            ////            from tt in tasks.DefaultIfEmpty()
            ////            where q.ProjectID == ProjectID && q.IsSubmitted == true

            ////            select new ProjectTaskListSlickGrid
            ////            {
            ////                id = q.ProjectTaskID,
            ////                NormsID = q.NormsID,
            ////                NormName = (tt == null ? "" : tt.NormsName),
            ////                DepatmentID = q.DepatmentID,
            ////                DepatmentName = t.DepartmentName,
            ////                TaskName = q.TaskName,
            ////                TaskTypeID = q.TaskTypeID,
            ////                TaskTypeName = u.TaskType1,
            ////                Duration = q.Duration,
            ////                AllottedHours = q.AllottedHours,
            ////                WBSID = q.WBSID,
            ////                WBSName = s.WBSCode,
            ////                Priority = q.Priority,
            ////                PriorityName = v.PriorityName,
            ////                StartDate = Convert.ToDateTime(q.StartDate).ToString("dd/MM/yyyy"),
            ////                EndDate = Convert.ToDateTime(q.EndDate).ToString("dd/MM/yyyy"),
            ////                Remarks = q.Remarks,
            ////                TaskNo = Convert.ToString(q.TaskNo)
            ////            }).ToList<ProjectTaskListSlickGrid>();
            ////}
            return list;
        }




        public OperationResult SetStartEndDateUsingDuration(int ProjectID, int Duration)
        {
            OperationResult result = new OperationResult();
            try
            {
                ////using (var db = new Cubicle_EntityEntities())
                ////{
                ////    Dictionary<string, string> dict = new Dictionary<string, string>();
                ////    List<usp_Set_Start_EndDate_Result> res = db.usp_Set_Start_EndDate(ProjectID, Duration).ToList<usp_Set_Start_EndDate_Result>();
                ////    foreach (var item in res)
                ////    {
                ////        dict["StartDate"] = Convert.ToDateTime(item.StartDate).Date.ToString("dd/MM/yyyy");
                ////        dict["EndDate"] = Convert.ToDateTime(item.EndDate).Date.ToString("dd/MM/yyyy");
                ////    }

                ////    result.lstDict.Add(dict);
                ////}
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        public OperationResult SetStartEndDateUsingDate(string StartDate, string EndDate, int Duration,int projectID)
        {
            OperationResult result = new OperationResult();
            ////CultureInfo ci = new CultureInfo("en-Gb");
            ////try
            ////{
            ////    using (var db = new Cubicle_EntityEntities())
            ////    {
            ////        Dictionary<string, string> dict = new Dictionary<string, string>();
            ////        List<usp_Set_Start_EndDateAwarded_Result> res = db.usp_Set_Start_EndDateAwarded(Convert.ToDateTime(StartDate, ci), Convert.ToDateTime(EndDate, ci), Duration, projectID).ToList<usp_Set_Start_EndDateAwarded_Result>();
            ////        foreach (var item in res)
            ////        {
            ////            dict["StartDate"] = Convert.ToDateTime(item.StartDate).Date.ToString("dd/MM/yyyy");
            ////            dict["EndDate"] = Convert.ToDateTime(item.EndDate).Date.ToString("dd/MM/yyyy");
            ////            dict["Duration"] = Convert.ToString(item.Duration);
            ////        }

            ////        result.lstDict.Add(dict);
            ////    }
            ////}
            ////catch (Exception ex)
            ////{
            ////}
            return result;
        }

        public OperationResult checkUserRightsOnTask(int UserID, int TaskId)
        {
            OperationResult result = new OperationResult();
            ////try
            ////{
            ////    using (var db = new Cubicle_EntityEntities())
            ////    {
            ////        ProjectTaskList_Contract task = GetTaskListByID(TaskId);
            ////        if (task != null)
            ////        {
            ////            BLUserRepository blUser = new BLUserRepository();
            ////            User user = blUser.GetuserByID(UserID);
            ////            if (task.DepatmentID != Convert.ToInt32(user.DepartmentID))
            ////            {
            ////                BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            ////                Project pr = blProject.GetProjectByID(task.ProjectID);
            ////                if (pr.ProjectLeader != UserID)
            ////                {
            ////                    BLProjectsAdminRepository blProjectAdmin = new BLProjectsAdminRepository();
            ////                    Boolean prAdmin = blProjectAdmin.IsProjectAdmin(Convert.ToInt32(task.ProjectID), Convert.ToInt32(UserID));
            ////                    if (!prAdmin)
            ////                    {
            ////                        result.MessageType = "I";
            ////                        result.Message = "You can not edit/delete this task.";
            ////                    }
            ////                    else
            ////                    {
            ////                        result.MessageType = "S";
            ////                    }
            ////                }
            ////                else
            ////                {
            ////                    result.MessageType = "S";
            ////                }
            ////            }
            ////            else
            ////            {
            ////                result.MessageType = "S";
            ////            }
            ////        }
            ////    }
            ////}
            ////catch (Exception ex)
            ////{
            ////}

            return result;
        }

        public string SubmitEstimationTaskByAllDepartment(string ProjectID)
        {
            string IsAllDeptTaskSubmitted = "N";
            //try
            //{
            //    int projectid = Convert.ToInt32(ProjectID);
            
            //    BLTaskListRepository blEstTask = new BLTaskListRepository();
            //    BLProjectsDepartmentRepository prdept = new BLProjectsDepartmentRepository();
            //    List<ProjectTaskList> est = blEstTask.GetEstimationTaskListByProjectID(projectid).ToList<ProjectTaskList>();
            //    List<ProjectsDepartment> ProjDept = prdept.GetProjectsDepartmentByProjectID(projectid);

            //    int taskSubmittedDeptCount = est.Where(c => c.IsSubmitted == true && (c.SysGen == null || c.SysGen == "N")).Select(c => c.DepatmentID).Distinct().Count();
            //    int ProjectDeptCount = ProjDept.Count();
            //    if (taskSubmittedDeptCount == ProjectDeptCount)
            //    {
            //        IsAllDeptTaskSubmitted = "Y";
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
            return IsAllDeptTaskSubmitted;
        }
        
        public string IsProjectScheduledOnce(string ProjectID)
        {
            string IsScheduled = "N";
            //try
            //{
            //    int projectid = Convert.ToInt32(ProjectID);

            //    BLTaskListRepository blEstTask = new BLTaskListRepository();              
            //    List<ProjectTaskList> est = blEstTask.GetEstimationTaskListByProjectID(projectid).ToList<ProjectTaskList>();

            //    int taskScheduled = est.Where(c => (c.SysGen == null || c.SysGen == "N") && c.IsScheduled == "Y").Select(c => c.IsScheduled).Count();

            //    if (taskScheduled >0)
            //    {
            //        IsScheduled = "Y";
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
            return IsScheduled;
        }


        public bool copyContrTask(string ProjectID, string Name,int NormSetID)
        {
            bool result = false;
            try
            {
            ////    using (var db = new Cubicle_EntityEntities())
            ////    {
            ////        db.usp_copyTaskDetails_Contract(Convert.ToInt32(ProjectID), NormSetID, Name);
            ////    }
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
    }
    
}
