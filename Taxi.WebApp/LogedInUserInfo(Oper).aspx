<%@ Page Title="اطلاعات کاربری" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeBehind="LogedInUserInfo(Oper).aspx.cs" Inherits="Taxi.WebApp.LogedInUserInfo_Oper_" %>

<%@ Register Src="Controls/MenuOperator.ascx" TagName="MenuOperator" TagPrefix="uc1" %>
<%@ Register Src="Controls/LogedInInfo.ascx" TagName="LogedInInfo" TagPrefix="uc2" %>
<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1102px">
        <tr>
            <td align="left" style="width: 171px">
                <uc3:LogOut ID="LogOut1" runat="server" />
            </td>
            <td align="right">
                <uc1:MenuOperator ID="MenuOperator1" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <uc2:LogedInInfo ID="LogedInInfo1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
