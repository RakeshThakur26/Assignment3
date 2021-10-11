using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Assignment3OnADONET
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            DataTable Result = db.GetEmployees();
            gvEmployeeDetails.DataSource = Result;
            gvEmployeeDetails.DataBind();
            if (!IsPostBack)
            {
                DataTable dt = db.GetDeptIds();
                dept_number.Items.Add("-- Choose --");
                DataTable dt2 = db.GetProjects();
                project_number.Items.Add("-- Choose --");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dept_number.Items.Add(new ListItem(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1], dt.Rows[i][0].ToString()));
                    project_number.Items.Add(new ListItem(dt2.Rows[i][0].ToString() + " - " + dt2.Rows[i][1], dt2.Rows[i][0].ToString()));
                }
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            int deptId = Convert.ToInt32(dept_number.SelectedValue.ToString());
            int projId = Convert.ToInt32(project_number.SelectedValue.ToString());
            
            db.InsertEmployee(title.Text, first_name.Text, last_name.Text, gender.Text, DOB.Text, Hired_date.Text, deptId, projId);

            DataTable Result = db.GetEmployees();
            gvEmployeeDetails.DataSource = Result;
            gvEmployeeDetails.DataBind();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
           string DeptId =dept_number.SelectedValue.ToString();
           int projId = Convert.ToInt32(project_number.SelectedValue.ToString());


            db.UpdateEmployee(Convert.ToInt32(emp_id.Text),title.Text, first_name.Text, last_name.Text, gender.Text, DOB.Text.ToString(), Hired_date.Text.ToString(), DeptId, projId);
            DataTable Result = db.GetEmployees();
            gvEmployeeDetails.DataSource = Result;
            gvEmployeeDetails.DataBind();
        }

        protected void gvEmployeeDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int Emp_id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DBConnection db = new DBConnection();
                DataTable dt = db.GetEmployeeById(Emp_id);
               
                title.Text = dt.Rows[0][1].ToString();
                first_name.Text = dt.Rows[0][2].ToString();
                last_name.Text = dt.Rows[0][3].ToString();
                gender.Text = dt.Rows[0][4].ToString();
                DOB.Text = dt.Rows[0][5].ToString();
                Hired_date.Text = dt.Rows[0][6].ToString();
                dept_number.Text = dt.Rows[0][7].ToString();
                project_number.Text = dt.Rows[0][8].ToString();
                emp_id.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DBConnection db = new DBConnection();
                db.DeleteEmployee(Emp_id);

                DataTable Result = db.GetEmployees();
                gvEmployeeDetails.DataSource = Result;
                gvEmployeeDetails.DataBind();
            }

        }

        protected void gvEmployeeDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvEmployeeDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }



    }
}