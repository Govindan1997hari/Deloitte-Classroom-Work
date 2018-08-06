<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Binding1.aspx.cs" Inherits="webprojects.Binding1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="169px" Width="290px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
                <asp:BoundField DataField="membership" HeaderText="membership" SortExpression="membership" />
                <asp:BoundField DataField="shoppingpreference" HeaderText="shoppingpreference" SortExpression="shoppingpreference" />
                <asp:BoundField DataField="COD" HeaderText="COD" SortExpression="COD" />
                <asp:BoundField DataField="passw" HeaderText="passw" SortExpression="passw" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
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
