namespace WindowsFormsApp12
{
    partial class Busqueda
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
            this.listb_bd = new System.Windows.Forms.ListBox();
            this.listb_tablas = new System.Windows.Forms.ListBox();
            this.lbl_basededatos = new System.Windows.Forms.Label();
            this.lbl_tablas = new System.Windows.Forms.Label();
            this.btnreturn = new System.Windows.Forms.Button();
            this.listb_vistas = new System.Windows.Forms.ListBox();
            this.lbl_vistas = new System.Windows.Forms.Label();
            this.lbl_storeprocedure = new System.Windows.Forms.Label();
            this.listb_storeprocedure = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listb_bd
            // 
            this.listb_bd.FormattingEnabled = true;
            this.listb_bd.Location = new System.Drawing.Point(197, 42);
            this.listb_bd.Name = "listb_bd";
            this.listb_bd.Size = new System.Drawing.Size(154, 30);
            this.listb_bd.TabIndex = 0;
            this.listb_bd.SelectedIndexChanged += new System.EventHandler(this.listb_bd_SelectedIndexChanged);
            // 
            // listb_tablas
            // 
            this.listb_tablas.FormattingEnabled = true;
            this.listb_tablas.Location = new System.Drawing.Point(197, 99);
            this.listb_tablas.Name = "listb_tablas";
            this.listb_tablas.Size = new System.Drawing.Size(154, 30);
            this.listb_tablas.TabIndex = 1;
            // 
            // lbl_basededatos
            // 
            this.lbl_basededatos.AutoSize = true;
            this.lbl_basededatos.Location = new System.Drawing.Point(73, 59);
            this.lbl_basededatos.Name = "lbl_basededatos";
            this.lbl_basededatos.Size = new System.Drawing.Size(96, 13);
            this.lbl_basededatos.TabIndex = 2;
            this.lbl_basededatos.Text = "BASE DE DATOS ";
            // 
            // lbl_tablas
            // 
            this.lbl_tablas.AutoSize = true;
            this.lbl_tablas.Location = new System.Drawing.Point(76, 116);
            this.lbl_tablas.Name = "lbl_tablas";
            this.lbl_tablas.Size = new System.Drawing.Size(48, 13);
            this.lbl_tablas.TabIndex = 3;
            this.lbl_tablas.Text = "TABLAS";
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(617, 13);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(75, 23);
            this.btnreturn.TabIndex = 4;
            this.btnreturn.Text = "RETURN";
            this.btnreturn.UseVisualStyleBackColor = true;
            // 
            // listb_vistas
            // 
            this.listb_vistas.FormattingEnabled = true;
            this.listb_vistas.Location = new System.Drawing.Point(197, 158);
            this.listb_vistas.Name = "listb_vistas";
            this.listb_vistas.Size = new System.Drawing.Size(154, 30);
            this.listb_vistas.TabIndex = 5;
            this.listb_vistas.SelectedIndexChanged += new System.EventHandler(this.listb_vistas_SelectedIndexChanged);
            // 
            // lbl_vistas
            // 
            this.lbl_vistas.AutoSize = true;
            this.lbl_vistas.Location = new System.Drawing.Point(76, 158);
            this.lbl_vistas.Name = "lbl_vistas";
            this.lbl_vistas.Size = new System.Drawing.Size(45, 13);
            this.lbl_vistas.TabIndex = 6;
            this.lbl_vistas.Text = "VISTAS";
            // 
            // lbl_storeprocedure
            // 
            this.lbl_storeprocedure.AutoSize = true;
            this.lbl_storeprocedure.Location = new System.Drawing.Point(73, 202);
            this.lbl_storeprocedure.Name = "lbl_storeprocedure";
            this.lbl_storeprocedure.Size = new System.Drawing.Size(112, 13);
            this.lbl_storeprocedure.TabIndex = 7;
            this.lbl_storeprocedure.Text = "STOREPROCEDURE";
            // 
            // listb_storeprocedure
            // 
            this.listb_storeprocedure.FormattingEnabled = true;
            this.listb_storeprocedure.Location = new System.Drawing.Point(197, 202);
            this.listb_storeprocedure.Name = "listb_storeprocedure";
            this.listb_storeprocedure.Size = new System.Drawing.Size(154, 30);
            this.listb_storeprocedure.TabIndex = 8;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listb_storeprocedure);
            this.Controls.Add(this.lbl_storeprocedure);
            this.Controls.Add(this.lbl_vistas);
            this.Controls.Add(this.listb_vistas);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.lbl_tablas);
            this.Controls.Add(this.lbl_basededatos);
            this.Controls.Add(this.listb_tablas);
            this.Controls.Add(this.listb_bd);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listb_bd;
        private System.Windows.Forms.ListBox listb_tablas;
        private System.Windows.Forms.Label lbl_basededatos;
        private System.Windows.Forms.Label lbl_tablas;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.ListBox listb_vistas;
        private System.Windows.Forms.Label lbl_vistas;
        private System.Windows.Forms.Label lbl_storeprocedure;
        private System.Windows.Forms.ListBox listb_storeprocedure;
    }
}