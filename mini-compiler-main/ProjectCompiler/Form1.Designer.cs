namespace ProjectCompiler
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAnalyzer = new System.Windows.Forms.Button();
            this.buttonMemory = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelLog = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControls.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mini Compiler";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(13, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(827, 161);
            this.textBox1.TabIndex = 1;
            // 
            // buttonScan
            // 
            this.buttonScan.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonScan.ForeColor = System.Drawing.Color.White;
            this.buttonScan.Location = new System.Drawing.Point(13, 13);
            this.buttonScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(120, 43);
            this.buttonScan.TabIndex = 2;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = false;
            this.buttonScan.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(694, 13);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(120, 43);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAnalyzer
            // 
            this.buttonAnalyzer.BackColor = System.Drawing.Color.Teal;
            this.buttonAnalyzer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalyzer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAnalyzer.ForeColor = System.Drawing.Color.White;
            this.buttonAnalyzer.Location = new System.Drawing.Point(140, 13);
            this.buttonAnalyzer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAnalyzer.Name = "buttonAnalyzer";
            this.buttonAnalyzer.Size = new System.Drawing.Size(200, 43);
            this.buttonAnalyzer.TabIndex = 4;
            this.buttonAnalyzer.Text = "Semantic Analyzer";
            this.buttonAnalyzer.UseVisualStyleBackColor = false;
            this.buttonAnalyzer.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMemory
            // 
            this.buttonMemory.BackColor = System.Drawing.Color.Teal;
            this.buttonMemory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMemory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMemory.ForeColor = System.Drawing.Color.White;
            this.buttonMemory.Location = new System.Drawing.Point(353, 13);
            this.buttonMemory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMemory.Name = "buttonMemory";
            this.buttonMemory.Size = new System.Drawing.Size(160, 43);
            this.buttonMemory.TabIndex = 5;
            this.buttonMemory.Text = "Memory";
            this.buttonMemory.UseVisualStyleBackColor = false;
            this.buttonMemory.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelControls.Controls.Add(this.buttonScan);
            this.panelControls.Controls.Add(this.buttonAnalyzer);
            this.panelControls.Controls.Add(this.buttonMemory);
            this.panelControls.Controls.Add(this.buttonReset);
            this.panelControls.Location = new System.Drawing.Point(13, 243);
            this.panelControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(827, 58);
            this.panelControls.TabIndex = 6;
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.White;
            this.panelLog.Controls.Add(this.flowLayoutPanel1);
            this.panelLog.Location = new System.Drawing.Point(13, 307);
            this.panelLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(827, 320);
            this.panelLog.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(827, 320);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 653);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Compiler CS334";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelControls.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAnalyzer;
        private System.Windows.Forms.Button buttonMemory;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
