package ec.edu.espe.distribuidas.proyecto.modelo;

import ec.edu.espe.distribuidas.proyecto.modelo.Factura;
import ec.edu.espe.distribuidas.proyecto.modelo.Reserva;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-04-09T16:52:27")
@StaticMetamodel(Usuario.class)
public class Usuario_ { 

    public static volatile SingularAttribute<Usuario, String> codigo;
    public static volatile SingularAttribute<Usuario, String> nombreusuario;
    public static volatile SingularAttribute<Usuario, String> apellido;
    public static volatile SingularAttribute<Usuario, String> direccion;
    public static volatile SingularAttribute<Usuario, String> tipoUsuario;
    public static volatile CollectionAttribute<Usuario, Factura> facturaCollection;
    public static volatile SingularAttribute<Usuario, String> telefono;
    public static volatile SingularAttribute<Usuario, String> contrasena;
    public static volatile CollectionAttribute<Usuario, Reserva> reservaCollection;
    public static volatile SingularAttribute<Usuario, String> cedula;

}