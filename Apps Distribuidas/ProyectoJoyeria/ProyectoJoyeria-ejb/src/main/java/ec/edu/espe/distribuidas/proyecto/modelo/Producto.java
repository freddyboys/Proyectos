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
@Table(name = "producto", catalog = "joyeria", schema = "")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Producto.findAll", query = "SELECT p FROM Producto p"),
    @NamedQuery(name = "Producto.findByCodigoproducto", query = "SELECT p FROM Producto p WHERE p.codigoproducto = :codigoproducto"),
    @NamedQuery(name = "Producto.findByNombreproducto", query = "SELECT p FROM Producto p WHERE p.nombreproducto = :nombreproducto"),
    @NamedQuery(name = "Producto.findByMarca", query = "SELECT p FROM Producto p WHERE p.marca = :marca"),
    @NamedQuery(name = "Producto.findByMaterial", query = "SELECT p FROM Producto p WHERE p.material = :material"),
    @NamedQuery(name = "Producto.findByPeso", query = "SELECT p FROM Producto p WHERE p.peso = :peso"),
    @NamedQuery(name = "Producto.findByExistencia", query = "SELECT p FROM Producto p WHERE p.existencia = :existencia"),
    @NamedQuery(name = "Producto.findByPrecio", query = "SELECT p FROM Producto p WHERE p.precio = :precio")})
public class Producto implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 5)
    @Column(name = "CODIGOPRODUCTO", nullable = false, length = 5)
    private String codigoproducto;
    @Size(max = 30)
    @Column(name = "NOMBREPRODUCTO", length = 30)
    private String nombreproducto;
    @Size(max = 30)
    @Column(name = "MARCA", length = 30)
    private String marca;
    @Size(max = 30)
    @Column(name = "MATERIAL", length = 30)
    private String material;
    @Size(max = 20)
    @Column(name = "PESO", length = 20)
    private String peso;
    @Size(max = 4)
    @Column(name = "EXISTENCIA", length = 4)
    private String existencia;
    @Size(max = 10)
    @Column(name = "PRECIO", length = 10)
    private String precio;
    @JoinColumn(name = "CODIGOPROVEEDOR", referencedColumnName = "CODIGOPROVEEDOR")
    @ManyToOne
    private Proveedor codigoproveedor;
    @JoinColumn(name = "CODIGOCATEGORIA", referencedColumnName = "CODIGOCATEGORIA")
    @ManyToOne
    private Categoria codigocategoria;
    @JoinColumn(name = "CODIGOCATA", referencedColumnName = "CODIGOCATA")
    @ManyToOne
    private Catalogo codigocata;
    @OneToMany(mappedBy = "codigoproducto")
    private Collection<Detalle> detalleCollection;
    @OneToMany(mappedBy = "codigoproducto")
    private Collection<Reserva> reservaCollection;

    public Producto() {
    }

    public Producto(String codigoproducto) {
        this.codigoproducto = codigoproducto;
    }

    public String getCodigoproducto() {
        return codigoproducto;
    }

    public void setCodigoproducto(String codigoproducto) {
        this.codigoproducto = codigoproducto;
    }

    public String getNombreproducto() {
        return nombreproducto;
    }

    public void setNombreproducto(String nombreproducto) {
        this.nombreproducto = nombreproducto;
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public String getMaterial() {
        return material;
    }

    public void setMaterial(String material) {
        this.material = material;
    }

    public String getPeso() {
        return peso;
    }

    public void setPeso(String peso) {
        this.peso = peso;
    }

    public String getExistencia() {
        return existencia;
    }

    public void setExistencia(String existencia) {
        this.existencia = existencia;
    }

    public String getPrecio() {
        return precio;
    }

    public void setPrecio(String precio) {
        this.precio = precio;
    }

    public Proveedor getCodigoproveedor() {
        return codigoproveedor;
    }

    public void setCodigoproveedor(Proveedor codigoproveedor) {
        this.codigoproveedor = codigoproveedor;
    }

    public Categoria getCodigocategoria() {
        return codigocategoria;
    }

    public void setCodigocategoria(Categoria codigocategoria) {
        this.codigocategoria = codigocategoria;
    }

    public Catalogo getCodigocata() {
        return codigocata;
    }

    public void setCodigocata(Catalogo codigocata) {
        this.codigocata = codigocata;
    }

    @XmlTransient
    public Collection<Detalle> getDetalleCollection() {
        return detalleCollection;
    }

    public void setDetalleCollection(Collection<Detalle> detalleCollection) {
        this.detalleCollection = detalleCollection;
    }

    @XmlTransient
    public Collection<Reserva> getReservaCollection() {
        return reservaCollection;
    }

    public void setReservaCollection(Collection<Reserva> reservaCollection) {
        this.reservaCollection = reservaCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (codigoproducto != null ? codigoproducto.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Producto)) {
            return false;
        }
        Producto other = (Producto) object;
        if ((this.codigoproducto == null && other.codigoproducto != null) || (this.codigoproducto != null && !this.codigoproducto.equals(other.codigoproducto))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ec.edu.espe.distribuidas.proyecto.modelo.Producto[ codigoproducto=" + codigoproducto + " ]";
    }
    
}
