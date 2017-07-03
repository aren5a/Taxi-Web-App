<%@ Page Title="تغییر مشخصات" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="UserUpdate.aspx.cs" Inherits="Taxi.WebApp.UserUpdate" %>

<%@ Register src="Controls/MenuPassenger.ascx" tagname="MenuPassenger" tagprefix="uc1" %>
<%@ Register src="Controls/UserUpdate.ascx" tagname="UserUpdate" tagprefix="uc2" %>

<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1106px">
        <tr>
        <td align="left">
            <uc3:LogOut ID="LogOut1" runat="server" />
        </td>
            <td align="right">
                <uc1:MenuPassenger ID="MenuPassenger1" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <uc2:UserUpdate ID="UserUpdate1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
