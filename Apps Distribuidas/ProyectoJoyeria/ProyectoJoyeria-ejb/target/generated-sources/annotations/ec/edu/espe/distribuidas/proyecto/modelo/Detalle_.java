package ec.edu.espe.distribuidas.proyecto.modelo;

import ec.edu.espe.distribuidas.proyecto.modelo.Factura;
import ec.edu.espe.distribuidas.proyecto.modelo.Producto;
import javax.annotation.Generated;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-04-09T16:52:27")
@StaticMetamodel(Detalle.class)
public class Detalle_ { 

    public static volatile SingularAttribute<Detalle, String> total;
    public static volatile SingularAttribute<Detalle, String> descuento;
    public static volatile SingularAttribute<Detalle, String> valorunitario;
    public static volatile SingularAttribute<Detalle, Producto> codigoproducto;
    public static volatile SingularAttribute<Detalle, String> cantidad;
    public static volatile SingularAttribute<Detalle, String> valortotal;
    public static volatile SingularAttribute<Detalle, String> descripcion;
    public static volatile SingularAttribute<Detalle, Factura> codigofactura;
    public static volatile SingularAttribute<Detalle, String> codigodetalle;
    public static volatile SingularAttribute<Detalle, String> subtotal;

}