namespace CapaPresentacion
{
    partial class Vehiculos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculos));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiartextbuscar = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtIdVehiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hgroupRegistros = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dgvVehiculos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hgroupRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hgroupRegistros.Panel)).BeginInit();
            this.hgroupRegistros.Panel.SuspendLayout();
            this.hgroupRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditar,
            this.toolStripSeparator1,
            this.btnGuardar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnLimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(925, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEditar
            // 
            this.btnEditar.CheckOnClick = true;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 22);
            this.btnEditar.Text = "ACTUALIZAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGuardar
            // 
            this.btnGuardar.CheckOnClick = true;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 22);
            this.btnGuardar.Text = "AGREGAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminar
            // 
            this.btnEliminar.CheckOnClick = true;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 22);
            this.btnEliminar.Text = "ELIMINAR (F4)";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.CheckOnClick = true;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 22);
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnLimpiartextbuscar
            // 
            this.btnLimpiartextbuscar.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.btnLimpiartextbuscar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.btnLimpiartextbuscar.UniqueName = "BB0612B0BBC04A72CEB9D04A2DCBA3AB";
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 25);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonHeaderGroup2);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.hgroupRegistros);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(925, 425);
            this.kryptonSplitContainer1.SplitterDistance = 364;
            this.kryptonSplitContainer1.TabIndex = 4;
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label9);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.cboxEstado);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label6);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtPrecio);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtAnio);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtIdVehiculo);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label4);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtMarca);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label3);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtModelo);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label1);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(364, 425);
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.LongText.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonHeaderGroup2.StateCommon.HeaderSecondary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.StateCommon.HeaderSecondary.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.kryptonHeaderGroup2.StateNormal.HeaderPrimary.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.kryptonHeaderGroup2.StateNormal.HeaderPrimary.Back.Color2 = System.Drawing.Color.LightSlateGray;
            this.kryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.StateNormal.HeaderSecondary.Back.Color1 = System.Drawing.SystemColors.InactiveCaption;
            this.kryptonHeaderGroup2.StateNormal.HeaderSecondary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.StateNormal.HeaderSecondary.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonHeaderGroup2.TabIndex = 1;
            this.kryptonHeaderGroup2.ValuesPrimary.Description = "Detalle Vehiculos";
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = null;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "Registros: 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(20, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Estado:";
            // 
            // cboxEstado
            // 
            this.cboxEstado.BackColor = System.Drawing.Color.White;
            this.cboxEstado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(34)))), ((int)(((byte)(118)))));
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cboxEstado.Location = new System.Drawing.Point(114, 231);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(238, 21);
            this.cboxEstado.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(20, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(114, 183);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(238, 27);
            this.txtPrecio.TabIndex = 25;
            // 
            // txtAnio
            // 
            this.txtAnio.BackColor = System.Drawing.Color.White;
            this.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Location = new System.Drawing.Point(114, 143);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(238, 27);
            this.txtAnio.TabIndex = 23;
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.BackColor = System.Drawing.Color.White;
            this.txtIdVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdVehiculo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVehiculo.Location = new System.Drawing.Point(114, 37);
            this.txtIdVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.Size = new System.Drawing.Size(238, 27);
            this.txtIdVehiculo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Año:";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.White;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(114, 73);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(238, 27);
            this.txtMarca.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.White;
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(114, 112);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(238, 27);
            this.txtModelo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id_Vehiculo:";
            // 
            // hgroupRegistros
            // 
            this.hgroupRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hgroupRegistros.Location = new System.Drawing.Point(0, 0);
            this.hgroupRegistros.Name = "hgroupRegistros";
            // 
            // hgroupRegistros.Panel
            // 
            this.hgroupRegistros.Panel.Controls.Add(this.dgvVehiculos);
            this.hgroupRegistros.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hgroupRegistros.Size = new System.Drawing.Size(556, 425);
            this.hgroupRegistros.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.hgroupRegistros.StateCommon.HeaderPrimary.Back.Color2 = System.Drawing.Color.LightSlateGray;
            this.hgroupRegistros.StateCommon.HeaderPrimary.Content.LongText.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.hgroupRegistros.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hgroupRegistros.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.hgroupRegistros.StateCommon.HeaderSecondary.Back.Color2 = System.Drawing.Color.LightSlateGray;
            this.hgroupRegistros.StateCommon.HeaderSecondary.Content.LongText.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.hgroupRegistros.StateCommon.HeaderSecondary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.hgroupRegistros.StateCommon.HeaderSecondary.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.hgroupRegistros.StateCommon.HeaderSecondary.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.hgroupRegistros.StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hgroupRegistros.StateCommon.HeaderSecondary.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.hgroupRegistros.StateCommon.HeaderSecondary.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.hgroupRegistros.StateNormal.HeaderPrimary.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.hgroupRegistros.StateNormal.HeaderPrimary.Back.Color2 = System.Drawing.Color.LightSlateGray;
            this.hgroupRegistros.StateNormal.HeaderPrimary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.hgroupRegistros.StateNormal.HeaderPrimary.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.hgroupRegistros.StateNormal.HeaderSecondary.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.hgroupRegistros.StateNormal.HeaderSecondary.Back.Color2 = System.Drawing.Color.LightSlateGray;
            this.hgroupRegistros.StateNormal.HeaderSecondary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.hgroupRegistros.StateNormal.HeaderSecondary.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.hgroupRegistros.StateNormal.HeaderSecondary.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.hgroupRegistros.TabIndex = 0;
            this.hgroupRegistros.ValuesPrimary.Description = "Listado de Vehiculos";
            this.hgroupRegistros.ValuesPrimary.Heading = "";
            this.hgroupRegistros.ValuesPrimary.Image = null;
            this.hgroupRegistros.ValuesSecondary.Heading = "Registros: 0";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToResizeRows = false;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehiculos.Location = new System.Drawing.Point(0, 0);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Palette = this.kryptonPalette1;
            this.dgvVehiculos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dgvVehiculos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvVehiculos.RowHeadersVisible = false;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(554, 381);
            this.dgvVehiculos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvVehiculos.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvVehiculos.StateNormal.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvVehiculos.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.dgvVehiculos.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvVehiculos.StatePressed.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvVehiculos.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.dgvVehiculos.StateSelected.HeaderColumn.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVehiculos.StateSelected.HeaderColumn.Back.Color2 = System.Drawing.SystemColors.InactiveCaption;
            this.dgvVehiculos.StateSelected.HeaderRow.Back.Color1 = System.Drawing.SystemColors.InactiveCaption;
            this.dgvVehiculos.StateSelected.HeaderRow.Back.Color2 = System.Drawing.SystemColors.InactiveCaption;
            this.dgvVehiculos.StateSelected.HeaderRow.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvVehiculos.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVehiculos.StateTracking.HeaderRow.Back.Color1 = System.Drawing.SystemColors.InactiveCaption;
            this.dgvVehiculos.StateTracking.HeaderRow.Back.Color2 = System.Drawing.SystemColors.InactiveCaption;
            this.dgvVehiculos.TabIndex = 2;
            this.dgvVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellClick);
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vehiculos";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Sistema Vehiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hgroupRegistros.Panel)).EndInit();
            this.hgroupRegistros.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hgroupRegistros)).EndInit();
            this.hgroupRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnLimpiartextbuscar;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hgroupRegistros;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvVehiculos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxEstado;
    }
}

