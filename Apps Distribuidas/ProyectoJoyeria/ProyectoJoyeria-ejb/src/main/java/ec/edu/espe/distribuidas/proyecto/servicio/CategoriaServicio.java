/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.servicio;

import ec.edu.espe.distribuidas.proyecto.dao.CategoriaFacade;
import ec.edu.espe.distribuidas.proyecto.modelo.Categoria;
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
public class CategoriaServicio {

    @EJB
    
    private CategoriaFacade categoriaFacade;

    public List<Categoria> listar(){
    
        return this.categoriaFacade.findAll();
    
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void crear (Categoria categoria){
    
        this.categoriaFacade.create(categoria);
        
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void modificar (Categoria categoria){
    
        this.categoriaFacade.edit(categoria);
    
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void eliminar (String codigo){
        Categoria categoria = this.categoriaFacade.find(codigo);
        this.categoriaFacade.remove(categoria);
        
    }
    
     public List<Categoria> listarPorNombre(String nombre){
        return this.categoriaFacade.findByNombre(nombre);
    }
    
}
