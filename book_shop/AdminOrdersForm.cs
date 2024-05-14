using book_shop.models;
using book_shop.provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_shop
{
    public partial class AdminOrdersForm : Form
    {
        private OrdersProvider ordersProvider = new OrdersProvider();
        private List<Orders> orders = new List<Orders>();
        private DateTime lastUpdate = DateTime.Now;
        private string search = null;
        
        public AdminOrdersForm()
        {
            InitializeComponent();
        }

        private void AdminOrdersForm_Load(object sender, EventArgs e)
        {
            orders = ordersProvider.GetAllOrders();
            RefreshOrders(orders);
        }

        public void RefreshOrders(List<Orders> orders)
        {
            ordersView.Rows.Clear();

            if (!string.IsNullOrEmpty(search))
            {
                orders = orders
                    .Where(o => o.user.Name
                    .Contains(search))             
                    .ToList();
            }

            orders = orders
                .Where(o => o.CreatedDate.Date == lastUpdate.Date)
                .ToList();

            foreach (Orders order in orders)
            {
                string books = "";
                foreach (BooksOrder book in order.Books)
                {
                    books += book.Books.Title + ", ";
                }
                ordersView.Rows.Add(order.Id, order.CreatedDate.ToShortDateString(), order.Status, 
                    books.Substring(0, books.Length - 2), order.user.Name);
            }
        }

        private void searchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            search = searchTxt.Text;
            RefreshOrders(orders);
        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {
            lastUpdate = datePick.Value;
            RefreshOrders(orders);
        }

        private void ordersView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int orderId = (int)ordersView.Rows[e.RowIndex].Cells[0].Value;
                AdminEditForm adminEditForm = new AdminEditForm();
                adminEditForm.UserId = orders.Where(o => o.Id == orderId).FirstOrDefault().user.Id;
                adminEditForm.ShowDialog();
                orders = ordersProvider.GetAllOrders();
                RefreshOrders(orders);
            }
            catch
            {
                MessageBox.Show("Внутренняя ошибка!");
            }
        }
    }
}
