namespace FallingFruits
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prune = new System.Windows.Forms.PictureBox();
            this.pear = new System.Windows.Forms.PictureBox();
            this.peach = new System.Windows.Forms.PictureBox();
            this.apple = new System.Windows.Forms.PictureBox();
            this.basket = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prune
            // 
            this.prune.BackColor = System.Drawing.Color.Transparent;
            this.prune.Image = ((System.Drawing.Image)(resources.GetObject("prune.Image")));
            this.prune.Location = new System.Drawing.Point(622, 249);
            this.prune.Name = "prune";
            this.prune.Size = new System.Drawing.Size(60, 60);
            this.prune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prune.TabIndex = 9;
            this.prune.TabStop = false;
            // 
            // pear
            // 
            this.pear.BackColor = System.Drawing.Color.Transparent;
            this.pear.Image = ((System.Drawing.Image)(resources.GetObject("pear.Image")));
            this.pear.Location = new System.Drawing.Point(435, 205);
            this.pear.Name = "pear";
            this.pear.Size = new System.Drawing.Size(60, 60);
            this.pear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pear.TabIndex = 8;
            this.pear.TabStop = false;
            // 
            // peach
            // 
            this.peach.BackColor = System.Drawing.Color.Transparent;
            this.peach.Image = ((System.Drawing.Image)(resources.GetObject("peach.Image")));
            this.peach.Location = new System.Drawing.Point(334, 191);
            this.peach.Name = "peach";
            this.peach.Size = new System.Drawing.Size(60, 60);
            this.peach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.peach.TabIndex = 7;
            this.peach.TabStop = false;
            // 
            // apple
            // 
            this.apple.BackColor = System.Drawing.Color.Transparent;
            this.apple.Image = ((System.Drawing.Image)(resources.GetObject("apple.Image")));
            this.apple.Location = new System.Drawing.Point(95, 205);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(60, 60);
            this.apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apple.TabIndex = 6;
            this.apple.TabStop = false;
            // 
            // basket
            // 
            this.basket.BackColor = System.Drawing.Color.Transparent;
            this.basket.Image = ((System.Drawing.Image)(resources.GetObject("basket.Image")));
            this.basket.Location = new System.Drawing.Point(334, 350);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(161, 177);
            this.basket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.basket.TabIndex = 1;
            this.basket.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 539);
            this.Controls.Add(this.prune);
            this.Controls.Add(this.pear);
            this.Controls.Add(this.peach);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.basket);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Falling Fruits";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.prune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox basket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox apple;
        private System.Windows.Forms.PictureBox peach;
        private System.Windows.Forms.PictureBox pear;
        private System.Windows.Forms.PictureBox prune;
        private System.Windows.Forms.Timer timer2;
    }
}

