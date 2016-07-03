<%@page import="ec.edu.espe.distribuidas.proyecto.web.ValidacionAction"%>
<%
  ValidacionAction action = new ValidacionAction();
  action.proceso(request, response);
%>