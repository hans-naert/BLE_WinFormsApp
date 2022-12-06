namespace BLE_WinFormsApp
{
    partial class BleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scanButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listServicesButton = new System.Windows.Forms.Button();
            this.listCharactericsButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.registerNotifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(39, 52);
            this.scanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(127, 22);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "SCAN";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(39, 112);
            this.connectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(127, 22);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(187, 36);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(501, 394);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listServicesButton
            // 
            this.listServicesButton.Location = new System.Drawing.Point(39, 175);
            this.listServicesButton.Name = "listServicesButton";
            this.listServicesButton.Size = new System.Drawing.Size(127, 23);
            this.listServicesButton.TabIndex = 3;
            this.listServicesButton.Text = "LIST SERVICES";
            this.listServicesButton.UseVisualStyleBackColor = true;
            this.listServicesButton.Click += new System.EventHandler(this.listServicesButton_Click);
            // 
            // listCharactericsButton
            // 
            this.listCharactericsButton.Location = new System.Drawing.Point(39, 235);
            this.listCharactericsButton.Name = "listCharactericsButton";
            this.listCharactericsButton.Size = new System.Drawing.Size(127, 39);
            this.listCharactericsButton.TabIndex = 4;
            this.listCharactericsButton.Text = "LIST CHARACTERISTICS";
            this.listCharactericsButton.UseVisualStyleBackColor = true;
            this.listCharactericsButton.Click += new System.EventHandler(this.listCharactericsButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(39, 299);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(127, 23);
            this.writeButton.TabIndex = 5;
            this.writeButton.Text = "WRITE";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // registerNotifyButton
            // 
            this.registerNotifyButton.Location = new System.Drawing.Point(39, 364);
            this.registerNotifyButton.Name = "registerNotifyButton";
            this.registerNotifyButton.Size = new System.Drawing.Size(127, 46);
            this.registerNotifyButton.TabIndex = 6;
            this.registerNotifyButton.Text = "REGISTER NOTIFY";
            this.registerNotifyButton.UseVisualStyleBackColor = true;
            this.registerNotifyButton.Click += new System.EventHandler(this.registerNotifyButton_Click);
            // 
            // BleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 455);
            this.Controls.Add(this.registerNotifyButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.listCharactericsButton);
            this.Controls.Add(this.listServicesButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.scanButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BleForm";
            this.Text = "BLE App";
            this.ResumeLayout(false);

        }

        #endregion

        private Button scanButton;
        private Button connectButton;
        private ListBox listBox1;
        private Button listServicesButton;
        private Button listCharactericsButton;
        private Button writeButton;
        private Button registerNotifyButton;
    }
}