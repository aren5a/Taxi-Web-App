<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LogedInUserServices.ascx.cs"
    Inherits="Taxi.WebApp.Controls.LogedInUserServices" %>
<style type="text/css">
    .style1
    {
        text-align: right;
        direction: rtl;
        font-family: Tahoma;
    }
</style>
<p class="style1">
    <img src="YourServices.jpg" />
</p>
<p class="style1">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Width="768px" BackColor="White" AllowPaging="True" 
        onpageindexchanging="GridView1_PageIndexChanging">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:BoundField DataField="Dest_Address" HeaderText="آدرس مقصد" SortExpression="Dest_Address"
                HeaderStyle-BackColor="Gray"  >
                <HeaderStyle BackColor="Gray" ForeColor="White"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Orig_Address" HeaderText="آدرس مسافر" SortExpression="Orig_Address"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray" ForeColor="White"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Driver_Name" HeaderText="نام راننده" SortExpression="Driver_Name"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray" ForeColor="White"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Date" HeaderText="تاریخ" SortExpression="Date" HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray" ForeColor="White"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Time" HeaderText="ساعت" SortExpression="Time" HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray" ForeColor="White"></HeaderStyle>
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    &nbsp;</p>
