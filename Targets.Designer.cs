namespace ToDo
{
    partial class Targets
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Targets));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtGetTask = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(18, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 565);
            this.panel2.TabIndex = 25;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Goldenrod;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(88, 35);
            this.bunifuCustomLabel1.TabIndex = 24;
            this.bunifuCustomLabel1.Text = "Targets";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel1.UseCompatibleTextRendering = true;
            // 
            // txtGetTask
            // 
            this.txtGetTask.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGetTask.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGetTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.txtGetTask.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGetTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGetTask.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGetTask.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtGetTask.HintForeColor = System.Drawing.Color.SteelBlue;
            this.txtGetTask.HintText = "";
            this.txtGetTask.isPassword = false;
            this.txtGetTask.LineFocusedColor = System.Drawing.Color.Fuchsia;
            this.txtGetTask.LineIdleColor = System.Drawing.Color.Turquoise;
            this.txtGetTask.LineMouseHoverColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGetTask.LineThickness = 3;
            this.txtGetTask.Location = new System.Drawing.Point(18, 618);
            this.txtGetTask.Margin = new System.Windows.Forms.Padding(6);
            this.txtGetTask.MaxLength = 32767;
            this.txtGetTask.Name = "txtGetTask";
            this.txtGetTask.Size = new System.Drawing.Size(646, 37);
            this.txtGetTask.TabIndex = 27;
            this.txtGetTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(670, 615);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 40);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 26;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 4;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Tomato;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Gold;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(11, 659);
            this.bunifuGradientPanel1.TabIndex = 23;
            // 
            // Targets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtGetTask);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "Targets";
            this.Size = new System.Drawing.Size(730, 659);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGetTask;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}
