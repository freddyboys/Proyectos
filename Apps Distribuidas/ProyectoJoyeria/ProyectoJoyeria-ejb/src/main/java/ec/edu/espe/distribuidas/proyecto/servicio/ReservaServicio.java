/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.servicio;

import ec.edu.espe.distribuidas.proyecto.dao.ReservaFacade;
import ec.edu.espe.distribuidas.proyecto.modelo.Reserva;
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
public class ReservaServicio {

    
    @EJB
    
    private ReservaFacade reservaFacade;
    
    public List<Reserva> listar(){
        return this.reservaFacade.findAll();
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void crear (Reserva reserva){
        this.reservaFacade.create(reserva);
        
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void modificar (Reserva reserva){
        this.reservaFacade.edit(reserva);
        
    }
    @TransactionAttribute(TransactionAttributeType.REQUIRED)
    public void eliminar (String codigo){
        Reserva reserva = this.reservaFacade.find(codigo);
        this.reservaFacade.remove(reserva);
    }

}
