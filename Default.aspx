<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LabDeRepaso1_Parcial2_._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

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
            Carné&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCarne" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar Estudiante" />
        </p>
    </div>

</asp:Content>
