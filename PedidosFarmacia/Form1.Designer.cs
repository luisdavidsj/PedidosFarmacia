
namespace PedidosFarmacia
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedic = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbTipoMedic = new System.Windows.Forms.ComboBox();
            this.rbCof = new System.Windows.Forms.RadioButton();
            this.rbEmp = new System.Windows.Forms.RadioButton();
            this.rbCem = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSecundaria = new System.Windows.Forms.CheckBox();
            this.chkPrincipal = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitar pedido de medicamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del medicamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo del medicamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad del producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Distribuidor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sucursal:";
            // 
            // txtMedic
            // 
            this.txtMedic.Location = new System.Drawing.Point(255, 98);
            this.txtMedic.Name = "txtMedic";
            this.txtMedic.Size = new System.Drawing.Size(121, 20);
            this.txtMedic.TabIndex = 6;
            this.txtMedic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(255, 159);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // cbTipoMedic
            // 
            this.cbTipoMedic.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.form1BindingSource, "AcceptButton", true));
            this.cbTipoMedic.FormattingEnabled = true;
            this.cbTipoMedic.Items.AddRange(new object[] {
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo",
            "Antibiótico"});
            this.cbTipoMedic.Location = new System.Drawing.Point(255, 128);
            this.cbTipoMedic.Name = "cbTipoMedic";
            this.cbTipoMedic.Size = new System.Drawing.Size(121, 21);
            this.cbTipoMedic.TabIndex = 8;
            this.cbTipoMedic.Tag = "";
            // 
            // rbCof
            // 
            this.rbCof.AutoSize = true;
            this.rbCof.Location = new System.Drawing.Point(19, 19);
            this.rbCof.Name = "rbCof";
            this.rbCof.Size = new System.Drawing.Size(64, 17);
            this.rbCof.TabIndex = 9;
            this.rbCof.Text = "Cofarma";
            this.rbCof.UseVisualStyleBackColor = true;
            // 
            // rbEmp
            // 
            this.rbEmp.AutoSize = true;
            this.rbEmp.Location = new System.Drawing.Point(19, 42);
            this.rbEmp.Name = "rbEmp";
            this.rbEmp.Size = new System.Drawing.Size(78, 17);
            this.rbEmp.TabIndex = 10;
            this.rbEmp.Text = "Empsephar";
            this.rbEmp.UseVisualStyleBackColor = true;
            // 
            // rbCem
            // 
            this.rbCem.AutoSize = true;
            this.rbCem.Location = new System.Drawing.Point(19, 65);
            this.rbCem.Name = "rbCem";
            this.rbCem.Size = new System.Drawing.Size(64, 17);
            this.rbCem.TabIndex = 11;
            this.rbCem.Text = "Cemefar";
            this.rbCem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCof);
            this.groupBox1.Controls.Add(this.rbCem);
            this.groupBox1.Controls.Add(this.rbEmp);
            this.groupBox1.Location = new System.Drawing.Point(255, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona distribuidor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSecundaria);
            this.groupBox2.Controls.Add(this.chkPrincipal);
            this.groupBox2.Location = new System.Drawing.Point(255, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecciona sucursal:";
            // 
            // chkSecundaria
            // 
            this.chkSecundaria.AutoSize = true;
            this.chkSecundaria.Location = new System.Drawing.Point(19, 44);
            this.chkSecundaria.Name = "chkSecundaria";
            this.chkSecundaria.Size = new System.Drawing.Size(80, 17);
            this.chkSecundaria.TabIndex = 1;
            this.chkSecundaria.Text = "Secundaria";
            this.chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // chkPrincipal
            // 
            this.chkPrincipal.AutoSize = true;
            this.chkPrincipal.Location = new System.Drawing.Point(19, 20);
            this.chkPrincipal.Name = "chkPrincipal";
            this.chkPrincipal.Size = new System.Drawing.Size(66, 17);
            this.chkPrincipal.TabIndex = 0;
            this.chkPrincipal.Text = "Principal";
            this.chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(122, 415);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(203, 415);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(102, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar campos";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(PedidosFarmacia.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTipoMedic);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtMedic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Solicitud de medicamentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedic;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbTipoMedic;
        private System.Windows.Forms.RadioButton rbCof;
        private System.Windows.Forms.RadioButton rbEmp;
        private System.Windows.Forms.RadioButton rbCem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSecundaria;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}

