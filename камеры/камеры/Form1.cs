using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace камеры
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=03FD\\SQLEXPRESS;Initial Catalog=login1;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from user1 where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Добро пожаловать в систему!");
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else if (count > 0)
            {
                MessageBox.Show("Duplicate username and password");
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны!");
            }

            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
