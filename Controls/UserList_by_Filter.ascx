<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserList_by_Filter.ascx.cs"
    Inherits="Taxi.WebApp.Controls.UserList_by_Filter_" %>
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
        font-family: Tahoma;
        font-size: smaller;
        color: Gray;
        font-style: italic;
    }
    .GridStyle
    {
        font-family:Tahoma;
        text-align:center;
    }
</style>
<p class="style">
   <img src=../p_search.jpg />
</p>
<p class="style">
    &nbsp;از تاریخ :
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
    &nbsp;&nbsp;   تعداد سرویس بیش از :&nbsp;
    <asp:TextBox ID="txtQuantity" runat="server" Width="33px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="bttSearch" runat="server" Text="جستجو" Font-Names="tahoma" OnClick="bttSearch_Click" />
</p>
<p class="style">
    <asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>
</p>
<p class="style">
    <asp:GridView ID="GridView1" runat="server" BackColor="White" AutoGenerateColumns="False"
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
        CellPadding="3" ForeColor="Black"
        GridLines="Vertical" onpageindexchanging="GridView1_PageIndexChanging" 
        AllowPaging="True">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:BoundField DataField="countf" HeaderText="تعداد سرویس" >
            <HeaderStyle CssClass="GridStyle" BackColor="Gray" />
            </asp:BoundField>
            <asp:BoundField DataField="Address" HeaderText="آدرس" >
            <HeaderStyle CssClass="GridStyle" BackColor="Gray" />
            </asp:BoundField>
            <asp:BoundField DataField="Tell_Num" HeaderText="شماره تماس" >
            <HeaderStyle CssClass="GridStyle" BackColor="Gray" />
            </asp:BoundField>
            <asp:BoundField DataField="Email" HeaderText="پست الکترونیکی" >
            <HeaderStyle CssClass="GridStyle" BackColor="Gray" />
            </asp:BoundField>
            <asp:BoundField DataField="l_name" HeaderText="نام خانوادگی" >
            <HeaderStyle CssClass="GridStyle" BackColor="Gray"/>
            </asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="نام" >
            <HeaderStyle CssClass="GridStyle" BackColor="Gray" />
            </asp:BoundField>
            <asp:BoundField DataField="UserName" HeaderText="نام کاربری" >
            <HeaderStyle CssClass="GridStyle" BackColor="Gray" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
</p>
