
namespace Mensajería_Whatsapp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SendEmailBttn = new System.Windows.Forms.Button();
            this.contentCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.from_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidad_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delay_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cc_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sheetName_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_label = new System.Windows.Forms.Label();
            this.sent_failed_lbl = new System.Windows.Forms.Label();
            this.pswd_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ccCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1374, 496);
            this.dataGridView1.TabIndex = 1;
            // 
            // SendEmailBttn
            // 
            this.SendEmailBttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SendEmailBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendEmailBttn.Location = new System.Drawing.Point(1211, 593);
            this.SendEmailBttn.Name = "SendEmailBttn";
            this.SendEmailBttn.Size = new System.Drawing.Size(175, 34);
            this.SendEmailBttn.TabIndex = 2;
            this.SendEmailBttn.Text = "Enviar correos";
            this.SendEmailBttn.UseVisualStyleBackColor = false;
            this.SendEmailBttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // contentCheckBox
            // 
            this.contentCheckBox.AutoSize = true;
            this.contentCheckBox.Location = new System.Drawing.Point(554, 543);
            this.contentCheckBox.Name = "contentCheckBox";
            this.contentCheckBox.Size = new System.Drawing.Size(159, 17);
            this.contentCheckBox.TabIndex = 3;
            this.contentCheckBox.Text = "Mandar Imagen/Contenido?";
            this.contentCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1398, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.refreshToolStripMenuItem.Text = "Reset";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // from_textbox
            // 
            this.from_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.from_textbox.Location = new System.Drawing.Point(83, 538);
            this.from_textbox.Name = "from_textbox";
            this.from_textbox.Size = new System.Drawing.Size(190, 20);
            this.from_textbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "From:";
            // 
            // cantidad_textbox
            // 
            this.cantidad_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cantidad_textbox.Location = new System.Drawing.Point(413, 540);
            this.cantidad_textbox.Name = "cantidad_textbox";
            this.cantidad_textbox.Size = new System.Drawing.Size(100, 20);
            this.cantidad_textbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad:";
            // 
            // delay_textbox
            // 
            this.delay_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delay_textbox.Location = new System.Drawing.Point(413, 577);
            this.delay_textbox.Name = "delay_textbox";
            this.delay_textbox.Size = new System.Drawing.Size(100, 20);
            this.delay_textbox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Delay (seg):";
            // 
            // cc_textbox
            // 
            this.cc_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cc_textbox.Location = new System.Drawing.Point(83, 574);
            this.cc_textbox.Name = "cc_textbox";
            this.cc_textbox.Size = new System.Drawing.Size(190, 20);
            this.cc_textbox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CC:";
            // 
            // sheetName_textbox
            // 
            this.sheetName_textbox.Location = new System.Drawing.Point(1230, 4);
            this.sheetName_textbox.Name = "sheetName_textbox";
            this.sheetName_textbox.Size = new System.Drawing.Size(156, 20);
            this.sheetName_textbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1093, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre de la Hoja/Sheet:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Location = new System.Drawing.Point(1280, 532);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(59, 13);
            this.timer_label.TabIndex = 15;
            this.timer_label.Text = "Tiempo (s):";
            // 
            // sent_failed_lbl
            // 
            this.sent_failed_lbl.AutoSize = true;
            this.sent_failed_lbl.Location = new System.Drawing.Point(1063, 532);
            this.sent_failed_lbl.Name = "sent_failed_lbl";
            this.sent_failed_lbl.Size = new System.Drawing.Size(139, 13);
            this.sent_failed_lbl.TabIndex = 16;
            this.sent_failed_lbl.Text = "Enviados:       No Enviados:";
            // 
            // pswd_textbox
            // 
            this.pswd_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pswd_textbox.Location = new System.Drawing.Point(83, 607);
            this.pswd_textbox.Name = "pswd_textbox";
            this.pswd_textbox.PasswordChar = '*';
            this.pswd_textbox.Size = new System.Drawing.Size(190, 20);
            this.pswd_textbox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pswd:";
            // 
            // ccCheckBox
            // 
            this.ccCheckBox.AutoSize = true;
            this.ccCheckBox.Location = new System.Drawing.Point(554, 578);
            this.ccCheckBox.Name = "ccCheckBox";
            this.ccCheckBox.Size = new System.Drawing.Size(136, 17);
            this.ccCheckBox.TabIndex = 19;
            this.ccCheckBox.Text = "Send Carbon Copy (cc)";
            this.ccCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 639);
            this.Controls.Add(this.ccCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pswd_textbox);
            this.Controls.Add(this.sent_failed_lbl);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sheetName_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cc_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delay_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from_textbox);
            this.Controls.Add(this.contentCheckBox);
            this.Controls.Add(this.SendEmailBttn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mail sender";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SendEmailBttn;
        private System.Windows.Forms.CheckBox contentCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.TextBox from_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantidad_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox delay_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cc_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sheetName_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label sent_failed_lbl;
        private System.Windows.Forms.TextBox pswd_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ccCheckBox;
    }
}

