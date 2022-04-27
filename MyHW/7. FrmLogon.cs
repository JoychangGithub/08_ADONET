using MyHW;
using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Insert:SignUp
            //參數寫法
            string userName = UsernameTextBox.Text;
            string userPassword = PasswordTextBox.Text;
            if (UsernameTextBox.Text == "" | PasswordTextBox.Text == "")
            {
                MessageBox.Show("請輸入帳號密碼");
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {


                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"Insert into MyMember (UserName, Password) values(@userName, @userPassword)";
                        command.Connection = conn;

                        command.Parameters.Add("@userName", SqlDbType.NVarChar, 50).Value = userName;
                        command.Parameters.Add("userPassword", SqlDbType.NVarChar, 50).Value = userPassword;

                        conn.Open();
                        command.ExecuteNonQuery();


                        MessageBox.Show("註冊成功");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void OK_Click(object sender, EventArgs e)
        {           
            //select:登入
            ////變數寫法
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString)) 
                {
                    string userName = UsernameTextBox.Text;
                    string userPassword = PasswordTextBox.Text;

                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from MyMember where UserName=@userName and Password=@userPassword";
                    command.Connection = conn;
                    command.Parameters.Add("@userName", SqlDbType.NVarChar, 50).Value=userName;
                    command.Parameters.Add("@userPassword", SqlDbType.NVarChar, 50).Value = userPassword;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader(); //select

                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("登入成功");
                        this.DialogResult = DialogResult.OK;

                        FrmMain frmmain = new FrmMain();
                        frmmain.Show();
                        
                    }
                    else 
                    {
                        MessageBox.Show("登入失敗");
                        this.Close();
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            //select:登入
            //try
            //{
            //    string userName = UsernameTextBox.Text;
            //    string userPassword = PasswordTextBox.Text;

            //    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
            //    {                   
            //        SqlCommand command = new SqlCommand();

            //        conn.Open();
            //        command.CommandText = $"Select * from MyMember where UserName='{userName}' and Password = '{userPassword}'";
            //        command.Connection = conn;


            //        SqlDataReader dataReader = command.ExecuteReader();

            //        if (dataReader.HasRows) //若有此資料
            //        {
            //            MessageBox.Show("Log on成功");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Log on失敗");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
    }
}
