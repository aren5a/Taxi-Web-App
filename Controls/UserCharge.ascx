<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserCharge.ascx.cs" Inherits="Taxi.WebApp.Controls.UserCharge" %>
<style type="text/css">
    .style1
    {
        text-align: right; 
        direction:rtl;
        font-family:Tahoma;
        font-size:13px;
        color:White;
        
    }
</style>
<p class="style1">

   <img src=../search_by.jpg />
</p>


<p class="style1">
    &nbsp;
    نام کاربری :&nbsp;<asp:TextBox 
        ID="txtUsername" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;نام :
    <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
     &nbsp;&nbsp;نام خانوادگی :
     <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
    &nbsp; شماره تماس : 
    <asp:TextBox ID="txtTell" runat="server"></asp:TextBox>
</p>



<p class="style1">
    &nbsp;


    <asp:Button ID="BTTSrchName" runat="server" Font-Names="Tahoma" Text="جستجو" 
        onclick="BTTSrchName_Click" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblSrchErr" runat="server" Font-Names="Tahoma" ForeColor="Red"></asp:Label>
   
</p>

<p class="style1">

</p>
<p class="style1">
    <img src=../user_charge.jpg />
</p>
<p class="style1">
    <asp:Label ID="LBLUsername" runat="server" Font-Names="Tahoma" 
        Text="نام کاربری :"></asp:Label>
&nbsp;
    <asp:Label ID="LBLUsername2" runat="server" Font-Names="tahoma" 
        Font-Size="13px" ForeColor="Yellow"></asp:Label>
&nbsp;
    <asp:Label ID="LBLUserCharge" runat="server" Font-Names="Tahoma" 
        Text=" شارژ فعلی : "></asp:Label>
    <asp:Label ID="LBLUserCharge2" runat="server" Font-Names="tahoma" 
        Font-Size="13px" ForeColor="Yellow"></asp:Label>
    &nbsp; مبلغ قابل شارژ :
    <asp:TextBox ID="TXTChargeAmount" runat="server" Width="128px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <br />
&nbsp;<asp:Button ID="bttCharge" runat="server" Font-Names="Tahoma" 
        Font-Overline="False" Font-Size="13px" Height="28px" Text="شارژ" 
        Width="80px" onclick="bttCharge_Click" />
        &nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Label ID="lblChargeErr" runat="server" ForeColor="Red"></asp:Label>
</p>
<p class="style1">

</p>
