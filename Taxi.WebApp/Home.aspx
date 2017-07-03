<%@ Page Title="صفحه اصلی" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Home.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<%@ Register src="Controls/MainMenu.ascx" tagname="MainMenu" tagprefix="uc1" %>

<%@ Register src="Controls/ShowNews.ascx" tagname="ShowNews" tagprefix="uc2" %>

<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table  dir="ltr">
        <tr>
        <td align="left" style="width: 1159px">

            <uc3:LogOut ID="LogOut1" runat="server" />

        </td>
            <td align="right">
            <uc1:MainMenu ID="MainMenu1" runat="server" />
            </td>
        </tr>
        <tr>
        <td colspan="2">
                <uc2:ShowNews ID="ShowNews1" runat="server" />
            </td>
        </tr>
    </table>
    
    </form>
</asp:Content>
