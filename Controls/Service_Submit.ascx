<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Service_Submit.ascx.cs"
    Inherits="Taxi.WebApp.Controls.WebUserControl2" %>
<%@ Register Assembly="AspMapNET" Namespace="AspMap.Web" TagPrefix="aspmap" %>
<style type="text/css">
    .style1
    {
        text-align: right;
        direction: rtl;
        font-family: Tahoma;
        font-size: 13px;
        color: White;
    }
</style>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<p class="style1">
    <img src="ServiceSubmit.jpg" />
    &nbsp;</p>
<p align="center" style="direction: ltr">
    <img src="../map_head.jpg" />
</p>
<asp:UpdatePanel ID="UpdatePanelMap" runat="server">
    <ContentTemplate>
        <table id="Table1" align="center" cellspacing="1" cellpadding="1" border="0">
            <tr>
                <td>
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
                        ImageUrl="~/Images/point2.gif" Map="map_" MapTool="Point" Height="20px" Width="19px">
                    </aspmap:MapToolButton>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <aspmap:Map ID="map_" runat="server" SmoothingMode="AntiAlias" FontQuality="ClearType"
                        ImageFormat="Gif" BackColor="#E6E6FA" Width="950px" OnPointTool="map_PointTool"
                        Height="800px"></aspmap:Map>
                </td>
            </tr>
        </table>
    </ContentTemplate>
</asp:UpdatePanel>
<p class="style1">
    <img src="../search_by.jpg" />
</p>
<asp:UpdatePanel ID="UpdatePanelService" runat="server">
    <ContentTemplate>
        <p class="style1">
            &nbsp; نام کاربری :&nbsp;<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;نام :
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            &nbsp;&nbsp; نام خانوادگی :
            <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
            &nbsp; شماره تماس :
            <asp:TextBox ID="txtTell" runat="server"></asp:TextBox>
        </p>
        <p class="style1">
            &nbsp;&nbsp;
            <asp:Button ID="BTTSrchName" runat="server" Font-Names="Tahoma" Text="جستجو" OnClick="BTTSrchName_Click"
                Font-Bold="True" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSrchErr" runat="server" Font-Names="Tahoma" ForeColor="Red"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="style1">
        </p>
        <p class="style1">
            <img src="../submit_serv.jpg" />
        </p>
        <p class="style1">
            نام کاربری :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsername2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; شارژ فعلی مسافر :
            <asp:Label ID="LBLBalance" runat="server" Font-Names="Tahoma" Font-Size="13px" ForeColor="Yellow"></asp:Label>
        </p>
        <p class="style1">
            <asp:Label ID="LBLEnter_Name" runat="server" Font-Names="Tahoma" Text="نام مسافر :"></asp:Label>
            &nbsp;*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TXTName2" runat="server"></asp:TextBox>
        </p>
        <p class="style1">
            <asp:Label ID="LBLEnter_l_Name" runat="server" Font-Names="Tahoma" Text="نام خانوادگی مسافر :"></asp:Label>
            &nbsp;*&nbsp;&nbsp;<asp:TextBox ID="TXTLName2" runat="server"></asp:TextBox>
            &nbsp;</p>
        <p class="style1">
            شماره تماس مسافر : *&nbsp;&nbsp;
            <asp:TextBox ID="txtTell2" runat="server"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                ControlToValidate="txtTell2" ErrorMessage="شماره تلفن معتبر نمی باشد" Font-Bold="False"
                Font-Names="Tahoma" ForeColor="Red" ValidationExpression="\d{8}"></asp:RegularExpressionValidator>
        </p>
        <p class="style1">
            آدرس مسافر :&nbsp;*&nbsp;
            <asp:TextBox ID="TXTOrigAdd" runat="server" TextMode="MultiLine" Width="656px" Height="41px"></asp:TextBox>
        </p>
        <p class="style1">
            مختصات :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; X
            <asp:TextBox ID="txtorigX" runat="server" Width="72px" ReadOnly="True"></asp:TextBox>
            &nbsp;Y
            <asp:TextBox ID="txtorigY" runat="server" Width="72px" ReadOnly="True"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp; راننده مناسب برای سرویس :
            <asp:Label ID="lblDriver" runat="server" Font-Names="tahoma" Font-Size="13px" ForeColor="Yellow"></asp:Label>
            &nbsp;
            <asp:HiddenField ID="DriverID" runat="server" />
        </p>
        <p class="style1">
            آدرس مقصد&nbsp; :&nbsp;*&nbsp;
            <asp:TextBox ID="TXTDestAdd" runat="server" TextMode="MultiLine" Width="656px" Height="41px"></asp:TextBox>
            &nbsp;</p>
        <p class="style1">
            <asp:Button ID="BttSubmit" runat="server" Text="ثبت سرویس" Font-Names="Tahoma" Font-Bold="True"
                OnClick="BttSubmit_Click" />
            &nbsp;
            <asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>
        </p>
    </ContentTemplate>
</asp:UpdatePanel>
