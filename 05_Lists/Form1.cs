using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Lists
{
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>(); 
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            orders.Add(new Order(random.Next(1000)));
            orders.Add(new Order(random.Next(1000)));
            orders.Add(new Order(random.Next(1000)));
            orders.Add(new Order(random.Next(1000)));

            //orderComboBox.Items.AddRange(orders
            //orderComboBox.DataSource = orders;
            UpdateOrderComboBox();
        }
        private void UpdateOrderComboBox()
        {
            orderComboBox.DataSource = null;
            orderComboBox.DataSource = orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if( orderComboBox.SelectedIndex == -1 )
            {
                MessageBox.Show("Select an order from list!");
                return;
            }

            Order selectedOrder = orderComboBox.SelectedItem as Order;
            MessageBox.Show(selectedOrder.ToString(), "Order Details", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void DellBtn_Click(object sender, EventArgs e)
        {
            if (orderComboBox.SelectedIndex == -1) return;
            orders.RemoveAt(orderComboBox.SelectedIndex);
            UpdateOrderComboBox();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            orders.Add(new Order(numericUpDown1.Value));
            UpdateOrderComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();   
        }

        private void removeSelectBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1 )
            {
                MessageBox.Show("No selected Item!");
                return;
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            
        }

        private void showSelectBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string res = "----------Selected Items ------------\n";
                foreach (var item in listBox1.SelectedItems)
                {
                    res += item.ToString() + Environment.NewLine;
                }
                MessageBox.Show(res);
            }
        }

        private void moveRightBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void moveLeftBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void deleteSelectBtn_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
            }
        }
    }
}
