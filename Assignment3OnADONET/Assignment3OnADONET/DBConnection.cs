﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace Assignment3OnADONET
{
    public class DBConnection
    {

        // Database connection using ADO.NET
        public SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-TD5N63QB;Initial Catalog=EmployeeManagement;Integrated Security=True");
            return conn;
        }


        // Method to execute all queries
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection conn = Connect();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }


        #region Employee Details

        public void InsertEmployee(string title, string first, string last, string gender, string DOB, string DOJ, int dept_id, int proj_id)
        {       
            string query = "insert into Employee values ('" + title + "'," + "'" + first +"', '"+ last +"','" + gender+ "',' " + DOB + "', '" + DOJ + "'," + dept_id + ","+ proj_id + ")";       
            ExecuteQuery(query); 
        }

        public DataTable GetEmployees()
        {
            string query = "select * from Employee";
            DataTable dt = ExecuteQuery(query);
            return dt;
        }

        public DataTable GetEmployeeById(int emp_id)
        {
            string query = "select * from Employee where emp_id=" + emp_id;
            DataTable dt = ExecuteQuery(query);
            return dt;
        }

        public DataTable GetEmployeeByDeptId(int dept_id)
        {
            string query = "select * from Employee where dept_number=" + dept_id;
            DataTable dt = ExecuteQuery(query);
            return dt;
        }
        public void DeleteEmployee(int emp_id)
        {
            string query = "delete from Employee where emp_id=" + emp_id;
            ExecuteQuery(query);
        }

        public void UpdateEmployee(int Emp_id, string title, string first, string last, string gender, string DOB, string DOJ, string dept_id, int proj_id)
        {
            string query = "update Employee set title='" + title + "'," + "first_name='" + first + "', last_name='" + last + "',gender ='" + gender + "',DOB =' " + DOB + "', Hired_date='" + DOJ + "',dept_number=" + dept_id + ",project_number=" + proj_id + "where emp_id=" + Emp_id;
            ExecuteQuery(query);
        }


        #endregion



        #region Department Details
        public DataTable GetDeptIds()
        {
            string query = "select * from Department";
            DataTable dt = ExecuteQuery(query);
            return dt;
        }

        public DataTable GetDepartment()
        {
            SqlConnection sqlConnection = Connect();
            string query = "select * from Department";
            DataTable dt = ExecuteQuery(query);     
            return dt;
        }

        public DataTable GetDepartmentByNum(int dept_num)
        {
           
            string query = "select * from Department where dept_number=" + dept_num;
            DataTable dt = ExecuteQuery(query);
            return dt;
        }

        public void InsertDepartment(string name)
        {
            string query = "insert into Department values ('" + name + "')";
             ExecuteQuery(query);
        }

        public void UpdateDepartment(int dept_number, string dept_name)
        {
            string query = "update Department set dept_name='" + dept_name + "' where dept_number=" + dept_number;
            ExecuteQuery(query);
        }

        public void DeleteDept(int Dept_num)
        {
            string query = "delete from Department where dept_number=" + Dept_num;
            ExecuteQuery(query);
        }

        #endregion



        #region Project Details
        public void InsertProject(string name, string startdate)
        {
            string query = "insert into Project values ('" + name + "','"+ startdate + "')";
            ExecuteQuery(query);
        }

        public DataTable GetProjects()
        {           
            string query = "select * from Project";
            DataTable dt = ExecuteQuery(query);
            return dt;
        }

        public void UpdateProject(int proj_number, string proj_name, string startdate)
        {
            string query = "update Project set proj_name='" + proj_name + "',startdate='"+startdate+"' where project_number=" + proj_number;
            ExecuteQuery(query);  
        }

        public DataTable GetProjectByNum(int proj_num)
        {
            string query = "select * from Project where project_number=" + proj_num;
            DataTable dt = ExecuteQuery(query);
            return dt;
        }

        public void DeleteProject(int num)
        {
            string query = "delete from Project where project_number=" + num;
            ExecuteQuery(query);
        }

        #endregion

    }

}