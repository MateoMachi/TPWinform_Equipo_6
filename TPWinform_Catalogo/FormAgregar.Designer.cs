using System;

namespace TPWinform_Catalogo
{
    partial class FormAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregar));
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCodArticulo = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelImagen = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodArticulo = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.pictureBoxAlta = new System.Windows.Forms.PictureBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            resources.ApplyResources(this.labelNombre, "labelNombre");
            this.labelNombre.Name = "labelNombre";
            // 
            // labelPrecio
            // 
            resources.ApplyResources(this.labelPrecio, "labelPrecio");
            this.labelPrecio.Name = "labelPrecio";
            // 
            // labelCodArticulo
            // 
            resources.ApplyResources(this.labelCodArticulo, "labelCodArticulo");
            this.labelCodArticulo.Name = "labelCodArticulo";
            // 
            // labelDescripcion
            // 
            resources.ApplyResources(this.labelDescripcion, "labelDescripcion");
            this.labelDescripcion.Name = "labelDescripcion";
            // 
            // labelMarca
            // 
            resources.ApplyResources(this.labelMarca, "labelMarca");
            this.labelMarca.Name = "labelMarca";
            // 
            // labelCategoria
            // 
            resources.ApplyResources(this.labelCategoria, "labelCategoria");
            this.labelCategoria.Name = "labelCategoria";
            // 
            // labelImagen
            // 
            resources.ApplyResources(this.labelImagen, "labelImagen");
            this.labelImagen.Name = "labelImagen";
            // 
            // textBoxNombre
            // 
            resources.ApplyResources(this.textBoxNombre, "textBoxNombre");
            this.textBoxNombre.Name = "textBoxNombre";
            // 
            // textBoxCodArticulo
            // 
            resources.ApplyResources(this.textBoxCodArticulo, "textBoxCodArticulo");
            this.textBoxCodArticulo.Name = "textBoxCodArticulo";
            // 
            // textBoxPrecio
            // 
            resources.ApplyResources(this.textBoxPrecio, "textBoxPrecio");
            this.textBoxPrecio.Name = "textBoxPrecio";
            // 
            // textBoxUrlImagen
            // 
            resources.ApplyResources(this.textBoxUrlImagen, "textBoxUrlImagen");
            this.textBoxUrlImagen.Name = "textBoxUrlImagen";
            this.textBoxUrlImagen.TextChanged += new System.EventHandler(this.textBoxUrlImagen_TextChanged);
            // 
            // buttonConfirmar
            // 
            resources.ApplyResources(this.buttonConfirmar, "buttonConfirmar");
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonCancelar
            // 
            resources.ApplyResources(this.buttonCancelar, "buttonCancelar");
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // pictureBoxAlta
            // 
            resources.ApplyResources(this.pictureBoxAlta, "pictureBoxAlta");
            this.pictureBoxAlta.Name = "pictureBoxAlta";
            this.pictureBoxAlta.TabStop = false;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBoxDescripcion, "textBoxDescripcion");
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMarca, "comboBoxMarca");
            this.comboBoxMarca.Name = "comboBoxMarca";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxCategoria, "comboBoxCategoria");
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            // 
            // FormAgregar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.pictureBoxAlta);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxUrlImagen);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxCodArticulo);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelCodArticulo);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAgregar";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCodArticulo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodArticulo;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxUrlImagen;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox pictureBoxAlta;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxCategoria;

    }
}