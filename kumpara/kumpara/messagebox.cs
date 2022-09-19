using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kumpara
{
    public partial class messagebox : Form
    {
        public messagebox()
        {
            InitializeComponent();
        }

        public DialogResult cevap;

        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            cevap = DialogResult.OK;
            Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            cevap = DialogResult.Cancel;
            this.Close();
        }

        //private void Button(object sender, EventArgs e)
        //{
        //    cevap = DialogResult.OK;
        //    Close();
        //}

        //private void btn_vazgeç_Click(object sender, EventArgs e)
        //{
        //    cevap = DialogResult.Abort;
        //    Close();
        //}

        //private void noButton(object sender, EventArgs e)
        //{
        //    cevap = DialogResult.Cancel;
        //}

    }
}
