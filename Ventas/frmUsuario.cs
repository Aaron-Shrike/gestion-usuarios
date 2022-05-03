using Entidades;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
  public partial class frmUsuario : Form
  {

    private Usuario Actual;

    #region "Singleton"

    private static frmUsuario frm;

    private frmUsuario()
    {
      InitializeComponent();
    }

    public static frmUsuario Crear(Form frmPadre)
    {
      if (frmUsuario.frm == null)
      {
        frmUsuario.frm = new frmUsuario()
        {
          MdiParent = frmPadre,
          WindowState = FormWindowState.Maximized
        };
      }
      frmUsuario.frm.BringToFront();

      return frmUsuario.frm;
    }

    private void frmUsuario_FormClosed(object sender, FormClosedEventArgs e)
    {
      frmUsuario.frm = null;
    }


    #endregion

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
      this.cboPersonal.SelectedIndex = -1;
      this.txtNombre.Text = "";
      this.txtClave.Text = "";
      this.txtRepetir.Text = "";
      this.cboTipo.SelectedIndex = -1;
      this.chkVigente.Checked = true;
      this.chkVigente.Enabled = false;
    }

    private void ActivarControles(bool estado)
    {
      this.gbEntidad.Enabled = estado;
      this.gbListado.Enabled = !estado;
      if( estado == true)
      {
        this.cboPersonal.Focus();
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

    private void frmUsuario_Load(object sender, EventArgs e)
    {
      this.CargarDatos();
    }

    private void CargarDatos()
    {
      this.CargarPersonal();
    }

    private void CargarPersonal()
    {
      RNPersonal rn = new RNPersonal();
      List<Personal> trabajadores;
      try
      {
        trabajadores = rn.ListarVigentes();
        this.cboPersonal.DataSource = null;
        if( trabajadores.Count > 0)
        {
          this.cboPersonal.ValueMember = "Codigo";
          this.cboPersonal.DisplayMember = "NombreCompleto";
          this.cboPersonal.DataSource = trabajadores;
          this.cboPersonal.SelectedIndex = -1;
        }
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      RNUsuario rn;
      Usuario usuario;

      if( this.ValidateChildren() == true)
      {
        usuario = this.CrearEntidad();
        rn = new RNUsuario();
        try
        {
          if( this.Actual == null)
          {
            rn.Registrar(usuario);
          }
          else
          {
            rn.Actualizar(usuario);
            
          }
          this.ActivarControles(false);
          this.btnListar.PerformClick();
        }
        catch(Exception ex)
        {
          MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private Usuario CrearEntidad()
    {
            Usuario usu= new Usuario
            {
                Personal = (Personal)this.cboPersonal.SelectedItem,
                Nombre = this.txtNombre.Text,
                Clave = this.txtClave.Text,
                Tipo = this.cboTipo.Text.Substring(0,1),
                Vigente = this.chkVigente.Checked 
            };
            if(this.Actual!=null)
            {
                usu.Codigo = this.Actual.Codigo;
            }
            return usu;
    }

    private void btnListar_Click(object sender, EventArgs e)
    {
      RNUsuario rn = new RNUsuario();
      List<Usuario> usuarios;

      try
      {
        usuarios = rn.Listar();
        this.dgvListado.DataSource = null;
        if( usuarios.Count > 0)
        {
          this.dgvListado.AutoGenerateColumns = false;
          this.dgvListado.DataSource = usuarios;
        }
        else
        {
          MessageBox.Show("No se encontraron usuarios", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }catch(Exception ex) {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
      }
    }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Usuario)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNUsuario rn = new RNUsuario();

            try
            {
                this.Actual = rn.Leer(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    this.cboPersonal.Text = this.Actual.Personal.NombreCompleto;
                    this.txtNombre.Text = this.Actual.Nombre;
                    this.txtClave.Text = this.Actual.Clave;
                    this.txtRepetir.Text = this.Actual.Clave;
                    if (this.Actual.Tipo.Equals("A"))
                    {
                        this.cboTipo.SelectedIndex = 0;
                    }
                    else
                    {
                        this.cboTipo.SelectedIndex = 1;
                    }
                    this.chkVigente.Checked = this.Actual.Vigente;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
