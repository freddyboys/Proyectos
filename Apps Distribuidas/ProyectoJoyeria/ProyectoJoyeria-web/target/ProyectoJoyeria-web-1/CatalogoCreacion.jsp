<%@page import="ec.edu.espe.distribuidas.proyecto.web.CatalogoCreacionAction" %>
<% 

    CatalogoCreacionAction action = new CatalogoCreacionAction();
    action.proceso(request, response);
%>