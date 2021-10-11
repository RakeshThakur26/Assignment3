<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="Assignment3OnADONET.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 40%;">

                <h2>Employee Details </h2>
               <tr>
                    <td>
                        <asp:Label ID="EmpID" runat="server" Text="">Employee ID :</asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="emp_id" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="Employee_Job_Title" runat="server" Text="">Job Title :</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="title" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="First" runat="server" Text="">First Name :</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="first_name" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Last" runat="server" Text="">Last Name :</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="last_name" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Gen" runat="server" Text="">Gender :</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="gender" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Birthday" runat="server" Text="">DOB :</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="DOB" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="HiredDate" runat="server" Text="">Hired Date : </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Hired_date" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
          

                 <tr>
                    <td><asp:Label ID="Dept" runat="server">Department Id :</asp:Label></td>
                 <td>  <asp:DropDownList ID="dept_number" runat="server"></asp:DropDownList> </td>  
                     
                </tr>
                
               
                
                 <tr>
                    <td><asp:Label ID="Proj" runat="server">Project number :</asp:Label></td>
                 <td>  <asp:DropDownList ID="project_number" runat="server"></asp:DropDownList> </td>  
                     
                </tr>
                <tr>
                    <td></td>
                    <td>  
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                    &nbsp &nbsp
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    </td>  
                </tr>

            </table>
        </div>
        <p>
            &nbsp;</p>
        <asp:GridView ID="gvEmployeeDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvEmployeeDetails_RowCommand" OnRowDeleting="gvEmployeeDetails_RowDeleting" OnRowEditing="gvEmployeeDetails_RowEditing" OnSelectedIndexChanged="gvEmployeeDetails_SelectedIndexChanged" >
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
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("emp_id") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("emp_id") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
