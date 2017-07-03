<%@ Page Title="ثبت هزینه" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="ServiceCostList.aspx.cs" Inherits="Taxi.WebApp.ServiceCostList" %>

<%@ Register src="Controls/MenuOperator.ascx" tagname="MenuOperator" tagprefix="uc1" %>
<%@ Register src="Controls/ServiceCostList.ascx" tagname="ServiceCostList" tagprefix="uc2" %>

<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1102px" >
        <tr>
        <td align="left">
            <uc3:LogOut ID="LogOut1" runat="server" />
        </td>
            <td align ="right">
                <uc1:MenuOperator ID="MenuOperator1" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <uc2:ServiceCostList ID="ServiceCostList1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
