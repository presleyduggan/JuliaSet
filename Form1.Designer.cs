namespace Julia2
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.currentc0 = new System.Windows.Forms.Label();
            this.c0textbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.c1textbox = new System.Windows.Forms.TextBox();
            this.c0label = new System.Windows.Forms.Label();
            this.c1label = new System.Windows.Forms.Label();
            this.currentc1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(267, 28);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(800, 800);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play Default";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentc0
            // 
            this.currentc0.Location = new System.Drawing.Point(12, 56);
            this.currentc0.Name = "currentc0";
            this.currentc0.Size = new System.Drawing.Size(249, 23);
            this.currentc0.TabIndex = 2;
            this.currentc0.Text = "C0:";
            this.currentc0.Click += new System.EventHandler(this.ffffffffffffffffffffffff_Click);
            // 
            // c0textbox
            // 
            this.c0textbox.Location = new System.Drawing.Point(12, 188);
            this.c0textbox.Name = "c0textbox";
            this.c0textbox.Size = new System.Drawing.Size(100, 20);
            this.c0textbox.TabIndex = 3;
            this.c0textbox.Text = "0";
            this.c0textbox.TextChanged += new System.EventHandler(this.c0textbox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Input Values";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // c1textbox
            // 
            this.c1textbox.Location = new System.Drawing.Point(12, 246);
            this.c1textbox.Name = "c1textbox";
            this.c1textbox.Size = new System.Drawing.Size(100, 20);
            this.c1textbox.TabIndex = 5;
            this.c1textbox.Text = "0";
            this.c1textbox.TextChanged += new System.EventHandler(this.c1textbox_TextChanged);
            // 
            // c0label
            // 
            this.c0label.Location = new System.Drawing.Point(17, 169);
            this.c0label.Name = "c0label";
            this.c0label.Size = new System.Drawing.Size(95, 16);
            this.c0label.TabIndex = 6;
            this.c0label.Text = "User c0";
            // 
            // c1label
            // 
            this.c1label.Location = new System.Drawing.Point(17, 227);
            this.c1label.Name = "c1label";
            this.c1label.Size = new System.Drawing.Size(95, 16);
            this.c1label.TabIndex = 7;
            this.c1label.Text = "User c1";
            // 
            // currentc1
            // 
            this.currentc1.Location = new System.Drawing.Point(12, 91);
            this.currentc1.Name = "currentc1";
            this.currentc1.Size = new System.Drawing.Size(249, 23);
            this.currentc1.TabIndex = 8;
            this.currentc1.Text = "C1:";
            this.currentc1.Click += new System.EventHandler(this.currentc1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 883);
            this.Controls.Add(this.currentc1);
            this.Controls.Add(this.c1label);
            this.Controls.Add(this.c0label);
            this.Controls.Add(this.c1textbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.c0textbox);
            this.Controls.Add(this.currentc0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label currentc0;
        private System.Windows.Forms.TextBox c0textbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox c1textbox;
        private System.Windows.Forms.Label c0label;
        private System.Windows.Forms.Label c1label;
        private System.Windows.Forms.Label currentc1;
    }
}

