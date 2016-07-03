package ec.edu.espe.distribuidas.proyecto.modelo;

import ec.edu.espe.distribuidas.proyecto.modelo.Fabricante;
import ec.edu.espe.distribuidas.proyecto.modelo.Producto;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-04-09T16:52:27")
@StaticMetamodel(Proveedor.class)
public class Proveedor_ { 

    public static volatile SingularAttribute<Proveedor, Fabricante> codigofabricante;
    public static volatile SingularAttribute<Proveedor, String> codigoproveedor;
    public static volatile SingularAttribute<Proveedor, String> nombreproveedor;
    public static volatile SingularAttribute<Proveedor, String> direccionproveedor;
    public static volatile SingularAttribute<Proveedor, String> apellidoproveedor;
    public static volatile SingularAttribute<Proveedor, String> telefonoproveedor;
    public static volatile CollectionAttribute<Proveedor, Producto> productoCollection;

}