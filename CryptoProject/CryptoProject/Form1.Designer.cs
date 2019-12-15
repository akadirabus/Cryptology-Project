namespace CryptoProject
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
            this.lblText = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnEn = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblText.Location = new System.Drawing.Point(39, 29);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(51, 20);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Text : ";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(101, 29);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(201, 81);
            this.tbData.TabIndex = 1;
            // 
            // btnEn
            // 
            this.btnEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEn.Location = new System.Drawing.Point(43, 161);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(89, 35);
            this.btnEn.TabIndex = 2;
            this.btnEn.Text = "ENCODE";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDec.Location = new System.Drawing.Point(213, 161);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(89, 35);
            this.btnDec.TabIndex = 3;
            this.btnDec.Text = "DECODE";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(39, 213);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(67, 20);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result : ";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(101, 213);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(201, 20);
            this.tbResult.TabIndex = 7;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(101, 116);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(201, 20);
            this.tbKey.TabIndex = 9;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKey.Location = new System.Drawing.Point(39, 116);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(43, 20);
            this.lblKey.TabIndex = 8;
            this.lblKey.Text = "Key :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 286);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RC4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnEn;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lblKey;
    }
}

