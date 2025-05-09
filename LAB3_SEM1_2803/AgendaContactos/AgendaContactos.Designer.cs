namespace LAB3_SEM1_2803.AgendaContactos
{
    partial class frmAgenda
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
            this.tvContactos = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNuevoNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreAct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidoAct = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtApellidoEliminar = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.optCorreo = new System.Windows.Forms.RadioButton();
            this.optNumero = new System.Windows.Forms.RadioButton();
            this.optNombre = new System.Windows.Forms.RadioButton();
            this.btnBuscarOpt = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.optVCard = new System.Windows.Forms.RadioButton();
            this.optCsv = new System.Windows.Forms.RadioButton();
            this.btnExportar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvContactos
            // 
            this.tvContactos.Location = new System.Drawing.Point(238, 177);
            this.tvContactos.Name = "tvContactos";
            this.tvContactos.Size = new System.Drawing.Size(321, 213);
            this.tvContactos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgendar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(220, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo contacto";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(92, 204);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(121, 29);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Categoria";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo E";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(92, 99);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(92, 59);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(92, 139);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(121, 20);
            this.txtCorreo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(92, 177);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNuevoNumero);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNombreAct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtApellidoAct);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizar numero";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(83, 125);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(121, 29);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nuevo num";
            // 
            // txtNuevoNumero
            // 
            this.txtNuevoNumero.Location = new System.Drawing.Point(83, 99);
            this.txtNuevoNumero.Name = "txtNuevoNumero";
            this.txtNuevoNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNuevoNumero.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Apellido";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.Location = new System.Drawing.Point(83, 18);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.Size = new System.Drawing.Size(121, 20);
            this.txtNombreAct.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre";
            // 
            // txtApellidoAct
            // 
            this.txtApellidoAct.Location = new System.Drawing.Point(83, 58);
            this.txtApellidoAct.Name = "txtApellidoAct";
            this.txtApellidoAct.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoAct.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtNombreEliminar);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtApellidoEliminar);
            this.groupBox3.Location = new System.Drawing.Point(12, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 134);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar numero";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(92, 84);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 29);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Apellido";
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Location = new System.Drawing.Point(92, 19);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(121, 20);
            this.txtNombreEliminar.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nombre";
            // 
            // txtApellidoEliminar
            // 
            this.txtApellidoEliminar.Location = new System.Drawing.Point(92, 58);
            this.txtApellidoEliminar.Name = "txtApellidoEliminar";
            this.txtApellidoEliminar.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoEliminar.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.optCorreo);
            this.groupBox4.Controls.Add(this.optNumero);
            this.groupBox4.Controls.Add(this.optNombre);
            this.groupBox4.Controls.Add(this.btnBuscarOpt);
            this.groupBox4.Controls.Add(this.btnTodos);
            this.groupBox4.Controls.Add(this.txtDato);
            this.groupBox4.Location = new System.Drawing.Point(456, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 159);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda";
            // 
            // optCorreo
            // 
            this.optCorreo.AutoSize = true;
            this.optCorreo.Location = new System.Drawing.Point(18, 74);
            this.optCorreo.Name = "optCorreo";
            this.optCorreo.Size = new System.Drawing.Size(56, 17);
            this.optCorreo.TabIndex = 16;
            this.optCorreo.TabStop = true;
            this.optCorreo.Text = "Correo";
            this.optCorreo.UseVisualStyleBackColor = true;
            // 
            // optNumero
            // 
            this.optNumero.AutoSize = true;
            this.optNumero.Location = new System.Drawing.Point(18, 50);
            this.optNumero.Name = "optNumero";
            this.optNumero.Size = new System.Drawing.Size(62, 17);
            this.optNumero.TabIndex = 15;
            this.optNumero.TabStop = true;
            this.optNumero.Text = "Numero";
            this.optNumero.UseVisualStyleBackColor = true;
            // 
            // optNombre
            // 
            this.optNombre.AutoSize = true;
            this.optNombre.Location = new System.Drawing.Point(18, 26);
            this.optNombre.Name = "optNombre";
            this.optNombre.Size = new System.Drawing.Size(62, 17);
            this.optNombre.TabIndex = 14;
            this.optNombre.TabStop = true;
            this.optNombre.Text = "Nombre";
            this.optNombre.UseVisualStyleBackColor = true;
            // 
            // btnBuscarOpt
            // 
            this.btnBuscarOpt.Location = new System.Drawing.Point(107, 124);
            this.btnBuscarOpt.Name = "btnBuscarOpt";
            this.btnBuscarOpt.Size = new System.Drawing.Size(97, 29);
            this.btnBuscarOpt.TabIndex = 13;
            this.btnBuscarOpt.Text = "Buscar";
            this.btnBuscarOpt.UseVisualStyleBackColor = true;
            this.btnBuscarOpt.Click += new System.EventHandler(this.btnBuscarOpt_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(6, 125);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(97, 29);
            this.btnTodos.TabIndex = 12;
            this.btnTodos.Text = "Mostrar todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(18, 98);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(121, 20);
            this.txtDato.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.optVCard);
            this.groupBox5.Controls.Add(this.optCsv);
            this.groupBox5.Controls.Add(this.btnExportar);
            this.groupBox5.Location = new System.Drawing.Point(672, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(115, 119);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exportar";
            // 
            // optVCard
            // 
            this.optVCard.AutoSize = true;
            this.optVCard.Location = new System.Drawing.Point(18, 50);
            this.optVCard.Name = "optVCard";
            this.optVCard.Size = new System.Drawing.Size(53, 17);
            this.optVCard.TabIndex = 15;
            this.optVCard.TabStop = true;
            this.optVCard.Text = "vCard";
            this.optVCard.UseVisualStyleBackColor = true;
            // 
            // optCsv
            // 
            this.optCsv.AutoSize = true;
            this.optCsv.Location = new System.Drawing.Point(18, 26);
            this.optCsv.Name = "optCsv";
            this.optCsv.Size = new System.Drawing.Size(46, 17);
            this.optCsv.TabIndex = 14;
            this.optCsv.TabStop = true;
            this.optCsv.Text = "CSV";
            this.optCsv.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(6, 73);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(97, 29);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(793, 399);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tvContactos);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmAgenda";
            this.Text = "Agenda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvContactos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombreAct;
        private System.Windows.Forms.TextBox txtApellidoAct;
        private System.Windows.Forms.TextBox txtNuevoNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApellidoEliminar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton optCorreo;
        private System.Windows.Forms.RadioButton optNumero;
        private System.Windows.Forms.RadioButton optNombre;
        private System.Windows.Forms.Button btnBuscarOpt;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton optVCard;
        private System.Windows.Forms.RadioButton optCsv;
        private System.Windows.Forms.Button btnExportar;
    }
}