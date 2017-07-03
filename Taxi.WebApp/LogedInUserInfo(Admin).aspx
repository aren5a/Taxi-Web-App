<%@ Page Title="اطلاعات کاربری" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="LogedInUserInfo(Admin).aspx.cs" Inherits="Taxi.WebApp.LogedInUserInfo_Admin_" %>

<%@ Register src="Controls/MenuAdmin.ascx" tagname="MenuAdmin" tagprefix="uc1" %>
<%@ Register src="Controls/LogedInInfo.ascx" tagname="LogedInInfo" tagprefix="uc2" %>

<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1098px" >
        <tr>
            <td align="left" style="width: 519px">
                <uc3:LogOut ID="LogOut1" runat="server" />
            <td style="width: 542px">
            </td align"right">
                <uc1:MenuAdmin ID="MenuAdmin1" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <uc2:LogedInInfo ID="LogedInInfo1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
