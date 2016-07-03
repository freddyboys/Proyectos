/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.dao;

import ec.edu.espe.distribuidas.proyecto.modelo.Catalogo;
import ec.edu.espe.distribuidas.proyecto.modelo.Categoria;
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
public class CategoriaFacade extends AbstractFacade<Categoria> {
    @PersistenceContext(unitName = "ec.edu.espe.distribuidas.proyecto_ProyectoJoyeria-ejb_ejb_1PU")
    private EntityManager em;

    @Override
    protected EntityManager getEntityManager() {
        return em;
    }

    public CategoriaFacade() {
        super(Categoria.class);
    }
    
    public List<Categoria> findByNombre(String nombre){
    
        String sql = "SELECT cat FROM Categoria cat WHERE cat.nombrecategoria LIKE ?1";
        Query qry = this.getEntityManager().createQuery(sql);
        qry.setParameter(1, nombre);
        return qry.getResultList();
    }
    
    
}
