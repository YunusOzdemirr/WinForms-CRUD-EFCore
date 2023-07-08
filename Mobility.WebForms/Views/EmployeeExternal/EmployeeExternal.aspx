<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="EmployeeExternal.aspx.cs" Inherits="Mobility.WebForms.Views.EmployeeExternal.EmployeeExternal" %>

<!DOCTYPE html>
<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Employee Management</h1>

        <!-- List Employees -->
        <h2>List Employees</h2>
        <asp:GridView ID="gridEmployees" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="MailAddress" HeaderText="Mail Address" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" />
                <asp:BoundField DataField="Age" HeaderText="Age" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button runat="server" Text="Edit" OnClick="EditEmployee_Click" CommandArgument='<%# Eval("Id") %>' />
                        <asp:Button runat="server" Text="Delete" OnClick="DeleteEmployee_Click" CommandArgument='<%# Eval("Id") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

        <!-- Create or Update Employee -->
        <h2>Create or Update Employee</h2>
        <div>
            <label for="Id">Id</label>
            <asp:TextBox ID="txtEmployeeId" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <label for="txtFirstName">First Name</label>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <label for="txtLastName">Last Name</label>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <label for="txtMailAddress">Mail Address</label>
            <asp:TextBox ID="txtMailAddress" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <label for="txtSalary">Salary</label>
            <asp:TextBox ID="txtSalary" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <label for="txtAge">Age</label>
            <asp:TextBox ID="txtAge" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="SaveEmployee_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="UpdateEmployee_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Cancel_Click" CssClass="btn btn-secondary" />
        </div>
    </form>
</body>
</html>
