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
            scanButton = new Button();
            connectButton = new Button();
            listBox1 = new ListBox();
            listServicesButton = new Button();
            listCharactericsButton = new Button();
            writeButton = new Button();
            registerNotifyButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            localNameTextBox = new TextBox();
            connectFilteredButton = new Button();
            ScanFilteredButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // scanButton
            // 
            scanButton.Location = new Point(24, 28);
            scanButton.Name = "scanButton";
            scanButton.Size = new Size(162, 40);
            scanButton.TabIndex = 0;
            scanButton.Text = "SCAN";
            scanButton.UseVisualStyleBackColor = true;
            scanButton.Click += scanButton_Click;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(24, 77);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(162, 41);
            connectButton.TabIndex = 1;
            connectButton.Text = "CONNECT";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(501, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(417, 524);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listServicesButton
            // 
            listServicesButton.Location = new Point(45, 233);
            listServicesButton.Margin = new Padding(3, 4, 3, 4);
            listServicesButton.Name = "listServicesButton";
            listServicesButton.Size = new Size(145, 31);
            listServicesButton.TabIndex = 3;
            listServicesButton.Text = "LIST SERVICES";
            listServicesButton.UseVisualStyleBackColor = true;
            listServicesButton.Click += listServicesButton_Click;
            // 
            // listCharactericsButton
            // 
            listCharactericsButton.Location = new Point(45, 313);
            listCharactericsButton.Margin = new Padding(3, 4, 3, 4);
            listCharactericsButton.Name = "listCharactericsButton";
            listCharactericsButton.Size = new Size(145, 52);
            listCharactericsButton.TabIndex = 4;
            listCharactericsButton.Text = "LIST CHARACTERISTICS";
            listCharactericsButton.UseVisualStyleBackColor = true;
            listCharactericsButton.Click += listCharactericsButton_Click;
            // 
            // writeButton
            // 
            writeButton.Location = new Point(45, 399);
            writeButton.Margin = new Padding(3, 4, 3, 4);
            writeButton.Name = "writeButton";
            writeButton.Size = new Size(145, 31);
            writeButton.TabIndex = 5;
            writeButton.Text = "WRITE";
            writeButton.UseVisualStyleBackColor = true;
            writeButton.Click += writeButton_Click;
            // 
            // registerNotifyButton
            // 
            registerNotifyButton.Location = new Point(45, 485);
            registerNotifyButton.Margin = new Padding(3, 4, 3, 4);
            registerNotifyButton.Name = "registerNotifyButton";
            registerNotifyButton.Size = new Size(145, 61);
            registerNotifyButton.TabIndex = 6;
            registerNotifyButton.Text = "REGISTER NOTIFY";
            registerNotifyButton.UseVisualStyleBackColor = true;
            registerNotifyButton.Click += registerNotifyButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(connectButton);
            groupBox1.Controls.Add(scanButton);
            groupBox1.Location = new Point(25, 51);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(202, 151);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "not filtered";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(localNameTextBox);
            groupBox2.Controls.Add(connectFilteredButton);
            groupBox2.Controls.Add(ScanFilteredButton);
            groupBox2.Location = new Point(244, 51);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(223, 219);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "filtered";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 48);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "local Name";
            // 
            // localNameTextBox
            // 
            localNameTextBox.Location = new Point(90, 44);
            localNameTextBox.Margin = new Padding(3, 4, 3, 4);
            localNameTextBox.Name = "localNameTextBox";
            localNameTextBox.Size = new Size(127, 27);
            localNameTextBox.TabIndex = 2;
            // 
            // connectFilteredButton
            // 
            connectFilteredButton.Location = new Point(26, 160);
            connectFilteredButton.Margin = new Padding(3, 4, 3, 4);
            connectFilteredButton.Name = "connectFilteredButton";
            connectFilteredButton.Size = new Size(86, 31);
            connectFilteredButton.TabIndex = 1;
            connectFilteredButton.Text = "CONNECT";
            connectFilteredButton.UseVisualStyleBackColor = true;
            connectFilteredButton.Click += connectFilteredButton_Click;
            // 
            // ScanFilteredButton
            // 
            ScanFilteredButton.Location = new Point(26, 105);
            ScanFilteredButton.Margin = new Padding(3, 4, 3, 4);
            ScanFilteredButton.Name = "ScanFilteredButton";
            ScanFilteredButton.Size = new Size(86, 31);
            ScanFilteredButton.TabIndex = 0;
            ScanFilteredButton.Text = "SCAN";
            ScanFilteredButton.UseVisualStyleBackColor = true;
            ScanFilteredButton.Click += ScanFilteredButton_Click;
            // 
            // BleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 607);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(registerNotifyButton);
            Controls.Add(writeButton);
            Controls.Add(listCharactericsButton);
            Controls.Add(listServicesButton);
            Controls.Add(listBox1);
            Name = "BleForm";
            Text = "BLE App";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button scanButton;
        private Button connectButton;
        private ListBox listBox1;
        private Button listServicesButton;
        private Button listCharactericsButton;
        private Button writeButton;
        private Button registerNotifyButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox localNameTextBox;
        private Button connectFilteredButton;
        private Button ScanFilteredButton;
        private Label label1;
    }
}