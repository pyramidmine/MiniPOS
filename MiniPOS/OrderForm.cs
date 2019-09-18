using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPOS
{
    public partial class OrderForm : Form
    {
        public int TableNumber { get; }

        public OrderForm(int tableNumber)
        {
            this.TableNumber = tableNumber;

            InitializeComponent();

            this.textBoxTableNumber.Text = tableNumber.ToString();
        }

        public List<OrderedMenuItem> GetOrderedMenuItems()
        {
            List<OrderedMenuItem> items = new List<OrderedMenuItem>();
            if (0 < this.numericUpDownMenu1.Value)
            {
                items.Add(new OrderedMenuItem(MiniPOS.Menu.Instance.Items[0], (int)this.numericUpDownMenu1.Value));
            }
            if (0 < this.numericUpDownMenu2.Value)
            {
                items.Add(new OrderedMenuItem(MiniPOS.Menu.Instance.Items[1], (int)this.numericUpDownMenu2.Value));
            }
            return items;
        }
    }
}
