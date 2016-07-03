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
@Table(name = "detalle", catalog = "joyeria", schema = "")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Detalle.findAll", query = "SELECT d FROM Detalle d"),
    @NamedQuery(name = "Detalle.findByCodigodetalle", query = "SELECT d FROM Detalle d WHERE d.codigodetalle = :codigodetalle"),
    @NamedQuery(name = "Detalle.findByCantidad", query = "SELECT d FROM Detalle d WHERE d.cantidad = :cantidad"),
    @NamedQuery(name = "Detalle.findByDescripcion", query = "SELECT d FROM Detalle d WHERE d.descripcion = :descripcion"),
    @NamedQuery(name = "Detalle.findByValorunitario", query = "SELECT d FROM Detalle d WHERE d.valorunitario = :valorunitario"),
    @NamedQuery(name = "Detalle.findByValortotal", query = "SELECT d FROM Detalle d WHERE d.valortotal = :valortotal"),
    @NamedQuery(name = "Detalle.findBySubtotal", query = "SELECT d FROM Detalle d WHERE d.subtotal = :subtotal"),
    @NamedQuery(name = "Detalle.findByDescuento", query = "SELECT d FROM Detalle d WHERE d.descuento = :descuento"),
    @NamedQuery(name = "Detalle.findByTotal", query = "SELECT d FROM Detalle d WHERE d.total = :total")})
public class Detalle implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 5)
    @Column(name = "CODIGODETALLE", nullable = false, length = 5)
    private String codigodetalle;
    @Size(max = 5)
    @Column(name = "CANTIDAD", length = 5)
    private String cantidad;
    @Size(max = 30)
    @Column(name = "DESCRIPCION", length = 30)
    private String descripcion;
    @Size(max = 10)
    @Column(name = "VALORUNITARIO", length = 10)
    private String valorunitario;
    @Size(max = 10)
    @Column(name = "VALORTOTAL", length = 10)
    private String valortotal;
    @Size(max = 10)
    @Column(name = "SUBTOTAL", length = 10)
    private String subtotal;
    @Size(max = 10)
    @Column(name = "DESCUENTO", length = 10)
    private String descuento;
    @Size(max = 10)
    @Column(name = "TOTAL", length = 10)
    private String total;
    @JoinColumn(name = "CODIGOPRODUCTO", referencedColumnName = "CODIGOPRODUCTO")
    @ManyToOne
    private Producto codigoproducto;
    @JoinColumn(name = "CODIGOFACTURA", referencedColumnName = "CODIGOFACTURA")
    @ManyToOne
    private Factura codigofactura;

    public Detalle() {
    }

    public Detalle(String codigodetalle) {
        this.codigodetalle = codigodetalle;
    }

    public String getCodigodetalle() {
        return codigodetalle;
    }

    public void setCodigodetalle(String codigodetalle) {
        this.codigodetalle = codigodetalle;
    }

    public String getCantidad() {
        return cantidad;
    }

    public void setCantidad(String cantidad) {
        this.cantidad = cantidad;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getValorunitario() {
        return valorunitario;
    }

    public void setValorunitario(String valorunitario) {
        this.valorunitario = valorunitario;
    }

    public String getValortotal() {
        return valortotal;
    }

    public void setValortotal(String valortotal) {
        this.valortotal = valortotal;
    }

    public String getSubtotal() {
        return subtotal;
    }

    public void setSubtotal(String subtotal) {
        this.subtotal = subtotal;
    }

    public String getDescuento() {
        return descuento;
    }

    public void setDescuento(String descuento) {
        this.descuento = descuento;
    }

    public String getTotal() {
        return total;
    }

    public void setTotal(String total) {
        this.total = total;
    }

    public Producto getCodigoproducto() {
        return codigoproducto;
    }

    public void setCodigoproducto(Producto codigoproducto) {
        this.codigoproducto = codigoproducto;
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
        hash += (codigodetalle != null ? codigodetalle.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Detalle)) {
            return false;
        }
        Detalle other = (Detalle) object;
        if ((this.codigodetalle == null && other.codigodetalle != null) || (this.codigodetalle != null && !this.codigodetalle.equals(other.codigodetalle))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ec.edu.espe.distribuidas.proyecto.modelo.Detalle[ codigodetalle=" + codigodetalle + " ]";
    }
    
}
