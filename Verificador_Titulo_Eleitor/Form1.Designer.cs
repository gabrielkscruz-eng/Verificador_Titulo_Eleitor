namespace Verificador_Titulo_Eleitor
{
    partial class Verificador_Eleitor
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
            this.btn_verificar = new System.Windows.Forms.Button();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_verifica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_verificar
            // 
            this.btn_verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificar.Location = new System.Drawing.Point(221, 161);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(155, 54);
            this.btn_verificar.TabIndex = 0;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // txt_titulo
            // 
            this.txt_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(19, 106);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(566, 49);
            this.txt_titulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entre com seu titulo para ser verificado:";
            // 
            // lbl_verifica
            // 
            this.lbl_verifica.AutoSize = true;
            this.lbl_verifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verifica.Location = new System.Drawing.Point(140, 241);
            this.lbl_verifica.Name = "lbl_verifica";
            this.lbl_verifica.Size = new System.Drawing.Size(251, 37);
            this.lbl_verifica.TabIndex = 3;
            this.lbl_verifica.Text = "Titulo é vericado";
            // 
            // Verificador_Eleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 309);
            this.Controls.Add(this.lbl_verifica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.btn_verificar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Verificador_Eleitor";
            this.Text = "Verificador do Título de Eleitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Verificador_Eleitor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_verifica;
    }
}

