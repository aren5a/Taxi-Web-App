<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ServiceCostList.ascx.cs"
    Inherits="Taxi.WebApp.Controls.ServiceCostList" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<style type="text/css">
    .style
    {
        direction: rtl;
        text-align: right;
        font-family: Tahoma;
        font-size: 13px;
        color: White;
    }
    .txtWatermark
    {
        font-size: x-small;
        text-align: right;
        font-style: italic;
    }
</style>
<p class="style">
    <img src="ServiceCost.jpg" />
</p>
<p class="style">
    نام مسافر یا راننده :
    <asp:TextBox ID="TXTSearch" runat="server"></asp:TextBox>
</p>
<p class="style">
    از تاریخ :
    <asp:DropDownList ID="FromListYear" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>1389</asp:ListItem>
        <asp:ListItem>1390</asp:ListItem>
        <asp:ListItem>1391</asp:ListItem>
        <asp:ListItem>1392</asp:ListItem>
        <asp:ListItem>1393</asp:ListItem>
        <asp:ListItem>1394</asp:ListItem>
        <asp:ListItem>1395</asp:ListItem>
        <asp:ListItem>1396</asp:ListItem>
        <asp:ListItem>1397</asp:ListItem>
        <asp:ListItem>1398</asp:ListItem>
        <asp:ListItem>1399</asp:ListItem>
    </asp:DropDownList>
    /
    <asp:DropDownList ID="FromListMounth" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
        <asp:ListItem>11</asp:ListItem>
        <asp:ListItem>12</asp:ListItem>
    </asp:DropDownList>
    /
    <asp:DropDownList ID="FromListDay" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
        <asp:ListItem>11</asp:ListItem>
        <asp:ListItem>12</asp:ListItem>
        <asp:ListItem>13</asp:ListItem>
        <asp:ListItem>14</asp:ListItem>
        <asp:ListItem>15</asp:ListItem>
        <asp:ListItem>16</asp:ListItem>
        <asp:ListItem>17</asp:ListItem>
        <asp:ListItem>18</asp:ListItem>
        <asp:ListItem>19</asp:ListItem>
        <asp:ListItem>20</asp:ListItem>
        <asp:ListItem>21</asp:ListItem>
        <asp:ListItem>22</asp:ListItem>
        <asp:ListItem>23</asp:ListItem>
        <asp:ListItem>24</asp:ListItem>
        <asp:ListItem>25</asp:ListItem>
        <asp:ListItem>26</asp:ListItem>
        <asp:ListItem>27</asp:ListItem>
        <asp:ListItem>28</asp:ListItem>
        <asp:ListItem>29</asp:ListItem>
        <asp:ListItem>30</asp:ListItem>
    </asp:DropDownList>
    &nbsp; تا&nbsp;&nbsp;
    <asp:DropDownList ID="ToListYear" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>1389</asp:ListItem>
        <asp:ListItem>1390</asp:ListItem>
        <asp:ListItem>1391</asp:ListItem>
        <asp:ListItem>1392</asp:ListItem>
        <asp:ListItem>1393</asp:ListItem>
        <asp:ListItem>1394</asp:ListItem>
        <asp:ListItem>1395</asp:ListItem>
        <asp:ListItem>1396</asp:ListItem>
        <asp:ListItem>1397</asp:ListItem>
        <asp:ListItem>1398</asp:ListItem>
        <asp:ListItem>1399</asp:ListItem>
    </asp:DropDownList>
    /
    <asp:DropDownList ID="ToListMounth" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
        <asp:ListItem>11</asp:ListItem>
        <asp:ListItem>12</asp:ListItem>
    </asp:DropDownList>
    /
    <asp:DropDownList ID="ToListDay" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
        <asp:ListItem>11</asp:ListItem>
        <asp:ListItem>12</asp:ListItem>
        <asp:ListItem>13</asp:ListItem>
        <asp:ListItem>14</asp:ListItem>
        <asp:ListItem>15</asp:ListItem>
        <asp:ListItem>16</asp:ListItem>
        <asp:ListItem>17</asp:ListItem>
        <asp:ListItem>18</asp:ListItem>
        <asp:ListItem>19</asp:ListItem>
        <asp:ListItem>20</asp:ListItem>
        <asp:ListItem>21</asp:ListItem>
        <asp:ListItem>22</asp:ListItem>
        <asp:ListItem>23</asp:ListItem>
        <asp:ListItem>24</asp:ListItem>
        <asp:ListItem>25</asp:ListItem>
        <asp:ListItem>26</asp:ListItem>
        <asp:ListItem>27</asp:ListItem>
        <asp:ListItem>28</asp:ListItem>
        <asp:ListItem>29</asp:ListItem>
        <asp:ListItem>30</asp:ListItem>
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Tahoma" OnClick="Button1_Click"
        Text="جستجو" />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblErr" runat="server" Font-Names="Tahoma" ForeColor="#FF3300"></asp:Label>
</p>
<p class="style">
    &nbsp;&nbsp;&nbsp;
</p>
<p class="style">
    &nbsp;
    <asp:Label ID="lblCost" runat="server" Font-Names="Tahoma" Text=" هزینه سرویس : "></asp:Label>
    &nbsp;<asp:TextBox ID="txtCost" runat="server"></asp:TextBox>
    &nbsp;
    <asp:Button ID="bttSubCost" runat="server" Font-Bold="True" Font-Names="Tahoma" OnClick="bttSubCost_Click"
        Text="ثبت" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblCostErr" runat="server" Font-Names="Tahoma" ForeColor="#FF3300"></asp:Label>
</p>
<p class="style">
    <asp:GridView ID="gvService" runat="server" BackColor="White" AutoGenerateColumns="False"
        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical"
        DataKeyNames="Service_Id,UserId" Width="869px" PageSize="5" 
        AllowPaging="true" onpageindexchanging="gvService_PageIndexChanging">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="bttCost" runat="server" Text="ثبت هزینه" OnCommand="Cmd_Pay" Visible='<%# IsNotPaid((Decimal)Eval("Cost")) %>'
                        CommandArgument='<%# Container.DataItemIndex %>' Font-Names="Tahoma" />
                </ItemTemplate>
                <HeaderStyle BackColor="Gray" />
            </asp:TemplateField>
            <asp:BoundField DataField="Cost" HeaderText="هزینه" SortExpression="هزینه" HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Dest_Address" HeaderText="آدرس مقصد" SortExpression="Dest_Address"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Orig_Address" HeaderText="آدرس مسافر" SortExpression="Orig_Address"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Driver_Name" HeaderText="نام راننده" SortExpression="Driver_Name"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Date" HeaderText="تاریخ" SortExpression="Date" HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Time" HeaderText="ساعت" SortExpression="Time" HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Tell_Num" HeaderText="شماره تماس مسافر" SortExpression="Tell_Num"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="L_Name" HeaderText="نام خانوادگی مسافر" SortExpression="L_Name"
                HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="نام مسافر" SortExpression="Name" HeaderStyle-BackColor="Gray">
                <HeaderStyle BackColor="Gray"></HeaderStyle>
            </asp:BoundField>
        </Columns>
    </asp:GridView>
</p>
<p class="style">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HiddenField ID="HFServiceID" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HiddenField ID="HFUserID" runat="server" />
</p>
<p class="style">
    <asp:ScriptManager ID="ScriptManager2" runat="server">
    </asp:ScriptManager>
    &nbsp;</p>
