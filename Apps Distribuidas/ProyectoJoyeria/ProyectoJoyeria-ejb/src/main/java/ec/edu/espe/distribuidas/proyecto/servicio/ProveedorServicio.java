/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.servicio;

import ec.edu.espe.distribuidas.proyecto.dao.ProveedorFacade;
import ec.edu.espe.distribuidas.proyecto.modelo.Proveedor;
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
public class ProveedorServicio {

  
    @EJB
    
    private ProveedorFacade proveedorFacade;
    
    public List<Proveedor> listar(){
        return this.proveedorFacade.findAll();
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void crear (Proveedor proveedor){
        this.proveedorFacade.create(proveedor);
        
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void modificar (Proveedor proveedor){
        this.proveedorFacade.edit(proveedor);
        
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void eliminar (String codigo){
        Proveedor proveedor = this.proveedorFacade.find(codigo);
        this.proveedorFacade.remove(proveedor);
    }
     public List<Proveedor> listarPorNombre(String nombre){
        return this.proveedorFacade.findByNombre(nombre);
    }
    
}
