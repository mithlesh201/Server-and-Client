namespace Client_and_Server
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
            this.tlpIBTG = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.fldIBTGIP = new System.Windows.Forms.TextBox();
            this.lblIBTGIP = new System.Windows.Forms.Label();
            this.fldIBTGPort = new System.Windows.Forms.NumericUpDown();
            this.lblIBTGPort = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fldConnecteas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tlpIBTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fldIBTGPort)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpIBTG
            // 
            this.tlpIBTG.AutoSize = true;
            this.tlpIBTG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpIBTG.ColumnCount = 5;
            this.tlpIBTG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpIBTG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpIBTG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpIBTG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpIBTG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpIBTG.Controls.Add(this.btnConnect, 4, 0);
            this.tlpIBTG.Controls.Add(this.fldIBTGIP, 1, 0);
            this.tlpIBTG.Controls.Add(this.lblIBTGIP, 0, 0);
            this.tlpIBTG.Controls.Add(this.fldIBTGPort, 3, 0);
            this.tlpIBTG.Controls.Add(this.lblIBTGPort, 2, 0);
            this.tlpIBTG.Location = new System.Drawing.Point(13, 13);
            this.tlpIBTG.Margin = new System.Windows.Forms.Padding(4);
            this.tlpIBTG.Name = "tlpIBTG";
            this.tlpIBTG.RowCount = 1;
            this.tlpIBTG.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIBTG.Size = new System.Drawing.Size(438, 36);
            this.tlpIBTG.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(334, 4);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // fldIBTGIP
            // 
            this.fldIBTGIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fldIBTGIP.Location = new System.Drawing.Point(32, 7);
            this.fldIBTGIP.Margin = new System.Windows.Forms.Padding(4);
            this.fldIBTGIP.Name = "fldIBTGIP";
            this.fldIBTGIP.Size = new System.Drawing.Size(121, 22);
            this.fldIBTGIP.TabIndex = 0;
            this.fldIBTGIP.Text = "192.168.0.33";
            // 
            // lblIBTGIP
            // 
            this.lblIBTGIP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIBTGIP.AutoSize = true;
            this.lblIBTGIP.Location = new System.Drawing.Point(4, 9);
            this.lblIBTGIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIBTGIP.Name = "lblIBTGIP";
            this.lblIBTGIP.Size = new System.Drawing.Size(20, 17);
            this.lblIBTGIP.TabIndex = 3;
            this.lblIBTGIP.Text = "IP";
            // 
            // fldIBTGPort
            // 
            this.fldIBTGPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fldIBTGPort.Location = new System.Drawing.Point(203, 7);
            this.fldIBTGPort.Margin = new System.Windows.Forms.Padding(4);
            this.fldIBTGPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fldIBTGPort.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fldIBTGPort.Name = "fldIBTGPort";
            this.fldIBTGPort.Size = new System.Drawing.Size(123, 22);
            this.fldIBTGPort.TabIndex = 1;
            this.fldIBTGPort.Value = new decimal(new int[] {
            9002,
            0,
            0,
            0});
            // 
            // lblIBTGPort
            // 
            this.lblIBTGPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIBTGPort.AutoSize = true;
            this.lblIBTGPort.Location = new System.Drawing.Point(161, 9);
            this.lblIBTGPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIBTGPort.Name = "lblIBTGPort";
            this.lblIBTGPort.Size = new System.Drawing.Size(34, 17);
            this.lblIBTGPort.TabIndex = 3;
            this.lblIBTGPort.Text = "Port";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.fldConnecteas, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(474, 13);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(256, 32);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Connect As";
            // 
            // fldConnecteas
            // 
            this.fldConnecteas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fldConnecteas.FormattingEnabled = true;
            this.fldConnecteas.Items.AddRange(new object[] {
            "Server"});
            this.fldConnecteas.Location = new System.Drawing.Point(92, 4);
            this.fldConnecteas.Margin = new System.Windows.Forms.Padding(4);
            this.fldConnecteas.Name = "fldConnecteas";
            this.fldConnecteas.Size = new System.Drawing.Size(160, 24);
            this.fldConnecteas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Client Message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 22);
            this.textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tlpIBTG);
            this.Name = "Form1";
            this.Text = "SocketServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpIBTG.ResumeLayout(false);
            this.tlpIBTG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fldIBTGPort)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpIBTG;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox fldIBTGIP;
        private System.Windows.Forms.Label lblIBTGIP;
        private System.Windows.Forms.NumericUpDown fldIBTGPort;
        private System.Windows.Forms.Label lblIBTGPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fldConnecteas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

