namespace CompArch_GUI
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
            this.runButton = new System.Windows.Forms.Button();
            this.stepButton = new System.Windows.Forms.Button();
            this.regOne = new System.Windows.Forms.Label();
            this.regTwo = new System.Windows.Forms.Label();
            this.regThr = new System.Windows.Forms.Label();
            this.monitorVM = new System.Windows.Forms.PictureBox();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hexViewerAddrBox = new System.Windows.Forms.TextBox();
            this.hexViewer = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.monitorVM)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(54, 346);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(145, 346);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 1;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            // 
            // regOne
            // 
            this.regOne.AutoSize = true;
            this.regOne.Location = new System.Drawing.Point(374, 36);
            this.regOne.Name = "regOne";
            this.regOne.Size = new System.Drawing.Size(35, 13);
            this.regOne.TabIndex = 2;
            this.regOne.Text = "label1";
            this.regOne.Click += new System.EventHandler(this.label1_Click);
            // 
            // regTwo
            // 
            this.regTwo.AutoSize = true;
            this.regTwo.Location = new System.Drawing.Point(374, 69);
            this.regTwo.Name = "regTwo";
            this.regTwo.Size = new System.Drawing.Size(35, 13);
            this.regTwo.TabIndex = 3;
            this.regTwo.Text = "label2";
            // 
            // regThr
            // 
            this.regThr.AutoSize = true;
            this.regThr.Location = new System.Drawing.Point(374, 104);
            this.regThr.Name = "regThr";
            this.regThr.Size = new System.Drawing.Size(35, 13);
            this.regThr.TabIndex = 4;
            this.regThr.Text = "label3";
            // 
            // monitorVM
            // 
            this.monitorVM.Location = new System.Drawing.Point(54, 36);
            this.monitorVM.Name = "monitorVM";
            this.monitorVM.Size = new System.Drawing.Size(256, 256);
            this.monitorVM.TabIndex = 5;
            this.monitorVM.TabStop = false;
            this.monitorVM.Click += new System.EventHandler(this.monitorVM_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(235, 346);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 170);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 122);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "dfdf\r\ndffd";
            // 
            // hexViewerAddrBox
            // 
            this.hexViewerAddrBox.Location = new System.Drawing.Point(614, 191);
            this.hexViewerAddrBox.Name = "hexViewerAddrBox";
            this.hexViewerAddrBox.Size = new System.Drawing.Size(120, 20);
            this.hexViewerAddrBox.TabIndex = 10;
            this.hexViewerAddrBox.TextChanged += new System.EventHandler(this.hexViewerAddrBox_TextChanged);
            this.hexViewerAddrBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hexViewerAddrBox_KeyPress);
            // 
            // hexViewer
            // 
            this.hexViewer.FormattingEnabled = true;
            this.hexViewer.Location = new System.Drawing.Point(538, 217);
            this.hexViewer.MaximumSize = new System.Drawing.Size(1000, 100);
            this.hexViewer.Name = "hexViewer";
            this.hexViewer.Size = new System.Drawing.Size(252, 95);
            this.hexViewer.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 537);
            this.Controls.Add(this.hexViewer);
            this.Controls.Add(this.hexViewerAddrBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.monitorVM);
            this.Controls.Add(this.regThr);
            this.Controls.Add(this.regTwo);
            this.Controls.Add(this.regOne);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.runButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monitorVM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Label regOne;
        private System.Windows.Forms.Label regTwo;
        private System.Windows.Forms.Label regThr;
        private System.Windows.Forms.PictureBox monitorVM;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox hexViewerAddrBox;
        private System.Windows.Forms.ListBox hexViewer;
    }
}

