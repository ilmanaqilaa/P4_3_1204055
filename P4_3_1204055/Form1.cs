using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_3_1204055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Textbox Angka tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul!");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");

                }
                else
                {

                    epWarning.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "Inputan hanya boleh huruf!");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");

                }
                else
                {
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka1, "Pastikan Angka 2 sudah terisi ya!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
            else
            {
                if (int.Parse(txtAngka1.Text) > int.Parse(txtAngka2.Text))
                {
                    epWrong.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka1, "Angka 1 tidak boleh melebihi Angka 2");
                    epCorrect.SetError(txtAngka1, "");
                }
                else
                {
                    epWrong.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul!");
                }
            }

        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if (int.Parse(txtAngka1.Text) > int.Parse(txtAngka2.Text))
                {
                    epWrong.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka2, "Angka 1 diharuskan kurang dari Angka 2");
                    epCorrect.SetError(txtAngka2, "");
                }
                else
                {
                    epWrong.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul!");
                }
            }
        }
    }
}
    