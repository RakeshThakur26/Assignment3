<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Assignment3OnADONET.Department" %>

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
                    <td>Department Number</td>
                    <td><asp:Label ID="dept_number" Text="" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Department Name</td>
                    <td><asp:TextBox ID="dept_name" runat="server"></asp:TextBox></td>
                </tr>
                
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Update" />
                        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
                    </td>
                </tr>
            </table>
        <div>
                <asp:GridView ID="gvDeptDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvDeptDetails_RowCommand" OnRowDeleting="gvDeptDetails_RowDeleting" OnRowEditing="gvDeptDetails_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="dept_number" HeaderText="Department Number" />
                        <asp:BoundField DataField="dept_name" HeaderText="Department Name" />
                        <asp:TemplateField HeaderText="Edit">
                             <ItemTemplate>
                                <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("dept_number") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("dept_number") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
