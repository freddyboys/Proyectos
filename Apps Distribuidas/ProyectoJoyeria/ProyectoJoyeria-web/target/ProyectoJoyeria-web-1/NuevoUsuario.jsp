<%-- 
    Document   : NuevoUsuario
    Created on : 05-abr-2013, 0:04:34
    Author     : Vero
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title></title>
    </head>
    <body>
       <h2>Registro de nuevo usuario del foro</h2>
        <p>Por favor ingrese la informaciòn del usuario a ser registrado, para que pueda interactuar en el foro. </p>
        <form method="post" name="forma" action="Registra.jsp">
        <table border="1">
            <tr>
                <td>Còdigo de Usuario:</td>
                <td><input type="text" name="Usuario" size="18" maxlength="15" /></td>
            </tr>
            <tr>
                <td>Clave:</td>
                <td><input type="password" name="clave" size="18" maxlength="15" /></td>
            </tr>
            <tr>
                <td>Confirme clave:</td>
                <td><input type="password" name="confirma" size="18" maxlength="15" /></td>
            </tr>
            <tr>
                <td>Nombre:</td>
                <td><input type="text" name="nombre" size="25" maxlength="100" /></td>
            </tr>
            <tr>
                <td>Apellido:</td>
                <td><input type="text" name="apellido" size="35" maxlength="100" /></td>
            </tr>

            <tr>
                <td>Cedula:</td>
                <td><input type="text" name="cedula" size="35" maxlength="100" /></td>
            </tr>

            <tr>
                <td>Direccion:</td>
                <td><input type="text" name="direccion" size="35" maxlength="100" /></td>
            </tr>

            <tr>
                <td>Telefono:</td>
                <td><input type="text" name="telefono" size="35" maxlength="100" /></td>
            </tr>
            
            <tr>
                <td>Tipo Usuario:</td>
                <td><input type="text" name="tipo" size="35" maxlength="100" /></td>
            </tr>


            
            <tr>
                <td colspan="2"><input type="submit" name="aceptar" value="Registrar" /></td>
            </tr>
            
        </table>
            </form>
    </body>
</html>
