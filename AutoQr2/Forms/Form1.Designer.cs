namespace AutoQr2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.RunButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gen1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gen1Ref = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Gen2TextBox = new System.Windows.Forms.TextBox();
            this.Gen3TextBox = new System.Windows.Forms.TextBox();
            this.Gen4TextBox = new System.Windows.Forms.TextBox();
            this.Gen2Ref = new System.Windows.Forms.Button();
            this.Gen3Ref = new System.Windows.Forms.Button();
            this.Gen4Ref = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PassViewButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ObsPathRef = new System.Windows.Forms.Button();
            this.ObsPathTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(491, 136);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "実行";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IdTextBox.Location = new System.Drawing.Point(368, 62);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(152, 19);
            this.IdTextBox.TabIndex = 1;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(368, 87);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '●';
            this.PassTextBox.Size = new System.Drawing.Size(152, 19);
            this.PassTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "1限";
            // 
            // Gen1TextBox
            // 
            this.Gen1TextBox.Location = new System.Drawing.Point(41, 12);
            this.Gen1TextBox.Name = "Gen1TextBox";
            this.Gen1TextBox.ReadOnly = true;
            this.Gen1TextBox.Size = new System.Drawing.Size(223, 19);
            this.Gen1TextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "2限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "3限";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "4限";
            // 
            // Gen1Ref
            // 
            this.Gen1Ref.Location = new System.Drawing.Point(270, 10);
            this.Gen1Ref.Name = "Gen1Ref";
            this.Gen1Ref.Size = new System.Drawing.Size(23, 23);
            this.Gen1Ref.TabIndex = 13;
            this.Gen1Ref.Text = "...";
            this.Gen1Ref.UseVisualStyleBackColor = true;
            this.Gen1Ref.Click += new System.EventHandler(this.Gen1Ref_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "ログインID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "パスワード";
            // 
            // Gen2TextBox
            // 
            this.Gen2TextBox.Location = new System.Drawing.Point(41, 37);
            this.Gen2TextBox.Name = "Gen2TextBox";
            this.Gen2TextBox.ReadOnly = true;
            this.Gen2TextBox.Size = new System.Drawing.Size(223, 19);
            this.Gen2TextBox.TabIndex = 16;
            // 
            // Gen3TextBox
            // 
            this.Gen3TextBox.Location = new System.Drawing.Point(41, 62);
            this.Gen3TextBox.Name = "Gen3TextBox";
            this.Gen3TextBox.ReadOnly = true;
            this.Gen3TextBox.Size = new System.Drawing.Size(223, 19);
            this.Gen3TextBox.TabIndex = 17;
            // 
            // Gen4TextBox
            // 
            this.Gen4TextBox.Location = new System.Drawing.Point(41, 87);
            this.Gen4TextBox.Name = "Gen4TextBox";
            this.Gen4TextBox.ReadOnly = true;
            this.Gen4TextBox.Size = new System.Drawing.Size(223, 19);
            this.Gen4TextBox.TabIndex = 18;
            // 
            // Gen2Ref
            // 
            this.Gen2Ref.Location = new System.Drawing.Point(270, 35);
            this.Gen2Ref.Name = "Gen2Ref";
            this.Gen2Ref.Size = new System.Drawing.Size(23, 23);
            this.Gen2Ref.TabIndex = 20;
            this.Gen2Ref.Text = "...";
            this.Gen2Ref.UseVisualStyleBackColor = true;
            this.Gen2Ref.Click += new System.EventHandler(this.Gen2Ref_Click);
            // 
            // Gen3Ref
            // 
            this.Gen3Ref.Location = new System.Drawing.Point(270, 60);
            this.Gen3Ref.Name = "Gen3Ref";
            this.Gen3Ref.Size = new System.Drawing.Size(23, 23);
            this.Gen3Ref.TabIndex = 21;
            this.Gen3Ref.Text = "...";
            this.Gen3Ref.UseVisualStyleBackColor = true;
            this.Gen3Ref.Click += new System.EventHandler(this.Gen3Ref_Click);
            // 
            // Gen4Ref
            // 
            this.Gen4Ref.Location = new System.Drawing.Point(270, 85);
            this.Gen4Ref.Name = "Gen4Ref";
            this.Gen4Ref.Size = new System.Drawing.Size(23, 23);
            this.Gen4Ref.TabIndex = 22;
            this.Gen4Ref.Text = "...";
            this.Gen4Ref.UseVisualStyleBackColor = true;
            this.Gen4Ref.Click += new System.EventHandler(this.Gen4Ref_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(410, 136);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PassViewButton
            // 
            this.PassViewButton.Location = new System.Drawing.Point(526, 85);
            this.PassViewButton.Name = "PassViewButton";
            this.PassViewButton.Size = new System.Drawing.Size(40, 23);
            this.PassViewButton.TabIndex = 27;
            this.PassViewButton.Text = "表示";
            this.PassViewButton.UseVisualStyleBackColor = true;
            this.PassViewButton.Click += new System.EventHandler(this.PassViewButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "OBSパス";
            // 
            // ObsPathRef
            // 
            this.ObsPathRef.Location = new System.Drawing.Point(543, 10);
            this.ObsPathRef.Name = "ObsPathRef";
            this.ObsPathRef.Size = new System.Drawing.Size(23, 23);
            this.ObsPathRef.TabIndex = 31;
            this.ObsPathRef.Text = "...";
            this.ObsPathRef.UseVisualStyleBackColor = true;
            this.ObsPathRef.Click += new System.EventHandler(this.ObsPathRef_Click);
            // 
            // ObsPathTextBox
            // 
            this.ObsPathTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ObsPathTextBox.Location = new System.Drawing.Point(368, 12);
            this.ObsPathTextBox.Name = "ObsPathTextBox";
            this.ObsPathTextBox.ReadOnly = true;
            this.ObsPathTextBox.Size = new System.Drawing.Size(169, 19);
            this.ObsPathTextBox.TabIndex = 32;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 147);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 12);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "バグ報告";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 175);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ObsPathTextBox);
            this.Controls.Add(this.ObsPathRef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassViewButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Gen4Ref);
            this.Controls.Add(this.Gen3Ref);
            this.Controls.Add(this.Gen2Ref);
            this.Controls.Add(this.Gen4TextBox);
            this.Controls.Add(this.Gen3TextBox);
            this.Controls.Add(this.Gen2TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gen1Ref);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gen1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RunButton);
            this.Name = "Form1";
            this.Text = "AutoQR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Gen1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Gen1Ref;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Gen2TextBox;
        private System.Windows.Forms.TextBox Gen3TextBox;
        private System.Windows.Forms.TextBox Gen4TextBox;
        private System.Windows.Forms.Button Gen2Ref;
        private System.Windows.Forms.Button Gen3Ref;
        private System.Windows.Forms.Button Gen4Ref;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button PassViewButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ObsPathRef;
        private System.Windows.Forms.TextBox ObsPathTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

