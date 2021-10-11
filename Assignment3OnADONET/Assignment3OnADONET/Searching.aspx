<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Searching.aspx.cs" Inherits="Assignment3OnADONET.Searching" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            

            <asp:Label ID="Label1" runat="server" Text="">Search by Employee ID </asp:Label>

            <asp:TextBox ID="Emp_search" runat="server"></asp:TextBox>
            <asp:LinkButton ID="btnEmpSearch" runat="server" OnClick="btnEmpSearch_Click">Search</asp:LinkButton>

            <br />
            <br />

             <asp:Label ID="Label2" runat="server" Text="">Search by Department ID </asp:Label>

            <asp:TextBox ID="Dept_search" runat="server"></asp:TextBox>
            <asp:LinkButton ID="btnDeptSearch" runat="server" OnClick="btnDeptSearch_Click">Search</asp:LinkButton>


            <br />
            <br />
            <br />


        </div>

        <div>
            <asp:Label ID="Department" runat="server" Text="">Click here to get Department details</asp:Label>
            <asp:LinkButton ID="btnDept" runat="server" OnClick="btnDept_Click">Department</asp:LinkButton>
            &nbsp
            
            <br />
            <br />
            
            <asp:Label ID="Label3" runat="server" Text="">Click here to get Project details</asp:Label>
            <asp:LinkButton ID="btnProj" runat="server" OnClick="btnProj_Click">Projects</asp:LinkButton>

            <br />

            <br />

        </div>

         <asp:GridView ID="gvEmployeeDetailsBySearch" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="emp_id" HeaderText="Employee ID" />
                <asp:BoundField DataField="title" HeaderText="Job Title" />
                <asp:BoundField DataField="first_name" HeaderText="First Name" />
                <asp:BoundField DataField="last_name" HeaderText="Last Name" />
                <asp:BoundField DataField="gender" HeaderText="Gender" />
                <asp:BoundField DataField="DOB" HeaderText="Birthday" />
                <asp:BoundField DataField="Hired_date" HeaderText="Hired Date" />
                <asp:BoundField DataField="dept_number" HeaderText="Department Id" />
                <asp:BoundField DataField="project_number" HeaderText="Project Number" />
                
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
