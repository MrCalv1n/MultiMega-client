namespace MultiMega_Client
{
    partial class formgestao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formgestao));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.b_adicionar = new System.Windows.Forms.Button();
            this.b_remover = new System.Windows.Forms.Button();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 199);
            this.listBox1.TabIndex = 0;
            // 
            // b_adicionar
            // 
            this.b_adicionar.Location = new System.Drawing.Point(357, 13);
            this.b_adicionar.Name = "b_adicionar";
            this.b_adicionar.Size = new System.Drawing.Size(75, 23);
            this.b_adicionar.TabIndex = 1;
            this.b_adicionar.Text = "Adicionar";
            this.b_adicionar.UseVisualStyleBackColor = true;
            // 
            // b_remover
            // 
            this.b_remover.Location = new System.Drawing.Point(357, 42);
            this.b_remover.Name = "b_remover";
            this.b_remover.Size = new System.Drawing.Size(75, 23);
            this.b_remover.TabIndex = 2;
            this.b_remover.Text = "Remover";
            this.b_remover.UseVisualStyleBackColor = true;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(275, 222);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 3;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            // 
            // b_cancelar
            // 
            this.b_cancelar.Location = new System.Drawing.Point(357, 222);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 23);
            this.b_cancelar.TabIndex = 4;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // formgestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 257);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.b_remover);
            this.Controls.Add(this.b_adicionar);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formgestao";
            this.Text = "Gestão de Contas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button b_adicionar;
        private System.Windows.Forms.Button b_remover;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_cancelar;
    }
}