<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Visulizar.aspx.cs" Inherits="LabDeRepaso1_Parcial2_.Visulizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="text-align: center">

        <div>
            <p style="font-size: x-large">
                Universidad:&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" />
            </p>
            <p style="font-size: x-large">
                <strong>Alumno</strong></p>
        </div>
        <asp:GridView ID="GridViewAlumno" runat="server">
        </asp:GridView>
        <div>
            <span style="font-size: x-large"><strong>Docente</strong></span></div>
        <asp:GridView ID="GridViewDocente" runat="server">
        </asp:GridView>
        <div>
            <strong><span style="font-size: x-large">Personal Administrativo</span></strong></div>
        <asp:GridView ID="GridViewPersonal" runat="server">
        </asp:GridView>

        </div>
</asp:Content>
