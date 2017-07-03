<%@ Page Title="ثبت خبر" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="NewsInsert.aspx.cs" Inherits="Taxi.WebApp.NewsInsert" %>

<%@ Register Src="Controls/MenuAdmin.ascx" TagName="MenuAdmin" TagPrefix="uc1" %>
<%@ Register Src="Controls/News_Insert.ascx" TagName="News_Insert" TagPrefix="uc2" %>
<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1103px">
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
                <uc2:News_Insert ID="News_Insert1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
