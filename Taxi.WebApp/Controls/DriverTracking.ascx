<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DriverTracking.ascx.cs"
    Inherits="Taxi.WebApp.Controls.DriverTracking" %>
<%@ Register Assembly="AspMapNET" Namespace="AspMap.Web" TagPrefix="aspmap" %>
<style>
    BODY
    {
        font-weight: normal;
        font-size: 9pt;
        font-family: "Verdana";
    }
    TD
    {
        font-weight: normal;
        font-size: 9pt;
        font-family: "Verdana";
    }
</style>
<table id="Table2" style="width: 525px; height: 488px" cellspacing="2" cellpadding="1"
    width="525" align="center" border="0">
    <tr>
        <td style="font-family: Tahoma; text-align: center; font-size: medium;">
            <img src="../tracking.jpg" />
        </td>
    </tr>
    <tr>
        <td align="right">
            <asp:ImageButton ID="zoomFull" runat="server" ImageUrl="~/Images/zoomfull.gif" BackColor="Cornsilk"
                BorderStyle="Outset" BorderWidth="2px" BorderColor="WhiteSmoke" OnClick="zoomFull_Click">
            </asp:ImageButton><aspmap:MapToolButton ID="zoomIn" runat="server" ImageUrl="~/Images/zoomin.gif"
                BackColor="Cornsilk" BorderStyle="Outset" BorderWidth="2px" BorderColor="WhiteSmoke"
                Map="map" ToolTip="Zoom In"></aspmap:MapToolButton><aspmap:MapToolButton ID="zoomOut"
                    runat="server" ImageUrl="~/Images/zoomout.gif" BackColor="Cornsilk" BorderStyle="Outset"
                    BorderWidth="2px" BorderColor="WhiteSmoke" Map="map" ToolTip="Zoom Out" MapTool="ZoomOut">
                </aspmap:MapToolButton><aspmap:MapToolButton ID="pan" runat="server" ImageUrl="~/Images/point.gif"
                    BackColor="Cornsilk" BorderStyle="Outset" BorderWidth="2px" BorderColor="WhiteSmoke"
                    Map="map" ToolTip="Center Map" MapTool="Center"></aspmap:MapToolButton>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <aspmap:Map ID="map" runat="server" BackColor="#FEFCED" BorderStyle="Solid" BorderWidth="1px"
                BorderColor="#C0C0FF" Width="950px" Height="800px" ImageFormat="Gif" ClientScript="StandardScript"
                AnimationInterval="1000" OnRefreshAnimationLayer="map_RefreshAnimationLayer">
            </aspmap:Map>
        </td>
    </tr>
</table>
