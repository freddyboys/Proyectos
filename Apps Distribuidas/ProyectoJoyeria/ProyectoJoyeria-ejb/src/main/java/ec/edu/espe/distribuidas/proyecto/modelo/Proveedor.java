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
@Table(name = "proveedor", catalog = "joyeria", schema = "")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Proveedor.findAll", query = "SELECT p FROM Proveedor p"),
    @NamedQuery(name = "Proveedor.findByCodigoproveedor", query = "SELECT p FROM Proveedor p WHERE p.codigoproveedor = :codigoproveedor"),
    @NamedQuery(name = "Proveedor.findByNombreproveedor", query = "SELECT p FROM Proveedor p WHERE p.nombreproveedor = :nombreproveedor"),
    @NamedQuery(name = "Proveedor.findByApellidoproveedor", query = "SELECT p FROM Proveedor p WHERE p.apellidoproveedor = :apellidoproveedor"),
    @NamedQuery(name = "Proveedor.findByDireccionproveedor", query = "SELECT p FROM Proveedor p WHERE p.direccionproveedor = :direccionproveedor"),
    @NamedQuery(name = "Proveedor.findByTelefonoproveedor", query = "SELECT p FROM Proveedor p WHERE p.telefonoproveedor = :telefonoproveedor")})
public class Proveedor implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 5)
    @Column(name = "CODIGOPROVEEDOR", nullable = false, length = 5)
    private String codigoproveedor;
    @Size(max = 20)
    @Column(name = "NOMBREPROVEEDOR", length = 20)
    private String nombreproveedor;
    @Size(max = 20)
    @Column(name = "APELLIDOPROVEEDOR", length = 20)
    private String apellidoproveedor;
    @Size(max = 80)
    @Column(name = "DIRECCIONPROVEEDOR", length = 80)
    private String direccionproveedor;
    @Size(max = 20)
    @Column(name = "TELEFONOPROVEEDOR", length = 20)
    private String telefonoproveedor;
    @OneToMany(mappedBy = "codigoproveedor")
    private Collection<Producto> productoCollection;
    @JoinColumn(name = "CODIGOFABRICANTE", referencedColumnName = "CODIGOFABRICANTE")
    @ManyToOne
    private Fabricante codigofabricante;

    public Proveedor() {
    }

    public Proveedor(String codigoproveedor) {
        this.codigoproveedor = codigoproveedor;
    }

    public String getCodigoproveedor() {
        return codigoproveedor;
    }

    public void setCodigoproveedor(String codigoproveedor) {
        this.codigoproveedor = codigoproveedor;
    }

    public String getNombreproveedor() {
        return nombreproveedor;
    }

    public void setNombreproveedor(String nombreproveedor) {
        this.nombreproveedor = nombreproveedor;
    }

    public String getApellidoproveedor() {
        return apellidoproveedor;
    }

    public void setApellidoproveedor(String apellidoproveedor) {
        this.apellidoproveedor = apellidoproveedor;
    }

    public String getDireccionproveedor() {
        return direccionproveedor;
    }

    public void setDireccionproveedor(String direccionproveedor) {
        this.direccionproveedor = direccionproveedor;
    }

    public String getTelefonoproveedor() {
        return telefonoproveedor;
    }

    public void setTelefonoproveedor(String telefonoproveedor) {
        this.telefonoproveedor = telefonoproveedor;
    }

    @XmlTransient
    public Collection<Producto> getProductoCollection() {
        return productoCollection;
    }

    public void setProductoCollection(Collection<Producto> productoCollection) {
        this.productoCollection = productoCollection;
    }

    public Fabricante getCodigofabricante() {
        return codigofabricante;
    }

    public void setCodigofabricante(Fabricante codigofabricante) {
        this.codigofabricante = codigofabricante;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (codigoproveedor != null ? codigoproveedor.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Proveedor)) {
            return false;
        }
        Proveedor other = (Proveedor) object;
        if ((this.codigoproveedor == null && other.codigoproveedor != null) || (this.codigoproveedor != null && !this.codigoproveedor.equals(other.codigoproveedor))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ec.edu.espe.distribuidas.proyecto.modelo.Proveedor[ codigoproveedor=" + codigoproveedor + " ]";
    }
    
}
