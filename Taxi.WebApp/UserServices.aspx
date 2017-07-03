<%@ Page Title="سرویس های شما" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeBehind="UserServices.aspx.cs" Inherits="Taxi.WebApp.UserServices" %>

<%@ Register Src="Controls/MenuPassenger.ascx" TagName="MenuPassenger" TagPrefix="uc1" %>
<%@ Register Src="Controls/LogedInUserServices.ascx" TagName="LogedInUserServices"
    TagPrefix="uc2" %>
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
                <uc2:LogedInUserServices ID="LogedInUserServices1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
