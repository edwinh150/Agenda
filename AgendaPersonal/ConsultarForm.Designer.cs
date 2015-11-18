namespace AgendaPersonal
{
    partial class ConsultarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarForm));
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.ResultadodataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarcomboBox
            // 
            this.BuscarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarcomboBox.FormattingEnabled = true;
            this.BuscarcomboBox.Items.AddRange(new object[] {
            "Todos",
            "PersonaId",
            "Nombre"});
            this.BuscarcomboBox.Location = new System.Drawing.Point(12, 37);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(136, 21);
            this.BuscarcomboBox.TabIndex = 0;
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(167, 37);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(338, 20);
            this.BuscartextBox.TabIndex = 1;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(527, 26);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(96, 40);
            this.Buscarbutton.TabIndex = 19;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ResultadodataGridView
            // 
            this.ResultadodataGridView.AllowUserToAddRows = false;
            this.ResultadodataGridView.AllowUserToDeleteRows = false;
            this.ResultadodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadodataGridView.Location = new System.Drawing.Point(12, 83);
            this.ResultadodataGridView.Name = "ResultadodataGridView";
            this.ResultadodataGridView.ReadOnly = true;
            this.ResultadodataGridView.Size = new System.Drawing.Size(641, 279);
            this.ResultadodataGridView.TabIndex = 20;
            // 
            // ConsultarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 373);
            this.Controls.Add(this.ResultadodataGridView);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.BuscarcomboBox);
            this.Name = "ConsultarForm";
            this.Text = "ConsultarForm";
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BuscarcomboBox;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridView ResultadodataGridView;
    }
}