<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="text1" runat="server"></asp:TextBox><br /><br />

    <asp:Button ID="Submit1" runat="server" Text="Add to Session State" OnClick="Session_Add" /><br /><br />
    <asp:Button ID="Submit2" runat="server" Text="View Session State" OnClick="CheckSession" /><br /><br />

    <asp:Label ID="span1" runat="server" Font-Bold="true" ForeColor="DarkBlue" />
</asp:Content>
