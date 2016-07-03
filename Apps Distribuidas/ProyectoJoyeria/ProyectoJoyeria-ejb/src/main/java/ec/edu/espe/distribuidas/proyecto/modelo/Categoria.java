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
@Table(name = "categoria", catalog = "joyeria", schema = "")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Categoria.findAll", query = "SELECT c FROM Categoria c"),
    @NamedQuery(name = "Categoria.findByCodigocategoria", query = "SELECT c FROM Categoria c WHERE c.codigocategoria = :codigocategoria"),
    @NamedQuery(name = "Categoria.findByNombrecategoria", query = "SELECT c FROM Categoria c WHERE c.nombrecategoria = :nombrecategoria"),
    @NamedQuery(name = "Categoria.findByDescripcioncategoria", query = "SELECT c FROM Categoria c WHERE c.descripcioncategoria = :descripcioncategoria")})
public class Categoria implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 5)
    @Column(name = "CODIGOCATEGORIA", nullable = false, length = 5)
    private String codigocategoria;
    @Size(max = 30)
    @Column(name = "NOMBRECATEGORIA", length = 30)
    private String nombrecategoria;
    @Size(max = 30)
    @Column(name = "DESCRIPCIONCATEGORIA", length = 30)
    private String descripcioncategoria;
    @OneToMany(mappedBy = "codigocategoria")
    private Collection<Producto> productoCollection;

    public Categoria() {
    }

    public Categoria(String codigocategoria) {
        this.codigocategoria = codigocategoria;
    }

    public String getCodigocategoria() {
        return codigocategoria;
    }

    public void setCodigocategoria(String codigocategoria) {
        this.codigocategoria = codigocategoria;
    }

    public String getNombrecategoria() {
        return nombrecategoria;
    }

    public void setNombrecategoria(String nombrecategoria) {
        this.nombrecategoria = nombrecategoria;
    }

    public String getDescripcioncategoria() {
        return descripcioncategoria;
    }

    public void setDescripcioncategoria(String descripcioncategoria) {
        this.descripcioncategoria = descripcioncategoria;
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
        hash += (codigocategoria != null ? codigocategoria.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Categoria)) {
            return false;
        }
        Categoria other = (Categoria) object;
        if ((this.codigocategoria == null && other.codigocategoria != null) || (this.codigocategoria != null && !this.codigocategoria.equals(other.codigocategoria))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ec.edu.espe.distribuidas.proyecto.modelo.Categoria[ codigocategoria=" + codigocategoria + " ]";
    }
    
}
