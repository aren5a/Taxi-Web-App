<%@ Page Title="ثبت سرویس" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="ServiceSubmite(Admin).aspx.cs" Inherits="Taxi.WebApp.ServiceSubmite_Admin_" %>

<%@ Register src="Controls/MenuAdmin.ascx" tagname="MenuAdmin" tagprefix="uc1" %>


<%@ Register src="Controls/Service_Submit.ascx" tagname="Service_Submit" tagprefix="uc2" %>


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
                <uc2:Service_Submit ID="Service_Submit1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
