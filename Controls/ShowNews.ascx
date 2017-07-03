<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShowNews.ascx.cs" Inherits="Taxi.WebApp.Controls.ShowNews" %>
<style type="text/css">
    .style
    {
        font-family: Tahoma;
        direction: rtl;
        text-align: right;
    }
</style>
                <p style="text-align: right;">
                    <img src="News.jpg" /></p>
                <div style="direction: rtl; text-align: right">
                    <asp:ListView ID="ListView1" runat="server" DataSourceID="NewsDS">
                        <AlternatingItemTemplate>
                            <li style="">
                                <asp:Label ID="News_subLabel" runat="server" ForeColor="Yellow" Text='<%# Eval("News_sub") %>' />
                                <br />
                                <asp:Label ID="News_fullLabel" runat="server" ForeColor="White" Text='<%# Eval("News_full") %>' />
                                <br />
                            </li>
                        </AlternatingItemTemplate>
                        <EditItemTemplate>
                            <li style="">
                                <asp:TextBox ID="News_subTextBox" runat="server" ForeColor="Yellow" Text='<%# Bind("News_sub") %>' />
                                <br />
                                <asp:TextBox ID="News_fullTextBox" runat="server" ForeColor="White" Text='<%# Bind("News_full") %>' />
                                <br />
                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                            </li>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            No data was returned.
                        </EmptyDataTemplate>
                        <InsertItemTemplate>
                            <li style="">
                                <asp:TextBox ID="News_subTextBox" runat="server" Text='<%# Bind("News_sub") %>' />
                                <br />
                                <asp:TextBox ID="News_fullTextBox" runat="server" Text='<%# Bind("News_full") %>' />
                                <br />
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                            </li>
                        </InsertItemTemplate>
                        <ItemSeparatorTemplate>
                            <br />
                        </ItemSeparatorTemplate>
                        <ItemTemplate>
                            <li style="">
                                <asp:Label ID="News_subLabel" runat="server" ForeColor="Yellow" Text='<%# Eval("News_sub") %>' />
                                <br />
                                <asp:Label ID="News_fullLabel" runat="server" ForeColor="White" Text='<%# Eval("News_full") %>' />
                                <br />
                            </li>
                        </ItemTemplate>
                        <LayoutTemplate>
                            <ul id="itemPlaceholderContainer" runat="server" style="">
                                <li runat="server" id="itemPlaceholder" />
                            </ul>
                            <div style="">
                            </div>
                        </LayoutTemplate>
                        <SelectedItemTemplate>
                            <li style="">
                                <asp:Label ID="News_subLabel" runat="server" Text='<%# Eval("News_sub") %>' />
                                <br />
                                <asp:Label ID="News_fullLabel" runat="server" Text='<%# Eval("News_full") %>' />
                                <br />
                            </li>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="4">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Button" />
                        </Fields>
                    </asp:DataPager>
                    <asp:SqlDataSource ID="NewsDS" runat="server" ConnectionString="<%$ ConnectionStrings:TaxiService %>"
                        SelectCommand="SELECT News_sub, News_full FROM News_Tbl ORDER BY Date DESC">
                    </asp:SqlDataSource>
                </div>
