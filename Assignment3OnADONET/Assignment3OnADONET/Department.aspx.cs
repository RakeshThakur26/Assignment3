using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Assignment3OnADONET
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            DataTable Result = db.GetDepartment();
            gvDeptDetails.DataSource = Result;
            gvDeptDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.InsertDepartment(dept_name.Text);

            DataTable Result = db.GetDepartment();
            gvDeptDetails.DataSource = Result;
            gvDeptDetails.DataBind();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.UpdateDepartment(Convert.ToInt32(dept_number.Text),dept_name.Text);

            DataTable Result = db.GetDepartment();
            gvDeptDetails.DataSource = Result;
            gvDeptDetails.DataBind();
        }

        protected void gvDeptDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {


        }

        protected void gvDeptDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvDeptDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int Dept_num = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {

                DBConnection db = new DBConnection();
                DataTable dt = db.GetDepartmentByNum(Dept_num);
                dept_number.Text = dt.Rows[0][0].ToString();
                dept_name.Text = dt.Rows[0][1].ToString();
               
            }
            else if (e.CommandName == "Delete")
            {
                DBConnection db = new DBConnection();
                db.DeleteDept(Dept_num);
               
                DataTable Result = db.GetDepartment();
                gvDeptDetails.DataSource = Result;
                gvDeptDetails.DataBind();
               

            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            dept_number.Text = string.Empty;
            dept_name.Text = string.Empty;


        }
    }
}