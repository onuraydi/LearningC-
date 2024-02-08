using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product 
            {
                Name = tbxname.Text,
                UnitPrice = Convert.ToDecimal(tbxunitPrice.Text),
                StockAmount = Convert.ToInt32(tbxstockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Added!");
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Updated!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
                tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
                tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product 
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Product Deleted!");
        }

        private void SearchProducts(string key)
        {
            //bu kısım getall'a uğrayıp öyle kontrol eder productdalda tanımladığımız getByName ile direkt veri
            //tabanındayken sorgu yapar buda verimiz çoğaldığında programın daha performanslı çalışmasını sağlar.
            // Aynı zamanda büyük harf küçük harf farklılığınıda ortadan kaldırır.
           // dgwProducts.DataSource = _productDal.GetAll().Where(p=>p.Name.Contains(key)).ToList(); 

            dgwProducts.DataSource = _productDal.GetByName(key);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }
    }
}
