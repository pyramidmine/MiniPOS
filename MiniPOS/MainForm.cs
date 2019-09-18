using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
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
    public partial class MainForm : Form
    {
        static readonly int TABLE_COUNT = 4;

        List<Table> tables = new List<Table>(TABLE_COUNT);

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < TABLE_COUNT; i++)
            {
                this.tables.Add(new Table(i, i + 1));
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonTable1_Click(object sender, EventArgs e)
        {
            ClickTable(0);
        }

        private void ButtonTable2_Click(object sender, EventArgs e)
        {
            ClickTable(1);
        }

        private void ButtonTable3_Click(object sender, EventArgs e)
        {
            ClickTable(2);
        }

        private void ButtonTable4_Click(object sender, EventArgs e)
        {
            ClickTable(3);
        }

        private void ClickTable(int tableId)
        {
            switch (this.tables[tableId].TableStatus)
            {
                case Table.Status.Empty:
                    OrderMenu(tableId);
                    break;
                case Table.Status.Ordered:
                    Pay(tableId);
                    break;
                case Table.Status.Paid:
                    CleanTable(tableId);
                    break;
                default:
                    break;
            }
        }

        private void OrderMenu(int tableId)
        {
            int tableNumber = this.tables[tableId].TableNumber;
            using (OrderForm orderForm = new OrderForm(tableNumber))
            {
                DialogResult result = orderForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<OrderedMenuItem> orders = orderForm.GetOrderedMenuItems();
                    if (0 < orders.Count)
                    {
                        this.tables[tableId].OrderedMenuItems = orders;
                        this.tables[tableId].TableStatus = Table.Status.Ordered;

                        StringBuilder sb = new StringBuilder(128);
                        sb.Append($"Table #{tableNumber}");
                        sb.Append(Environment.NewLine);
                        foreach (var v in orders)
                        {
                            sb.Append($"{v.MenuItem.Name}, {v.Quantity}, {v.MenuItem.Price * v.Quantity:C}");
                            sb.Append(Environment.NewLine);
                        }
                        Button tableButton = this.Controls[$"buttonTable{tableNumber}"] as Button;
                        tableButton.Text = sb.ToString();
                    }
                }
            }
        }

        private void Pay(int tableId)
        {
            Table table = this.tables[tableId];
            using (PayForm payForm = new PayForm())
            {
                DialogResult result = payForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string ip = "127.0.0.1";
                    short port = 1521;
                    string databaseName = "xe";
                    string id = "SYSTEM";
                    string password = "1234";
                    string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={ip})(PORT={port})))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={databaseName})));User ID={id};Password={password};Connection Timeout=30;Pooling=true;Statement Cache Size=1;";

                    try
                    {
                        using (OracleConnection conn = new OracleConnection(connectionString))
                        {
                            conn.Open();
                            if (conn.State == ConnectionState.Open)
                            {
                                foreach (var order in table.OrderedMenuItems)
                                {
                                    string sql =
                                        $"INSERT INTO PAYMENT " +
                                        $"(TABLE_ID, MENU_NAME, UNIT_PRICE, QUANTITY, TOTAL_PRICE, PAYMENT_TYPE) " +
                                        $"VALUES " +
                                        $"({tableId}, '{order.MenuItem.Name}', {order.MenuItem.Price}, {order.Quantity}, {order.MenuItem.Price * order.Quantity}, {(short)payForm.PaymentType})";

                                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                                    {
                                        cmd.ExecuteNonQuery();
                                    }
                                }

                                table.OrderedMenuItems = null;
                                table.TableStatus = Table.Status.Paid;

                                StringBuilder sb = new StringBuilder(128);
                                sb.Append($"Table #{table.TableNumber}");
                                sb.Append(Environment.NewLine);
                                sb.Append("Paid");
                                Button tableButton = this.Controls[$"buttonTable{table.TableNumber}"] as Button;
                                tableButton.Text = sb.ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CleanTable(int tableId)
        {
            Table table = this.tables[tableId];

            table.TableStatus = Table.Status.Empty;

            StringBuilder sb = new StringBuilder(128);
            sb.Append($"Table #{table.TableNumber}");
            Button tableButton = this.Controls[$"buttonTable{table.TableNumber}"] as Button;
            tableButton.Text = sb.ToString();
        }
    }

    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public MenuItem(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

    public class Menu
    {
        public Dictionary<int, MenuItem> Items = new Dictionary<int, MenuItem>()
        {
            [0] = new MenuItem(0, "김치볶음밥", 5000),
            [1] = new MenuItem(1, "된장찌개", 6000)
        };

        private Menu()
        {
        }

        private static Menu _instance = null;
        public static Menu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Menu();
                }
                return _instance;
            }
        }
    }

    public class OrderedMenuItem
    {
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }

        public OrderedMenuItem(MenuItem menuItem, int quantity)
        {
            MenuItem = menuItem;
            Quantity = quantity;
        }
    }

    public class Table
    {
        public enum Status
        {
            Empty,
            Ordered,
            Paid
        };

        public List<OrderedMenuItem> OrderedMenuItems { get; set; }

        public int TableId { get; }
        public int TableNumber { get; }
        public Status TableStatus { get; set; } = Status.Empty;

        public Table(int tableId, int tableNumber)
        {
            this.TableId = tableId;
            this.TableNumber = tableNumber;
        }
    }

    public enum PaymentType
    {
        CreditCard,
        Cash
    }
}
