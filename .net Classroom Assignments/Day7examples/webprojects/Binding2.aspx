<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Binding2.aspx.cs" Inherits="webprojects.Binding2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Id" DataSourceID="SqlDataSource2" GridLines="Both">
            <EditItemTemplate>
                Id:
                <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                name:
                <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                <br />
                gender:
                <asp:TextBox ID="genderTextBox" runat="server" Text='<%# Bind("gender") %>' />
                <br />
                membership:
                <asp:TextBox ID="membershipTextBox" runat="server" Text='<%# Bind("membership") %>' />
                <br />
                shoppingpreference:
                <asp:TextBox ID="shoppingpreferenceTextBox" runat="server" Text='<%# Bind("shoppingpreference") %>' />
                <br />
                COD:
                <asp:TextBox ID="CODTextBox" runat="server" Text='<%# Bind("COD") %>' />
                <br />
                passw:
                <asp:TextBox ID="passwTextBox" runat="server" Text='<%# Bind("passw") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                name:
                <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                <br />
                gender:
                <asp:TextBox ID="genderTextBox" runat="server" Text='<%# Bind("gender") %>' />
                <br />
                membership:
                <asp:TextBox ID="membershipTextBox" runat="server" Text='<%# Bind("membership") %>' />
                <br />
                shoppingpreference:
                <asp:TextBox ID="shoppingpreferenceTextBox" runat="server" Text='<%# Bind("shoppingpreference") %>' />
                <br />
                COD:
                <asp:TextBox ID="CODTextBox" runat="server" Text='<%# Bind("COD") %>' />
                <br />
                passw:
                <asp:TextBox ID="passwTextBox" runat="server" Text='<%# Bind("passw") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                name:
                <asp:Label ID="nameLabel" runat="server" Text='<%# Bind("name") %>' />
                <br />
                gender:
                <asp:Label ID="genderLabel" runat="server" Text='<%# Bind("gender") %>' />
                <br />
                membership:
                <asp:Label ID="membershipLabel" runat="server" Text='<%# Bind("membership") %>' />
                <br />
                shoppingpreference:
                <asp:Label ID="shoppingpreferenceLabel" runat="server" Text='<%# Bind("shoppingpreference") %>' />
                <br />
                COD:
                <asp:Label ID="CODLabel" runat="server" Text='<%# Bind("COD") %>' />
                <br />
                passw:
                <asp:Label ID="passwLabel" runat="server" Text='<%# Bind("passw") %>' />
                <br />

                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:TrainingDBConnectionString %>" DeleteCommand="DELETE FROM [RegisterShopping] WHERE [Id] = @original_Id AND [name] = @original_name AND [gender] = @original_gender AND [membership] = @original_membership AND [shoppingpreference] = @original_shoppingpreference AND [COD] = @original_COD AND [passw] = @original_passw" InsertCommand="INSERT INTO [RegisterShopping] ([name], [gender], [membership], [shoppingpreference], [COD], [passw]) VALUES (@name, @gender, @membership, @shoppingpreference, @COD, @passw)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [RegisterShopping]" UpdateCommand="UPDATE [RegisterShopping] SET [name] = @name, [gender] = @gender, [membership] = @membership, [shoppingpreference] = @shoppingpreference, [COD] = @COD, [passw] = @passw WHERE [Id] = @original_Id AND [name] = @original_name AND [gender] = @original_gender AND [membership] = @original_membership AND [shoppingpreference] = @original_shoppingpreference AND [COD] = @original_COD AND [passw] = @original_passw">
            <DeleteParameters>
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_gender" Type="String" />
                <asp:Parameter Name="original_membership" Type="String" />
                <asp:Parameter Name="original_shoppingpreference" Type="String" />
                <asp:Parameter Name="original_COD" Type="String" />
                <asp:Parameter Name="original_passw" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="gender" Type="String" />
                <asp:Parameter Name="membership" Type="String" />
                <asp:Parameter Name="shoppingpreference" Type="String" />
                <asp:Parameter Name="COD" Type="String" />
                <asp:Parameter Name="passw" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="gender" Type="String" />
                <asp:Parameter Name="membership" Type="String" />
                <asp:Parameter Name="shoppingpreference" Type="String" />
                <asp:Parameter Name="COD" Type="String" />
                <asp:Parameter Name="passw" Type="String" />
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_gender" Type="String" />
                <asp:Parameter Name="original_membership" Type="String" />
                <asp:Parameter Name="original_shoppingpreference" Type="String" />
                <asp:Parameter Name="original_COD" Type="String" />
                <asp:Parameter Name="original_passw" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:TrainingDBConnectionString %>" DeleteCommand="DELETE FROM [RegisterShopping] WHERE [Id] = @original_Id AND [name] = @original_name AND [gender] = @original_gender AND [membership] = @original_membership AND [shoppingpreference] = @original_shoppingpreference AND [COD] = @original_COD AND [passw] = @original_passw" InsertCommand="INSERT INTO [RegisterShopping] ([name], [gender], [membership], [shoppingpreference], [COD], [passw]) VALUES (@name, @gender, @membership, @shoppingpreference, @COD, @passw)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [RegisterShopping]" UpdateCommand="UPDATE [RegisterShopping] SET [name] = @name, [gender] = @gender, [membership] = @membership, [shoppingpreference] = @shoppingpreference, [COD] = @COD, [passw] = @passw WHERE [Id] = @original_Id AND [name] = @original_name AND [gender] = @original_gender AND [membership] = @original_membership AND [shoppingpreference] = @original_shoppingpreference AND [COD] = @original_COD AND [passw] = @original_passw">
            <DeleteParameters>
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_gender" Type="String" />
                <asp:Parameter Name="original_membership" Type="String" />
                <asp:Parameter Name="original_shoppingpreference" Type="String" />
                <asp:Parameter Name="original_COD" Type="String" />
                <asp:Parameter Name="original_passw" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="gender" Type="String" />
                <asp:Parameter Name="membership" Type="String" />
                <asp:Parameter Name="shoppingpreference" Type="String" />
                <asp:Parameter Name="COD" Type="String" />
                <asp:Parameter Name="passw" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="gender" Type="String" />
                <asp:Parameter Name="membership" Type="String" />
                <asp:Parameter Name="shoppingpreference" Type="String" />
                <asp:Parameter Name="COD" Type="String" />
                <asp:Parameter Name="passw" Type="String" />
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_gender" Type="String" />
                <asp:Parameter Name="original_membership" Type="String" />
                <asp:Parameter Name="original_shoppingpreference" Type="String" />
                <asp:Parameter Name="original_COD" Type="String" />
                <asp:Parameter Name="original_passw" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
