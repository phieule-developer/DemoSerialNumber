using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSerialNumber
{
     public partial class Register : Form
     {
          public Register()
          {
               InitializeComponent();
          }
          private static readonly HttpClient client = new HttpClient();

          private void label6_Click(object sender, EventArgs e)
          {
               this.Hide();
               Form1 fr1 = new Form1();
               fr1.Show();
          }

         async private void btnRegister_Click(object sender, EventArgs e)
          {
               var body = new Dictionary<string, string>
                                {
                                  {
                                        "computer_code", Helper.GetUUID()
                                  },
                                  {
                                        "user_name", txtUsername.Text
                                  },
                                  {
                                        "password", txtPassword.Text
                                  },
                                  {
                                        "name", txtName.Text
                                  },
                                  {
                                        "confirm_password", txtConfirmPassword.Text
                                  }
                                };

               var content = new System.Net.Http.FormUrlEncodedContent(body);

               var response = await client.PostAsync("http://13.212.239.178:8000/api/auth/register", content);

               var responseString = await response.Content.ReadAsStringAsync();

               dynamic users = JsonConvert.DeserializeObject(responseString);

               if (users["status"] == 200)
               {
                    txtName.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";

                    MessageBox.Show(new Form { TopMost = true }, "Đăng ký tài khoản thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                    MessageBox.Show(new Form { TopMost = true }, users["message"].ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
          }
     }
}
