<%@ Page Title="پیگیری تاکسی" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeBehind="CarTrack.aspx.cs" Inherits="Taxi.WebApp.CarTrack" %>

<%@ Register Src="Controls/MenuPassenger.ascx" TagName="MenuPassenger" TagPrefix="uc1" %>
<%@ Register Src="Controls/DriverTracking.ascx" TagName="DriverTracking" TagPrefix="uc2" %>
<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table>
        <tr>
            <td align="left" style="width: 361px">

                <uc3:LogOut ID="LogOut1" runat="server" />

            </td>
            <td align="right" style="width: 1105px">
                <uc1:MenuPassenger ID="MenuPassenger1" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center" style="width: 1105px">
                <uc2:DriverTracking ID="DriverTracking1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
