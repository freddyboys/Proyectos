package ec.edu.espe.distribuidas.proyecto.modelo;

import ec.edu.espe.distribuidas.proyecto.modelo.Producto;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-04-09T16:52:27")
@StaticMetamodel(Catalogo.class)
public class Catalogo_ { 

    public static volatile SingularAttribute<Catalogo, String> descripcioncatalogo;
    public static volatile SingularAttribute<Catalogo, String> nombrecatalogo;
    public static volatile SingularAttribute<Catalogo, String> codigocata;
    public static volatile CollectionAttribute<Catalogo, Producto> productoCollection;

}