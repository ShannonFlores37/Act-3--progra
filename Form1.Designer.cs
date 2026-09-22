namespace Act_3__progra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblarchivo = new Label();
            btnplay = new Button();
            btnstop = new Button();
            lbla = new Label();
            panel1 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblarchivo
            // 
            lblarchivo.AutoSize = true;
            lblarchivo.Location = new Point(50, 43);
            lblarchivo.Name = "lblarchivo";
            lblarchivo.Size = new Size(120, 15);
            lblarchivo.TabIndex = 0;
            lblarchivo.Text = "Archivo seleccionado";
            lblarchivo.Click += lblarchivo_Click;
            // 
            // btnplay
            // 
            btnplay.BackColor = Color.LimeGreen;
            btnplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnplay.ForeColor = SystemColors.ButtonHighlight;
            btnplay.Location = new Point(119, 315);
            btnplay.Name = "btnplay";
            btnplay.Size = new Size(104, 44);
            btnplay.TabIndex = 1;
            btnplay.Text = "Aceptar";
            btnplay.UseVisualStyleBackColor = false;
            btnplay.Click += btnplay_Click;
            // 
            // btnstop
            // 
            btnstop.BackColor = Color.Red;
            btnstop.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstop.ForeColor = Color.White;
            btnstop.Location = new Point(551, 314);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(105, 47);
            btnstop.TabIndex = 2;
            btnstop.Text = "stop";
            btnstop.UseVisualStyleBackColor = false;
            // 
            // lbla
            // 
            lbla.AutoSize = true;
            lbla.Location = new Point(3, 13);
            lbla.Name = "lbla";
            lbla.Size = new Size(200, 15);
            lbla.TabIndex = 3;
            lbla.Text = "No hay ningun archivo seleccionado";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbla);
            panel1.Location = new Point(50, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 40);
            panel1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(261, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnstop);
            Controls.Add(btnplay);
            Controls.Add(lblarchivo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Reproductor p3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblarchivo;
        private Button btnplay;
        private Button btnstop;
        private Label lbla;
        private Panel panel1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
    }
}
