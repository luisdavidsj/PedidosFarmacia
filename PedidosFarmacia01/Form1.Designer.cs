
namespace PedidosFarmacia01
{
    partial class Form1
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNombreMedic = new System.Windows.Forms.TextBox();
            this.cbTipoMedic = new System.Windows.Forms.ComboBox();
            this.gbDist = new System.Windows.Forms.GroupBox();
            this.rbCem = new System.Windows.Forms.RadioButton();
            this.rbEmp = new System.Windows.Forms.RadioButton();
            this.rbCof = new System.Windows.Forms.RadioButton();
            this.gbSuc = new System.Windows.Forms.GroupBox();
            this.chkSecundaria = new System.Windows.Forms.CheckBox();
            this.chkPrincipal = new System.Windows.Forms.CheckBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDist.SuspendLayout();
            this.gbSuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(51, 308);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNombreMedic
            // 
            this.txtNombreMedic.Location = new System.Drawing.Point(184, 43);
            this.txtNombreMedic.Name = "txtNombreMedic";
            this.txtNombreMedic.Size = new System.Drawing.Size(200, 20);
            this.txtNombreMedic.TabIndex = 1;
            this.txtNombreMedic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMedic_KeyPress);
            // 
            // cbTipoMedic
            // 
            this.cbTipoMedic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMedic.FormattingEnabled = true;
            this.cbTipoMedic.Items.AddRange(new object[] {
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo",
            "Antibiótico"});
            this.cbTipoMedic.Location = new System.Drawing.Point(184, 69);
            this.cbTipoMedic.Name = "cbTipoMedic";
            this.cbTipoMedic.Size = new System.Drawing.Size(200, 21);
            this.cbTipoMedic.TabIndex = 2;
            // 
            // gbDist
            // 
            this.gbDist.Controls.Add(this.rbCem);
            this.gbDist.Controls.Add(this.rbEmp);
            this.gbDist.Controls.Add(this.rbCof);
            this.gbDist.Location = new System.Drawing.Point(184, 125);
            this.gbDist.Name = "gbDist";
            this.gbDist.Size = new System.Drawing.Size(200, 100);
            this.gbDist.TabIndex = 4;
            this.gbDist.TabStop = false;
            this.gbDist.Text = "Selecciona distribuidor";
            // 
            // rbCem
            // 
            this.rbCem.AutoSize = true;
            this.rbCem.Location = new System.Drawing.Point(7, 68);
            this.rbCem.Name = "rbCem";
            this.rbCem.Size = new System.Drawing.Size(64, 17);
            this.rbCem.TabIndex = 2;
            this.rbCem.TabStop = true;
            this.rbCem.Text = "Cemefar";
            this.rbCem.UseVisualStyleBackColor = true;
            // 
            // rbEmp
            // 
            this.rbEmp.AutoSize = true;
            this.rbEmp.Location = new System.Drawing.Point(7, 44);
            this.rbEmp.Name = "rbEmp";
            this.rbEmp.Size = new System.Drawing.Size(78, 17);
            this.rbEmp.TabIndex = 1;
            this.rbEmp.TabStop = true;
            this.rbEmp.Text = "Empsephar";
            this.rbEmp.UseVisualStyleBackColor = true;
            // 
            // rbCof
            // 
            this.rbCof.AutoSize = true;
            this.rbCof.Location = new System.Drawing.Point(7, 20);
            this.rbCof.Name = "rbCof";
            this.rbCof.Size = new System.Drawing.Size(64, 17);
            this.rbCof.TabIndex = 0;
            this.rbCof.TabStop = true;
            this.rbCof.Text = "Cofarma";
            this.rbCof.UseVisualStyleBackColor = true;
            // 
            // gbSuc
            // 
            this.gbSuc.Controls.Add(this.chkSecundaria);
            this.gbSuc.Controls.Add(this.chkPrincipal);
            this.gbSuc.Location = new System.Drawing.Point(184, 231);
            this.gbSuc.Name = "gbSuc";
            this.gbSuc.Size = new System.Drawing.Size(200, 71);
            this.gbSuc.TabIndex = 5;
            this.gbSuc.TabStop = false;
            this.gbSuc.Text = "Selecciona sucursal:";
            // 
            // chkSecundaria
            // 
            this.chkSecundaria.AutoSize = true;
            this.chkSecundaria.Location = new System.Drawing.Point(7, 44);
            this.chkSecundaria.Name = "chkSecundaria";
            this.chkSecundaria.Size = new System.Drawing.Size(80, 17);
            this.chkSecundaria.TabIndex = 1;
            this.chkSecundaria.Text = "Secundaria";
            this.chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // chkPrincipal
            // 
            this.chkPrincipal.AutoSize = true;
            this.chkPrincipal.Location = new System.Drawing.Point(7, 20);
            this.chkPrincipal.Name = "chkPrincipal";
            this.chkPrincipal.Size = new System.Drawing.Size(66, 17);
            this.chkPrincipal.TabIndex = 0;
            this.chkPrincipal.Text = "Principal";
            this.chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(132, 308);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(85, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar campos";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(184, 96);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del medicamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo del medicamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad del producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Distribuidor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sucursal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 365);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.gbSuc);
            this.Controls.Add(this.gbDist);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbTipoMedic);
            this.Controls.Add(this.txtNombreMedic);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "Form1";
            this.Text = "Solicitar medicamentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDist.ResumeLayout(false);
            this.gbDist.PerformLayout();
            this.gbSuc.ResumeLayout(false);
            this.gbSuc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNombreMedic;
        private System.Windows.Forms.ComboBox cbTipoMedic;
        private System.Windows.Forms.GroupBox gbDist;
        private System.Windows.Forms.RadioButton rbCem;
        private System.Windows.Forms.RadioButton rbEmp;
        private System.Windows.Forms.RadioButton rbCof;
        private System.Windows.Forms.GroupBox gbSuc;
        private System.Windows.Forms.CheckBox chkSecundaria;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

