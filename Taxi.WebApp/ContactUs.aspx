<%@ Page Title="ارتباط با ما" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Taxi.WebApp.ContactUs" %>

<%@ Register Src="Controls/MainMenu.ascx" TagName="MainMenu" TagPrefix="uc1" %>
<%@ Register src="Controls/LogOut.ascx" tagname="LogOut" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table>
        <tr>
            <td align="left">
                <uc2:LogOut ID="LogOut1" runat="server" />
            </td>
            <td align="right">
                <uc1:MainMenu ID="MainMenu1" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <div align="center">
                    <table style="width: 1097px; height: 374px;">
                        <tr>
                            <td align="center">
                                <img src="Contact1.png" style="height: 93px; width: 97px" />
                            </td>
                            <td align="center">
                                <img src="Contact2.png" style="height: 96px; width: 97px" />
                            </td>
                            <td align="center">
                                <img src="Contact3.png" style="height: 96px; width: 95px" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <p dir="rtl" style="text-align: center">
                                    <span style="color: White"><span style="font-size: 14px"><span style="font-family: tahoma, geneva, sans-serif">
                                        آدرس:تهران-خیایان دکتر فاطمی-خیابان جویبار-پلاک 33-اتحادیه تاکسیرانی های شهری کشور</span></span></span></p>
                                <p dir="rtl" style="text-align: center">
                                    <span style="color: White"><span style="font-size: 14px"><span style="font-family: tahoma, geneva, sans-serif">
                                        تلفن:88661 </span></span></span>
                                </p>
                                <p dir="rtl" style="text-align: center">
                                    <span style="color: White"><span style="font-size: 14px"><span style="font-family: tahoma, geneva, sans-serif">
                                        وب سایت:www.irtu.ir</span></span></span></p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="center">
                                <img src="ContactUsMap.jpg" />
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
