using Microsoft.Data.SqlClient;
using System.Data;

namespace _2_Ado.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con = null;

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            //Connected Mimari ile Ürünlerin Getirilmesi
            try
            {
                con = new SqlConnection(cn);
                con.Open();

                //MessageBox.Show("Baðlanti Acildi.");

                SqlCommand cmd = new SqlCommand("Select ProductID,ProductName,UnitPrice from Products", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //?? operatörü bir deðerin null olup olmadýðýný kontrol eder ve eðer null ise sað taraftaki deðeri döner.
                    string urunAdi = dr["ProductName"].ToString() ?? "--";
                    int id = Convert.ToInt32(dr["ProductID"]);
                    double birimFiyat = Convert.ToDouble(dr["UnitPrice"]);

                    lstListe.Items.Add($"{id}-{urunAdi}/{birimFiyat}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            //Disconnected Mimari ile Kategorilerin Getirilmesi

            string cn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(cn);
                SqlCommand cmd = new SqlCommand("Select CategoryID,CategoryName,Description from Categories", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                lstListe.DisplayMember = "CategoryName";
                lstListe.ValueMember = "CategoryID";
                lstListe.DataSource = dt;

                // dgwKategoriler.DataSource = dt;

                //cmbKategoriler.DisplayMember = "CategoryName";
                //cmbKategoriler.ValueMember = "CategoryID";
                //cmbKategoriler.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string id;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedValue != null)
            {
                id = lstListe.SelectedValue.ToString();
                txtPrdName.Text = lstListe.Text;
                //MessageBox.Show(id);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string urunAdi = txtPrdName.Text;

                con = new SqlConnection(cn);
                con.Open();
                SqlCommand cmdEkle = new SqlCommand("Insert into Products (ProductName,UnitPrice,Discontinued) values (@name,@price,@disc)");
                cmdEkle.Connection = con;
                cmdEkle.Parameters.AddWithValue("@name", urunAdi);
                cmdEkle.Parameters.AddWithValue("@price", 98500);
                cmdEkle.Parameters.AddWithValue("@disc", true);

                int sonuc = cmdEkle.ExecuteNonQuery();

                //if (sonuc > 0)
                //{
                //    MessageBox.Show("Ekleme iþlemi baþarýlý.");
                //}

                string mesaj = sonuc > 0 ? "Ekleme iþlemi baþarýlý." : "Bir hata oluþtu.";
                MessageBox.Show(mesaj);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cn);
                con.Open();
                SqlCommand cmdUpdate = new SqlCommand("Update Categories set CategoryName=@cname where CategoryID=@id", con);
                cmdUpdate.Parameters.AddWithValue("@cname", txtPrdName.Text);
                cmdUpdate.Parameters.AddWithValue("@id", id);

                int sonuc = cmdUpdate.ExecuteNonQuery();

                string mesaj = sonuc > 0 ? "Güncelleme iþlemi baþarýlý." : "Bir hata oluþtu.";
                MessageBox.Show(mesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //secilen kategoriyi silelim

            try
            {
                con = new SqlConnection(cn);
                con.Open();
                SqlCommand cmdSil = new SqlCommand("Delete from Categories where CategoryID=@id", con);
                cmdSil.Parameters.AddWithValue("@id", id);

                int sonuc = cmdSil.ExecuteNonQuery();
                string mesaj = sonuc > 0 ? "Silme iþlemi baþarýlý." : "Bir hata oluþtu.";
                MessageBox.Show(mesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
