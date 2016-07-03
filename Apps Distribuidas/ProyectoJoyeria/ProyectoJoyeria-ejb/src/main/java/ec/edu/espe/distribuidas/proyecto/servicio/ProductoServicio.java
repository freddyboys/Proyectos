/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.servicio;

import ec.edu.espe.distribuidas.proyecto.dao.ProductoFacade;
import ec.edu.espe.distribuidas.proyecto.modelo.Producto;
import java.util.List;
import javax.ejb.EJB;
import javax.ejb.Stateless;
import javax.ejb.LocalBean;
import javax.ejb.TransactionAttribute;
import javax.ejb.TransactionAttributeType;

/**
 *
 * @author Vero
 */
@Stateless
@LocalBean
public class ProductoServicio {

    @EJB
    
    private ProductoFacade productoFacade;
    
    public List<Producto> listar(){
        return this.productoFacade.findAll();
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void crear (Producto producto){
        this.productoFacade.create(producto);
        
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void modificar (Producto producto){
        this.productoFacade.edit(producto);
        
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void eliminar (String codigo){
        Producto producto = this.productoFacade.find(codigo);
        this.productoFacade.remove(producto);
    }
    
    public List<Producto> listarPorNombre(String nombre){
        return this.productoFacade.findByNombre(nombre);
    }
    
}
        
      