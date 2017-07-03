<%@ Control Language="C#" AutoEventWireup="true"  CodeBehind="News_Insert.ascx.cs" Inherits="Taxi.WebApp.Controls.News_Insert" %>
<style type="text/css">
    .News
 {
     font-family:Tahoma;
     
     direction:rtl;
     text-align:right;
        height: 245px;
        width: 613px;
        font-size:13px;
        color:White;
    }
    
    .style2
    {
        width: 90px;
    }
    
    .style3
    {
        width: 90px;
        height: 117px;
    }
    .style4
    {
        height: 117px;
    }
    
</style>
<p style="text-align:right">
<img src="NewsInsert.jpg />
</p>
<div align="right">
<table  class="News" align="right" dir="rtl">
<tr>

<td class="style2">
موضوع خبر :
</td>
<td>
<asp:TextBox ID="SubjectTXT" runat="server" Width="486px" Font-Names="Tahoma"></asp:TextBox>
</td>

</tr>
<tr dir="rtl" align="right">

<td class="style3" >
 شرح خبر :
</td>
<td align="right" class="style4">
<asp:TextBox ID="NewsTXT" runat="server" Height="89px" TextMode="MultiLine" 
        Width="486px" Font-Names="Tahoma"></asp:TextBox>
</td>

</tr>
<tr>
<td>
</td>
<td align="right">
    <asp:Button ID="Sub_NewsBtt" runat="server" Font-Names="Tahoma" 
        onclick="Sub_NewsBtt_Click" Text=" ثبت خبر" />
    <br />

    <asp:Label ID="InfoLBL" runat="server" Font-Names="Tahoma" ForeColor="Red" 
        Visible="False"></asp:Label>
</td>
</tr>

</table>
</div>
