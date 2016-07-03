/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.dao;

import ec.edu.espe.distribuidas.proyecto.modelo.Catalogo;
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
public class CatalogoFacade extends AbstractFacade<Catalogo> {
    @PersistenceContext(unitName = "ec.edu.espe.distribuidas.proyecto_ProyectoJoyeria-ejb_ejb_1PU")
    private EntityManager em;

    @Override
    protected EntityManager getEntityManager() {
        return em;
    }

    public CatalogoFacade() {
        super(Catalogo.class);
    }
    
    public List<Catalogo> findByNombre(String nombre){
    
        String sql = "SELECT ca FROM Catalogo ca WHERE ca.nombrecatalogo LIKE ?1";
        Query qry = this.getEntityManager().createQuery(sql);
        qry.setParameter(1, nombre);
        return qry.getResultList();
    }
    
}
