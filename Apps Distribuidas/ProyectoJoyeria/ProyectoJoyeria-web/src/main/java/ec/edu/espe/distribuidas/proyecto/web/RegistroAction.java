/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.web;

import ec.edu.espe.distribuidas.proyecto.modelo.Usuario;
import ec.edu.espe.distribuidas.proyecto.servicio.UsuarioServicio;
import javax.naming.InitialContext;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author Vero
 */
public class RegistroAction {
    
    private UsuarioServicio usuarioServicio;
    
    public RegistroAction(){
        try{
            this.usuarioServicio = (UsuarioServicio) new InitialContext().lookup("java:global/ProyectoJoyeria-ear/ProyectoJoyeria-ejb-1/UsuarioServicio!ec.edu.espe.distribuidas.proyecto.servicio.UsuarioServicio");
            
        }catch (Exception e){
            e.printStackTrace();
            
        }
        
    }
    
    public Integer proceso (HttpServletRequest request, HttpServletResponse response){
       String Usuario = request.getParameter("Usuario");
       String clave = request.getParameter("clave");
       String confirma = request.getParameter("confirma");
       String nombre = request.getParameter("nombre");
       String apellido = request.getParameter("apellido");
       String cedula = request.getParameter("cedula");
       String direccion = request.getParameter("direccion");
       String telefono = request.getParameter("telefono");
       String tipo = request.getParameter("tipo"); 
       
       if (!clave.equals(confirma)){
           return 1;
       }else{
           
           Usuario usuario = new Usuario();
           usuario.setContrasena(clave);
           usuario.setCodigo(Usuario);
           usuario.setNombreusuario(nombre);
           usuario.setApellido(apellido);
           usuario.setCedula(cedula);
           usuario.setDireccion(direccion);
           usuario.setTelefono(telefono);
           usuario.setTipoUsuario(tipo);
           this.usuarioServicio.registrar(usuario);
           return 0; 
              
       }
    }
    
}
