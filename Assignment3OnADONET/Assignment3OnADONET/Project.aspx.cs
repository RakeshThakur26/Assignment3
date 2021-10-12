using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Assignment3OnADONET
{
    public partial class Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            DataTable dtProjectResult = db.GetProjects();
            gvProject.DataSource = dtProjectResult;
            gvProject.DataBind();

        }



        protected void btnSave_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.InsertProject(proj_name.Text, startdate.Text);

            DataTable dtProjectResult = db.GetProjects();
            gvProject.DataSource = dtProjectResult;
            gvProject.DataBind();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.UpdateProject(Convert.ToInt32(project_number.Text), proj_name.Text, startdate.Text);

            DataTable dtProjectResult = db.GetProjects();
            gvProject.DataSource = dtProjectResult;
            gvProject.DataBind();

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            proj_name.Text = string.Empty;
            project_number.Text = string.Empty;
            startdate.Text = string.Empty;
        }

        protected void gvProject_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int projId = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            { 
                DBConnection db = new DBConnection();
                DataTable dtProject = db.GetProjectByNum(projId);
                project_number.Text = dtProject.Rows[0][0].ToString();
                proj_name.Text = dtProject.Rows[0][1].ToString();
                startdate.Text = dtProject.Rows[0][2].ToString();
            }
            else if (e.CommandName == "Delete")
            {
                DBConnection db = new DBConnection();
                db.DeleteProject(projId);

                DataTable dtProjectResult = db.GetProjects();
                gvProject.DataSource = dtProjectResult;
                gvProject.DataBind();
            }
        }

        protected void gvProject_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvProject_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}