/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.servicio;


import ec.edu.espe.distribuidas.proyecto.dao.CatalogoFacade;
import ec.edu.espe.distribuidas.proyecto.modelo.Catalogo;
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
public class CatalogoServicio {

   
    @EJB
    
    private CatalogoFacade catalogoFacade;

    public List<Catalogo> listar(){
    
        return this.catalogoFacade.findAll();
    
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void crear (Catalogo catalogo){
    
        this.catalogoFacade.create(catalogo);
        
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void modificar (Catalogo catalogo){
    
        this.catalogoFacade.edit(catalogo);
    
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void eliminar (Catalogo catalogo){
       this.catalogoFacade.remove(catalogo);
        
    }
     public List<Catalogo> listarPorNombre(String nombre){
        return this.catalogoFacade.findByNombre(nombre);
    }
     
     public Catalogo obtenerPorCodigo(String codigo) {
        return this.catalogoFacade.find(codigo);
    }
    
    
}
