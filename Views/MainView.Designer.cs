namespace Supermarker_mvp.Views
{
    partial class MainView
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
            panel1 = new Panel();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 497);
            panel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = SystemColors.ButtonFace;
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.ImageAlign = ContentAlignment.BottomCenter;
            BtnExit.Location = new Point(0, 394);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(200, 103);
            BtnExit.TabIndex = 2;
            BtnExit.TextAlign = ContentAlignment.BottomCenter;
            BtnExit.UseVisualStyleBackColor = false;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackColor = SystemColors.ButtonFace;
            BtnPayMode.BackgroundImage = Properties.Resources.buy2;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.ImageAlign = ContentAlignment.BottomCenter;
            BtnPayMode.Location = new Point(0, 59);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(200, 103);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.TextAlign = ContentAlignment.BottomCenter;
            BtnPayMode.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarker";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
    }
}