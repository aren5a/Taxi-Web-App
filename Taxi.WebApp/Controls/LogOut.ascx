<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LogOut.ascx.cs" Inherits="Taxi.WebApp.Controls.LogOut" %>
<style type="text/css">
    .style
    {
        direction: rtl;
        text-align: right;
        font-family: Tahoma;
    }
</style>
<p>
    <asp:Button ID="btnLogOut" runat="server" Text="خروج" OnClick="btnLogOut_Click" 
        Width="37px" />
    &nbsp;&nbsp;
    <asp:Label ID="lblUserName" runat="server" ForeColor="White"></asp:Label>
</p>
