using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTextFileSystem
{
    public partial class Form1 : Form
    {
        string data;
        string[] page = new string[5];
        string[] names = new string[5];
        string[] places = new string[5];
        string[] phone = new string[5];
        string[] email = new string[5];
        int buttonClickCount = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = File.ReadAllText("D:\\one_team\\FileOperations\\ReadTextFileSystem\\MyData.txt");
            data.TrimEnd(' ');
            data = Regex.Replace(data, "\\s", "");
            page = data.Split(' ', ')', '/');
            names = data.Split(')', '+');
            places = data.Split('+', '|');
            phone = data.Split('|', '*');
            email = data.Split('*', '/');
            if (page[0] == "1")
            {
                txtName.Text = names[2];
                txtPlace.Text = places[1];
                txtPhoneNumber.Text = phone[1];
                txtEmail.Text = email[1];
                lblPageNumber.Text = "1/6";
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            buttonClickCount = buttonClickCount + 1;
            if (page[3] == buttonClickCount.ToString())
            {
                txtName.Text = names[5];
                txtPlace.Text = places[3];
                txtPhoneNumber.Text = phone[3];
                txtEmail.Text = email[3];
                lblPageNumber.Text = "2/6";
            }
            if (page[6] == buttonClickCount.ToString())
            {
                txtName.Text = names[8];
                txtPlace.Text = places[5];
                txtPhoneNumber.Text = phone[5];
                txtEmail.Text = email[5];
                lblPageNumber.Text = "3/6";
            }
            if (page[9] == buttonClickCount.ToString())
            {
                txtName.Text = names[11];
                txtPlace.Text = places[7];
                txtPhoneNumber.Text = phone[7];
                txtEmail.Text = email[7];
                lblPageNumber.Text = "4/6";
            }
            if (page[12] == buttonClickCount.ToString())
            {
                txtName.Text = names[14];
                txtPlace.Text = places[9];
                txtPhoneNumber.Text = phone[9];
                txtEmail.Text = email[11];
                lblPageNumber.Text = "5/6";
            }
            if (page[15] == buttonClickCount.ToString())
            {
                txtName.Text = names[17];
                txtPlace.Text = places[11];
                txtPhoneNumber.Text = phone[11];
                txtEmail.Text = email[11];
                lblPageNumber.Text = "6/6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonClickCount = buttonClickCount - 1;
            if (page[0] == buttonClickCount.ToString())
            {
                txtName.Text = names[2];
                txtPlace.Text = places[1];
                txtPhoneNumber.Text = phone[1];
                txtEmail.Text = email[1];
                lblPageNumber.Text = "1/6";
            }
            if (page[3] == buttonClickCount.ToString())
            {
                txtName.Text = names[5];
                txtPlace.Text = places[3];
                txtPhoneNumber.Text = phone[3];
                txtEmail.Text = email[3];
                lblPageNumber.Text = "2/6";
            }
            if (page[6] == buttonClickCount.ToString())
            {
                txtName.Text = names[8];
                txtPlace.Text = places[5];
                txtPhoneNumber.Text = phone[5];
                txtEmail.Text = email[5];
                lblPageNumber.Text = "3/6";
            }
            if (page[9] == buttonClickCount.ToString())
            {
                txtName.Text = names[11];
                txtPlace.Text = places[7];
                txtPhoneNumber.Text = phone[7];
                txtEmail.Text = email[7];
                lblPageNumber.Text = "4/6";
            }
            if (page[12] == buttonClickCount.ToString())
            {
                txtName.Text = names[14];
                txtPlace.Text = places[9];
                txtPhoneNumber.Text = phone[9];
                txtEmail.Text = email[11];
                lblPageNumber.Text = "5/6";
            }
            if (page[15] == buttonClickCount.ToString())
            {
                txtName.Text = names[17];
                txtPlace.Text = places[11];
                txtPhoneNumber.Text = phone[11];
                txtEmail.Text = email[11];
                lblPageNumber.Text = "6/6";
            }
        }
    }
}

