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
@Table(name = "reserva", catalog = "joyeria", schema = "")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Reserva.findAll", query = "SELECT r FROM Reserva r"),
    @NamedQuery(name = "Reserva.findByCodigoreserva", query = "SELECT r FROM Reserva r WHERE r.codigoreserva = :codigoreserva"),
    @NamedQuery(name = "Reserva.findByDescripcionreserva", query = "SELECT r FROM Reserva r WHERE r.descripcionreserva = :descripcionreserva")})
public class Reserva implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 5)
    @Column(name = "CODIGORESERVA", nullable = false, length = 5)
    private String codigoreserva;
    @Size(max = 40)
    @Column(name = "DESCRIPCIONRESERVA", length = 40)
    private String descripcionreserva;
    @JoinColumn(name = "CODIGO", referencedColumnName = "CODIGO")
    @ManyToOne
    private Usuario codigo;
    @JoinColumn(name = "CODIGOPRODUCTO", referencedColumnName = "CODIGOPRODUCTO")
    @ManyToOne
    private Producto codigoproducto;

    public Reserva() {
    }

    public Reserva(String codigoreserva) {
        this.codigoreserva = codigoreserva;
    }

    public String getCodigoreserva() {
        return codigoreserva;
    }

    public void setCodigoreserva(String codigoreserva) {
        this.codigoreserva = codigoreserva;
    }

    public String getDescripcionreserva() {
        return descripcionreserva;
    }

    public void setDescripcionreserva(String descripcionreserva) {
        this.descripcionreserva = descripcionreserva;
    }

    public Usuario getCodigo() {
        return codigo;
    }

    public void setCodigo(Usuario codigo) {
        this.codigo = codigo;
    }

    public Producto getCodigoproducto() {
        return codigoproducto;
    }

    public void setCodigoproducto(Producto codigoproducto) {
        this.codigoproducto = codigoproducto;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (codigoreserva != null ? codigoreserva.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Reserva)) {
            return false;
        }
        Reserva other = (Reserva) object;
        if ((this.codigoreserva == null && other.codigoreserva != null) || (this.codigoreserva != null && !this.codigoreserva.equals(other.codigoreserva))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ec.edu.espe.distribuidas.proyecto.modelo.Reserva[ codigoreserva=" + codigoreserva + " ]";
    }
    
}
