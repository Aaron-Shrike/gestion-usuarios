using Entidades;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
  public partial class frmPersonal : Form
  {

    #region "Singleton"

    private static frmPersonal frm;

    private frmPersonal()
    {
      InitializeComponent();
    }

    public static frmPersonal Crear(Form frmPadre )
    {
      if( frmPersonal.frm == null)
      {
        frmPersonal.frm = new frmPersonal()
        {
                                MdiParent = frmPadre,
                                WindowState = FormWindowState.Maximized
        };
      }
      frmPersonal.frm.BringToFront();

      return frmPersonal.frm;
    }

    private void frmPersonal_FormClosed(object sender, FormClosedEventArgs e)
    {
      frmPersonal.frm = null;
    }

    #endregion

    private Personal Actual;


    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      this.ActivarControles(true);
      this.LimpiarControles();
      this.Actual = null;
    }

    private void LimpiarControles()
    {
      this.txtDNI.Text = "";
      this.txtNombres.Text = "";
      this.txtApellidoPaterno.Text = "";
      this.txtApellidoMaterno.Text = "";
      this.txtCelular.Text = "";
      this.txtCorreo.Text = "";
      this.chkVigente.Checked = true;
      this.chkVigente.Enabled = false;
    }

    private void ActivarControles(bool estado)
    {
      this.gbEntidad.Enabled = estado;
      this.gbListado.Enabled = !estado;
      if (estado == true)
      {
        this.txtDNI.Focus();
      }
      else
      {
        this.btnListar.Focus();
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.ActivarControles(false);
    }

    private void btnListar_Click(object sender, EventArgs e)
    {
      RNPersonal rn = new RNPersonal();
      List<Personal> trabajadores;

      try
      {
        trabajadores = rn.Listar();
        this.dgvListado.DataSource = null;
        if (trabajadores.Count > 0)
        {
          this.dgvListado.AutoGenerateColumns = false;
          this.dgvListado.DataSource = trabajadores;
        }
        else
        {
          MessageBox.Show("No se encontraron trabajadores", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      RNPersonal rn;
      Personal trabajador;

      if (this.ValidateChildren() == true)
      {
        trabajador = this.CrearEntidad();
        rn = new RNPersonal();
        try
        {
          if (this.Actual == null)
          {
            rn.Registrar(trabajador);
          }
          else
          {
            //codigo se obtiene en la función crearEntidad
            rn.Actualizar(trabajador);
          }
          this.ActivarControles(false);
          this.btnListar.PerformClick();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
          trabajador = null;
          rn = null;
        }
      }
    }

    private Personal CrearEntidad()
    {
      Personal per = new Personal
      {
        DNI = this.txtDNI.Text,
        Nombres = this.txtNombres.Text,
        ApellidoPaterno = this.txtApellidoPaterno.Text,
        ApellidoMaterno = this.txtApellidoMaterno.Text,
        Celular = this.txtCelular.Text,
        Correo = this.txtCorreo.Text,
        FechaNacimiento = this.dtpFechaNacimiento.Value,
        Vigente = this.chkVigente.Checked
      };
      if (this.Actual != null)
      {
        per.Codigo = this.Actual.Codigo;
      }

      return per;
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (this.dgvListado.CurrentRow != null)
      {
        this.Actual = (Personal)this.dgvListado.CurrentRow.DataBoundItem;
        this.PresentarDatos();
      }
      else
      {
        MessageBox.Show("Debe seleccionar un trabajador", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void PresentarDatos()
    {
      RNPersonal rn = new RNPersonal();

      try
      {
        this.Actual = rn.Leer(this.Actual.Codigo);
        if (this.Actual != null)
        {
          this.txtDNI.Text = this.Actual.DNI;
          this.txtNombres.Text = this.Actual.Nombres;
          this.txtApellidoPaterno.Text = this.Actual.ApellidoPaterno;
          this.txtApellidoMaterno.Text = this.Actual.ApellidoMaterno;
          this.dtpFechaNacimiento.Value = this.Actual.FechaNacimiento;
          this.txtCelular.Text = this.Actual.Celular;
          this.txtCorreo.Text = this.Actual.Correo;
          this.chkVigente.Checked = this.Actual.Vigente;
          this.chkVigente.Enabled = true;
          this.ActivarControles(true);
        }
        else
        {
          MessageBox.Show("No se encontró el personal indicado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    
  }
}
