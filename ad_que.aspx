<%@ Page Title="" Language="C#" MasterPageFile="~/Ad.Master" AutoEventWireup="true" CodeBehind="ad_que.aspx.cs" Inherits="WebApplication2.ad_que" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><br/>
    <br /><div style="background-color:#e6f2ff;padding:50px;border-radius:10px;align-content:center;margin-left:25%;width:50%;text-align:center;">
        <asp:Label Class="textb" ID="Label1" runat="server" Text="Select course"></asp:Label> : 
        <asp:DropDownList Class="textb" ID="DropDownList1" runat="server">
            <asp:ListItem>HTML</asp:ListItem>
            <asp:ListItem>CSS</asp:ListItem>
        </asp:DropDownList>
        <br /><br />

        <asp:TextBox Class="textb" ID="TextBox1" runat="server" placeholder="Enter Question Id "></asp:TextBox><br /><br />
    <textarea Class="texta" Id="TextArea1" cols="20" name="S1" rows="2" placeholder="Enter Question" runat="server"></textarea><br /><br />

    <textarea Class="texta" id="TextArea2" cols="20" name="S2" rows="2" placeholder="Enter Option 1" runat="server"></textarea><br /><br />

    <textarea Class="texta" id="TextArea3" cols="20" name="S3" rows="2" placeholder="Enter Option 2" runat="server"></textarea><br /><br />

    <textarea  Class="texta" id="TextArea4" cols="20" name="S4" rows="2" placeholder="Enter Option 3" runat="server"></textarea><br /><br />

    <textarea  Class="texta" id="TextArea5" cols="20" name="S5" rows="2" placeholder="Enter Option 4" runat="server"></textarea><br /><br />

    <textarea  Class="texta" id="TextArea6" cols="20" name="S6" rows="2" placeholder="Enter Answer" runat="server"></textarea><br /><br />

        <asp:Button ID="Button1"  class="btn btn-primary rounded-pill btn-lg" runat="server" Text="Upload" OnClick="Button1_Click" />
        </div>
    <br /><br />
    <div style="text-align:center;"> 
        <h3 style="text-align:center;">HTML QUESTIONS</h3>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="313px" Width="1314px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <h3 style="text-align:center;">CSS QUESTIONS</h3>
        <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="267px" Width="1314px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
       </div>
</asp:Content>
