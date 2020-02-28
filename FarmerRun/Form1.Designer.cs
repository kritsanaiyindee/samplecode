namespace FarmerRun
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.farmer = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.farmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameEvent);
            // 
            // farmer
            // 
            this.farmer.BackColor = System.Drawing.Color.Transparent;
            this.farmer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.farmer.Image = global::FarmerRun.Properties.Resources.running2;
            this.farmer.Location = new System.Drawing.Point(12, 459);
            this.farmer.Name = "farmer";
            this.farmer.Size = new System.Drawing.Size(81, 95);
            this.farmer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.farmer.TabIndex = 3;
            this.farmer.TabStop = false;
            // 
            // obstacle2
            // 
            this.obstacle2.BackColor = System.Drawing.Color.Transparent;
            this.obstacle2.BackgroundImage = global::FarmerRun.Properties.Resources.rotten_apple_png_8;
            this.obstacle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obstacle2.Location = new System.Drawing.Point(1065, 506);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(63, 55);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle2.TabIndex = 2;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // obstacle1
            // 
            this.obstacle1.BackColor = System.Drawing.Color.Transparent;
            this.obstacle1.BackgroundImage = global::FarmerRun.Properties.Resources._146_512;
            this.obstacle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obstacle1.Location = new System.Drawing.Point(582, 488);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(57, 49);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle1.TabIndex = 1;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "coin";
            // 
            // floor
            // 
            this.floor.BackgroundImage = global::FarmerRun.Properties.Resources.max;
            this.floor.Location = new System.Drawing.Point(-4, 560);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(1146, 50);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "คะแนน";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(761, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 76);
            this.label2.TabIndex = 7;
            this.label2.Text = "จับเวลา";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmerRun.Properties.Resources.Desert_Background_1162;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 607);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.farmer);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.floor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FKeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.farmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox farmer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

