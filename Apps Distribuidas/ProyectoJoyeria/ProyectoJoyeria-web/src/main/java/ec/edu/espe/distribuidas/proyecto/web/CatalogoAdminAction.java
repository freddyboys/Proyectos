/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.web;

import ec.edu.espe.distribuidas.proyecto.modelo.Catalogo;
import ec.edu.espe.distribuidas.proyecto.servicio.CatalogoServicio;
import java.io.IOException;
import java.util.List;
import javax.naming.InitialContext;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author Vero
 */
public class CatalogoAdminAction {
    
    private CatalogoServicio catalogoServicio;
    
    public CatalogoAdminAction(){

        try{
        this.catalogoServicio = (CatalogoServicio) new InitialContext().lookup("java:global/ProyectoJoyeria-ear/ProyectoJoyeria-ejb-1/CatalogoServicio!ec.edu.espe.distribuidas.proyecto.servicio.CatalogoServicio");
        }catch (Exception e){
            
            e.printStackTrace();
        }}

     public void proceso(HttpServletRequest request, HttpServletResponse response) throws IOException  {
        
    }
    
    public List<Catalogo> obtenerTodos() {
        return this.catalogoServicio.listar();
    }
    
    public List<Catalogo> obtenerPorPatron(String patron) {
        return this.catalogoServicio.listarPorNombre(patron);
    }
 
     
}

