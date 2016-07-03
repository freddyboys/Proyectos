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
@Table(name = "credito", catalog = "joyeria", schema = "")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Credito.findAll", query = "SELECT c FROM Credito c"),
    @NamedQuery(name = "Credito.findByCodigocredito", query = "SELECT c FROM Credito c WHERE c.codigocredito = :codigocredito"),
    @NamedQuery(name = "Credito.findByTipoDeCredito", query = "SELECT c FROM Credito c WHERE c.tipoDeCredito = :tipoDeCredito"),
    @NamedQuery(name = "Credito.findByPlazo", query = "SELECT c FROM Credito c WHERE c.plazo = :plazo")})
public class Credito implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 5)
    @Column(name = "CODIGOCREDITO", nullable = false, length = 5)
    private String codigocredito;
    @Size(max = 10)
    @Column(name = "TIPO_DE_CREDITO", length = 10)
    private String tipoDeCredito;
    @Size(max = 5)
    @Column(name = "PLAZO", length = 5)
    private String plazo;
    @OneToMany(mappedBy = "codigocredito")
    private Collection<Factura> facturaCollection;

    public Credito() {
    }

    public Credito(String codigocredito) {
        this.codigocredito = codigocredito;
    }

    public String getCodigocredito() {
        return codigocredito;
    }

    public void setCodigocredito(String codigocredito) {
        this.codigocredito = codigocredito;
    }

    public String getTipoDeCredito() {
        return tipoDeCredito;
    }

    public void setTipoDeCredito(String tipoDeCredito) {
        this.tipoDeCredito = tipoDeCredito;
    }

    public String getPlazo() {
        return plazo;
    }

    public void setPlazo(String plazo) {
        this.plazo = plazo;
    }

    @XmlTransient
    public Collection<Factura> getFacturaCollection() {
        return facturaCollection;
    }

    public void setFacturaCollection(Collection<Factura> facturaCollection) {
        this.facturaCollection = facturaCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (codigocredito != null ? codigocredito.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Credito)) {
            return false;
        }
        Credito other = (Credito) object;
        if ((this.codigocredito == null && other.codigocredito != null) || (this.codigocredito != null && !this.codigocredito.equals(other.codigocredito))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ec.edu.espe.distribuidas.proyecto.modelo.Credito[ codigocredito=" + codigocredito + " ]";
    }
    
}
