package ec.edu.espe.distribuidas.proyecto.modelo;

import ec.edu.espe.distribuidas.proyecto.modelo.Factura;
import javax.annotation.Generated;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.3.2.v20111125-r10461", date="2013-04-09T16:52:27")
@StaticMetamodel(Envio.class)
public class Envio_ { 

    public static volatile SingularAttribute<Envio, String> codigoenvio;
    public static volatile SingularAttribute<Envio, String> descripcionEnvio;
    public static volatile SingularAttribute<Envio, Factura> codigofactura;

}