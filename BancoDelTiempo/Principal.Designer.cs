namespace BancoDelTiempo
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.listViewServices = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Schedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateService = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.listViewMovements = new System.Windows.Forms.ListView();
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Horas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Servicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Beneficiario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateMovement = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSaludo = new System.Windows.Forms.Label();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewServices
            // 
            this.listViewServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.User,
            this.Tipo,
            this.Hours,
            this.Description,
            this.Schedule,
            this.Category});
            this.listViewServices.Location = new System.Drawing.Point(360, 182);
            this.listViewServices.Name = "listViewServices";
            this.listViewServices.Size = new System.Drawing.Size(546, 282);
            this.listViewServices.TabIndex = 20;
            this.listViewServices.UseCompatibleStateImageBehavior = false;
            this.listViewServices.View = System.Windows.Forms.View.Details;
            this.listViewServices.SelectedIndexChanged += new System.EventHandler(this.listViewServices_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 108;
            // 
            // Tipo
            // 
            this.Tipo.DisplayIndex = 1;
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 77;
            // 
            // Hours
            // 
            this.Hours.DisplayIndex = 2;
            this.Hours.Text = "Horas";
            this.Hours.Width = 73;
            // 
            // Description
            // 
            this.Description.DisplayIndex = 3;
            this.Description.Text = "Descripción";
            this.Description.Width = 107;
            // 
            // Schedule
            // 
            this.Schedule.DisplayIndex = 4;
            this.Schedule.Text = "Horario";
            // 
            // Category
            // 
            this.Category.DisplayIndex = 5;
            this.Category.Text = "Categoria";
            // 
            // btnCreateService
            // 
            this.btnCreateService.Location = new System.Drawing.Point(508, 23);
            this.btnCreateService.Name = "btnCreateService";
            this.btnCreateService.Size = new System.Drawing.Size(113, 36);
            this.btnCreateService.TabIndex = 21;
            this.btnCreateService.Text = "NUEVO SERVICIO";
            this.btnCreateService.UseVisualStyleBackColor = true;
            this.btnCreateService.Click += new System.EventHandler(this.btnCreateService_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(627, 23);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(82, 36);
            this.btnPerfil.TabIndex = 22;
            this.btnPerfil.Text = "MI PERFIL";
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // listViewMovements
            // 
            this.listViewMovements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Fecha,
            this.Horas,
            this.Servicio,
            this.Beneficiario});
            this.listViewMovements.Location = new System.Drawing.Point(17, 182);
            this.listViewMovements.Name = "listViewMovements";
            this.listViewMovements.Size = new System.Drawing.Size(303, 282);
            this.listViewMovements.TabIndex = 23;
            this.listViewMovements.UseCompatibleStateImageBehavior = false;
            this.listViewMovements.View = System.Windows.Forms.View.Details;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            // 
            // Horas
            // 
            this.Horas.Text = "Horas";
            // 
            // Servicio
            // 
            this.Servicio.Text = "Servicio";
            // 
            // Beneficiario
            // 
            this.Beneficiario.Text = "Beneficiario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "LISTADO DE SERVICIOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "DATOS DE LA CUENTA";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtBalance.Location = new System.Drawing.Point(177, 120);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(83, 36);
            this.txtBalance.TabIndex = 26;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBalance.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "SALDO TOTAL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "MOVIMIENTOS:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(569, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "BUSCAR SERVICIO:";
            // 
            // btnCreateMovement
            // 
            this.btnCreateMovement.Location = new System.Drawing.Point(360, 23);
            this.btnCreateMovement.Name = "btnCreateMovement";
            this.btnCreateMovement.Size = new System.Drawing.Size(142, 35);
            this.btnCreateMovement.TabIndex = 32;
            this.btnCreateMovement.Text = "NUEVO MOVIMIENTO";
            this.btnCreateMovement.UseVisualStyleBackColor = true;
            this.btnCreateMovement.Click += new System.EventHandler(this.btnCreateMovement_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "HORAS";
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaludo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSaludo.Location = new System.Drawing.Point(733, 32);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(60, 24);
            this.labelSaludo.TabIndex = 34;
            this.labelSaludo.Text = "label7";
            this.labelSaludo.Click += new System.EventHandler(this.labelSaludo_Click);
            // 
            // User
            // 
            this.User.DisplayIndex = 6;
            this.User.Text = "User";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 487);
            this.Controls.Add(this.labelSaludo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreateMovement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewMovements);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnCreateService);
            this.Controls.Add(this.listViewServices);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco del TIempo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewServices;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Hours;
        private System.Windows.Forms.Button btnCreateService;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.ListView listViewMovements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Schedule;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateMovement;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Horas;
        private System.Windows.Forms.ColumnHeader Servicio;
        private System.Windows.Forms.ColumnHeader Beneficiario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.ColumnHeader User;
    }
}

