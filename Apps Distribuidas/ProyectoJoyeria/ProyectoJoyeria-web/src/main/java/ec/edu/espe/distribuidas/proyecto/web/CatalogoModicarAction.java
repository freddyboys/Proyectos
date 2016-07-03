/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.web;

import ec.edu.espe.distribuidas.proyecto.modelo.Catalogo;
import ec.edu.espe.distribuidas.proyecto.servicio.CatalogoServicio;
import javax.naming.InitialContext;

/**
 *
 * @author Vero
 */
public class CatalogoModicarAction {
    
    private CatalogoServicio catalogoServicio;
    
    public CatalogoModicarAction(){
    
        try{
            this.catalogoServicio = (CatalogoServicio) new InitialContext().lookup("java:global/ProyectoJoyeria-ear/ProyectoJoyeria-ejb-1/CatalogoServicio!ec.edu.espe.distribuidas.proyecto.servicio.CatalogoServicio");
            
        }catch (Exception e){
            e.printStackTrace();
            
        }
        
    }
    
    public Catalogo obtenerCatalogo (String Codigo){
        
        Catalogo catalogo = this.catalogoServicio.obtenerPorCodigo(Codigo);
        
        return catalogo;
    
    
    }

    
}
