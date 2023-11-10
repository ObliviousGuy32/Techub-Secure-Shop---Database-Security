namespace Shop
{
    partial class Form3SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3SignUp));
            this.txtPsswd = new System.Windows.Forms.TextBox();
            this.txtUsrNme = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPsswd
            // 
            this.txtPsswd.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPsswd.Location = new System.Drawing.Point(381, 240);
            this.txtPsswd.Name = "txtPsswd";
            this.txtPsswd.Size = new System.Drawing.Size(244, 22);
            this.txtPsswd.TabIndex = 4;
            this.txtPsswd.Text = "Email";
            // 
            // txtUsrNme
            // 
            this.txtUsrNme.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUsrNme.Location = new System.Drawing.Point(381, 197);
            this.txtUsrNme.Name = "txtUsrNme";
            this.txtUsrNme.Size = new System.Drawing.Size(244, 22);
            this.txtUsrNme.TabIndex = 3;
            this.txtUsrNme.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(381, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Location = new System.Drawing.Point(381, 279);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtPsswd);
            this.Controls.Add(this.txtUsrNme);
            this.DoubleBuffered = true;
            this.Name = "Form3SignUp";
            this.Text = "Form3SignUp";
            this.Load += new System.EventHandler(this.Form3SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPsswd;
        private System.Windows.Forms.TextBox txtUsrNme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}