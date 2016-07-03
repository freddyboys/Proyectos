/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.dao;

import ec.edu.espe.distribuidas.proyecto.modelo.Fabricante;
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
public class FabricanteFacade extends AbstractFacade<Fabricante> {
    @PersistenceContext(unitName = "ec.edu.espe.distribuidas.proyecto_ProyectoJoyeria-ejb_ejb_1PU")
    private EntityManager em;

    @Override
    protected EntityManager getEntityManager() {
        return em;
    }

    public FabricanteFacade() {
        super(Fabricante.class);
    }
    
     public List<Fabricante> findByNombre(String nombre){
    
        String sql = "SELECT fa FROM Fabricante fa WHERE fa.nombrefabricante LIKE ?1";
        Query qry = this.getEntityManager().createQuery(sql);
        qry.setParameter(1, nombre);
        return qry.getResultList();
    }
}
