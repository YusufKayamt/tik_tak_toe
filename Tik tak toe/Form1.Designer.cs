namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(46, 41);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(80, 80);
            this.A1.TabIndex = 0;
            this.A1.Text = "A1";
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(132, 41);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(80, 80);
            this.A2.TabIndex = 1;
            this.A2.Text = "A2";
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(218, 41);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(80, 80);
            this.A3.TabIndex = 2;
            this.A3.Text = "A3";
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(46, 127);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(80, 80);
            this.B1.TabIndex = 3;
            this.B1.Text = "B1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(132, 127);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(80, 80);
            this.B2.TabIndex = 4;
            this.B2.Text = "B2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(218, 127);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(80, 80);
            this.B3.TabIndex = 5;
            this.B3.Text = "B3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(46, 213);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(80, 80);
            this.C1.TabIndex = 6;
            this.C1.Text = "C1";
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(132, 213);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 80);
            this.button8.TabIndex = 7;
            this.button8.Text = "C2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(218, 213);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 80);
            this.button9.TabIndex = 8;
            this.button9.Text = "C3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(348, 337);
            this.ControlBox = false;
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.MaximumSize = new System.Drawing.Size(366, 384);
            this.MinimumSize = new System.Drawing.Size(366, 384);
            this.Name = "Form1";
            this.Text = "XOX";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

