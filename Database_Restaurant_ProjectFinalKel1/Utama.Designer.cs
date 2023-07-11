namespace Database_Restaurant_ProjectFinalKel1
{
    partial class Utama
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
            this.btnpembeli = new System.Windows.Forms.Button();
            this.btnkasir = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnkoki = new System.Windows.Forms.Button();
            this.btnsuplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpembeli
            // 
            this.btnpembeli.Location = new System.Drawing.Point(79, 171);
            this.btnpembeli.Name = "btnpembeli";
            this.btnpembeli.Size = new System.Drawing.Size(101, 125);
            this.btnpembeli.TabIndex = 0;
            this.btnpembeli.Text = "Pembeli";
            this.btnpembeli.UseVisualStyleBackColor = true;
            // 
            // btnkasir
            // 
            this.btnkasir.Location = new System.Drawing.Point(212, 171);
            this.btnkasir.Name = "btnkasir";
            this.btnkasir.Size = new System.Drawing.Size(101, 125);
            this.btnkasir.TabIndex = 1;
            this.btnkasir.Text = "Kasir";
            this.btnkasir.UseVisualStyleBackColor = true;
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(350, 171);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(101, 125);
            this.btnmenu.TabIndex = 2;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            // 
            // btnkoki
            // 
            this.btnkoki.Location = new System.Drawing.Point(487, 171);
            this.btnkoki.Name = "btnkoki";
            this.btnkoki.Size = new System.Drawing.Size(101, 125);
            this.btnkoki.TabIndex = 3;
            this.btnkoki.Text = "Koki";
            this.btnkoki.UseVisualStyleBackColor = true;
            // 
            // btnsuplier
            // 
            this.btnsuplier.Location = new System.Drawing.Point(618, 171);
            this.btnsuplier.Name = "btnsuplier";
            this.btnsuplier.Size = new System.Drawing.Size(101, 125);
            this.btnsuplier.TabIndex = 4;
            this.btnsuplier.Text = "Suplier";
            this.btnsuplier.UseVisualStyleBackColor = true;
            // 
            // Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsuplier);
            this.Controls.Add(this.btnkoki);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnkasir);
            this.Controls.Add(this.btnpembeli);
            this.Name = "Utama";
            this.Text = "Utama";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpembeli;
        private System.Windows.Forms.Button btnkasir;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnkoki;
        private System.Windows.Forms.Button btnsuplier;
    }
}