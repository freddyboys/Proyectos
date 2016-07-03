/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.dao;

import ec.edu.espe.distribuidas.proyecto.modelo.Factura;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

/**
 *
 * @author Vero
 */
@Stateless
public class FacturaFacade extends AbstractFacade<Factura> {
    @PersistenceContext(unitName = "ec.edu.espe.distribuidas.proyecto_ProyectoJoyeria-ejb_ejb_1PU")
    private EntityManager em;

    @Override
    protected EntityManager getEntityManager() {
        return em;
    }

    public FacturaFacade() {
        super(Factura.class);
    }
    
}
