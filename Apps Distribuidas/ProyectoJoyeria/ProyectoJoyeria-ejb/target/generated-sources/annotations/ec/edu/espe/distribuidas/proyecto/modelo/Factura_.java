package ec.edu.espe.distribuidas.proyecto.modelo;

import ec.edu.espe.distribuidas.proyecto.modelo.Credito;
import ec.edu.espe.distribuidas.proyecto.modelo.Detalle;
import ec.edu.espe.distribuidas.proyecto.modelo.Envio;
import ec.edu.espe.distribuidas.proyecto.modelo.Usuario;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-04-09T16:52:27")
@StaticMetamodel(Factura.class)
public class Factura_ { 

    public static volatile SingularAttribute<Factura, Usuario> codigo;
    public static volatile SingularAttribute<Factura, String> fechafactura;
    public static volatile SingularAttribute<Factura, String> codigofactura;
    public static volatile SingularAttribute<Factura, Credito> codigocredito;
    public static volatile SingularAttribute<Factura, String> nombrefactura;
    public static volatile CollectionAttribute<Factura, Detalle> detalleCollection;
    public static volatile CollectionAttribute<Factura, Envio> envioCollection;

}