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
@Table(name = "fabricante", catalog = "joyeria", schema = "")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Fabricante.findAll", query = "SELECT f FROM Fabricante f"),
    @NamedQuery(name = "Fabricante.findByCodigofabricante", query = "SELECT f FROM Fabricante f WHERE f.codigofabricante = :codigofabricante"),
    @NamedQuery(name = "Fabricante.findByNombrefabricante", query = "SELECT f FROM Fabricante f WHERE f.nombrefabricante = :nombrefabricante"),
    @NamedQuery(name = "Fabricante.findByDireccionfabricante", query = "SELECT f FROM Fabricante f WHERE f.direccionfabricante = :direccionfabricante"),
    @NamedQuery(name = "Fabricante.findByTelefonofabricante", query = "SELECT f FROM Fabricante f WHERE f.telefonofabricante = :telefonofabricante"),
    @NamedQuery(name = "Fabricante.findByEmailfabricante", query = "SELECT f FROM Fabricante f WHERE f.emailfabricante = :emailfabricante")})
public class Fabricante implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 5)
    @Column(name = "CODIGOFABRICANTE", nullable = false, length = 5)
    private String codigofabricante;
    @Size(max = 20)
    @Column(name = "NOMBREFABRICANTE", length = 20)
    private String nombrefabricante;
    @Size(max = 80)
    @Column(name = "DIRECCIONFABRICANTE", length = 80)
    private String direccionfabricante;
    @Size(max = 20)
    @Column(name = "TELEFONOFABRICANTE", length = 20)
    private String telefonofabricante;
    @Size(max = 50)
    @Column(name = "EMAILFABRICANTE", length = 50)
    private String emailfabricante;
    @OneToMany(mappedBy = "codigofabricante")
    private Collection<Proveedor> proveedorCollection;

    public Fabricante() {
    }

    public Fabricante(String codigofabricante) {
        this.codigofabricante = codigofabricante;
    }

    public String getCodigofabricante() {
        return codigofabricante;
    }

    public void setCodigofabricante(String codigofabricante) {
        this.codigofabricante = codigofabricante;
    }

    public String getNombrefabricante() {
        return nombrefabricante;
    }

    public void setNombrefabricante(String nombrefabricante) {
        this.nombrefabricante = nombrefabricante;
    }

    public String getDireccionfabricante() {
        return direccionfabricante;
    }

    public void setDireccionfabricante(String direccionfabricante) {
        this.direccionfabricante = direccionfabricante;
    }

    public String getTelefonofabricante() {
        return telefonofabricante;
    }

    public void setTelefonofabricante(String telefonofabricante) {
        this.telefonofabricante = telefonofabricante;
    }

    public String getEmailfabricante() {
        return emailfabricante;
    }

    public void setEmailfabricante(String emailfabricante) {
        this.emailfabricante = emailfabricante;
    }

    @XmlTransient
    public Collection<Proveedor> getProveedorCollection() {
        return proveedorCollection;
    }

    public void setProveedorCollection(Collection<Proveedor> proveedorCollection) {
        this.proveedorCollection = proveedorCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (codigofabricante != null ? codigofabricante.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Fabricante)) {
            return false;
        }
        Fabricante other = (Fabricante) object;
        if ((this.codigofabricante == null && other.codigofabricante != null) || (this.codigofabricante != null && !this.codigofabricante.equals(other.codigofabricante))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ec.edu.espe.distribuidas.proyecto.modelo.Fabricante[ codigofabricante=" + codigofabricante + " ]";
    }
    
}
