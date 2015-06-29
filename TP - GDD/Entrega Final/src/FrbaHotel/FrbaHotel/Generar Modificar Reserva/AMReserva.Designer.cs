namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class AMReserva
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpoBoxAlta = new System.Windows.Forms.GroupBox();
            this.btnEliminarHab = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.calendarioHasta = new System.Windows.Forms.MonthCalendar();
            this.calendarioDesde = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.gridHabSeleccionada = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorReserva = new System.Windows.Forms.TextBox();
            this.btnVerif = new System.Windows.Forms.Button();
            this.lblReserVal = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboHotel = new System.Windows.Forms.ComboBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.GridRegimen = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nmUpDnCantHuesp = new System.Windows.Forms.NumericUpDown();
            this.btnCalendarioHasta = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.btnCalendarioDesde = new System.Windows.Forms.Button();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.cboRegimen = new System.Windows.Forms.ComboBox();
            this.txtFechaCarga = new System.Windows.Forms.MaskedTextBox();
            this.Regimen = new System.Windows.Forms.Label();
            this.lblFechaCarga = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblCantHuespedes = new System.Windows.Forms.Label();
            this.txtNumeroReserva = new System.Windows.Forms.MaskedTextBox();
            this.lblNumRes = new System.Windows.Forms.Label();
            this.btnFindReserva = new System.Windows.Forms.Button();
            this.btnDatosClie = new System.Windows.Forms.Button();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHabSeleccionada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRegimen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDnCantHuesp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(816, 522);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 25);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar/Confirmar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 519);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.btnEliminarHab);
            this.gpoBoxAlta.Controls.Add(this.btnAgregar);
            this.gpoBoxAlta.Controls.Add(this.calendarioHasta);
            this.gpoBoxAlta.Controls.Add(this.calendarioDesde);
            this.gpoBoxAlta.Controls.Add(this.label3);
            this.gpoBoxAlta.Controls.Add(this.gridHabSeleccionada);
            this.gpoBoxAlta.Controls.Add(this.label2);
            this.gpoBoxAlta.Controls.Add(this.label1);
            this.gpoBoxAlta.Controls.Add(this.txtValorReserva);
            this.gpoBoxAlta.Controls.Add(this.btnVerif);
            this.gpoBoxAlta.Controls.Add(this.lblReserVal);
            this.gpoBoxAlta.Controls.Add(this.lblDolar);
            this.gpoBoxAlta.Controls.Add(this.txtValor);
            this.gpoBoxAlta.Controls.Add(this.cboHotel);
            this.gpoBoxAlta.Controls.Add(this.lblHotel);
            this.gpoBoxAlta.Controls.Add(this.lblValor);
            this.gpoBoxAlta.Controls.Add(this.GridRegimen);
            this.gpoBoxAlta.Controls.Add(this.nmUpDnCantHuesp);
            this.gpoBoxAlta.Controls.Add(this.btnCalendarioHasta);
            this.gpoBoxAlta.Controls.Add(this.lblHasta);
            this.gpoBoxAlta.Controls.Add(this.txtHasta);
            this.gpoBoxAlta.Controls.Add(this.btnCalendarioDesde);
            this.gpoBoxAlta.Controls.Add(this.txtDesde);
            this.gpoBoxAlta.Controls.Add(this.cboRegimen);
            this.gpoBoxAlta.Controls.Add(this.txtFechaCarga);
            this.gpoBoxAlta.Controls.Add(this.Regimen);
            this.gpoBoxAlta.Controls.Add(this.lblFechaCarga);
            this.gpoBoxAlta.Controls.Add(this.lblDesde);
            this.gpoBoxAlta.Controls.Add(this.lblCantHuespedes);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 52);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(965, 445);
            this.gpoBoxAlta.TabIndex = 7;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Datos de Reserva";
            // 
            // btnEliminarHab
            // 
            this.btnEliminarHab.Enabled = false;
            this.btnEliminarHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHab.Location = new System.Drawing.Point(487, 377);
            this.btnEliminarHab.Name = "btnEliminarHab";
            this.btnEliminarHab.Size = new System.Drawing.Size(94, 25);
            this.btnEliminarHab.TabIndex = 54;
            this.btnEliminarHab.Text = "Eliminar";
            this.btnEliminarHab.UseVisualStyleBackColor = true;
            this.btnEliminarHab.Click += new System.EventHandler(this.btnEliminarHab_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(16, 377);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 25);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // calendarioHasta
            // 
            this.calendarioHasta.Location = new System.Drawing.Point(704, 61);
            this.calendarioHasta.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.calendarioHasta.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.calendarioHasta.Name = "calendarioHasta";
            this.calendarioHasta.TabIndex = 38;
            this.calendarioHasta.Visible = false;
            this.calendarioHasta.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarioHasta_DateSelected);
            // 
            // calendarioDesde
            // 
            this.calendarioDesde.Location = new System.Drawing.Point(341, 61);
            this.calendarioDesde.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.calendarioDesde.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.calendarioDesde.Name = "calendarioDesde";
            this.calendarioDesde.TabIndex = 34;
            this.calendarioDesde.Visible = false;
            this.calendarioDesde.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarioDesde_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Habitaciones Seleccionadas:";
            // 
            // gridHabSeleccionada
            // 
            this.gridHabSeleccionada.AllowUserToAddRows = false;
            this.gridHabSeleccionada.AllowUserToDeleteRows = false;
            this.gridHabSeleccionada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHabSeleccionada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.gridHabSeleccionada.Enabled = false;
            this.gridHabSeleccionada.Location = new System.Drawing.Point(487, 208);
            this.gridHabSeleccionada.MultiSelect = false;
            this.gridHabSeleccionada.Name = "gridHabSeleccionada";
            this.gridHabSeleccionada.ReadOnly = true;
            this.gridHabSeleccionada.Size = new System.Drawing.Size(472, 153);
            this.gridHabSeleccionada.TabIndex = 51;
            this.gridHabSeleccionada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHabSeleccionada_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Informacion";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Habitaciones Disponibles:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(829, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "dll.";
            // 
            // txtValorReserva
            // 
            this.txtValorReserva.Enabled = false;
            this.txtValorReserva.Location = new System.Drawing.Point(627, 409);
            this.txtValorReserva.Name = "txtValorReserva";
            this.txtValorReserva.Size = new System.Drawing.Size(196, 23);
            this.txtValorReserva.TabIndex = 48;
            // 
            // btnVerif
            // 
            this.btnVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerif.Location = new System.Drawing.Point(262, 116);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(111, 49);
            this.btnVerif.TabIndex = 10;
            this.btnVerif.Text = "Verificar disponibilidad";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // lblReserVal
            // 
            this.lblReserVal.AutoSize = true;
            this.lblReserVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserVal.Location = new System.Drawing.Point(484, 411);
            this.lblReserVal.Name = "lblReserVal";
            this.lblReserVal.Size = new System.Drawing.Size(144, 20);
            this.lblReserVal.TabIndex = 46;
            this.lblReserVal.Text = "Valor de la reserva:";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(350, 411);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(28, 20);
            this.lblDolar.TabIndex = 45;
            this.lblDolar.Text = "dll.";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(235, 411);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(102, 23);
            this.txtValor.TabIndex = 44;
            // 
            // cboHotel
            // 
            this.cboHotel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHotel.FormattingEnabled = true;
            this.cboHotel.Items.AddRange(new object[] {
            "Exterior",
            "Interior"});
            this.cboHotel.Location = new System.Drawing.Point(63, 74);
            this.cboHotel.Name = "cboHotel";
            this.cboHotel.Size = new System.Drawing.Size(310, 24);
            this.cboHotel.TabIndex = 43;
            this.cboHotel.SelectedIndexChanged += new System.EventHandler(this.cboHotel_SelectedIndexChanged);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(0, 74);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(61, 20);
            this.lblHotel.TabIndex = 42;
            this.lblHotel.Text = "* Hotel:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(12, 411);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(217, 20);
            this.lblValor.TabIndex = 41;
            this.lblValor.Text = "Valor de la habitación por día:";
            // 
            // GridRegimen
            // 
            this.GridRegimen.AllowUserToAddRows = false;
            this.GridRegimen.AllowUserToDeleteRows = false;
            this.GridRegimen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRegimen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.GridRegimen.Location = new System.Drawing.Point(9, 208);
            this.GridRegimen.MultiSelect = false;
            this.GridRegimen.Name = "GridRegimen";
            this.GridRegimen.ReadOnly = true;
            this.GridRegimen.Size = new System.Drawing.Size(472, 153);
            this.GridRegimen.TabIndex = 40;
            this.GridRegimen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRegimen_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Informacion";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // nmUpDnCantHuesp
            // 
            this.nmUpDnCantHuesp.Enabled = false;
            this.nmUpDnCantHuesp.Location = new System.Drawing.Point(158, 117);
            this.nmUpDnCantHuesp.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmUpDnCantHuesp.Name = "nmUpDnCantHuesp";
            this.nmUpDnCantHuesp.Size = new System.Drawing.Size(61, 23);
            this.nmUpDnCantHuesp.TabIndex = 39;
            // 
            // btnCalendarioHasta
            // 
            this.btnCalendarioHasta.Enabled = false;
            this.btnCalendarioHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarioHasta.Location = new System.Drawing.Point(851, 31);
            this.btnCalendarioHasta.Name = "btnCalendarioHasta";
            this.btnCalendarioHasta.Size = new System.Drawing.Size(94, 25);
            this.btnCalendarioHasta.TabIndex = 37;
            this.btnCalendarioHasta.Text = "Seleccionar";
            this.btnCalendarioHasta.UseVisualStyleBackColor = true;
            this.btnCalendarioHasta.Click += new System.EventHandler(this.btnCalendarioHasta_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(626, 32);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(112, 20);
            this.lblHasta.TabIndex = 36;
            this.lblHasta.Text = "* Fecha hasta:";
            // 
            // txtHasta
            // 
            this.txtHasta.Enabled = false;
            this.txtHasta.Location = new System.Drawing.Point(752, 32);
            this.txtHasta.Mask = "00/00/0000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(93, 23);
            this.txtHasta.TabIndex = 35;
            this.txtHasta.ValidatingType = typeof(System.DateTime);
            // 
            // btnCalendarioDesde
            // 
            this.btnCalendarioDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarioDesde.Location = new System.Drawing.Point(501, 32);
            this.btnCalendarioDesde.Name = "btnCalendarioDesde";
            this.btnCalendarioDesde.Size = new System.Drawing.Size(94, 25);
            this.btnCalendarioDesde.TabIndex = 33;
            this.btnCalendarioDesde.Text = "Seleccionar";
            this.btnCalendarioDesde.UseVisualStyleBackColor = true;
            this.btnCalendarioDesde.Click += new System.EventHandler(this.btnCalendarioDesde_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.Enabled = false;
            this.txtDesde.Location = new System.Drawing.Point(389, 32);
            this.txtDesde.Mask = "00/00/0000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(93, 23);
            this.txtDesde.TabIndex = 32;
            this.txtDesde.ValidatingType = typeof(System.DateTime);
            // 
            // cboRegimen
            // 
            this.cboRegimen.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegimen.FormattingEnabled = true;
            this.cboRegimen.Items.AddRange(new object[] {
            "Exterior",
            "Interior"});
            this.cboRegimen.Location = new System.Drawing.Point(526, 74);
            this.cboRegimen.Name = "cboRegimen";
            this.cboRegimen.Size = new System.Drawing.Size(202, 24);
            this.cboRegimen.TabIndex = 30;
            // 
            // txtFechaCarga
            // 
            this.txtFechaCarga.Enabled = false;
            this.txtFechaCarga.Location = new System.Drawing.Point(136, 32);
            this.txtFechaCarga.Mask = "00/00/0000";
            this.txtFechaCarga.Name = "txtFechaCarga";
            this.txtFechaCarga.Size = new System.Drawing.Size(93, 23);
            this.txtFechaCarga.TabIndex = 28;
            this.txtFechaCarga.ValidatingType = typeof(System.DateTime);
            // 
            // Regimen
            // 
            this.Regimen.AutoSize = true;
            this.Regimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regimen.Location = new System.Drawing.Point(433, 74);
            this.Regimen.Name = "Regimen";
            this.Regimen.Size = new System.Drawing.Size(87, 20);
            this.Regimen.TabIndex = 19;
            this.Regimen.Text = "* Regimen:";
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCarga.Location = new System.Drawing.Point(6, 32);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(124, 20);
            this.lblFechaCarga.TabIndex = 18;
            this.lblFechaCarga.Text = "Fecha de carga:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(267, 33);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(116, 20);
            this.lblDesde.TabIndex = 14;
            this.lblDesde.Text = "* Fecha desde:";
            // 
            // lblCantHuespedes
            // 
            this.lblCantHuespedes.AutoSize = true;
            this.lblCantHuespedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantHuespedes.Location = new System.Drawing.Point(5, 116);
            this.lblCantHuespedes.Name = "lblCantHuespedes";
            this.lblCantHuespedes.Size = new System.Drawing.Size(147, 20);
            this.lblCantHuespedes.TabIndex = 2;
            this.lblCantHuespedes.Text = "* Cant. Huespedes:";
            // 
            // txtNumeroReserva
            // 
            this.txtNumeroReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroReserva.Location = new System.Drawing.Point(198, 17);
            this.txtNumeroReserva.Mask = "999999999";
            this.txtNumeroReserva.Name = "txtNumeroReserva";
            this.txtNumeroReserva.Size = new System.Drawing.Size(87, 24);
            this.txtNumeroReserva.TabIndex = 30;
            // 
            // lblNumRes
            // 
            this.lblNumRes.AutoSize = true;
            this.lblNumRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRes.Location = new System.Drawing.Point(19, 20);
            this.lblNumRes.Name = "lblNumRes";
            this.lblNumRes.Size = new System.Drawing.Size(157, 18);
            this.lblNumRes.TabIndex = 29;
            this.lblNumRes.Text = "Número de reserva:";
            // 
            // btnFindReserva
            // 
            this.btnFindReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindReserva.Location = new System.Drawing.Point(301, 18);
            this.btnFindReserva.Name = "btnFindReserva";
            this.btnFindReserva.Size = new System.Drawing.Size(94, 25);
            this.btnFindReserva.TabIndex = 54;
            this.btnFindReserva.Text = "Buscar";
            this.btnFindReserva.UseVisualStyleBackColor = true;
            this.btnFindReserva.Click += new System.EventHandler(this.btnFindReserva_Click);
            // 
            // btnDatosClie
            // 
            this.btnDatosClie.Enabled = false;
            this.btnDatosClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosClie.Location = new System.Drawing.Point(658, 522);
            this.btnDatosClie.Name = "btnDatosClie";
            this.btnDatosClie.Size = new System.Drawing.Size(152, 25);
            this.btnDatosClie.TabIndex = 55;
            this.btnDatosClie.Text = "Datos Cliente";
            this.btnDatosClie.UseVisualStyleBackColor = true;
            this.btnDatosClie.Click += new System.EventHandler(this.btnDatosClie_Click);
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarReserva.Location = new System.Drawing.Point(401, 18);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(152, 25);
            this.btnModificarReserva.TabIndex = 56;
            this.btnModificarReserva.Text = "Modificar Reserva";
            this.btnModificarReserva.UseVisualStyleBackColor = true;
            this.btnModificarReserva.Visible = false;
            this.btnModificarReserva.Click += new System.EventHandler(this.btnModificarReserva_Click);
            // 
            // AMReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 559);
            this.Controls.Add(this.btnModificarReserva);
            this.Controls.Add(this.btnDatosClie);
            this.Controls.Add(this.btnFindReserva);
            this.Controls.Add(this.txtNumeroReserva);
            this.Controls.Add(this.lblNumRes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "AMReserva";
            this.Text = "Generar o modificar Reserva";
            this.Load += new System.EventHandler(this.AMReserva_Load);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHabSeleccionada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRegimen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDnCantHuesp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.ComboBox cboRegimen;
        private System.Windows.Forms.MaskedTextBox txtFechaCarga;
        private System.Windows.Forms.Label Regimen;
        private System.Windows.Forms.Label lblFechaCarga;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblCantHuespedes;
        private System.Windows.Forms.Button btnCalendarioDesde;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.MonthCalendar calendarioHasta;
        private System.Windows.Forms.Button btnCalendarioHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.MonthCalendar calendarioDesde;
        private System.Windows.Forms.NumericUpDown nmUpDnCantHuesp;
        private System.Windows.Forms.DataGridView GridRegimen;
        private System.Windows.Forms.ComboBox cboHotel;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorReserva;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.Label lblReserVal;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridHabSeleccionada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.MaskedTextBox txtNumeroReserva;
        private System.Windows.Forms.Label lblNumRes;
        private System.Windows.Forms.Button btnFindReserva;
        private System.Windows.Forms.Button btnDatosClie;
        private System.Windows.Forms.Button btnEliminarHab;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Button btnModificarReserva;
    }
}