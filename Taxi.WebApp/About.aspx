<%@ Page Title="درباره ما" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="Taxi.WebApp.About" %>

<%@ Register Src="Controls/MainMenu.ascx" TagName="MainMenu" TagPrefix="uc1" %>
<%@ Register Src="Controls/AboutUs.ascx" TagName="AboutUs" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table align="right" style="width: 885px">
        <tr>
            <td style="width: 667px">
                <uc1:MainMenu ID="MainMenu1" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="center" style="width: 667px">
                <uc2:AboutUs ID="AboutUs1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
