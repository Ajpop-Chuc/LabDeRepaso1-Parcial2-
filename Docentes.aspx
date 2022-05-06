<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Docentes.aspx.cs" Inherits="LabDeRepaso1_Parcial2_.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p><%: Title %></p>
    <div class="jumbotron">
        <p>
            Universidad
            <asp:TextBox ID="TextBoxNombreU" runat="server"></asp:TextBox>
        </p>
        <p>
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        </p>
        <p>
            Apellido&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
        </p>
        <p>
            Direccion&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
        </p>
        <p>
            Fecha de Nacimiento
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p>
            ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
            Titulo&nbsp;&nbsp;<asp:TextBox ID="TextBoxTitulo" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonIngresar" runat="server" OnClick="Button1_Click" Text="Ingresar Docente" />
        </p>
        </div>
    <h3>&nbsp;</h3>
</asp:Content>
