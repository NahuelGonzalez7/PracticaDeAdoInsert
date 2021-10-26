<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaMedico.aspx.cs" Inherits="WebMedicos.VistaMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:Button ID="btnListar" runat="server" Text="Mostrar Medicos" OnClick="btnListar_Click" />
        <p>
            <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <asp:Button ID="btnInsertar" runat="server" Text="Insertar Medico" OnClick="btnInsertar_Click" />
        </p>
        <asp:Label ID="lblNroMatricula" runat="server" Text="Numero Matricula:"></asp:Label>
        <asp:TextBox ID="txtNroMatricula" runat="server"></asp:TextBox>
            <asp:Button ID="btnModificar" runat="server" Text="Modificar Medico" OnClick="btnModificar_Click" />
        <p>
            <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad:"></asp:Label>
            <asp:DropDownList ID="ddlEspecialidad" runat="server">
            </asp:DropDownList>
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Medico" OnClick="btnEliminar_Click" />
        </p>
        <asp:GridView ID="gridMedicos" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
