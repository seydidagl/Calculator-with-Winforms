namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.textadsoyad = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textyas = new System.Windows.Forms.TextBox();
            this.textdeger = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pointbutton = new System.Windows.Forms.Button();
            this.buttondell = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonmultıply = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttondivide = new System.Windows.Forms.Button();
            this.buttonplus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Informatıonlabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name\r\nSurname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel1.Location = new System.Drawing.Point(831, 180);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link of this Image";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(44, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textadsoyad
            // 
            this.textadsoyad.Location = new System.Drawing.Point(126, 38);
            this.textadsoyad.Multiline = true;
            this.textadsoyad.Name = "textadsoyad";
            this.textadsoyad.Size = new System.Drawing.Size(199, 39);
            this.textadsoyad.TabIndex = 4;
            this.textadsoyad.Leave += new System.EventHandler(this.textadsoyad_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(460, 47);
            this.dateTimePicker1.MaxDate = new System.DateTime(2005, 11, 2, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1963, 11, 2, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2005, 11, 2, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(126, 83);
            this.textemail.Multiline = true;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(199, 37);
            this.textemail.TabIndex = 6;
            this.textemail.Leave += new System.EventHandler(this.textemail_Leave);
            // 
            // textyas
            // 
            this.textyas.Enabled = false;
            this.textyas.Location = new System.Drawing.Point(460, 83);
            this.textyas.Multiline = true;
            this.textyas.Name = "textyas";
            this.textyas.Size = new System.Drawing.Size(199, 36);
            this.textyas.TabIndex = 7;
            // 
            // textdeger
            // 
            this.textdeger.Enabled = false;
            this.textdeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textdeger.Location = new System.Drawing.Point(601, 441);
            this.textdeger.Multiline = true;
            this.textdeger.Name = "textdeger";
            this.textdeger.Size = new System.Drawing.Size(511, 176);
            this.textdeger.TabIndex = 8;
            this.textdeger.Text = "0";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(130, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(213, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(44, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 45);
            this.button4.TabIndex = 11;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(130, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 45);
            this.button5.TabIndex = 12;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(213, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 45);
            this.button6.TabIndex = 13;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(44, 183);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 45);
            this.button7.TabIndex = 14;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(130, 183);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 45);
            this.button8.TabIndex = 15;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(213, 183);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 45);
            this.button9.TabIndex = 16;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(299, 183);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 45);
            this.button10.TabIndex = 17;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonzero_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(340, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Age";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(340, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bırthday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "E-mail";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.Pointbutton);
            this.groupBox1.Controls.Add(this.buttondell);
            this.groupBox1.Controls.Add(this.buttonclear);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.buttonmultıply);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonminus);
            this.groupBox1.Controls.Add(this.buttondivide);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.buttonplus);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Location = new System.Drawing.Point(58, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 374);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculatıon";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Pointbutton
            // 
            this.Pointbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Pointbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pointbutton.Location = new System.Drawing.Point(44, 286);
            this.Pointbutton.Name = "Pointbutton";
            this.Pointbutton.Size = new System.Drawing.Size(80, 44);
            this.Pointbutton.TabIndex = 28;
            this.Pointbutton.Text = ".";
            this.Pointbutton.UseVisualStyleBackColor = true;
            this.Pointbutton.Click += new System.EventHandler(this.Pointbutton_Click);
            // 
            // buttondell
            // 
            this.buttondell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttondell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttondell.Location = new System.Drawing.Point(130, 285);
            this.buttondell.Name = "buttondell";
            this.buttondell.Size = new System.Drawing.Size(249, 45);
            this.buttondell.TabIndex = 27;
            this.buttondell.Text = "=";
            this.buttondell.UseVisualStyleBackColor = true;
            this.buttondell.Click += new System.EventHandler(this.buttonequal_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonclear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonclear.Location = new System.Drawing.Point(299, 60);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(80, 107);
            this.buttonclear.TabIndex = 26;
            this.buttonclear.Text = "C";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonmultıply
            // 
            this.buttonmultıply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonmultıply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonmultıply.Location = new System.Drawing.Point(213, 234);
            this.buttonmultıply.Name = "buttonmultıply";
            this.buttonmultıply.Size = new System.Drawing.Size(80, 45);
            this.buttonmultıply.TabIndex = 25;
            this.buttonmultıply.Text = "X";
            this.buttonmultıply.UseVisualStyleBackColor = true;
            this.buttonmultıply.Click += new System.EventHandler(this.buttonmultıply_Click);
            // 
            // buttonminus
            // 
            this.buttonminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonminus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonminus.Location = new System.Drawing.Point(130, 234);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(80, 45);
            this.buttonminus.TabIndex = 23;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.buttonminus_Click);
            // 
            // buttondivide
            // 
            this.buttondivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttondivide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttondivide.Location = new System.Drawing.Point(299, 234);
            this.buttondivide.Name = "buttondivide";
            this.buttondivide.Size = new System.Drawing.Size(80, 45);
            this.buttondivide.TabIndex = 24;
            this.buttondivide.Text = "/";
            this.buttondivide.UseVisualStyleBackColor = true;
            this.buttondivide.Click += new System.EventHandler(this.buttondivide_Click);
            // 
            // buttonplus
            // 
            this.buttonplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonplus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonplus.Location = new System.Drawing.Point(44, 234);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(80, 45);
            this.buttonplus.TabIndex = 22;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(693, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textadsoyad);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textemail);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.textyas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(58, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1084, 225);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informatıon";
            // 
            // Informatıonlabel
            // 
            this.Informatıonlabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Informatıonlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Informatıonlabel.Location = new System.Drawing.Point(726, 303);
            this.Informatıonlabel.Name = "Informatıonlabel";
            this.Informatıonlabel.Size = new System.Drawing.Size(225, 97);
            this.Informatıonlabel.TabIndex = 27;
            this.Informatıonlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1445, 690);
            this.Controls.Add(this.Informatıonlabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textdeger);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textadsoyad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textyas;
        private System.Windows.Forms.TextBox textdeger;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonmultıply;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttondivide;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttondell;
        private System.Windows.Forms.Label Informatıonlabel;
        private System.Windows.Forms.Button Pointbutton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

