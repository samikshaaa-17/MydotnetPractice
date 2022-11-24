<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><br /><br />
    <!--  style="align-content:center;margin-top:200px;margin-left:400px;align-items:center;border:solid;border-color:darkgray;height:200px;width:400px;padding:10px-->
    <div  style="background-color:#e6f2ff;padding:50px;border-radius:10px;align-content:center;margin-left:20%;width:50%;text-align:center;">
    
    <asp:TextBox Class="textb"  ID="TextBox2" runat="server" placeholder="Enter E-mail ID " TextMode="Email"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:TextBox Class="textb" ID="TextBox3" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br /><br />
        <asp:Button class="btn btn-primary rounded-pill sm" ID="Button1" runat="server" Text="LOGIN" OnClick="Button1_Click" />
       
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
      </div>
     <br />
        <br />
</asp:Content>

