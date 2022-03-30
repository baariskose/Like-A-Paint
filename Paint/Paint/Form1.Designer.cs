namespace Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResimYükle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.penSize = new System.Windows.Forms.NumericUpDown();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.renkSec = new System.Windows.Forms.Button();
            this.btnCizgi = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSilgi = new System.Windows.Forms.Button();
            this.btnKalem = new System.Windows.Forms.Button();
            this.btnDoldur = new System.Windows.Forms.Button();
            this.btnRenkSec = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btnResimYükle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.penSize);
            this.panel1.Controls.Add(this.btnCizgi);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSilgi);
            this.panel1.Controls.Add(this.btnKalem);
            this.panel1.Controls.Add(this.btnDoldur);
            this.panel1.Controls.Add(this.btnRenkSec);
            this.panel1.Controls.Add(this.renkSec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 108);
            this.panel1.TabIndex = 0;
            // 
            // btnResimYükle
            // 
            this.btnResimYükle.BackColor = System.Drawing.Color.Moccasin;
            this.btnResimYükle.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimYükle.Location = new System.Drawing.Point(641, 22);
            this.btnResimYükle.Name = "btnResimYükle";
            this.btnResimYükle.Size = new System.Drawing.Size(66, 54);
            this.btnResimYükle.TabIndex = 12;
            this.btnResimYükle.Text = "Resim Sec";
            this.btnResimYükle.UseVisualStyleBackColor = false;
            this.btnResimYükle.Click += new System.EventHandler(this.btnResimYükle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(511, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kalem Boyutu:";
            // 
            // penSize
            // 
            this.penSize.Location = new System.Drawing.Point(514, 42);
            this.penSize.Name = "penSize";
            this.penSize.Size = new System.Drawing.Size(67, 22);
            this.penSize.TabIndex = 10;
            this.penSize.ValueChanged += new System.EventHandler(this.penSize_ValueChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Moccasin;
            this.btnTemizle.BackgroundImage = global::Paint.Properties.Resources.cleaning;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(779, 22);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(58, 54);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // renkSec
            // 
            this.renkSec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.renkSec.Location = new System.Drawing.Point(12, 33);
            this.renkSec.Name = "renkSec";
            this.renkSec.Size = new System.Drawing.Size(36, 31);
            this.renkSec.TabIndex = 0;
            this.renkSec.UseVisualStyleBackColor = false;
            // 
            // btnCizgi
            // 
            this.btnCizgi.BackColor = System.Drawing.Color.Moccasin;
            this.btnCizgi.BackgroundImage = global::Paint.Properties.Resources.diagonal_line;
            this.btnCizgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCizgi.Location = new System.Drawing.Point(313, 23);
            this.btnCizgi.Name = "btnCizgi";
            this.btnCizgi.Size = new System.Drawing.Size(60, 49);
            this.btnCizgi.TabIndex = 9;
            this.btnCizgi.UseVisualStyleBackColor = false;
            this.btnCizgi.Click += new System.EventHandler(this.btnCizgi_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Moccasin;
            this.btnKaydet.BackgroundImage = global::Paint.Properties.Resources.diskette;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(713, 20);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(60, 54);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Moccasin;
            this.button3.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(445, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 50);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.BackgroundImage = global::Paint.Properties.Resources.oval;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Image = global::Paint.Properties.Resources.dry_clean__1_;
            this.button2.Location = new System.Drawing.Point(379, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 49);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSilgi
            // 
            this.btnSilgi.BackColor = System.Drawing.Color.Moccasin;
            this.btnSilgi.BackgroundImage = global::Paint.Properties.Resources.eraser__1_;
            this.btnSilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSilgi.Location = new System.Drawing.Point(247, 21);
            this.btnSilgi.Name = "btnSilgi";
            this.btnSilgi.Size = new System.Drawing.Size(60, 51);
            this.btnSilgi.TabIndex = 4;
            this.btnSilgi.UseVisualStyleBackColor = false;
            this.btnSilgi.Click += new System.EventHandler(this.btnSilgi_Click);
            // 
            // btnKalem
            // 
            this.btnKalem.BackColor = System.Drawing.Color.Moccasin;
            this.btnKalem.BackgroundImage = global::Paint.Properties.Resources.pencil;
            this.btnKalem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKalem.Location = new System.Drawing.Point(181, 21);
            this.btnKalem.Name = "btnKalem";
            this.btnKalem.Size = new System.Drawing.Size(60, 51);
            this.btnKalem.TabIndex = 3;
            this.btnKalem.UseVisualStyleBackColor = false;
            this.btnKalem.Click += new System.EventHandler(this.btnKalem_Click);
            // 
            // btnDoldur
            // 
            this.btnDoldur.BackColor = System.Drawing.Color.Moccasin;
            this.btnDoldur.BackgroundImage = global::Paint.Properties.Resources.fill;
            this.btnDoldur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoldur.Location = new System.Drawing.Point(115, 21);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(60, 51);
            this.btnDoldur.TabIndex = 2;
            this.btnDoldur.UseVisualStyleBackColor = false;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // btnRenkSec
            // 
            this.btnRenkSec.BackColor = System.Drawing.Color.Moccasin;
            this.btnRenkSec.BackgroundImage = global::Paint.Properties.Resources.color_palette;
            this.btnRenkSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRenkSec.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRenkSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenkSec.Location = new System.Drawing.Point(54, 22);
            this.btnRenkSec.Name = "btnRenkSec";
            this.btnRenkSec.Size = new System.Drawing.Size(55, 51);
            this.btnRenkSec.TabIndex = 1;
            this.btnRenkSec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRenkSec.UseVisualStyleBackColor = false;
            this.btnRenkSec.Click += new System.EventHandler(this.btnRenkSec_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(862, 503);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            this.picBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseClick);
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1500, 1500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRenkSec;
        private System.Windows.Forms.Button renkSec;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSilgi;
        private System.Windows.Forms.Button btnKalem;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCizgi;
        private System.Windows.Forms.NumericUpDown penSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResimYükle;
    }
}

