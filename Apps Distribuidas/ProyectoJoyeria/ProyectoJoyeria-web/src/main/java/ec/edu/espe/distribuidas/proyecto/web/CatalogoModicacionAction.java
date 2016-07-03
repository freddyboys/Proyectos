/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.web;

import ec.edu.espe.distribuidas.proyecto.modelo.Catalogo;
import ec.edu.espe.distribuidas.proyecto.servicio.CatalogoServicio;
import java.io.IOException;
import javax.naming.InitialContext;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author Vero
 */
public class CatalogoModicacionAction {
   private CatalogoServicio catalogoServicio;
    
    public CatalogoModicacionAction(){
    
        try{
            this.catalogoServicio = (CatalogoServicio) new InitialContext().lookup("java:global/ProyectoJoyeria-ear/ProyectoJoyeria-ejb-1/CatalogoServicio!ec.edu.espe.distribuidas.proyecto.servicio.CatalogoServicio");
            
        }catch (Exception e){
            e.printStackTrace();
            
        }
        
    }
    
    public void proceso(HttpServletRequest request, HttpServletResponse response) throws IOException  {
        String Codigo = request.getParameter("Codigo");
        String nombre = request.getParameter("nombre");
         String descripcion = request.getParameter("descripcion");
         Catalogo catalogo = new Catalogo();
         catalogo.setCodigocata(Codigo);
         catalogo.setNombrecatalogo(nombre);
         catalogo.setDescripcioncatalogo(descripcion);
         this.catalogoServicio.modificar(catalogo);
         response.sendRedirect("AdministrarCatalogo.jsp");

    }

    
    
}
