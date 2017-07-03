<%@ Page Title="ثبت کاربر جدید" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeBehind="UserInsert(Admin).aspx.cs" Inherits="Taxi.WebApp.UserInsert_Admin_" %>

<%@ Register Src="Controls/MenuAdmin.ascx" TagName="MenuAdmin" TagPrefix="uc1" %>
<%@ Register Src="Controls/UserInsert.ascx" TagName="UserInsert" TagPrefix="uc2" %>
<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1104px">
        <tr>
            <td align="left">
                <uc3:LogOut ID="LogOut1" runat="server" />
            </td>
            <td align="right">
                <uc1:MenuAdmin ID="MenuAdmin1" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <uc2:UserInsert ID="UserInsert1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
