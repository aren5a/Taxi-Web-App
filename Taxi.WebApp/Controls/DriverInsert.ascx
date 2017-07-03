<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DriverInsert.ascx.cs"
    Inherits="Taxi.WebApp.Controls.DriverInsert" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<style type="text/css">
    .style
    {
        font-family: Tahoma;
        direction: rtl;
        text-align: right;
        font-size:13px;
        color:White;
       
    }
        .WaterM
    {
        font-family:Tahoma;
        font-size:smaller;
        color:Gray;
        font-style:italic;
    }
</style>
<p class="style">
  <img src=../search_driver.jpg />
</p>
<p class="style">
    &nbsp;نام یا خودرو :
    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
    &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BttSearch" runat="server" Font-Bold="True" Font-Names="Tahoma" Height="26px"
        Text="جستجو" OnClick="BttSearch_Click" />
</p>
<p class="style">
    <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red" Font-Names="Tahoma"></asp:Label>
</p>
<p class="style">
    <asp:GridView ID="gvDriver" runat="server" BackColor="White" AutoGenerateColumns="False"
        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        GridLines="Vertical" AllowPaging="true" 
        onpageindexchanging="gvDriver_PageIndexChanging">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="نام" SortExpression="Name" HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="L_Name" HeaderText="نام خانوادگی" SortExpression="L_Name"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="email" HeaderText="پست الکترونیک" SortExpression="email"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="tell_num" HeaderText="شماره تماس" SortExpression="tell_num"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="employ_date" HeaderText="تاریخ استخدام" SortExpression="employ_date"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Car_Name" HeaderText="نام خودرو" SortExpression="Car_Name"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:TemplateField ShowHeader="False" HeaderText="وضعیت">
                <ItemTemplate>
                    <asp:LinkButton ID="btnActivity" runat="server" CausesValidation="false" Text='<%#Eval("Is_ActiveF") %>'
                        CommandArgument='<%#Eval("DriverID") %>' OnCommand="btnActivity_Command" ControlStyle-Font-Underline="false" />
                </ItemTemplate>
                <HeaderStyle BackColor="#7E7E7E" />
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="btnRemoveItem" runat="server" CausesValidation="false" Text="حذف راننده"
                        CommandArgument='<%#Eval("DriverID") %>' OnCommand="btnRemove_Command" ControlStyle-Font-Underline="false" />
                </ItemTemplate>
                <HeaderStyle BackColor="#7E7E7E" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
</p>
<p class="style">
   <img src=../submit_new_d.jpg />
</p>
<p class="style">
    نام&nbsp; :&nbsp;*&nbsp;&nbsp;
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:TextBoxWatermarkExtender ID="TXTName_TextBoxWatermarkExtender" 
        runat="server" Enabled="True" TargetControlID="txtName" WatermarkCssClass="WaterM" 
        WatermarkText="فارسی تایپ شود">
        </asp:TextBoxWatermarkExtender>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; نام خانوادگی&nbsp; :
    * 
    <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
        <asp:TextBoxWatermarkExtender ID="TXTL_Name_TextBoxWatermarkExtender" 
        runat="server" Enabled="True" TargetControlID="txtlname" WatermarkCssClass="WaterM" 
        WatermarkText="فارسی تایپ شود">
    </asp:TextBoxWatermarkExtender>
    &nbsp;
</p>

<p class="style">
   &nbsp;پست الکترونیکی :&nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:TextBoxWatermarkExtender ID="TXTEmail_TextBoxWatermarkExtender" 
            runat="server" Enabled="True" TargetControlID="txtEmail" 
            WatermarkCssClass="WaterM" WatermarkText="example@example.com&nbsp; ">
        </asp:TextBoxWatermarkExtender>
    &nbsp;
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="   پست الکترونیکی را به طور صحیح وارد نمایید"
        Font-Bold="False" Font-Names="Tahoma" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Width="371px" ForeColor="Red"></asp:RegularExpressionValidator>
</p>
<p class="style">
    شماره تماس :&nbsp;*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txttellnum" runat="server"></asp:TextBox>
        
        <asp:TextBoxWatermarkExtender ID="TXTTell_TextBoxWatermarkExtender" 
        runat="server" Enabled="True" TargetControlID="txttellnum" 
        WatermarkCssClass="WaterM" WatermarkText="بدون کد استان">
    </asp:TextBoxWatermarkExtender>
    &nbsp;
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txttellnum"
        ErrorMessage="شماره تلفن معتبر نمی باشد" Font-Bold="False" Font-Names="Tahoma"
        ValidationExpression="\d{8}" ForeColor="Red"></asp:RegularExpressionValidator>
</p>
<p class="style">
    آدرس منزل :
    *
    <asp:TextBox ID="txtAddress" runat="server" Height="22px" Width="616px"></asp:TextBox>
</p>
<p class="style">
    &nbsp;نوع وسیله نقلیه : * &nbsp;<asp:DropDownList ID="DropDownList1" runat="server"
        DataSourceID="SqlDataSource1" DataTextField="Car_Name" DataValueField="Car_Type_ID">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; تاریخ استخدام :
    *&nbsp;
    <asp:TextBox ID="txtEmpDate" runat="server"></asp:TextBox>
    &nbsp;<asp:Button ID="bttEntDate" runat="server" Font-Bold="True" OnClick="bttEntDate_Click"
        Text="ثبت تاریخ جاری" Font-Names="Tahoma" />
</p>
<p class="style">
    <asp:Button ID="bttInsert" runat="server" Text="ثبت " Font-Bold="True"
        OnClick="bttInsert_Click" Font-Names="Tahoma" Width="70px" />
        &nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaxiService %>"
        SelectCommand="SELECT [Car_Name], [Car_Type_ID] FROM [Car_Type_Tbl]"></asp:SqlDataSource>
</p>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>

