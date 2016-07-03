package ec.edu.espe.distribuidas.proyecto.modelo;

import ec.edu.espe.distribuidas.proyecto.modelo.Producto;
import ec.edu.espe.distribuidas.proyecto.modelo.Usuario;
import javax.annotation.Generated;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-04-09T16:52:27")
@StaticMetamodel(Reserva.class)
public class Reserva_ { 

    public static volatile SingularAttribute<Reserva, Usuario> codigo;
    public static volatile SingularAttribute<Reserva, Producto> codigoproducto;
    public static volatile SingularAttribute<Reserva, String> codigoreserva;
    public static volatile SingularAttribute<Reserva, String> descripcionreserva;

}