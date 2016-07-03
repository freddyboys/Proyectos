package ec.edu.espe.distribuidas.proyecto.modelo;

import ec.edu.espe.distribuidas.proyecto.modelo.Proveedor;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-04-09T16:52:27")
@StaticMetamodel(Fabricante.class)
public class Fabricante_ { 

    public static volatile SingularAttribute<Fabricante, String> codigofabricante;
    public static volatile SingularAttribute<Fabricante, String> direccionfabricante;
    public static volatile SingularAttribute<Fabricante, String> emailfabricante;
    public static volatile CollectionAttribute<Fabricante, Proveedor> proveedorCollection;
    public static volatile SingularAttribute<Fabricante, String> telefonofabricante;
    public static volatile SingularAttribute<Fabricante, String> nombrefabricante;

}