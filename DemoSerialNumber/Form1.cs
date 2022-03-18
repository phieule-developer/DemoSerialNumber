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
     public partial class Form1 : Form
     {
          private static readonly HttpClient client = new HttpClient();

          public Form1()
          {
               InitializeComponent();
               init();
          }
          void init()
          {
               var uuid =  Helper.GetUUID();
               lbComputerCode.Text = uuid;
          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }

          private void label2_Click(object sender, EventArgs e)
          {

          }

          private async void btnContinue_Click(object sender, EventArgs e)
          {
               try
               {
                    if (txtUserName.Text == "" || txtPassword.Text == "")
                    {
                         if(txtUserName.Text == "")
                         {
                              MessageBox.Show("Vui lòng điền tên đăng nhập");
                         }
                         else
                         {
                              MessageBox.Show("Vui lòng điền mật khẩu");
                         }
                    }
                    else
                    {
                         var computer_code = Helper.GetUUID();
                         var user_name = txtUserName.Text;
                         var password = txtPassword.Text;

                         var body = new Dictionary<string, string>
                                {
                                  {
                                        "computer_code", Helper.GetUUID()
                                  },
                                   {
                                        "user_name", txtUserName.Text
                                  },
                                    {
                                        "password", txtPassword.Text
                                  }
                                };

                         var content = new FormUrlEncodedContent(body);

                         var response = await client.PostAsync("http://13.212.239.178:8000/api/auth/login", content);

                         var responseString = await response.Content.ReadAsStringAsync();

                         dynamic users = JsonConvert.DeserializeObject(responseString);

                         if (users["status"] == 200)
                         {
                              MessageBox.Show(new Form { TopMost = true }, users["message"].ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                         else
                         {

                              MessageBox.Show(new Form { TopMost = true }, users["message"].ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         }
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString());
               }
               
          }

          private void label5_Click(object sender, EventArgs e)
          {
               this.Hide();
               Register fr1 = new Register();
               fr1.Show();
          }
     }
}
