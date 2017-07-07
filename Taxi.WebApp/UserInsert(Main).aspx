<%@ Page Title="ثبت نام" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="UserInsert(Main).aspx.cs" Inherits="Taxi.WebApp.UserInsert_Main_" %>

<%@ Register Src="Controls/MainMenu.ascx" TagName="MainMenu" TagPrefix="uc1" %>
<%@ Register Src="Controls/UserInsert.ascx" TagName="UserInsert" TagPrefix="uc2" %>
<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1104px">
        <tr>
            <td align="left" class="style13" style="width: 588px">
                <uc3:LogOut ID="LogOut1" runat="server" />
            </td>
            <td align="right" style="width: 552px">
                <uc1:MainMenu ID="MainMenu1" runat="server" />
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
