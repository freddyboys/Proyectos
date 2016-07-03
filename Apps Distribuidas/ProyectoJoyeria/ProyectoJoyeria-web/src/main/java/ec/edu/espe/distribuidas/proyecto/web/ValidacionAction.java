/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.web;

import ec.edu.espe.distribuidas.proyecto.modelo.Usuario;
import ec.edu.espe.distribuidas.proyecto.servicio.UsuarioServicio;
import java.io.IOException;
import javax.naming.InitialContext;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 *
 * @author Vero
 */
public class ValidacionAction {
 
     private UsuarioServicio usuarioServicio;
    
    public ValidacionAction(){
        try{
            this.usuarioServicio = (UsuarioServicio) new InitialContext().lookup("java:global/ProyectoJoyeria-ear/ProyectoJoyeria-ejb-1/UsuarioServicio!ec.edu.espe.distribuidas.proyecto.servicio.UsuarioServicio");
            
        }catch (Exception e){
            e.printStackTrace();
        }
        
    }
    
    public void proceso (HttpServletRequest request, HttpServletResponse response) throws IOException {
       String Usuario = request.getParameter("Usuario");
       String clave = request.getParameter("clave");
       Usuario usuario = this.usuarioServicio.autenticacion(Usuario, clave);
       if (usuario == null){
           
           response.sendRedirect("index.jsp");
       } else{
           HttpSession session = request.getSession();
           session.setAttribute("usuario", usuario);
         if ("A".equals(usuario.getTipoUsuario())){
            response.sendRedirect("menuadministrador.jsp");           
           }else{
                           response.sendRedirect("menu.jsp");  
           
           }  
       }
        
    }
   
}
