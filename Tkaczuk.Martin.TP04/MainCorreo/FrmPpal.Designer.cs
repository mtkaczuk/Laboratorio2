namespace MainCorreo
{
    partial class FrmPpal
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
            this.components = new System.ComponentModel.Container();
            this.grpPaquete = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpEstadosPaquetes = new System.Windows.Forms.GroupBox();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.grpPaquete.SuspendLayout();
            this.grpEstadosPaquetes.SuspendLayout();
            this.cmsListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPaquete
            // 
            this.grpPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPaquete.Controls.Add(this.lblDireccion);
            this.grpPaquete.Controls.Add(this.mtxtTrackingID);
            this.grpPaquete.Controls.Add(this.lblTrackingID);
            this.grpPaquete.Controls.Add(this.txtDireccion);
            this.grpPaquete.Controls.Add(this.btnMostrarTodos);
            this.grpPaquete.Controls.Add(this.btnAgregar);
            this.grpPaquete.Location = new System.Drawing.Point(443, 302);
            this.grpPaquete.Name = "grpPaquete";
            this.grpPaquete.Size = new System.Drawing.Size(287, 125);
            this.grpPaquete.TabIndex = 0;
            this.grpPaquete.TabStop = false;
            this.grpPaquete.Text = "Paquete";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(9, 66);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(6, 39);
            this.mtxtTrackingID.Mask = "000-000-0000";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(163, 20);
            this.mtxtTrackingID.TabIndex = 0;
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Location = new System.Drawing.Point(9, 24);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(63, 13);
            this.lblTrackingID.TabIndex = 3;
            this.lblTrackingID.Text = "Tracking ID";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 82);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(163, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(175, 66);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(101, 36);
            this.btnMostrarTodos.TabIndex = 3;
            this.btnMostrarTodos.Text = "&Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(175, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpEstadosPaquetes
            // 
            this.grpEstadosPaquetes.Controls.Add(this.lblEstadoEntregado);
            this.grpEstadosPaquetes.Controls.Add(this.lblEstadoEnViaje);
            this.grpEstadosPaquetes.Controls.Add(this.lblEstadoIngresado);
            this.grpEstadosPaquetes.Controls.Add(this.lstEstadoEntregado);
            this.grpEstadosPaquetes.Controls.Add(this.lstEstadoEnViaje);
            this.grpEstadosPaquetes.Controls.Add(this.lstEstadoIngresado);
            this.grpEstadosPaquetes.Location = new System.Drawing.Point(12, 12);
            this.grpEstadosPaquetes.Name = "grpEstadosPaquetes";
            this.grpEstadosPaquetes.Size = new System.Drawing.Size(718, 284);
            this.grpEstadosPaquetes.TabIndex = 1;
            this.grpEstadosPaquetes.TabStop = false;
            this.grpEstadosPaquetes.Text = "Estados Paquetes";
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(502, 39);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEstadoEntregado.TabIndex = 5;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(261, 39);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoEnViaje.TabIndex = 4;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(18, 39);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblEstadoIngresado.TabIndex = 3;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.ContextMenuStrip = this.cmsListas;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(494, 58);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(213, 212);
            this.lstEstadoEntregado.TabIndex = 2;
            this.lstEstadoEntregado.TabStop = false;
            // 
            // cmsListas
            // 
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.cmsListas.Name = "cmsListas";
            this.cmsListas.Size = new System.Drawing.Size(125, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar...";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(253, 58);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(213, 212);
            this.lstEstadoEnViaje.TabIndex = 1;
            this.lstEstadoEnViaje.TabStop = false;
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(11, 58);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(213, 212);
            this.lstEstadoIngresado.TabIndex = 0;
            this.lstEstadoIngresado.TabStop = false;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Enabled = false;
            this.rtbMostrar.Location = new System.Drawing.Point(12, 302);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(425, 125);
            this.rtbMostrar.TabIndex = 3;
            this.rtbMostrar.Text = "";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 439);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.grpEstadosPaquetes);
            this.Controls.Add(this.grpPaquete);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Martin.Tkaczuk.2D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.grpPaquete.ResumeLayout(false);
            this.grpPaquete.PerformLayout();
            this.grpEstadosPaquetes.ResumeLayout(false);
            this.grpEstadosPaquetes.PerformLayout();
            this.cmsListas.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.GroupBox grpPaquete;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.GroupBox grpEstadosPaquetes;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}



