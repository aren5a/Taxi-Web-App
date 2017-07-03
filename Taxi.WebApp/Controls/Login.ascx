<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="Taxi.WebApp.Controls.Login" %>
<style type="text/css">
    .loginStyle
    {
        font-family: Tahoma;
        direction: rtl;
        text-align: right;
        color: White;
    }
</style>
<div align="right" dir="rtl">
    <table border="1px">
        <tr>
            <td>
                <table class="loginStyle" border="0px" style="border-style:dotted">
                    <tr>
                        <td>
                            نام کاربری :
                        </td>
                        <td>
                            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            رمز ورود :
                        </td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="bttLogin" runat="server" Text="ورود" OnClick="bttLogin_Click" Style="height: 26px"
                                Font-Names="tahoma" />
                        </td>
                        <td>
                            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</div>
