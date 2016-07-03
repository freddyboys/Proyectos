<%@page import="ec.edu.espe.distribuidas.proyecto.web.CatalogoModicacionAction" %>
<% 

    CatalogoModicacionAction action = new CatalogoModicacionAction();
    action.proceso(request, response);
            
%>