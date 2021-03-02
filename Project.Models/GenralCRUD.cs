using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Project.Models
{
    public class GenralCRUD
    {
       
        public void AddProject(ProjectInfo objInfo)
        {
            List<SQLParam> Param = new List<SQLParam>();
            Param.Add(new SQLParam("@ProjectName", objInfo.ProjectName));
            Param.Add(new SQLParam("@ProjectCode", objInfo.ProjectCode));
            string strSpName = "usp_AddProject";
            SQLExecuteNonQuery sqlHAsy = new SQLExecuteNonQuery ();
            sqlHAsy.ExecuteNonQuery(strSpName, Param);
        }

        public async Task<int> AddProjectAsync(ProjectInfo objInfo)
        {
            List<SQLParam> Param = new List<SQLParam>();
            Param.Add(new SQLParam("@ProjectName", objInfo.ProjectName));
            Param.Add(new SQLParam("@ProjectCode", objInfo.ProjectCode));
            string strSpName = "usp_AddProject";
            SQLExecuteNonQueryAsync sqlHAsy = new SQLExecuteNonQueryAsync();
            return await sqlHAsy.ExecuteNonQueryAsync(strSpName, Param);
        }

        public void UpdateProject(ProjectInfo objInfo)
        {
            List<SQLParam> Param = new List<SQLParam>();
            Param.Add(new SQLParam("@ProjectID", objInfo.ProjectID));
            Param.Add(new SQLParam("@ProjectName", objInfo.ProjectName));
            Param.Add(new SQLParam("@ProjectCode", objInfo.ProjectCode));
            string strSpName = "usp_UpdateProject";
            SQLExecuteNonQuery  sqlHAsy = new SQLExecuteNonQuery ();
            sqlHAsy.ExecuteNonQuery(strSpName, Param);
        }

        public async Task<int> UpdateProjectAsync(ProjectInfo objInfo)
        {
            List<SQLParam> Param = new List<SQLParam>();
            Param.Add(new SQLParam("@ProjectID", objInfo.ProjectID));
            Param.Add(new SQLParam("@ProjectName", objInfo.ProjectName));
            Param.Add(new SQLParam("@ProjectCode", objInfo.ProjectCode));
            string strSpName = "usp_UpdateProject";
            SQLExecuteNonQueryAsync sqlHAsy = new SQLExecuteNonQueryAsync();
            return await sqlHAsy.ExecuteNonQueryAsync(strSpName, Param);
        }

        public ProjectInfo GetProject(int? id)
        {
            List<SQLParam> Param = new List<SQLParam>();
            Param.Add(new SQLParam("@ProjectID", id));
            string strSpName = "usp_GetProject";
            SQLGet sqlHAsy = new SQLGet();
            return sqlHAsy.ExecuteAsObject<ProjectInfo>(strSpName, Param);
        }

        public async Task<ProjectInfo> GetProjectAsync(ProjectInfo objInfo)
        {
            List<SQLParam> Param = new List<SQLParam>();
            Param.Add(new SQLParam("@ProjectID", objInfo.ProjectID));
            string strSpName = "usp_GetProject";
            SQLGetAsync sqlHAsy = new SQLGetAsync();            
            return await sqlHAsy.ExecuteAsObjectAsync<ProjectInfo>(strSpName, Param);
        }

        public IList<ProjectInfo> GetProjectAsIList()
        {
            string strSpName = "usp_GetProjectList";
            SQLGetList sqlHAsy = new SQLGetList();
            return sqlHAsy.ExecuteAsList<ProjectInfo>(strSpName);
        }

        public List<ProjectInfo> GetProjectAsList()
        {
            string strSpName = "usp_GetProjectList";
            SQLGetList sqlHAsy = new SQLGetList();
            return sqlHAsy.ExecuteAsList<ProjectInfo>(strSpName) as List<ProjectInfo>;
        }

        public async Task<IList<ProjectInfo>> GetProjectAsIListAsync()
        {           
            string strSpName = "usp_GetProjectList";
            SQLGetListAsync sqlHAsy = new SQLGetListAsync();            
            return await sqlHAsy.ExecuteAsListAsync<ProjectInfo>(strSpName);
        }

        public async Task<IList<ProjectInfo>> GetProjectAsListAsync()
        {
            string strSpName = "usp_GetProjectList";
            SQLGetListAsync sqlHAsy = new SQLGetListAsync();
            return await sqlHAsy.ExecuteAsListAsync<ProjectInfo>(strSpName);
        }

        public void DeleteProject(int id)
        {
            List<SQLParam> Param = new List<SQLParam>();
            Param.Add(new SQLParam("@ProjectID", id));
            string strSpName = "usp_DeleteProject";
            SQLExecuteNonQuery sqlHAsy = new SQLExecuteNonQuery();
            sqlHAsy.ExecuteNonQuery(strSpName, Param);
        }
    }

}
