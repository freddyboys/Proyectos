/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ec.edu.espe.distribuidas.proyecto.modelo;

import java.io.Serializable;
import java.util.Collection;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author Vero
 */
@Entity
@Table(name = "factura", catalog = "joyeria", schema = "")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Factura.findAll", query = "SELECT f FROM Factura f"),
    @NamedQuery(name = "Factura.findByCodigofactura", query = "SELECT f FROM Factura f WHERE f.codigofactura = :codigofactura"),
    @NamedQuery(name = "Factura.findByNombrefactura", query = "SELECT f FROM Factura f WHERE f.nombrefactura = :nombrefactura"),
    @NamedQuery(name = "Factura.findByFechafactura", query = "SELECT f FROM Factura f WHERE f.fechafactura = :fechafactura")})
public class Factura implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 5)
    @Column(name = "CODIGOFACTURA", nullable = false, length = 5)
    private String codigofactura;
    @Size(max = 20)
    @Column(name = "NOMBREFACTURA", length = 20)
    private String nombrefactura;
    @Size(max = 20)
    @Column(name = "FECHAFACTURA", length = 20)
    private String fechafactura;
    @OneToMany(mappedBy = "codigofactura")
    private Collection<Envio> envioCollection;
    @JoinColumn(name = "CODIGO", referencedColumnName = "CODIGO")
    @ManyToOne
    private Usuario codigo;
    @JoinColumn(name = "CODIGOCREDITO", referencedColumnName = "CODIGOCREDITO")
    @ManyToOne
    private Credito codigocredito;
    @OneToMany(mappedBy = "codigofactura")
    private Collection<Detalle> detalleCollection;

    public Factura() {
    }

    public Factura(String codigofactura) {
        this.codigofactura = codigofactura;
    }

    public String getCodigofactura() {
        return codigofactura;
    }

    public void setCodigofactura(String codigofactura) {
        this.codigofactura = codigofactura;
    }

    public String getNombrefactura() {
        return nombrefactura;
    }

    public void setNombrefactura(String nombrefactura) {
        this.nombrefactura = nombrefactura;
    }

    public String getFechafactura() {
        return fechafactura;
    }

    public void setFechafactura(String fechafactura) {
        this.fechafactura = fechafactura;
    }

    @XmlTransient
    public Collection<Envio> getEnvioCollection() {
        return envioCollection;
    }

    public void setEnvioCollection(Collection<Envio> envioCollection) {
        this.envioCollection = envioCollection;
    }

    public Usuario getCodigo() {
        return codigo;
    }

    public void setCodigo(Usuario codigo) {
        this.codigo = codigo;
    }

    public Credito getCodigocredito() {
        return codigocredito;
    }

    public void setCodigocredito(Credito codigocredito) {
        this.codigocredito = codigocredito;
    }

    @XmlTransient
    public Collection<Detalle> getDetalleCollection() {
        return detalleCollection;
    }

    public void setDetalleCollection(Collection<Detalle> detalleCollection) {
        this.detalleCollection = detalleCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (codigofactura != null ? codigofactura.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Factura)) {
            return false;
        }
        Factura other = (Factura) object;
        if ((this.codigofactura == null && other.codigofactura != null) || (this.codigofactura != null && !this.codigofactura.equals(other.codigofactura))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ec.edu.espe.distribuidas.proyecto.modelo.Factura[ codigofactura=" + codigofactura + " ]";
    }
    
}
