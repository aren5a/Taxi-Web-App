<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="UserListByFilter.aspx.cs" Inherits="Taxi.WebApp.UserListByFilter" %>

<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc1" %>
<%@ Register src="Controls/MenuAdmin.ascx" tagname="MenuAdmin" tagprefix="uc2" %>
<%@ Register src="Controls/UserList_by_Filter.ascx" tagname="UserList_by_Filter" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1105px" >
        <tr>
            <td align="left">
                <uc1:LogOut ID="LogOut1" runat="server" />
            </td>
            <td align="right" style="width: 947px">
                <uc2:MenuAdmin ID="MenuAdmin1" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <uc3:UserList_by_Filter ID="UserList_by_Filter1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
