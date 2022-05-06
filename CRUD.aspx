<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="LabDeRepaso1_Parcial2_.CRUD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
    <p>
        Universidad
        <asp:TextBox ID="TextBoxUniversidad" runat="server"></asp:TextBox>
&nbsp;
    </p>
        <p class="text-center" style="text-align: center">
            <span style="font-size: large"><strong>Estudiante</strong></span>
    </p>
        <p class="text-center">
            Carné:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCarne" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="ButtonBuscarAlumno" runat="server" OnClick="ButtonBuscarAlumno_Click" Text="Buscar" />
    </p>
        <p class="text-center">
            &nbsp;Nombre:
            <asp:TextBox ID="TextBoxNombreEstudiante" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Apellido:
            <asp:TextBox ID="TextBoxApellidoEstudiante" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="ButtonActualizar" runat="server" OnClick="ButtonActualizar_Click" Text="Actualizar" />
    </p>
        <p class="text-center" style="text-align: center">
            <strong><span style="font-size: large; text-align: center">Docente</span><span style="font-size: x-large"> </span></strong>&nbsp;</p>
        <p>
            ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="ButtonBuscarDocente" runat="server" OnClick="ButtonBuscarDocente_Click" Text="Buscar" />
    </p>
        <p>
            Nombre:&nbsp;
            <asp:TextBox ID="TextBoxNombreDocente" runat="server" Enabled="False"></asp:TextBox>
&nbsp;&nbsp; Apellido:
            <asp:TextBox ID="TextBoxApellidoDocente" runat="server" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
    </p>
        <p>
            &nbsp;</p>
        </div>
</asp:Content>
