﻿namespace Phantom
{
    partial class ByteCrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByteCrypt));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.antiDebug = new System.Windows.Forms.CheckBox();
            this.buildButton = new System.Windows.Forms.Button();
            this.selfDelete = new System.Windows.Forms.CheckBox();
            this.hidden = new System.Windows.Forms.CheckBox();
            this.antiVM = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.optionsPage = new System.Windows.Forms.TabPage();
            this.powershellcontents = new System.Windows.Forms.RichTextBox();
            this.customPowershell = new System.Windows.Forms.CheckBox();
            this.testMessagebox = new System.Windows.Forms.Button();
            this.messageboxcontent = new System.Windows.Forms.RichTextBox();
            this.messageBox = new System.Windows.Forms.CheckBox();
            this.executionDelay = new System.Windows.Forms.CheckBox();
            this.mutex = new System.Windows.Forms.CheckBox();
            this.rootkit = new System.Windows.Forms.CheckBox();
            this.uacBypass = new System.Windows.Forms.CheckBox();
            this.startup = new System.Windows.Forms.CheckBox();
            this.runas = new System.Windows.Forms.CheckBox();
            this.binderPage = new System.Windows.Forms.TabPage();
            this.removeFile = new System.Windows.Forms.Button();
            this.addFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.outputPage = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.optionsPage.SuspendLayout();
            this.binderPage.SuspendLayout();
            this.outputPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "File path:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 20);
            this.textBox1.TabIndex = 1;
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(388, 27);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(60, 20);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // antiDebug
            // 
            this.antiDebug.AutoSize = true;
            this.antiDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiDebug.Location = new System.Drawing.Point(3, 3);
            this.antiDebug.Margin = new System.Windows.Forms.Padding(2);
            this.antiDebug.Name = "antiDebug";
            this.antiDebug.Size = new System.Drawing.Size(86, 19);
            this.antiDebug.TabIndex = 6;
            this.antiDebug.Text = "Anti Debug";
            this.antiDebug.UseVisualStyleBackColor = true;
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(9, 287);
            this.buildButton.Margin = new System.Windows.Forms.Padding(2);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(440, 38);
            this.buildButton.TabIndex = 7;
            this.buildButton.Text = "Build";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // selfDelete
            // 
            this.selfDelete.AutoSize = true;
            this.selfDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selfDelete.Location = new System.Drawing.Point(3, 43);
            this.selfDelete.Margin = new System.Windows.Forms.Padding(2);
            this.selfDelete.Name = "selfDelete";
            this.selfDelete.Size = new System.Drawing.Size(69, 19);
            this.selfDelete.TabIndex = 8;
            this.selfDelete.Text = "Melt file";
            this.selfDelete.UseVisualStyleBackColor = true;
            // 
            // hidden
            // 
            this.hidden.AutoSize = true;
            this.hidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidden.Location = new System.Drawing.Point(3, 62);
            this.hidden.Margin = new System.Windows.Forms.Padding(2);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(98, 19);
            this.hidden.TabIndex = 9;
            this.hidden.Text = "Hide console";
            this.hidden.UseVisualStyleBackColor = true;
            // 
            // antiVM
            // 
            this.antiVM.AutoSize = true;
            this.antiVM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiVM.Location = new System.Drawing.Point(3, 23);
            this.antiVM.Margin = new System.Windows.Forms.Padding(2);
            this.antiVM.Name = "antiVM";
            this.antiVM.Size = new System.Drawing.Size(67, 19);
            this.antiVM.TabIndex = 10;
            this.antiVM.Text = "Anti VM";
            this.antiVM.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.optionsPage);
            this.tabControl1.Controls.Add(this.binderPage);
            this.tabControl1.Controls.Add(this.outputPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 52);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 232);
            this.tabControl1.TabIndex = 11;
            // 
            // optionsPage
            // 
            this.optionsPage.Controls.Add(this.powershellcontents);
            this.optionsPage.Controls.Add(this.customPowershell);
            this.optionsPage.Controls.Add(this.testMessagebox);
            this.optionsPage.Controls.Add(this.messageboxcontent);
            this.optionsPage.Controls.Add(this.messageBox);
            this.optionsPage.Controls.Add(this.executionDelay);
            this.optionsPage.Controls.Add(this.mutex);
            this.optionsPage.Controls.Add(this.rootkit);
            this.optionsPage.Controls.Add(this.uacBypass);
            this.optionsPage.Controls.Add(this.startup);
            this.optionsPage.Controls.Add(this.runas);
            this.optionsPage.Controls.Add(this.hidden);
            this.optionsPage.Controls.Add(this.selfDelete);
            this.optionsPage.Controls.Add(this.antiDebug);
            this.optionsPage.Controls.Add(this.antiVM);
            this.optionsPage.Location = new System.Drawing.Point(4, 22);
            this.optionsPage.Margin = new System.Windows.Forms.Padding(2);
            this.optionsPage.Name = "optionsPage";
            this.optionsPage.Padding = new System.Windows.Forms.Padding(2);
            this.optionsPage.Size = new System.Drawing.Size(430, 206);
            this.optionsPage.TabIndex = 0;
            this.optionsPage.Text = "Options";
            this.optionsPage.UseVisualStyleBackColor = true;
            // 
            // powershellcontents
            // 
            this.powershellcontents.Enabled = false;
            this.powershellcontents.Location = new System.Drawing.Point(152, 140);
            this.powershellcontents.Name = "powershellcontents";
            this.powershellcontents.Size = new System.Drawing.Size(271, 58);
            this.powershellcontents.TabIndex = 21;
            this.powershellcontents.Text = "powershell.exe {Your-Command-Here}";
            // 
            // customPowershell
            // 
            this.customPowershell.AutoSize = true;
            this.customPowershell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customPowershell.Location = new System.Drawing.Point(152, 120);
            this.customPowershell.Margin = new System.Windows.Forms.Padding(2);
            this.customPowershell.Name = "customPowershell";
            this.customPowershell.Size = new System.Drawing.Size(195, 19);
            this.customPowershell.TabIndex = 20;
            this.customPowershell.Text = "Custom PowerShell Command";
            this.customPowershell.UseVisualStyleBackColor = true;
            this.customPowershell.CheckedChanged += new System.EventHandler(this.customPowershell_CheckedChanged);
            // 
            // testMessagebox
            // 
            this.testMessagebox.Location = new System.Drawing.Point(315, 85);
            this.testMessagebox.Name = "testMessagebox";
            this.testMessagebox.Size = new System.Drawing.Size(108, 23);
            this.testMessagebox.TabIndex = 19;
            this.testMessagebox.Text = "Test Messagebox";
            this.testMessagebox.UseVisualStyleBackColor = true;
            this.testMessagebox.Click += new System.EventHandler(this.testMessagebox_Click);
            // 
            // messageboxcontent
            // 
            this.messageboxcontent.Enabled = false;
            this.messageboxcontent.Location = new System.Drawing.Point(152, 23);
            this.messageboxcontent.Name = "messageboxcontent";
            this.messageboxcontent.Size = new System.Drawing.Size(271, 58);
            this.messageboxcontent.TabIndex = 18;
            this.messageboxcontent.Text = "";
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.Location = new System.Drawing.Point(152, 3);
            this.messageBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(97, 19);
            this.messageBox.TabIndex = 17;
            this.messageBox.Text = "Messagebox";
            this.messageBox.UseVisualStyleBackColor = true;
            this.messageBox.CheckedChanged += new System.EventHandler(this.messageBox_CheckedChanged);
            // 
            // executionDelay
            // 
            this.executionDelay.AutoSize = true;
            this.executionDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executionDelay.Location = new System.Drawing.Point(3, 180);
            this.executionDelay.Margin = new System.Windows.Forms.Padding(2);
            this.executionDelay.Name = "executionDelay";
            this.executionDelay.Size = new System.Drawing.Size(114, 19);
            this.executionDelay.TabIndex = 16;
            this.executionDelay.Text = "Execution Delay";
            this.executionDelay.UseVisualStyleBackColor = true;
            // 
            // mutex
            // 
            this.mutex.AutoSize = true;
            this.mutex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutex.Location = new System.Drawing.Point(3, 160);
            this.mutex.Margin = new System.Windows.Forms.Padding(2);
            this.mutex.Name = "mutex";
            this.mutex.Size = new System.Drawing.Size(110, 19);
            this.mutex.TabIndex = 15;
            this.mutex.Text = "Single Instance";
            this.mutex.UseVisualStyleBackColor = true;
            this.mutex.CheckedChanged += new System.EventHandler(this.mutex_CheckedChanged);
            // 
            // rootkit
            // 
            this.rootkit.AutoSize = true;
            this.rootkit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootkit.Location = new System.Drawing.Point(3, 140);
            this.rootkit.Margin = new System.Windows.Forms.Padding(2);
            this.rootkit.Name = "rootkit";
            this.rootkit.Size = new System.Drawing.Size(64, 19);
            this.rootkit.TabIndex = 14;
            this.rootkit.Text = "Rootkit";
            this.rootkit.UseVisualStyleBackColor = true;
            this.rootkit.CheckedChanged += new System.EventHandler(this.rootkit_CheckedChanged);
            // 
            // uacBypass
            // 
            this.uacBypass.AutoSize = true;
            this.uacBypass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uacBypass.Location = new System.Drawing.Point(3, 120);
            this.uacBypass.Margin = new System.Windows.Forms.Padding(2);
            this.uacBypass.Name = "uacBypass";
            this.uacBypass.Size = new System.Drawing.Size(92, 19);
            this.uacBypass.TabIndex = 13;
            this.uacBypass.Text = "UAC Bypass";
            this.uacBypass.UseVisualStyleBackColor = true;
            this.uacBypass.CheckedChanged += new System.EventHandler(this.uacBypass_CheckedChanged);
            // 
            // startup
            // 
            this.startup.AutoSize = true;
            this.startup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startup.Location = new System.Drawing.Point(3, 101);
            this.startup.Margin = new System.Windows.Forms.Padding(2);
            this.startup.Name = "startup";
            this.startup.Size = new System.Drawing.Size(85, 19);
            this.startup.TabIndex = 12;
            this.startup.Text = "Installation";
            this.startup.UseVisualStyleBackColor = true;
            this.startup.CheckedChanged += new System.EventHandler(this.startup_CheckedChanged);
            // 
            // runas
            // 
            this.runas.AutoSize = true;
            this.runas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runas.Location = new System.Drawing.Point(3, 82);
            this.runas.Margin = new System.Windows.Forms.Padding(2);
            this.runas.Name = "runas";
            this.runas.Size = new System.Drawing.Size(103, 19);
            this.runas.TabIndex = 11;
            this.runas.Text = "Run as admin";
            this.runas.UseVisualStyleBackColor = true;
            this.runas.CheckedChanged += new System.EventHandler(this.runas_CheckedChanged);
            // 
            // binderPage
            // 
            this.binderPage.Controls.Add(this.removeFile);
            this.binderPage.Controls.Add(this.addFile);
            this.binderPage.Controls.Add(this.listBox1);
            this.binderPage.Location = new System.Drawing.Point(4, 22);
            this.binderPage.Margin = new System.Windows.Forms.Padding(2);
            this.binderPage.Name = "binderPage";
            this.binderPage.Padding = new System.Windows.Forms.Padding(2);
            this.binderPage.Size = new System.Drawing.Size(430, 206);
            this.binderPage.TabIndex = 2;
            this.binderPage.Text = "Binder";
            this.binderPage.UseVisualStyleBackColor = true;
            // 
            // removeFile
            // 
            this.removeFile.Location = new System.Drawing.Point(98, 177);
            this.removeFile.Margin = new System.Windows.Forms.Padding(2);
            this.removeFile.Name = "removeFile";
            this.removeFile.Size = new System.Drawing.Size(93, 27);
            this.removeFile.TabIndex = 2;
            this.removeFile.Text = "Remove file";
            this.removeFile.UseVisualStyleBackColor = true;
            this.removeFile.Click += new System.EventHandler(this.removeFile_Click);
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(2, 177);
            this.addFile.Margin = new System.Windows.Forms.Padding(2);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(93, 27);
            this.addFile.TabIndex = 1;
            this.addFile.Text = "Add file";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 4);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 160);
            this.listBox1.TabIndex = 0;
            // 
            // outputPage
            // 
            this.outputPage.Controls.Add(this.listBox2);
            this.outputPage.Location = new System.Drawing.Point(4, 22);
            this.outputPage.Margin = new System.Windows.Forms.Padding(2);
            this.outputPage.Name = "outputPage";
            this.outputPage.Padding = new System.Windows.Forms.Padding(2);
            this.outputPage.Size = new System.Drawing.Size(430, 206);
            this.outputPage.TabIndex = 3;
            this.outputPage.Text = "Output";
            this.outputPage.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(426, 186);
            this.listBox2.TabIndex = 4;
            // 
            // PhantomMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(457, 334);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PhantomMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ByteCrypt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.optionsPage.ResumeLayout(false);
            this.optionsPage.PerformLayout();
            this.binderPage.ResumeLayout(false);
            this.outputPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.CheckBox antiDebug;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.CheckBox selfDelete;
        private System.Windows.Forms.CheckBox hidden;
        private System.Windows.Forms.CheckBox antiVM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage optionsPage;
        private System.Windows.Forms.TabPage binderPage;
        private System.Windows.Forms.TabPage outputPage;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button removeFile;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.CheckBox runas;
        private System.Windows.Forms.CheckBox startup;
        private System.Windows.Forms.CheckBox uacBypass;
        private System.Windows.Forms.CheckBox rootkit;
        private System.Windows.Forms.CheckBox mutex;
        private System.Windows.Forms.CheckBox executionDelay;
        private System.Windows.Forms.CheckBox messageBox;
        private System.Windows.Forms.RichTextBox messageboxcontent;
        private System.Windows.Forms.Button testMessagebox;
        private System.Windows.Forms.CheckBox customPowershell;
        private System.Windows.Forms.RichTextBox powershellcontents;
    }
}