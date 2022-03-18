
namespace DemoSerialNumber
{
     partial class Register
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
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.txtName = new System.Windows.Forms.TextBox();
               this.txtUsername = new System.Windows.Forms.TextBox();
               this.txtPassword = new System.Windows.Forms.TextBox();
               this.txtConfirmPassword = new System.Windows.Forms.TextBox();
               this.btnRegister = new System.Windows.Forms.Button();
               this.label6 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label1.Location = new System.Drawing.Point(324, 46);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(200, 32);
               this.label1.TabIndex = 0;
               this.label1.Text = "Tạo tài khoản";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(158, 119);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(69, 17);
               this.label2.TabIndex = 1;
               this.label2.Text = "Họ và tên";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(158, 185);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(105, 17);
               this.label3.TabIndex = 2;
               this.label3.Text = "Tên đăng nhập";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(161, 251);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(66, 17);
               this.label4.TabIndex = 3;
               this.label4.Text = "Mật khẩu";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(158, 313);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(125, 17);
               this.label5.TabIndex = 4;
               this.label5.Text = "Xác thực mật khẩu";
               // 
               // txtName
               // 
               this.txtName.Location = new System.Drawing.Point(307, 113);
               this.txtName.Name = "txtName";
               this.txtName.Size = new System.Drawing.Size(266, 22);
               this.txtName.TabIndex = 5;
               // 
               // txtUsername
               // 
               this.txtUsername.Location = new System.Drawing.Point(307, 182);
               this.txtUsername.Name = "txtUsername";
               this.txtUsername.Size = new System.Drawing.Size(266, 22);
               this.txtUsername.TabIndex = 6;
               // 
               // txtPassword
               // 
               this.txtPassword.Location = new System.Drawing.Point(307, 246);
               this.txtPassword.Name = "txtPassword";
               this.txtPassword.Size = new System.Drawing.Size(266, 22);
               this.txtPassword.TabIndex = 7;
               this.txtPassword.UseSystemPasswordChar = true;
               // 
               // txtConfirmPassword
               // 
               this.txtConfirmPassword.Location = new System.Drawing.Point(307, 308);
               this.txtConfirmPassword.Name = "txtConfirmPassword";
               this.txtConfirmPassword.Size = new System.Drawing.Size(266, 22);
               this.txtConfirmPassword.TabIndex = 8;
               this.txtConfirmPassword.UseSystemPasswordChar = true;
               // 
               // btnRegister
               // 
               this.btnRegister.Location = new System.Drawing.Point(366, 350);
               this.btnRegister.Name = "btnRegister";
               this.btnRegister.Size = new System.Drawing.Size(124, 44);
               this.btnRegister.TabIndex = 9;
               this.btnRegister.Text = "Đăng ký";
               this.btnRegister.UseVisualStyleBackColor = true;
               this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.ForeColor = System.Drawing.Color.Blue;
               this.label6.Location = new System.Drawing.Point(363, 409);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(132, 17);
               this.label6.TabIndex = 10;
               this.label6.Text = "Quay lại đăng nhập";
               this.label6.Click += new System.EventHandler(this.label6_Click);
               // 
               // Register
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.btnRegister);
               this.Controls.Add(this.txtConfirmPassword);
               this.Controls.Add(this.txtPassword);
               this.Controls.Add(this.txtUsername);
               this.Controls.Add(this.txtName);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Name = "Register";
               this.Text = "Register";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.TextBox txtName;
          private System.Windows.Forms.TextBox txtUsername;
          private System.Windows.Forms.TextBox txtPassword;
          private System.Windows.Forms.TextBox txtConfirmPassword;
          private System.Windows.Forms.Button btnRegister;
          private System.Windows.Forms.Label label6;
     }
}