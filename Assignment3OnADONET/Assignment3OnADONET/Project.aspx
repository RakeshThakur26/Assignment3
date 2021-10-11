<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="Assignment3OnADONET.Project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table>
                <tr>
                    <td>Project Number</td>
                    <td><asp:Label ID="project_number" Text="" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Project Name</td>
                    <td><asp:TextBox ID="proj_name" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td> Start date</td>
                    <td><asp:TextBox ID="startdate" runat="server"></asp:TextBox></td>
                </tr>
                
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Update" />
                        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <asp:GridView ID="gvProject" runat="server" AutoGenerateColumns="False" OnRowCommand="gvProject_RowCommand" OnRowDeleting="gvProject_RowDeleting" OnRowEditing="gvProject_RowEditing" >
            <Columns>
                <asp:BoundField DataField="project_number" HeaderText="Project Number" />
                <asp:BoundField DataField="proj_name" HeaderText="Project Name" />
                <asp:BoundField DataField="startdate" HeaderText="Start date" />
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("project_number") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("project_number") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
