namespace sevilization
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnXMLwrite = new System.Windows.Forms.Button();
            this.btnXMLread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnjsonread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(130, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "deptId";
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Location = new System.Drawing.Point(361, 26);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(114, 37);
            this.btnbinarywrite.TabIndex = 2;
            this.btnbinarywrite.Text = "binary write";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            this.btnbinarywrite.Click += new System.EventHandler(this.btnbinarywrite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "deptname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "deptlocation\r\n\r\n";
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(130, 147);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(100, 22);
            this.txtlocation.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(130, 70);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 6;
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(521, 26);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(134, 37);
            this.btnbinaryread.TabIndex = 7;
            this.btnbinaryread.Text = "binary read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // btnXMLwrite
            // 
            this.btnXMLwrite.Location = new System.Drawing.Point(361, 95);
            this.btnXMLwrite.Name = "btnXMLwrite";
            this.btnXMLwrite.Size = new System.Drawing.Size(114, 39);
            this.btnXMLwrite.TabIndex = 8;
            this.btnXMLwrite.Text = "XML write";
            this.btnXMLwrite.UseVisualStyleBackColor = true;
            this.btnXMLwrite.Click += new System.EventHandler(this.btnXMLwrite_Click);
            // 
            // btnXMLread
            // 
            this.btnXMLread.Location = new System.Drawing.Point(521, 91);
            this.btnXMLread.Name = "btnXMLread";
            this.btnXMLread.Size = new System.Drawing.Size(134, 43);
            this.btnXMLread.TabIndex = 9;
            this.btnXMLread.Text = "XML read";
            this.btnXMLread.UseVisualStyleBackColor = true;
            this.btnXMLread.Click += new System.EventHandler(this.btnXMLread_Click);
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Location = new System.Drawing.Point(361, 178);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(124, 38);
            this.btnsoapwrite.TabIndex = 10;
            this.btnsoapwrite.Text = "soap write";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            this.btnsoapwrite.Click += new System.EventHandler(this.btnsoapwrite_Click);
            // 
            // btnsoapread
            // 
            this.btnsoapread.Location = new System.Drawing.Point(521, 178);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(134, 38);
            this.btnsoapread.TabIndex = 11;
            this.btnsoapread.Text = "soap read";
            this.btnsoapread.UseVisualStyleBackColor = true;
            this.btnsoapread.Click += new System.EventHandler(this.btnsoapread_Click);
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(362, 251);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(124, 41);
            this.btnjsonwrite.TabIndex = 12;
            this.btnjsonwrite.Text = "json write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            this.btnjsonwrite.Click += new System.EventHandler(this.btnjsonwrite_Click);
            // 
            // btnjsonread
            // 
            this.btnjsonread.Location = new System.Drawing.Point(521, 251);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(134, 41);
            this.btnjsonread.TabIndex = 13;
            this.btnjsonread.Text = "json read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            this.btnjsonread.Click += new System.EventHandler(this.btnjsonread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjsonread);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnsoapread);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnXMLread);
            this.Controls.Add(this.btnXMLwrite);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "serilazation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnXMLwrite;
        private System.Windows.Forms.Button btnXMLread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnjsonread;
    }
}

