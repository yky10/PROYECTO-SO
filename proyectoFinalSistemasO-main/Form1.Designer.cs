namespace administradorTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelInfo1 = new System.Windows.Forms.Label();
            this.LabelInfo2 = new System.Windows.Forms.Label();
            this.LabelInfo3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version de Windows";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 44);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelInfo1
            // 
            this.LabelInfo1.AutoSize = true;
            this.LabelInfo1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo1.Location = new System.Drawing.Point(78, 165);
            this.LabelInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInfo1.Name = "LabelInfo1";
            this.LabelInfo1.Size = new System.Drawing.Size(54, 18);
            this.LabelInfo1.TabIndex = 2;
            this.LabelInfo1.Text = "label2";
            // 
            // LabelInfo2
            // 
            this.LabelInfo2.AutoSize = true;
            this.LabelInfo2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo2.Location = new System.Drawing.Point(598, 374);
            this.LabelInfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInfo2.Name = "LabelInfo2";
            this.LabelInfo2.Size = new System.Drawing.Size(54, 18);
            this.LabelInfo2.TabIndex = 3;
            this.LabelInfo2.Text = "label2";
            // 
            // LabelInfo3
            // 
            this.LabelInfo3.AutoSize = true;
            this.LabelInfo3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo3.Location = new System.Drawing.Point(78, 304);
            this.LabelInfo3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInfo3.Name = "LabelInfo3";
            this.LabelInfo3.Size = new System.Drawing.Size(54, 18);
            this.LabelInfo3.TabIndex = 4;
            this.LabelInfo3.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(502, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelInfo3);
            this.Controls.Add(this.LabelInfo2);
            this.Controls.Add(this.LabelInfo1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelInfo1;
        private System.Windows.Forms.Label LabelInfo2;
        private System.Windows.Forms.Label LabelInfo3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}