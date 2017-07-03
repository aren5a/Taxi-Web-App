<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LogedInInfo.ascx.cs" Inherits="Taxi.WebApp.Controls.LogedInInfo" %>
<style type="text/css">
    .style1
    {
        text-align: right;
        direction: rtl;
        font-family: Tahoma;
    }
    .style4
    {
        text-align: right;
        direction: rtl;
        font-family: Tahoma;
        color: White;
    }
    .style5
    {
        text-align: right;
        direction: rtl;
        font-family: Tahoma;
        color: Yellow;
    }
    .style6
    {
        width: 259px;
    }
    .style7
    {
        text-align: right;
        direction: rtl;
        font-family: Tahoma;
        width: 283px;
    }
</style>
<p align="center" dir="rtl">
    <img src="UserInfo.jpg" />
</p>
<div dir="rtl">
    <table border="1" style="height: 230px; width: 755px">
        <tr>
            <td class="style4">
                نام :
            </td>
            <td class="style4">
                <asp:Label ID="lblName" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td class="style4">
                نام خانوادگی :
            </td>
            <td class="style4">
                <asp:Label ID="lbllName" runat="server" CssClass="style5"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style4">
                پست الکترونیکی :
            </td>
            <td class="style4">
                <asp:Label ID="lblEmail" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td class="style4">
                شماره تماس :
            </td>
            <td class="style4">
                <asp:Label ID="lblTellNum" runat="server" CssClass="style5"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style4">
                آدرس :
            </td>
            <td class="style4" colspan="3">
                <asp:Label ID="lblAddress" runat="server" CssClass="style5"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style4">
                اعتبار حساب :
            </td>
            <td class="style4">
                <asp:Label ID="lblBalance" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td class="style4">
                آخربن تاریخ شارژ :
            </td>
            <td class="style4">
                <asp:Label ID="lblChargeDate" runat="server" CssClass="style5"></asp:Label>
            </td>
        </tr>
    </table>
</div>

