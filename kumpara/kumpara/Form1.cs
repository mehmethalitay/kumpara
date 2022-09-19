
using System.Data;
using System.Data.SQLite;

namespace kumpara
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan;
        SQLiteDataAdapter da;
        DataSet ds;
        int x = 0, y = 0;
        bool hareket = false;
        double tutar = 0;
        string lblpara;
        List<decimal> gelen = new List<decimal>();
        List<decimal> giden = new List<decimal>();


        private void listele()
        {
            baglan = new SQLiteConnection("Data Source=kumparam;Version=3;");
            da = new SQLiteDataAdapter("Select *From anakumparam", baglan);
            ds = new DataSet();
            if (ConnectionState.Closed == baglan.State) baglan.Open();

            SQLiteCommand cmd = baglan.CreateCommand();
            cmd.CommandText = "select * from anakumparam";
            SQLiteDataReader dr = cmd.ExecuteReader();

            gelen.Clear();
            giden.Clear();

            while (dr.Read())
            {
                if (dr["yon"].ToString() == "Giren")
                {
                    gelen.Add(Convert.ToDecimal(dr["para"]));

                }
                else
                {
                    giden.Add(Convert.ToDecimal(dr["para"]));
                }

            }

            double giren = 0, cikan = 0, para = 0; ;

            foreach (var girentop in gelen)
            {
                giren = giren + double.Parse(girentop.ToString());
            }

            foreach (var cikantop in giden)
            {
                cikan = cikan + double.Parse(cikantop.ToString());
            }

            para = giren - cikan;

            lblpara = Convert.ToString(para);

            nowmoneyTb.Text = "";

            Double value;
            if (Double.TryParse(lblpara, out value))
                mainmonetTb.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                mainmonetTb.Text = String.Empty;
        }



            private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            hareket = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket == true)
            {
                this.Location = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void headerLbl_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            hareket = true;
        }

        private void headerLbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket == true)
            {
                this.Location = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void headerLbl_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }

        private void nowmoneyTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';
        }

        private void mainmonetTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';
        }

        DialogResult Mesaj(string Mesaj)
        {
            messagebox fr = new messagebox();
            fr.mLbl.Text = Mesaj;
            fr.ShowDialog();
            return fr.cevap;
        }

        private void exiButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult closecontrol = Mesaj("Programı kapatmak istediğinizden eminmisiniz ?");

                if (closecontrol == DialogResult.Cancel)
                {

                    return;

                }
                Environment.Exit(0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Çıkış Yapılmadı\n" + hata.ToString());
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (nowmoneyTb.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!");
            }
            try
            {
                tutar = Convert.ToDouble(nowmoneyTb.Text);
                if (ConnectionState.Closed == baglan.State) baglan.Open();
                SQLiteCommand con = new SQLiteCommand("Insert Into anakumparam (para,yon) values (@para,@yon)", baglan);
                con.Parameters.AddWithValue("@para", tutar);
                con.Parameters.AddWithValue("@yon", "Giren");
                con.ExecuteNonQuery();
                nowmoneyTb.Text = "";
                SQLiteCommand con1 = new SQLiteCommand("Insert Into logs(tarih,para,yon) values (@tarih,@para,@yon)", baglan);
                con1.Parameters.AddWithValue("@tarih", System.DateTime.Now);
                con1.Parameters.AddWithValue("@para", tutar);
                con1.Parameters.AddWithValue("@yon", "Giren");
                con1.ExecuteNonQuery();
                listele();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata alındı lütfen işlemi kontrol ediniz?\n" + hata.ToString());
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (nowmoneyTb.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!");
            }
            try
            {
                tutar = Convert.ToDouble(nowmoneyTb.Text);
                if (ConnectionState.Closed == baglan.State) baglan.Open();
                SQLiteCommand con = new SQLiteCommand("Insert Into anakumparam (para,yon) values (@para,@yon)", baglan);
                con.Parameters.AddWithValue("@para", tutar);
                con.Parameters.AddWithValue("@yon", "Çıkan");
                con.ExecuteNonQuery();
                nowmoneyTb.Text = "";
                SQLiteCommand con1 = new SQLiteCommand("Insert Into logs(tarih,para,yon) values (@tarih,@para,@yon)", baglan);
                con1.Parameters.AddWithValue("@tarih", System.DateTime.Now);
                con1.Parameters.AddWithValue("@para", tutar);
                con1.Parameters.AddWithValue("@yon", "Çıkan");
                con1.ExecuteNonQuery();
                listele();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata alındı lütfen işlemi kontrol ediniz\n" + hata.ToString());
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }
    }
}