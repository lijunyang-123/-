<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LINQDemo1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="211px" Width="755px" OnRowCommand="GridView1_RowCommand">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="productid" HeaderText="编号" />
                    <asp:BoundField DataField="productname" HeaderText="商品名称" />
                    <asp:BoundField DataField="price" HeaderText="价格" />
                    <asp:BoundField DataField="typeid_1" HeaderText="一级分类" />
                    <asp:BoundField DataField="typeid_2" HeaderText="二级分类" />
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("productid") %>' CommandName="del" OnClientClick="return confrim('确认删除吗?')">删除</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
                                        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/WebForm2.aspx">新增</asp:LinkButton>

        </div>
    </form>
</body>
</html>
