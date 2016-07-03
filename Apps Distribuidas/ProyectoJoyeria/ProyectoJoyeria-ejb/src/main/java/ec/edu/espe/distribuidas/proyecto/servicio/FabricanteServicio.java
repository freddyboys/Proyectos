/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.servicio;

import ec.edu.espe.distribuidas.proyecto.dao.FabricanteFacade;
import ec.edu.espe.distribuidas.proyecto.modelo.Fabricante;
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
public class FabricanteServicio {

    @EJB
    
    private FabricanteFacade fabricanteFacade;
    
    public List<Fabricante> listar(){
        return this.fabricanteFacade.findAll();
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void crear (Fabricante fabricante){
        this.fabricanteFacade.create(fabricante);
        
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void modificar (Fabricante fabricante){
        this.fabricanteFacade.edit(fabricante);
        
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void eliminar (String codigo){
        Fabricante fabricante = this.fabricanteFacade.find(codigo);
        this.fabricanteFacade.remove(fabricante);
    }
   
     public List<Fabricante> listarPorNombre(String nombre){
        return this.fabricanteFacade.findByNombre(nombre);
    }
    

}
