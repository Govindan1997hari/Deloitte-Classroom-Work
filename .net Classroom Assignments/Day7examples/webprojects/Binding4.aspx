<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Binding4.aspx.cs" Inherits="webprojects.Binding4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Id" DataSourceID="SqlDataSource1" GridLines="Vertical" Height="50px" Width="125px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
                <asp:BoundField DataField="membership" HeaderText="membership" SortExpression="membership" />
                <asp:BoundField DataField="shoppingpreference" HeaderText="shoppingpreference" SortExpression="shoppingpreference" />
                <asp:BoundField DataField="COD" HeaderText="COD" SortExpression="COD" />
                <asp:BoundField DataField="passw" HeaderText="passw" SortExpression="passw" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        </asp:DetailsView>
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
