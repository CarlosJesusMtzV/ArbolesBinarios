namespace ArbolesBinarios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtValor = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            lstRecorrido = new ListBox();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(24, 12);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 48);
            txtValor.TabIndex = 0;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.InactiveCaption;
            btnInsertar.Location = new Point(24, 121);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(129, 56);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.InactiveCaption;
            btnEliminar.Location = new Point(200, 121);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 56);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.InactiveCaption;
            btnBuscar.Location = new Point(374, 121);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(129, 56);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lstRecorrido
            // 
            lstRecorrido.FormattingEnabled = true;
            lstRecorrido.Location = new Point(57, 258);
            lstRecorrido.Name = "lstRecorrido";
            lstRecorrido.Size = new Size(230, 124);
            lstRecorrido.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lstRecorrido);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtValor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBuscar;
        private ListBox lstRecorrido;
    }
}
