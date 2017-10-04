namespace ModernProxyChecker
{
    partial class MainForm
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
            this.ProxyDataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxLog = new System.Windows.Forms.RichTextBox();
            this.btnAddProxy = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRemoveAll = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnStartTest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProxyDataGridView
            // 
            this.ProxyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProxyDataGridView.Location = new System.Drawing.Point(12, 74);
            this.ProxyDataGridView.Name = "ProxyDataGridView";
            this.ProxyDataGridView.Size = new System.Drawing.Size(327, 240);
            this.ProxyDataGridView.TabIndex = 0;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 320);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(327, 96);
            this.textBoxLog.TabIndex = 1;
            this.textBoxLog.Text = "";
            // 
            // btnAddProxy
            // 
            this.btnAddProxy.Depth = 0;
            this.btnAddProxy.Location = new System.Drawing.Point(345, 74);
            this.btnAddProxy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddProxy.Name = "btnAddProxy";
            this.btnAddProxy.Primary = true;
            this.btnAddProxy.Size = new System.Drawing.Size(75, 23);
            this.btnAddProxy.TabIndex = 2;
            this.btnAddProxy.Text = "Add";
            this.btnAddProxy.UseVisualStyleBackColor = true;
            this.btnAddProxy.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Depth = 0;
            this.btnRemoveAll.Location = new System.Drawing.Point(345, 104);
            this.btnRemoveAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Primary = true;
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "Clear";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.Depth = 0;
            this.btnStartTest.Location = new System.Drawing.Point(345, 320);
            this.btnStartTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Primary = true;
            this.btnStartTest.Size = new System.Drawing.Size(75, 23);
            this.btnStartTest.TabIndex = 5;
            this.btnStartTest.Text = "Start";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // button1
            // 
            this.button1.Depth = 0;
            this.button1.Location = new System.Drawing.Point(345, 349);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(433, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnAddProxy);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.ProxyDataGridView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modern Proxy Checker";
            ((System.ComponentModel.ISupportInitialize)(this.ProxyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProxyDataGridView;
        private System.Windows.Forms.RichTextBox textBoxLog;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddProxy;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemoveAll;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartTest;
        private MaterialSkin.Controls.MaterialRaisedButton button1;
    }
}

