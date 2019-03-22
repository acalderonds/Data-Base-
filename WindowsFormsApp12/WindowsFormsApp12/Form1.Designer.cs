namespace WindowsFormsApp12
{
    partial class frm_cargardatos
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btndatos = new System.Windows.Forms.Button();
            this.dgv_resul = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resul)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(54, 29);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btndatos
            // 
            this.btndatos.Location = new System.Drawing.Point(198, 29);
            this.btndatos.Name = "btndatos";
            this.btndatos.Size = new System.Drawing.Size(75, 23);
            this.btndatos.TabIndex = 1;
            this.btndatos.Text = "DATOS";
            this.btndatos.UseVisualStyleBackColor = true;
            //this.btndatos.Click += new System.EventHandler(this.btndatos.Click);
            // 
            // dgv_resul
            // 
            this.dgv_resul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resul.Location = new System.Drawing.Point(54, 88);
            this.dgv_resul.Name = "dgv_resul";
            this.dgv_resul.Size = new System.Drawing.Size(240, 150);
            this.dgv_resul.TabIndex = 2;
            // 
            // frm_cargardatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_resul);
            this.Controls.Add(this.btndatos);
            this.Controls.Add(this.btn_buscar);
            this.Name = "frm_cargardatos";
            this.Text = "Cargardatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resul)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btndatos;
        private System.Windows.Forms.DataGridView dgv_resul;
    }
}

