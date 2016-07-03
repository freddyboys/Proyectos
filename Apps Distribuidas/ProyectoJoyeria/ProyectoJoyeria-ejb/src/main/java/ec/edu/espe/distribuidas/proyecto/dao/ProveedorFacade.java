/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.dao;

import ec.edu.espe.distribuidas.proyecto.modelo.Fabricante;
import ec.edu.espe.distribuidas.proyecto.modelo.Proveedor;
import java.util.List;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;

/**
 *
 * @author Vero
 */
@Stateless
public class ProveedorFacade extends AbstractFacade<Proveedor> {
    @PersistenceContext(unitName = "ec.edu.espe.distribuidas.proyecto_ProyectoJoyeria-ejb_ejb_1PU")
    private EntityManager em;

    @Override
    protected EntityManager getEntityManager() {
        return em;
    }

    public ProveedorFacade() {
        super(Proveedor.class);
    }
    
    public List<Proveedor> findByNombre(String nombre){
    
        String sql = "SELECT pro FROM Proveedor pro WHERE pro.nombreproveedor LIKE ?1";
        Query qry = this.getEntityManager().createQuery(sql);
        qry.setParameter(1, nombre);
        return qry.getResultList();
    }
}
