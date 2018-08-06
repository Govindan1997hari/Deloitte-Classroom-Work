<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Binding3.aspx.cs" Inherits="webprojects.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="Id" DataSourceID="SqlDataSource1" InsertItemPosition="LastItem">
            <AlternatingItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' />
                    </td>
                    <td>
                        <asp:Label ID="membershipLabel" runat="server" Text='<%# Eval("membership") %>' />
                    </td>
                    <td>
                        <asp:Label ID="shoppingpreferenceLabel" runat="server" Text='<%# Eval("shoppingpreference") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CODLabel" runat="server" Text='<%# Eval("COD") %>' />
                    </td>
                    <td>
                        <asp:Label ID="passwLabel" runat="server" Text='<%# Eval("passw") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="genderTextBox" runat="server" Text='<%# Bind("gender") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="membershipTextBox" runat="server" Text='<%# Bind("membership") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="shoppingpreferenceTextBox" runat="server" Text='<%# Bind("shoppingpreference") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CODTextBox" runat="server" Text='<%# Bind("COD") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="passwTextBox" runat="server" Text='<%# Bind("passw") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="genderTextBox" runat="server" Text='<%# Bind("gender") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="membershipTextBox" runat="server" Text='<%# Bind("membership") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="shoppingpreferenceTextBox" runat="server" Text='<%# Bind("shoppingpreference") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CODTextBox" runat="server" Text='<%# Bind("COD") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="passwTextBox" runat="server" Text='<%# Bind("passw") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' />
                    </td>
                    <td>
                        <asp:Label ID="membershipLabel" runat="server" Text='<%# Eval("membership") %>' />
                    </td>
                    <td>
                        <asp:Label ID="shoppingpreferenceLabel" runat="server" Text='<%# Eval("shoppingpreference") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CODLabel" runat="server" Text='<%# Eval("COD") %>' />
                    </td>
                    <td>
                        <asp:Label ID="passwLabel" runat="server" Text='<%# Eval("passw") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                <tr runat="server" style="">
                                    <th runat="server"></th>
                                    <th runat="server">Id</th>
                                    <th runat="server">name</th>
                                    <th runat="server">gender</th>
                                    <th runat="server">membership</th>
                                    <th runat="server">shoppingpreference</th>
                                    <th runat="server">COD</th>
                                    <th runat="server">passw</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' />
                    </td>
                    <td>
                        <asp:Label ID="membershipLabel" runat="server" Text='<%# Eval("membership") %>' />
                    </td>
                    <td>
                        <asp:Label ID="shoppingpreferenceLabel" runat="server" Text='<%# Eval("shoppingpreference") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CODLabel" runat="server" Text='<%# Eval("COD") %>' />
                    </td>
                    <td>
                        <asp:Label ID="passwLabel" runat="server" Text='<%# Eval("passw") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
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
