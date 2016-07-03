package ec.edu.espe.distribuidas.proyecto.modelo;

import ec.edu.espe.distribuidas.proyecto.modelo.Catalogo;
import ec.edu.espe.distribuidas.proyecto.modelo.Categoria;
import ec.edu.espe.distribuidas.proyecto.modelo.Detalle;
import ec.edu.espe.distribuidas.proyecto.modelo.Proveedor;
import ec.edu.espe.distribuidas.proyecto.modelo.Reserva;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-04-09T16:52:27")
@StaticMetamodel(Producto.class)
public class Producto_ { 

    public static volatile SingularAttribute<Producto, String> peso;
    public static volatile SingularAttribute<Producto, Proveedor> codigoproveedor;
    public static volatile SingularAttribute<Producto, String> precio;
    public static volatile SingularAttribute<Producto, String> codigoproducto;
    public static volatile SingularAttribute<Producto, Categoria> codigocategoria;
    public static volatile SingularAttribute<Producto, String> nombreproducto;
    public static volatile SingularAttribute<Producto, String> marca;
    public static volatile SingularAttribute<Producto, String> existencia;
    public static volatile CollectionAttribute<Producto, Reserva> reservaCollection;
    public static volatile SingularAttribute<Producto, Catalogo> codigocata;
    public static volatile CollectionAttribute<Producto, Detalle> detalleCollection;
    public static volatile SingularAttribute<Producto, String> material;

}