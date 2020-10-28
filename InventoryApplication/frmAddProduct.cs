using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventoryApplication
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _description;
        private int _Quantity;
        private double _SellProduct;
        BindingSource ProductList;

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            ProductList = new BindingSource();

            string [] ListOfProductCategory = new string[]
            {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Diary",
                "Frozen Goods",
                "Meats",
                "Personal Care",
                "Other"

            };
            foreach (string Item in ListOfProductCategory)
            {
                cbCategory.Items.Add(Item);
            }
         }
        public string _ProductName(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                //Exception here
                return name;
        }
        public int _Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
                //Exception here
                return Convert.ToInt32(qty);
        }
        public double _SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                //Exception here
                return Convert.ToDouble(price);
        }

    }
}
