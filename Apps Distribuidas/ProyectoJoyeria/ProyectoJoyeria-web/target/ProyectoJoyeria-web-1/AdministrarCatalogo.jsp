<%@page import="ec.edu.espe.distribuidas.proyecto.web.CatalogoAdminAction" %>
<%@page import="java.util.List" %>
<%@page import="ec.edu.espe.distribuidas.proyecto.modelo.Catalogo"%>
<%

String patron = request.getParameter("nombre");
List<Catalogo> listado = null;
CatalogoAdminAction action = new CatalogoAdminAction();
if (patron !=null && patron.length()>1){
listado = action.obtenerPorPatron(patron);
}else{
listado = action.obtenerTodos();

}

%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
   <title>Home Page</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />


<style type="text/css">

body {
	margin:0px;
	}
	
td {
	font:11px Verdana, Arial, Helvetica, sans-serif;
	color:#003366;
	}
	
a {
	color: #FF6600;
	font-weight:bold;
	}
	
a:hover {
	color: #3366CC;
	}

/* ID Styles */

#navigation td {
	border-bottom: 2px solid #C0DFFD;
	}
	
#navigation a {
	font: 11px Verdana, Arial, Helvetica, sans-serif;
	color: #003366;
	line-height:16px;
	letter-spacing:.1em;
	text-decoration: none;
	display:block;
	padding:8px 6px 10px 26px;
	background: url("images/mm_arrow.gif") 14px 45% no-repeat;
	}
	
#navigation a:hover {
	background: #ffffff url("mm_arrow.gif") 14px 45% no-repeat;
	color:#FF6600;
	}
	
#logo 	{
	font:24px Verdana, Arial, Helvetica, sans-serif;
	color: #CCFF99;
	letter-spacing:.2em;
	line-height:30px;
	}

#tagline 	{	
	font:12px Verdana, Arial, Helvetica, sans-serif;
	color: #FF9933;
	letter-spacing:.4em;
	line-height:18px;
	}

#monthformat {
	border-bottom: 2px solid #E6F3FF;
		}
		
#dateformat {
	font:11px Verdana, Arial, Helvetica, sans-serif;
	color: #003366;
	letter-spacing:.2em;
	}
	
#dateformat a {
	font:11px Verdana, Arial, Helvetica, sans-serif;
	color: #003366;
	font-weight:bold;
	letter-spacing:.1em;
	}
	
#dateformat a:hover {
	color: #FF6600;
	letter-spacing:.1em;
	}
	
/* Class Styles */
	
.bodyText {
	font:11px Verdana, Arial, Helvetica, sans-serif;
	color:#003366;
	line-height:20px;
	margin-top:0px;
	}
	
.pageName{
	font: 18px Verdana, Arial, Helvetica, sans-serif;
	color: #3366CC;
	line-height:24px;
	letter-spacing:.2em;
	}
	
.subHeader {
	font:bold 10px Verdana, Arial, Helvetica, sans-serif;
	color: #3366CC;
	line-height:16px;
	letter-spacing:.2em;
	}

.quote {
	font: 20px Verdana, Arial, Helvetica, sans-serif;
	color: #759DA1;
	line-height:30px;
	}
	
.smallText {
	font: 10px Verdana, Arial, Helvetica, sans-serif;
	color: #003366;
	}
	

	
#nav    {
	height: 62px;
	margin-right: 0px;
	margin-left: 0px;
	color: #FFFFFF;
	background-color: #CCCCCC;
	background-image: url(images/nav-bg.jpg);
	background-repeat: repeat-x;
	background-position: top;
	padding-top: 0;
	padding-right: 0px;
	padding-bottom: 0;
	padding-left: 0px;
	border-right-width: 0px;
	border-left-width: 0px;
	border-right-style: solid;
	border-left-style: solid;
	border-right-color: #000000;
	border-left-color: #000000;
	margin-bottom: 0px;
}
#nav ul {
	margin: 0px;
	padding: 0px;
}
#nav ul li {
	margin: 0px;
	display: block;
	float: left;
	list-style: none;
	clear: right;
}
#nav ul li a {
	display: block;
	padding-right: 60px;
	padding-left: 60px;
	text-align: center;
	color: #CCCC22;
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size: 12px;
	line-height: 62px;
	font-weight: normal;
	
	background-repeat: no-repeat;
	background-position: right top;
}
#nav ul li a:hover {
	text-decoration: none;
	color: #ffffff;
	background-repeat: repeat-x;
	background-position: top;
	background-color: #999966;
}
#nav ul li#active {
	
	text-decoration: none;
}
#nav ul li#active a {
	color: #FFFFFF;
}

.Estilo2 {color: #669933}
.Estilo3 {
	font-size: 20px;
	color: #CC6633;
	font-style: italic;
	font-family: Georgia, "Times New Roman", Times, serif;
}
body {
}
    .style5
    {
        width: 352px;
        height: 146px;
    }
    .style6
    {
        width: 249px;
    }
    .style7
    {
        width: 114px;
        height: 150px;
    }
    .style8
    {
        color: #3366CC;
        line-height: 24px;
        letter-spacing: .2em;
        font-style: normal;
        font-variant: normal;
        font-weight: normal;
        font-size: 18px;
        font-family: Verdana, Arial, Helvetica, sans-serif;
        width: 332px;
    }
    .style9
    {
        width: 332px;
    }
    .style10
    {
        color: #003366;
        line-height: 20px;
        margin-top: 0px;
        font-style: normal;
        font-variant: normal;
        font-weight: normal;
        font-size: 11px;
        font-family: Verdana, Arial, Helvetica, sans-serif;
        width: 332px;
    }
    -->
</style>
</head>
<body bgcolor="#CCFF99">
    <form name="forma1" method="post" action="AdministracionCatalogo.jsp">
<table border="0" cellpadding="0" cellspacing="0" bgcolor="CCFF99">
  <tr bgcolor="#3366CC">
    <td colspan="3" rowspan="2" bgcolor="#CCFF99">
        <img alt="" class="style7" src="images/ta_Ring4U.gif" /><img alt="" class="style5" 
            src="images/424932_333574353361411_811991302_n%20(2).jpg" /></td>
    <td height="63" colspan="3" align="center" valign="bottom" nowrap="nowrap" bgcolor="#CCFF99" id="logo"><span class="Estilo2">JOYERIA AMISTAD</span> </td>
    <td width="123" bgcolor="#CCFF99">&nbsp;</td>
  </tr>

  <tr bgcolor="#3366CC">
    <td height="64" colspan="3" align="center" valign="top" bgcolor="#CCFF99" id="tagline">A TU ALCANCE </td>
	<td width="123" bgcolor="#CCFF99">&nbsp;</td>
  </tr>

 

  <tr bgcolor="#CCFF99">
  	<td height="25" colspan="7" bgcolor="#CCFF99" id="dateformat"><p>
        
      </p>    </td>
  </tr>
	  
	  <tr bgcolor="#CCFF99">
	   <td colspan="7" bgcolor="#E7FFF3" align="justify" 
             style="border-style: 0; border-color: 0; border-width: 0px; background-image: url('images/nav-bg.jpg'); padding-right: 0px; padding-left: 0px;">
    
	  <div id="nav">
      <ul>
        <li><a href="index.jsp">INICIO</a></li>
		  <li><a href="RESERVAR.jsp">RESERVAR</a></li>
       <li><a href="Empresa.jsp">CONTACTO</a> </li>
          <li><a href="Usuario.jsp">ACCESO</a> </li>
      </ul>
      </div>	  </td>
  </tr>
  
  
 <tr>
    <td colspan="7" bgcolor="#003366"><img src="images/mm_spacer.gif" alt="" width="1" height="1" border="0" /></td>
  </tr>

 <tr>
    <td width="165" valign="top" bgcolor="#E6F3FF">
	<table border="0" cellspacing="0" cellpadding="0" width="165" 
            style="font-family: Vrinda; font-size: 11px; color: #0000FF">
        <tr>
          <td width="165">&nbsp;
            <div align="center"><br />
              &nbsp;<br />
              <span class="Estilo3">CATALOGO</span></div>
            </td>
        </tr>
        <tr>
          <td width="165"><a href="FOTOSDEPORTADA.jsp" >FOTOS DE PORTADA </a></td>
        </tr>
          <tr>
          <td width="165"><a href="ANILLOSDECOMPROMISO.jsp" >ANILLOS DE COMPROMISO </a></td>
        </tr>
        <tr>
          <td width="165"><a href="AROS.jsp">AROS DE MATRIMONIO </a></td>
        </tr>
        <tr>
          <td width="165">&nbsp;</td>
        </tr>
        <tr>
                  <td width="165"><a href="JOYASDEPLATA.jsp">JOYAS DE PLATA </a></td>
                  </tr>
	    <tr>
          <td width="165">&nbsp;</td>
        </tr>
		<tr>
          <td width="165">&nbsp;</td>
          </tr>
      </table>
 	�<br />
  	&nbsp;<br />
  	&nbsp;<br />
  	&nbsp;<br /> 	</td>
    <td width="59"><img src="images/mm_spacer.gif" alt="" width="50" height="1" border="0" /></td>
    <td colspan="2" valign="top"><img src="images/mm_spacer.gif" alt="" width="305" height="1" border="0" /></td>        
        
         <h1>Administraci�n de </h1>
         
         <table border='1' width=60% align='center'>
            <tr>
                <td colspan="2">B�squeda</td>
            </tr>
            <tr>
                <td>Nombre</td>
                <td><input type="text" name="patron" size="10" maxlength="30" /></td>
            </tr>
            <tr>
                <td colspan="2"><input type="submit" name="buscar" value="Buscar"/></td>
            </tr>
        </table>
        </form>
        <p>&nbsp;</p>
        <form name="forma2" method="post" action="CatalogoModificar.jsp">
        <table border='2' width=80% align='center'>
            <tr>
                <td>C�digo</td>
                <td>Nombre</td>
                <td>Descripcion</td>
                <td>Seleccionar</td>
            </tr>
            <% for (Catalogo item : listado) { %>
            <tr>
                <td><%=item.getCodigocata()%></td>
                <td><%=item.getNombrecatalogo()%></td>
                <td><%=item.getDescripcioncatalogo()%></td>
                <td><input type="radio" name="codigo" value="<%=item.getCodigocata()%>"/></td>
            </tr>    
            <%}%>
        </table>
            
        <table align='center'>
            <tr>
                <td><input type="button" name="nuevo" value="Nuevo" onclick="javascript: window.location = 'CatalogoNuevo.jsp';"/></td>
                <td><input type="submit" name="modificar" value="Modificar"/></td>
                <td><input type="button" name="eliminar" value="Eliminar" onclick="javascript: eliminar(this);"/></td>
            </tr>
        </table>
    
    
    
    
    <td width="50"><img src="images/mm_spacer.gif" alt="" width="50" height="1" border="0" /></td>
        <td valign="top" class="style6"><br />
		&nbsp;<br />
		<table border="0" cellspacing="0" cellpadding="0" width="190">
			<tr>
			<td colspan="3" class="subHeader" align="center">&nbsp;</td>
			</tr>

			<tr>
			<td width="40">&nbsp;</td>
			<td width="110" id="sidebar" class="smallText">&nbsp;</td>
			<td width="40">&nbsp;</td>
			</tr>
		</table>	</td>
	<td width="123">&nbsp;</td>
  </tr>
  <tr>
    <td width="165">&nbsp;</td>
    <td width="59">&nbsp;</td>
    <td width="277">&nbsp;</td>
    <td width="236">&nbsp;</td>
    <td width="50">&nbsp;</td>
    <td class="style6">&nbsp;</td>
	<td width="123">&nbsp;</td>
  </tr>
</table>
    </form>
    </body>
</html>