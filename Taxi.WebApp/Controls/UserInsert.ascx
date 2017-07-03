<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserInsert.ascx.cs"
    Inherits="Taxi.WebApp.Controls.Register" %>
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
    
    .style6
    {
        width: 524px;
        height: 3px;
    }
    .style7
    {
        height: 3px;
        width: 197px;
    }
    
    .style12
    {
        width: 524px;
    }
    .style13
    {
        width: 197px;
    }
    .WaterM
    {
        font-family: Tahoma;
        font-size: smaller;
        color: Gray;
        font-style: italic;
    }
</style>
<p class="style1">
    <img src="UserInsert.jpg" />
</p>
<p class="style1">
    نام کاربری : *&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtUser" runat="server" AutoPostBack="True" OnTextChanged="UserTXT_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Username_ErrLBL" runat="server" ForeColor="Red"></asp:Label>
</p>
<p class="style1">
    رمز ورود :&nbsp;*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
    &nbsp;
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPass"
        ControlToValidate="TXTPassConfirm" ErrorMessage="رمز های وارد شده با هم همخانی ندارند"
        Font-Names="Tahoma" ForeColor="Red"></asp:CompareValidator>
</p>
<p class="style1">
    تکرار رمز ورود : *
    <asp:TextBox ID="TXTPassConfirm" runat="server" TextMode="Password"></asp:TextBox>
    &nbsp;&nbsp;
    <asp:Label ID="LBLAcc_Type" runat="server" Text="نوع حساب کاربری : " Visible="False"></asp:Label>
    <asp:DropDownList ID="User_TypeList" runat="server" DataSourceID="SqlDataSource1"
        DataTextField="Type_Name" DataValueField="User_Type_ID" Visible="False">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaxiService %>"
        SelectCommand="SELECT [User_Type_ID], [Type_Name] FROM [User_Type_Tbl]"></asp:SqlDataSource>
</p>
<p class="style1">
    نام :&nbsp;*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TXTName" runat="server"></asp:TextBox>
    <asp:TextBoxWatermarkExtender ID="TXTName_TextBoxWatermarkExtender" runat="server"
        Enabled="True" TargetControlID="TXTName" WatermarkCssClass="WaterM" WatermarkText="فارسی تایپ شود">
    </asp:TextBoxWatermarkExtender>
    &nbsp;&nbsp;&nbsp; نام خانوادگی :&nbsp;*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TXTL_Name" runat="server"></asp:TextBox>
    <asp:TextBoxWatermarkExtender ID="TXTL_Name_TextBoxWatermarkExtender" runat="server"
        Enabled="True" TargetControlID="TXTL_Name" WatermarkCssClass="WaterM" WatermarkText="فارسی تایپ شود">
    </asp:TextBoxWatermarkExtender>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<div class="style1">
    <table style="border-style: none; border-color: inherit; border-width: 1px; height: 53px;
        width: 736px;">
        <tr>
            <td class="style12">
                پست الکترونیکی :
            </td>
            <td class="style13">
                <asp:TextBox ID="TXTEmail" runat="server" Height="22px" Width="190px" Style="margin-left: 0px;
                    margin-right: 31px;"></asp:TextBox>
                <asp:TextBoxWatermarkExtender ID="TXTEmail_TextBoxWatermarkExtender" runat="server"
                    Enabled="True" TargetControlID="TXTEmail" WatermarkCssClass="WaterM" WatermarkText="example@example.com&nbsp; ">
                </asp:TextBoxWatermarkExtender>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="   پست الکترونیکی را مانند مثال وارد نمایید"
                    Font-Bold="False" Font-Names="Tahoma" ControlToValidate="TXTEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    Width="371px" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
            </td>
            <td style="text-align: left; direction: rtl; font-family: Tahoma; font-size: x-small;
                color: #C0C0C0;" class="style7">
                example@example.com
            </td>
            <td>
            </td>
        </tr>
    </table>
    تلفن :&nbsp;*&nbsp;
    <asp:TextBox ID="TXTTell" runat="server" Width="128px"></asp:TextBox>
    <asp:TextBoxWatermarkExtender ID="TXTTell_TextBoxWatermarkExtender" runat="server"
        Enabled="True" TargetControlID="TXTTell" WatermarkCssClass="WaterM" WatermarkText="بدون کد استان">
    </asp:TextBoxWatermarkExtender>
    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
        ControlToValidate="TXTTell" ErrorMessage="شماره تلفن معتبر نمی باشد" Font-Bold="False"
        Font-Names="Tahoma" ValidationExpression="\d{8}" ForeColor="Red"></asp:RegularExpressionValidator>
    <br />
    <br />
</div>
<p class="style1">
    آدرس :&nbsp;*
    <asp:TextBox ID="TXTAddress" runat="server" Width="616px"></asp:TextBox>
    <asp:TextBoxWatermarkExtender ID="TXTAddress_TextBoxWatermarkExtender" runat="server"
        Enabled="True" TargetControlID="TXTAddress" WatermarkCssClass="WaterM" WatermarkText="*آدرسی که نوشته اید را روی نقشه مشخص کنید">
    </asp:TextBoxWatermarkExtender>
</p>
<p class="style1">
    <asp:Button ID="ClearForm" runat="server" Font-Bold="False" Text="فرم جدید" OnClick="ClearForm_Click"
        Font-Names="tahoma" Font-Size="13px" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="SubButt" runat="server" Font-Bold="False" Text="ثبت کاربر جدید" OnClick="SubButt_Click"
        Font-Names="tahoma" />
    &nbsp;<asp:Label ID="InfoLBL" runat="server" ForeColor="Red"></asp:Label>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:SqlDataSource ID="SqlDataSourceUserName" runat="server" ConnectionString="<%$ ConnectionStrings:TaxiService %>"
        SelectCommand="SELECT [UserName] FROM [User_Tbl]"></asp:SqlDataSource>
</p>
<h4 align="center">
    نقشه تهران</h4>
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
            <aspmap:MapToolButton ID="centerTool" runat="server" ImageUrl="~/Images/center.gif"
                ToolTip="Center" Map="map_" MapTool="Center"></aspmap:MapToolButton>
            &nbsp;&nbsp; &nbsp;&nbsp;<aspmap:MapToolButton ID="pointTool" runat="server" ToolTip="Point Tool"
                ImageUrl="~/Images/point.gif" Map="map_" MapTool="Point"></aspmap:MapToolButton>
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
