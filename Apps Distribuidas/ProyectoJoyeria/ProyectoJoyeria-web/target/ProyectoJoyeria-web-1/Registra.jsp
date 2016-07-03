<%@page import="ec.edu.espe.distribuidas.proyecto.web.RegistroAction" %>
<%@page import="ec.edu.espe.distribuidas.proyecto.modelo.Usuario" %>
<%@page contentType="text/html" pageEncoding="UTF-8" %>
<%

    RegistroAction action = new RegistroAction();
    Integer resultado = action.proceso(request, response);
    if (resultado!=0){
        response.sendRedirect("AGREGARUSUARIO.jsp");
    }

%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
              <title>Confirmacion de registro de Usuario</title>
    </head>
    <body>
        <h1>Confirmacion de Registro de Usuario</h1>
        <p>El usuario <%=request.getParameter("nombre")%> ha sido registrado correctamente.</p>
        <a href="index.jsp">Ir a inicio de sesion</a>
    </body>
</html>
