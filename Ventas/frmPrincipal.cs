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
  public partial class frmPrincipal : Form
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void mnuPersonal_Click(object sender, EventArgs e)
    {
      frmPersonal frm = frmPersonal.Crear(this);

      frm.Show();
    }

    private void mnuUsuario_Click(object sender, EventArgs e)
    {
      frmUsuario  frm = frmUsuario.Crear(this);

      frm.Show();
    }
  }
}
