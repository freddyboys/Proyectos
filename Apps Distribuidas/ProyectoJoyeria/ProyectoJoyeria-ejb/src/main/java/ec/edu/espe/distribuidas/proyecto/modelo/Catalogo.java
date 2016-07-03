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
@Table(name = "catalogo", catalog = "joyeria", schema = "")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Catalogo.findAll", query = "SELECT c FROM Catalogo c"),
    @NamedQuery(name = "Catalogo.findByCodigocata", query = "SELECT c FROM Catalogo c WHERE c.codigocata = :codigocata"),
    @NamedQuery(name = "Catalogo.findByNombrecatalogo", query = "SELECT c FROM Catalogo c WHERE c.nombrecatalogo = :nombrecatalogo"),
    @NamedQuery(name = "Catalogo.findByDescripcioncatalogo", query = "SELECT c FROM Catalogo c WHERE c.descripcioncatalogo = :descripcioncatalogo")})
public class Catalogo implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 5)
    @Column(name = "CODIGOCATA", nullable = false, length = 5)
    private String codigocata;
    @Size(max = 20)
    @Column(name = "NOMBRECATALOGO", length = 20)
    private String nombrecatalogo;
    @Size(max = 50)
    @Column(name = "DESCRIPCIONCATALOGO", length = 50)
    private String descripcioncatalogo;
    @OneToMany(mappedBy = "codigocata")
    private Collection<Producto> productoCollection;

    public Catalogo() {
    }

    public Catalogo(String codigocata) {
        this.codigocata = codigocata;
    }

    public String getCodigocata() {
        return codigocata;
    }

    public void setCodigocata(String codigocata) {
        this.codigocata = codigocata;
    }

    public String getNombrecatalogo() {
        return nombrecatalogo;
    }

    public void setNombrecatalogo(String nombrecatalogo) {
        this.nombrecatalogo = nombrecatalogo;
    }

    public String getDescripcioncatalogo() {
        return descripcioncatalogo;
    }

    public void setDescripcioncatalogo(String descripcioncatalogo) {
        this.descripcioncatalogo = descripcioncatalogo;
    }

    @XmlTransient
    public Collection<Producto> getProductoCollection() {
        return productoCollection;
    }

    public void setProductoCollection(Collection<Producto> productoCollection) {
        this.productoCollection = productoCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (codigocata != null ? codigocata.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Catalogo)) {
            return false;
        }
        Catalogo other = (Catalogo) object;
        if ((this.codigocata == null && other.codigocata != null) || (this.codigocata != null && !this.codigocata.equals(other.codigocata))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ec.edu.espe.distribuidas.proyecto.modelo.Catalogo[ codigocata=" + codigocata + " ]";
    }
    
}
