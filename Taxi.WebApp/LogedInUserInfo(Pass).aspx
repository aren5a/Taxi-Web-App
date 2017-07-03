<%@ Page Title="اطلاعات کاربری" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="LogedInUserInfo(Pass).aspx.cs" Inherits="Taxi.WebApp.WebForm2" %>



<%@ Register src="Controls/MenuPassenger.ascx" tagname="MenuPassenger" tagprefix="uc1" %>
<%@ Register src="Controls/LogedInInfo.ascx" tagname="LogedInInfo" tagprefix="uc2" %>



<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc3" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width: 1105px">
        <tr>
        <td align="left" style="width: 384px">
        
            <uc3:LogOut ID="LogOut1" runat="server" />
        
        </td>
            <td align="right">
              
                <uc1:MenuPassenger ID="MenuPassenger1" runat="server" />
              
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
              
                <uc2:LogedInInfo ID="LogedInInfo1" runat="server" />
              
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
