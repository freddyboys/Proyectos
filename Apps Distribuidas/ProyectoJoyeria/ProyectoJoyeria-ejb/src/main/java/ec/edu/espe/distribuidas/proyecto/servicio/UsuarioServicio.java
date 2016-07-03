/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.servicio;

import ec.edu.espe.distribuidas.proyecto.dao.UsuarioFacade;
import ec.edu.espe.distribuidas.proyecto.modelo.Usuario;
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
public class UsuarioServicio {

     @EJB
      private UsuarioFacade usuarioFacade;

        public Usuario autenticacion(String codigoUsuario, String clave) {
            Usuario usuario = usuarioFacade.find(codigoUsuario);
            if (usuario!=null && usuario.getContrasena().equals(clave)) {
                return usuario;
            } else {
                 return null;
            }
        }

        @TransactionAttribute(TransactionAttributeType.REQUIRED)
        public void registrar(Usuario usuario) {
            usuarioFacade.create(usuario);
       }


}
