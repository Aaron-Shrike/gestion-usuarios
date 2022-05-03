namespace Ventas
{
  partial class frmPrincipal
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.Ribbon();
            this.tabDatos = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnPersonal = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.btnUsuario = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.CaptionBarVisible = false;
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Minimized = false;
            this.mnuPrincipal.Name = "mnuPrincipal";
            // 
            // 
            // 
            this.mnuPrincipal.OrbDropDown.BorderRoundness = 8;
            this.mnuPrincipal.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.OrbDropDown.Name = "";
            this.mnuPrincipal.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.mnuPrincipal.OrbDropDown.TabIndex = 0;
            this.mnuPrincipal.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010_Extended;
            this.mnuPrincipal.OrbVisible = false;
            this.mnuPrincipal.RibbonTabFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 109);
            this.mnuPrincipal.TabIndex = 2;
            this.mnuPrincipal.Tabs.Add(this.tabDatos);
            this.mnuPrincipal.TabSpacing = 3;
            // 
            // tabDatos
            // 
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Panels.Add(this.ribbonPanel1);
            this.tabDatos.Text = "Datos";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.btnPersonal);
            this.ribbonPanel1.Items.Add(this.ribbonSeparator1);
            this.ribbonPanel1.Items.Add(this.btnUsuario);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Gestionar";
            // 
            // btnPersonal
            // 
            this.btnPersonal.Image = global::Ventas.Properties.Resources.Google_Noto_Emoji_People_Profession_10526_woman_construction_worker_light_skin_tone;
            this.btnPersonal.LargeImage = global::Ventas.Properties.Resources.Google_Noto_Emoji_People_Profession_10526_woman_construction_worker_light_skin_tone;
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPersonal.SmallImage")));
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.Click += new System.EventHandler(this.mnuPersonal_Click);
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Image = global::Ventas.Properties.Resources.Aha_Soft_Free_Large_Boss_Admin;
            this.btnUsuario.LargeImage = global::Ventas.Properties.Resources.Aha_Soft_Free_Large_Boss_Admin;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnUsuario.SmallImage")));
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.Click += new System.EventHandler(this.mnuUsuario_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Ribbon mnuPrincipal;
        private System.Windows.Forms.RibbonTab tabDatos;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnPersonal;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonButton btnUsuario;
    }
}