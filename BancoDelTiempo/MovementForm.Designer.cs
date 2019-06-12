namespace BancoDelTiempo
{
    partial class MovementForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateMovement = new System.Windows.Forms.DateTimePicker();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtFromUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dar de alta un movimiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateMovement
            // 
            this.dateMovement.Location = new System.Drawing.Point(219, 102);
            this.dateMovement.Name = "dateMovement";
            this.dateMovement.Size = new System.Drawing.Size(200, 20);
            this.dateMovement.TabIndex = 22;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(219, 143);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Horas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Servicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Beneficiario:";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(219, 183);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(100, 20);
            this.txtService.TabIndex = 28;
            // 
            // txtFromUser
            // 
            this.txtFromUser.Location = new System.Drawing.Point(219, 225);
            this.txtFromUser.Name = "txtFromUser";
            this.txtFromUser.Size = new System.Drawing.Size(100, 20);
            this.txtFromUser.TabIndex = 29;
            // 
            // MovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 338);
            this.Controls.Add(this.txtFromUser);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.dateMovement);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MovementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de alta movimiento";
            this.Load += new System.EventHandler(this.MovementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateMovement;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtFromUser;
    }
}