<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserUpdate.ascx.cs"
    Inherits="Taxi.WebApp.Controls.UserUpdate" %>
<%@ Register Assembly="AspMapNET" Namespace="AspMap.Web" TagPrefix="aspmap" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<style type="text/css">
    .style1
    {
        font-family: Tahoma;
        text-align: right;
        direction: rtl;
        font-size: 13px;
        color: White;
    }
    
    .style14
    {
        width: 435px;
    }
    
    .style18
    {
        width: 293px;
        height: 3px;
    }
    .style19
    {
        width: 552px;
        height: 23px;
    }
    .style21
    {
        width: 293px;
        height: 23px;
    }
    .style22
    {
        width: 435px;
        height: 23px;
    }
    .WaterM
    {
        font-family: Tahoma;
        font-size: smaller;
        color: Gray;
        font-style: italic;
    }
</style>
<h4 align="right">
    <img src="../UpdateUser.jpg" />
</h4>
<h4 align="center">
    <img src="../map_head.jpg" /></h4>
<table id="Table1" align="center" cellspacing="1" cellpadding="1" border="0">
    <tr>
        <td colspan="2">
            <asp:ImageButton ID="zoomFull" runat="server" ImageUrl="~/Images/zoomfull.gif" BorderStyle="Outset"
                BorderWidth="1px" ToolTip="Zoom All" BorderColor="White" OnClick="zoomFull_Click">
            </asp:ImageButton>
            <aspmap:MapToolButton ID="zoomInTool" runat="server" ImageUrl="~/Images/zoomin.gif"
                Map="map_" ToolTip="Zoom In"></aspmap:MapToolButton>
            <aspmap:MapToolButton ID="zoomOutTool" runat="server" ImageUrl="~/Images/zoomout.gif"
                ToolTip="Zoom Out" Map="map_" MapTool="ZoomOut"></aspmap:MapToolButton>
            <aspmap:MapToolButton ID="panTool" runat="server" ImageUrl="~/Images/pan.gif" ToolTip="Pan"
                Map="map_" MapTool="Pan"></aspmap:MapToolButton>
            <aspmap:MapToolButton ID="centerTool" runat="server" ImageUrl="~/Images/point.gif"
                ToolTip="Center" Map="map_" MapTool="Center"></aspmap:MapToolButton>
            &nbsp;&nbsp; &nbsp;&nbsp;<aspmap:MapToolButton ID="pointTool" runat="server" ToolTip="Point Tool"
                ImageUrl="~/Images/Point2.gif" Map="map_" MapTool="Point"></aspmap:MapToolButton>
        </td>
    </tr>
    <tr>
        <td valign="top" colspan="2">
            <aspmap:Map ID="map_" runat="server" SmoothingMode="AntiAlias" FontQuality="ClearType"
                ImageFormat="Gif" BackColor="#E6E6FA" Width="950px" OnPointTool="map_PointTool"
                Height="800px"></aspmap:Map>
        </td>
    </tr>
</table>
<p class="style1">
    نام کاربری :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="UserTXT" runat="server" AutoPostBack="True"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Username_ErrLBL" runat="server" Font-Names="tahoma" Font-Size="13px"
        ForeColor="Red"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblUsername" runat="server" ForeColor="#666666"
        Font-Size="Small"></asp:Label>
</p>
<p class="style1">
    رمز ورود :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="PassTXT" runat="server" TextMode="Password"></asp:TextBox>
    &nbsp;
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="PassTXT"
        ControlToValidate="PassConfirmTXT" ErrorMessage="رمز های وارد شده با هم همخانی ندارند"
        Font-Names="Tahoma" ForeColor="Red"></asp:CompareValidator>
</p>
<p class="style1">
    تکرار رمز ورود :&nbsp;
    <asp:TextBox ID="PassConfirmTXT" runat="server" TextMode="Password"></asp:TextBox>
    &nbsp;&nbsp;
    </p>
<p class="style1">
    نام :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="NameTXT" runat="server"></asp:TextBox>
    <asp:TextBoxWatermarkExtender ID="NameTXT_TextBoxWatermarkExtender" runat="server"
        Enabled="True" TargetControlID="NameTXT" WatermarkCssClass="WaterM" WatermarkText="فارسی تایپ شود">
    </asp:TextBoxWatermarkExtender>
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblName" runat="server" ForeColor="#666666"
        Font-Size="Small"></asp:Label>
    &nbsp;&nbsp;&nbsp; نام خانوادگی :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="L_NameTXT" runat="server"></asp:TextBox>
    <asp:TextBoxWatermarkExtender ID="L_NameTXT_TextBoxWatermarkExtender" runat="server"
        Enabled="True" TargetControlID="L_NameTXT" WatermarkCssClass="WaterM" WatermarkText="فارسی تایپ شود">
    </asp:TextBoxWatermarkExtender>
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lbll_name" runat="server" ForeColor="#666666"
        Font-Size="Small"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<div class="style1">
    <table style="border-style: none; border-color: inherit; border-width: 1px; height: 53px;
        width: 844px;">
        <tr>
            <td class="style21">
                پست الکترونیکی :
            </td>
            <td class="style19" style="text-align: right">
                <asp:TextBox ID="EmailTXT" runat="server" Height="22px" Width="140px" Style="margin-left: 0px;
                    margin-right: 31px;"></asp:TextBox>
                <asp:TextBoxWatermarkExtender ID="EmailTXT_TextBoxWatermarkExtender" runat="server"
                    Enabled="True" TargetControlID="EmailTXT" WatermarkCssClass="WaterM" WatermarkText="example@example.com&nbsp; ">
                </asp:TextBoxWatermarkExtender>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblEmail" runat="server" ForeColor="#666666" Font-Size="Small"></asp:Label>
            </td>
            <td class="style22">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="   پست الکترونیکی را مانند مثال وارد نمایید"
                    Font-Bold="False" Font-Names="Tahoma" ControlToValidate="EmailTXT" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    Width="371px" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style18">
            </td>
            <td style="text-align: left; direction: rtl; font-family: Tahoma; font-size: x-small;
                color: #C0C0C0;">
                &nbsp;
            </td>
            <td class="style14">
            </td>
        </tr>
    </table>
</div>
<div class="style1">
    <br />
    <br />
    تلفن :
    <asp:TextBox ID="TellTXT" runat="server" Width="128px"></asp:TextBox>
    <asp:TextBoxWatermarkExtender ID="TellTXT_TextBoxWatermarkExtender" runat="server"
        Enabled="True" TargetControlID="TellTXT" WatermarkCssClass="WaterM" WatermarkText="بدون کد استان">
    </asp:TextBoxWatermarkExtender>
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblTell" runat="server" ForeColor="#666666"
        Font-Size="Small"></asp:Label>
    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
        ControlToValidate="TellTXT" ErrorMessage="شماره تلفن معتبر نمی باشد" Font-Bold="False"
        Font-Names="Tahoma" ValidationExpression="\d{8}" ForeColor="Red"></asp:RegularExpressionValidator>
    <br />
    <br />
</div>
<p class="style1">
    آدرس :
    <asp:TextBox ID="AddressTXT" runat="server" Width="616px"></asp:TextBox>
    <asp:TextBoxWatermarkExtender ID="AddressTXT_TextBoxWatermarkExtender" runat="server"
        Enabled="True" TargetControlID="AddressTXT" WatermarkCssClass="WaterM" WatermarkText="در صورت تغییر آدرس روی نقشه نیز مشخص کنید (فارسی تایپ شود)">
    </asp:TextBoxWatermarkExtender>
</p>
<p class="style1">
    <asp:Label ID="lblAddress" runat="server" ForeColor="#666666" Font-Size="Small"></asp:Label>
    &nbsp;&nbsp;</p>
<p class="style1">
    X :
    <asp:Label ID="lblOrigX" runat="server" ForeColor="#666666"
        Font-Size="Small"></asp:Label>
&nbsp;Y :
    <asp:Label ID="lblOrigY" runat="server" ForeColor="#666666"
        Font-Size="Small"></asp:Label>
</p>
<p class="style1">
    <asp:Button ID="bttEditUser" runat="server" Font-Bold="False" Text="تغییر اطلاعات کاربر"
        OnClick="bttEditUser_Click" Font-Names="tahoma" Font-Size="13px" />
    &nbsp;<asp:Label ID="InfoLBL" runat="server" ForeColor="Red" Visible="False"></asp:Label>
</p>
<p class="style1">
    <table>
        <tr>
            <td>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
            <td>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaxiService %>"
        SelectCommand="SELECT [User_Type_ID], [Type_Name] FROM [User_Type_Tbl]"></asp:SqlDataSource>

            </td>
        </tr>
    </table>
</p>
