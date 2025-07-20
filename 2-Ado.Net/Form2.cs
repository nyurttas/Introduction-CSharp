using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace _2_Ado.Net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /*
                    form yüklendiğinde tüm kategoriler comboboxa yüklenir.
                   secilen kategoriye ait tüm ürünler listboxa yüklenir.
                   Listboxtan herhangi bir ürün seçtiğimde bu ürüne ait tüm OrderDetail bilgisi datagridviewda gösterilir.
                    */
        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = GetAllData("Select CategoryID,CategoryName from Categories");

            if (dt != null)
            {
                cmbCategories.ValueMember = "CategoryID";
                cmbCategories.DisplayMember = "CategoryName";
                cmbCategories.DataSource = dt;
            }
        }

        private DataTable GetAllData(string query)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbSqlConnection"].ConnectionString);
                SqlCommand cmd = new SqlCommand(query, cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex != -1)
            {
                //string isim = null;
                //string sonuc = isim ?? "Varsayılan İsim";

                //? SelectedValue dönüş tipi object olduğu için null olabilir. Bu yüzden null kontrolü yapılır.
                string? secilenID = cmbCategories.SelectedValue?.ToString();

                string sorgu = $"Select ProductID,ProductName from Products where CategoryID={secilenID}";

                DataTable dt = GetAllData(sorgu);
                lstProductList.DisplayMember = "ProductName";
                lstProductList.ValueMember = "ProductID";
                lstProductList.DataSource = dt;

                //kategorilerdeki ürün adedini sayar:
                lblProductCount.Text=lstProductList.Items.Count.ToString();
            }
        }

        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductList.SelectedIndex != -1)
            {
                string? secilenID = lstProductList.SelectedValue?.ToString();

                if (secilenID != null)
                {
                    string sorgu = $"Select * from [Order Details] where ProductID={secilenID}";

                    DataTable dt = GetAllData(sorgu);

                    if (dt != null)
                    {
                        dgwDetails.DataSource = dt;
                    }
                }
            }
        }
    }
}
