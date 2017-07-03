<%@ Page Title="ورود به حساب کاربری" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="LoginForm.aspx.cs" Inherits="Taxi.WebApp.WebForm1" %>

<%@ Register Src="Controls/MainMenu.ascx" TagName="MainMenu" TagPrefix="uc1" %>
<%@ Register Src="Controls/Login.ascx" TagName="Login" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1101px">
        <tr align="right">
            <td align="right">
                <div align="right">
                    <uc1:MainMenu ID="MainMenu1" runat="server" />
                </div>
            </td>
        </tr>
        <tr align="center">
            <td align="center">
                <div align="center">
                    <uc2:Login ID="Login1" runat="server" />
                </div>
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
