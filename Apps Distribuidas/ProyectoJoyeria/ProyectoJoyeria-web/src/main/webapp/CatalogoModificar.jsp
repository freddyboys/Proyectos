 <%@page import="ec.edu.espe.distribuidas.proyecto.modelo.Catalogo"%>
 <%@page import="ec.edu.espe.distribuidas.proyecto.web.CatalogoModicarAction"%>
<%
    System.out.println("El codigo a modificar es: "+request.getParameter("Codigo"));
    CatalogoModicarAction action = new CatalogoModicarAction();
    Catalogo item = action.obtenerCatalogo(request.getParameter("Codigo"));
%>
 
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Creacion de Catalogos</title>
    </head>
    <body>
        <h1>Creacion de Catalogos</h1>
        <form name="forma" action="CatalogoModificacion.jsp" method="post" >
        <table >
            <tr>
                <td>Codigo</td>
                <td><input type='text' name="codigo" value='<%=item.getCodigocata()%>'/></td>
            </tr>
            <tr>
                <td>Nombre</td>
                <td><input type='text' name="nombre" value='<%=item.getNombrecatalogo()%>'/></td>
            </tr>
            <tr>
                <td>Descripcion</td>
                <td><input type='text' name="descripcion" value='<%=item.getDescripcioncatalogo()%>'/></td>
            </tr>
            <tr>
                <td><input type='submit' name="enviar" value="Modificar" /></td>
                <td><input type='button' name="cancelar" value="cancelar" onclick="window.location = 'AdministradorCatalogo.jsp';" /></td>
            </tr>
        </table>
        </form>
    </body>
</html>
