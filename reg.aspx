<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br>
    <div  style="background-color:#e6f2ff;padding:50px;border-radius:10px;align-content:center;margin-left:20%;width:50%;text-align:center;">
    <asp:TextBox Class="textb" ID="TextBox1" runat="server" placeholder="Enter Name"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
    <br />
   <br />
    <asp:TextBox Class="textb" ID="TextBox2" runat="server" placeholder="Enter E-mail ID " TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
     
        
        
    <br />
    <br />
    <asp:TextBox Class="textb" ID="TextBox3" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br /><br />
        <asp:TextBox Class="textb" ID="TextBox4" runat="server" placeholder="Phone No."></asp:TextBox>
        <br /><br />
        <asp:DropDownList Class="textb" ID="DropDownList1" runat="server">
            <asp:ListItem>HTML</asp:ListItem>
            <asp:ListItem>CSS</asp:ListItem>
        </asp:DropDownList>
       
        <br /><br />
   <asp:Button class="btn btn-primary rounded-pill sm" ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
        <br />
      </div>
</asp:Content>
