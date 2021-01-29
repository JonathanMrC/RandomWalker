namespace RandomWalker
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
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.Simulation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_box
            // 
            this.pic_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_box.Enabled = false;
            this.pic_box.Location = new System.Drawing.Point(0, 0);
            this.pic_box.Margin = new System.Windows.Forms.Padding(0);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(800, 450);
            this.pic_box.TabIndex = 0;
            this.pic_box.TabStop = false;
            // 
            // Simulation
            // 
            this.Simulation.Interval = 10;
            this.Simulation.Tick += new System.EventHandler(this.Simulation_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic_box);
            this.Name = "Form1";
            this.Text = "RandomWalker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.Timer Simulation;
    }
}

