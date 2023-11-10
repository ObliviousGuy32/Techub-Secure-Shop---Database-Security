namespace Shop
{
    partial class Form2SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2SignIn));
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtUsrNme = new System.Windows.Forms.TextBox();
            this.txtPsswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Black;
            this.btnVerify.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerify.Location = new System.Drawing.Point(478, 324);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 0;
            this.btnVerify.Text = "Sign In";
            this.btnVerify.UseVisualStyleBackColor = false;
            // 
            // txtUsrNme
            // 
            this.txtUsrNme.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUsrNme.Location = new System.Drawing.Point(403, 212);
            this.txtUsrNme.Name = "txtUsrNme";
            this.txtUsrNme.Size = new System.Drawing.Size(244, 22);
            this.txtUsrNme.TabIndex = 1;
            this.txtUsrNme.Text = "Username";
            // 
            // txtPsswd
            // 
            this.txtPsswd.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPsswd.Location = new System.Drawing.Point(403, 255);
            this.txtPsswd.Name = "txtPsswd";
            this.txtPsswd.Size = new System.Drawing.Size(244, 22);
            this.txtPsswd.TabIndex = 2;
            this.txtPsswd.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(448, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Not a member? Click here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Forgot your password? Click here";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(36, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPsswd);
            this.Controls.Add(this.txtUsrNme);
            this.Controls.Add(this.btnVerify);
            this.Name = "Form2SignIn";
            this.Text = "Form2SignIn";
            this.Load += new System.EventHandler(this.Form2SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtUsrNme;
        private System.Windows.Forms.TextBox txtPsswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}