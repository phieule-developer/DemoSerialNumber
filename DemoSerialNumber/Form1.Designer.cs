
namespace DemoSerialNumber
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
               this.label2 = new System.Windows.Forms.Label();
               this.btnLogin = new System.Windows.Forms.Button();
               this.label3 = new System.Windows.Forms.Label();
               this.lbComputerCode = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.txtUserName = new System.Windows.Forms.TextBox();
               this.txtPassword = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label2.Location = new System.Drawing.Point(258, 60);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(278, 32);
               this.label2.TabIndex = 2;
               this.label2.Text = "Demo Serial Number";
               this.label2.Click += new System.EventHandler(this.label2_Click);
               // 
               // btnLogin
               // 
               this.btnLogin.Location = new System.Drawing.Point(326, 326);
               this.btnLogin.Name = "btnLogin";
               this.btnLogin.Size = new System.Drawing.Size(168, 41);
               this.btnLogin.TabIndex = 3;
               this.btnLogin.Text = "Đăng Nhập";
               this.btnLogin.UseVisualStyleBackColor = true;
               this.btnLogin.Click += new System.EventHandler(this.btnContinue_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(209, 396);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(61, 17);
               this.label3.TabIndex = 4;
               this.label3.Text = "Mã máy:";
               // 
               // lbComputerCode
               // 
               this.lbComputerCode.AutoSize = true;
               this.lbComputerCode.Location = new System.Drawing.Point(288, 396);
               this.lbComputerCode.Name = "lbComputerCode";
               this.lbComputerCode.Size = new System.Drawing.Size(72, 17);
               this.lbComputerCode.TabIndex = 5;
               this.lbComputerCode.Text = "ABCDXYZ";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(199, 166);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(71, 17);
               this.label1.TabIndex = 6;
               this.label1.Text = "Tài khoản";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(199, 227);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(66, 17);
               this.label4.TabIndex = 7;
               this.label4.Text = "Mật khẩu";
               // 
               // txtUserName
               // 
               this.txtUserName.Location = new System.Drawing.Point(311, 161);
               this.txtUserName.Name = "txtUserName";
               this.txtUserName.Size = new System.Drawing.Size(245, 22);
               this.txtUserName.TabIndex = 8;
               // 
               // txtPassword
               // 
               this.txtPassword.Location = new System.Drawing.Point(311, 227);
               this.txtPassword.Name = "txtPassword";
               this.txtPassword.Size = new System.Drawing.Size(245, 22);
               this.txtPassword.TabIndex = 9;
               this.txtPassword.UseSystemPasswordChar = true;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label5.ForeColor = System.Drawing.Color.Blue;
               this.label5.Location = new System.Drawing.Point(461, 273);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(95, 17);
               this.label5.TabIndex = 10;
               this.label5.Text = "Tạo tài khoản";
               this.label5.Click += new System.EventHandler(this.label5_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.txtPassword);
               this.Controls.Add(this.txtUserName);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.lbComputerCode);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.btnLogin);
               this.Controls.Add(this.label2);
               this.Name = "Form1";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button btnLogin;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label lbComputerCode;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox txtUserName;
          private System.Windows.Forms.TextBox txtPassword;
          private System.Windows.Forms.Label label5;
     }
}

