namespace Setup_Install {
    partial class FrmMain {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lbl_Line1 = new System.Windows.Forms.Label();
            this.lbl_Line2 = new System.Windows.Forms.Label();
            this.Btn_Prev = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Content1 = new System.Windows.Forms.Label();
            this.lbl_Content2 = new System.Windows.Forms.Label();
            this.lbl_Content3 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.prg = new System.Windows.Forms.ProgressBar();
            this.tmr_Zip = new System.Windows.Forms.Timer(this.components);
            this.rdo_Reset = new System.Windows.Forms.RadioButton();
            this.rdo_Remove = new System.Windows.Forms.RadioButton();
            this.pic_Welcome = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.pnl_Welcome = new System.Windows.Forms.Panel();
            this.tmr_Welcome = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Welcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.pnl_Welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Line1
            // 
            this.lbl_Line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Line1.Location = new System.Drawing.Point(0, 64);
            this.lbl_Line1.Name = "lbl_Line1";
            this.lbl_Line1.Size = new System.Drawing.Size(497, 1);
            this.lbl_Line1.TabIndex = 0;
            this.lbl_Line1.Text = "lbl_Line1";
            // 
            // lbl_Line2
            // 
            this.lbl_Line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Line2.Location = new System.Drawing.Point(0, 331);
            this.lbl_Line2.Name = "lbl_Line2";
            this.lbl_Line2.Size = new System.Drawing.Size(497, 1);
            this.lbl_Line2.TabIndex = 1;
            this.lbl_Line2.Text = "lbl_Line2";
            // 
            // Btn_Prev
            // 
            this.Btn_Prev.Location = new System.Drawing.Point(209, 342);
            this.Btn_Prev.Name = "Btn_Prev";
            this.Btn_Prev.Size = new System.Drawing.Size(88, 23);
            this.Btn_Prev.TabIndex = 0;
            this.Btn_Prev.UseVisualStyleBackColor = true;
            this.Btn_Prev.Click += new System.EventHandler(this.Btn_Prev_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Location = new System.Drawing.Point(304, 342);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(88, 23);
            this.Btn_Next.TabIndex = 1;
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(400, 342);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(88, 23);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(77, 10);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(414, 37);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "lbl_Title";
            // 
            // lbl_Content1
            // 
            this.lbl_Content1.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Content1.Location = new System.Drawing.Point(6, 77);
            this.lbl_Content1.Name = "lbl_Content1";
            this.lbl_Content1.Size = new System.Drawing.Size(422, 33);
            this.lbl_Content1.TabIndex = 5;
            this.lbl_Content1.Text = "lbl_Content1";
            // 
            // lbl_Content2
            // 
            this.lbl_Content2.Font = new System.Drawing.Font("微軟正黑體", 8.25F);
            this.lbl_Content2.Location = new System.Drawing.Point(6, 247);
            this.lbl_Content2.Name = "lbl_Content2";
            this.lbl_Content2.Size = new System.Drawing.Size(505, 30);
            this.lbl_Content2.TabIndex = 6;
            this.lbl_Content2.Text = "lbl_Content2";
            // 
            // lbl_Content3
            // 
            this.lbl_Content3.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Content3.Location = new System.Drawing.Point(557, 98);
            this.lbl_Content3.Name = "lbl_Content3";
            this.lbl_Content3.Size = new System.Drawing.Size(418, 38);
            this.lbl_Content3.TabIndex = 7;
            this.lbl_Content3.Text = "lbl_Content3";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(562, 139);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txt
            // 
            this.txt.Enabled = false;
            this.txt.Location = new System.Drawing.Point(564, 168);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 22);
            this.txt.TabIndex = 10;
            this.txt.Text = "C:\\test";
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(564, 196);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(121, 24);
            this.cmb.TabIndex = 11;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prg
            // 
            this.prg.Location = new System.Drawing.Point(564, 254);
            this.prg.Name = "prg";
            this.prg.Size = new System.Drawing.Size(100, 23);
            this.prg.TabIndex = 13;
            // 
            // tmr_Zip
            // 
            this.tmr_Zip.Tick += new System.EventHandler(this.tmr_Zip_Tick);
            // 
            // rdo_Reset
            // 
            this.rdo_Reset.AutoSize = true;
            this.rdo_Reset.Location = new System.Drawing.Point(564, 296);
            this.rdo_Reset.Name = "rdo_Reset";
            this.rdo_Reset.Size = new System.Drawing.Size(47, 16);
            this.rdo_Reset.TabIndex = 14;
            this.rdo_Reset.TabStop = true;
            this.rdo_Reset.Text = "修復";
            this.rdo_Reset.UseVisualStyleBackColor = true;
            this.rdo_Reset.CheckedChanged += new System.EventHandler(this.rdo_Reset_CheckedChanged);
            // 
            // rdo_Remove
            // 
            this.rdo_Remove.AutoSize = true;
            this.rdo_Remove.Location = new System.Drawing.Point(564, 318);
            this.rdo_Remove.Name = "rdo_Remove";
            this.rdo_Remove.Size = new System.Drawing.Size(47, 16);
            this.rdo_Remove.TabIndex = 15;
            this.rdo_Remove.TabStop = true;
            this.rdo_Remove.Text = "移除";
            this.rdo_Remove.UseVisualStyleBackColor = true;
            this.rdo_Remove.CheckedChanged += new System.EventHandler(this.rdo_Remove_CheckedChanged);
            // 
            // pic_Welcome
            // 
            this.pic_Welcome.Image = global::Setup_Install.Properties.Resources.welcome_icon;
            this.pic_Welcome.Location = new System.Drawing.Point(41, 6);
            this.pic_Welcome.Name = "pic_Welcome";
            this.pic_Welcome.Size = new System.Drawing.Size(252, 244);
            this.pic_Welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Welcome.TabIndex = 16;
            this.pic_Welcome.TabStop = false;
            // 
            // pic
            // 
            this.pic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Image = global::Setup_Install.Properties.Resources.Test;
            this.pic.Location = new System.Drawing.Point(560, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(73, 64);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Welcome.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Welcome.Location = new System.Drawing.Point(121, 230);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(105, 24);
            this.lbl_Welcome.TabIndex = 17;
            this.lbl_Welcome.Text = "WELCOME";
            // 
            // pnl_Welcome
            // 
            this.pnl_Welcome.Controls.Add(this.lbl_Welcome);
            this.pnl_Welcome.Controls.Add(this.pic_Welcome);
            this.pnl_Welcome.Location = new System.Drawing.Point(708, 17);
            this.pnl_Welcome.Name = "pnl_Welcome";
            this.pnl_Welcome.Size = new System.Drawing.Size(332, 295);
            this.pnl_Welcome.TabIndex = 18;
            // 
            // tmr_Welcome
            // 
            this.tmr_Welcome.Interval = 1100;
            this.tmr_Welcome.Tick += new System.EventHandler(this.tmr_Welcome_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 531);
            this.Controls.Add(this.pnl_Welcome);
            this.Controls.Add(this.rdo_Remove);
            this.Controls.Add(this.rdo_Reset);
            this.Controls.Add(this.prg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lbl_Content3);
            this.Controls.Add(this.lbl_Content2);
            this.Controls.Add(this.lbl_Content1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.Btn_Prev);
            this.Controls.Add(this.lbl_Line2);
            this.Controls.Add(this.lbl_Line1);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Setup Install";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Welcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.pnl_Welcome.ResumeLayout(false);
            this.pnl_Welcome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Line1;
        private System.Windows.Forms.Label lbl_Line2;
        private System.Windows.Forms.Button Btn_Prev;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Content1;
        private System.Windows.Forms.Label lbl_Content2;
        private System.Windows.Forms.Label lbl_Content3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar prg;
        private System.Windows.Forms.Timer tmr_Zip;
        private System.Windows.Forms.RadioButton rdo_Reset;
        private System.Windows.Forms.RadioButton rdo_Remove;
        private System.Windows.Forms.PictureBox pic_Welcome;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Panel pnl_Welcome;
        private System.Windows.Forms.Timer tmr_Welcome;
    }
}

