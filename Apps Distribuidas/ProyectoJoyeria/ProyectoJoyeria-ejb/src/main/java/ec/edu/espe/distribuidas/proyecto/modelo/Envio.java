/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.modelo;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Vero
 */
@Entity
@Table(name = "envio", catalog = "joyeria", schema = "")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Envio.findAll", query = "SELECT e FROM Envio e"),
    @NamedQuery(name = "Envio.findByCodigoenvio", query = "SELECT e FROM Envio e WHERE e.codigoenvio = :codigoenvio"),
    @NamedQuery(name = "Envio.findByDescripcionEnvio", query = "SELECT e FROM Envio e WHERE e.descripcionEnvio = :descripcionEnvio")})
public class Envio implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 5)
    @Column(name = "CODIGOENVIO", nullable = false, length = 5)
    private String codigoenvio;
    @Size(max = 100)
    @Column(name = "DESCRIPCION_ENVIO", length = 100)
    private String descripcionEnvio;
    @JoinColumn(name = "CODIGOFACTURA", referencedColumnName = "CODIGOFACTURA")
    @ManyToOne
    private Factura codigofactura;

    public Envio() {
    }

    public Envio(String codigoenvio) {
        this.codigoenvio = codigoenvio;
    }

    public String getCodigoenvio() {
        return codigoenvio;
    }

    public void setCodigoenvio(String codigoenvio) {
        this.codigoenvio = codigoenvio;
    }

    public String getDescripcionEnvio() {
        return descripcionEnvio;
    }

    public void setDescripcionEnvio(String descripcionEnvio) {
        this.descripcionEnvio = descripcionEnvio;
    }

    public Factura getCodigofactura() {
        return codigofactura;
    }

    public void setCodigofactura(Factura codigofactura) {
        this.codigofactura = codigofactura;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (codigoenvio != null ? codigoenvio.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Envio)) {
            return false;
        }
        Envio other = (Envio) object;
        if ((this.codigoenvio == null && other.codigoenvio != null) || (this.codigoenvio != null && !this.codigoenvio.equals(other.codigoenvio))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ec.edu.espe.distribuidas.proyecto.modelo.Envio[ codigoenvio=" + codigoenvio + " ]";
    }
    
}
