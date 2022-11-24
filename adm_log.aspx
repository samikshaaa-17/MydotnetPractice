<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adm_log.aspx.cs" Inherits="WebApplication2.adm_log" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><br /><br />
    <div style="background-color:#e6f2ff;padding:50px;border-radius:10px;align-content:center;margin-left:20%;width:50%;text-align:center;">
     <asp:TextBox Class="textb" ID="TextBox1" runat="server" Placeholder="Enter name" ></asp:TextBox> <br /><br />
    <asp:TextBox Class="textb" ID="TextBox2" runat="server" Placeholder="Enter Password" TextMode="Password"></asp:TextBox><br /><br />
    <asp:Button class="btn btn-primary rounded-pill sm" ID="Button1" runat="server" Text="LOGIN" OnClick="Button1_Click" />
    </div>
    
    <br /><br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
