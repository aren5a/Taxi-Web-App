<%@ Page Title="مدیریت راننده ها" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeBehind="DriverInsert.aspx.cs" Inherits="Taxi.WebApp.DriverInsert" %>

<%@ Register Src="Controls/MenuAdmin.ascx" TagName="MenuAdmin" TagPrefix="uc1" %>
<%@ Register Src="Controls/DriverInsert.ascx" TagName="DriverInsert" TagPrefix="uc2" %>
<%@ Register Src="Controls/LogOut.ascx" TagName="LogOut" TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1100px">
        <tr>
            <td align="left" style="width: 523px">
                <uc3:LogOut ID="LogOut1" runat="server" />
            </td>
            <td>
                <uc1:MenuAdmin ID="MenuAdmin1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 481px" colspan="2" align="center">
                <uc2:DriverInsert ID="DriverInsert1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
