using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Assignment3OnADONET
{
    public partial class Searching : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void btnDeptSearch_Click(object sender, EventArgs e)
        {

            DBConnection db = new DBConnection();
            Emp_search.Text = string.Empty;

            // displaying Employee details Gridview on click
            DataTable dtDepartment = db.GetEmployeeByDeptId(Convert.ToInt32(Dept_search.Text));
            gvEmployeeDetailsBySearch.DataSource = dtDepartment;
            gvEmployeeDetailsBySearch.DataBind();
           
        }

        protected void btnEmpSearch_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            Dept_search.Text = string.Empty;

            DataTable dtEmployees = db.GetEmployeeById(Convert.ToInt32(Emp_search.Text));
            gvEmployeeDetailsBySearch.DataSource = dtEmployees;
            gvEmployeeDetailsBySearch.DataBind();


        }

        protected void btnDept_Click(object sender, EventArgs e)
        {
            Response.Redirect("Department.aspx");
        }

        protected void btnProj_Click(object sender, EventArgs e)
        {
            Response.Redirect("project.aspx");
        }


    }
}