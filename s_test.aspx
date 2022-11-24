<%@ Page Title="" Language="C#" MasterPageFile="~/st.Master" AutoEventWireup="true" CodeBehind="s_test.aspx.cs" Inherits="WebApplication2.s_test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br /><br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
     
    <div style="background-color:#e6f2ff;padding:50px;border-radius:10px;margin-left:15%;width:70%;">
    
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            
            <table cellpadding="10px">
                <tr>
                    
                     <th>   <%#Eval("Id")%>:<%#Eval("Question")%></th>
                </tr>
                <tr>
                    <td>
                      <asp:RadioButton ID="RadioButton1" runat="server" Text='<%#Eval("Opt1")%>' GroupName="rad1" /><br />
                      <asp:RadioButton ID="RadioButton2" runat="server" Text='<%#Eval("Opt2")%>' GroupName="rad1"/><br />
                      <asp:RadioButton ID="RadioButton3" runat="server" Text='<%#Eval("Opt3")%>' GroupName="rad1"/><br />
                      <asp:RadioButton ID="RadioButton4" runat="server" Text='<%#Eval("Opt4")%>' GroupName="rad1"/><br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("Answer")%>' Visible="false"></asp:Label> </td>
                 </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server"></asp:Label></td>
                </tr>
                 
            </table>
               
        </ItemTemplate>
    </asp:Repeater>
   <!-- <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <table cellpadding="10px">
                <tr>
                    <td>
                      <h3>  <%#Eval("Id")%>:<%#Eval("Question")%></td></h3>
                </tr>
                <tr>
                    <td>
                      <asp:RadioButton ID="RadioButton1" runat="server" Text='<%#Eval("Opt1")%>' GroupName="rad1" /><br />
                      <asp:RadioButton ID="RadioButton2" runat="server" Text='<%#Eval("Opt2")%>' GroupName="rad1"/><br />
                      <asp:RadioButton ID="RadioButton3" runat="server" Text='<%#Eval("Opt3")%>' GroupName="rad1"/><br />
                      <asp:RadioButton ID="RadioButton4" runat="server" Text='<%#Eval("Opt4")%>' GroupName="rad1"/><br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:Repeater>  -->

    <hr />
    <span><asp:Button ID="Button1" class="btn btn-primary rounded-pill sm" runat="server" Text="SUBMIT" OnClick="Button1_Click" /> &nbsp;&nbsp;&nbsp;&nbsp; <b>Marks : </b><asp:Label ID="Label4" runat="server" Text=""></asp:Label></span>
        </div>
</asp:Content>
