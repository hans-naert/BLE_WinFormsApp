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
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(67, 70);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(94, 29);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "SCAN";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(67, 149);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(94, 29);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(196, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(572, 404);
            this.listBox1.TabIndex = 2;
            // 
            // BleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.scanButton);
            this.Name = "BleForm";
            this.Text = "BLE App";
            this.ResumeLayout(false);

        }

        #endregion

        private Button scanButton;
        private Button connectButton;
        private ListBox listBox1;
    }
}