using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public List<Invoice> invoices = new List<Invoice>();  // list view
        public const double VAT = 0.1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            // Khai báo để lấy thông tin
            string customerName = txtCustomerName.Text.Trim();    // .Trim() -> dùng để xóa dấu cách dư ra khi nhập tên
            string typeOfCustomer = cboTypeOfCustomer.Text;
            int numberOfPeople = 0;
            double lastMonth = 0;
            double thisMonth = 0;



            if (customerName == "")
            {
                MessageBox.Show("Please enter customer name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (typeOfCustomer == "")
            {
                MessageBox.Show("Please choose type of customer.",
                   "Validation Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            if (typeOfCustomer == "Household customer")
            {
            if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0)                                                                       // Check xem user có nhập số âm ko
                {
                    MessageBox.Show("Please enter number of people.",
                   "Validation Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    return;
                }
            }
            if (!double.TryParse(txtLastMonth.Text, out lastMonth) || lastMonth < 0)
            {
                MessageBox.Show("Please enter last month's water meter.",
                   "Validation Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtThisMonth.Text, out thisMonth) || thisMonth < 0)
            {
                MessageBox.Show("Please enter this month's water meter.",
                   "Validation Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            if (lastMonth > thisMonth)
            {
                MessageBox.Show("Please enter last month less than this month.",
                      "Validation Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }












            // Tạo biến var dùng để gọi Calculator
            var waterBill = Calculator(typeOfCustomer, numberOfPeople, lastMonth, thisMonth);



            // show kết qủa lên list view
            // Item1 và Item2 là hai double đã trèn              
            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(lastMonth.ToString());
            item.SubItems.Add(thisMonth.ToString());
            item.SubItems.Add(waterBill.Item1.ToString());
            item.SubItems.Add(waterBill.Item2.ToString());
            lvWaterBill.Items.Add(item);



            // store data listview
            Invoice invoice = new Invoice
            {
                CustomerName = customerName,
                LastMonth = lastMonth,
                ThisMonth = thisMonth,
                Consumption = waterBill.Item1,
                WaterMoney = waterBill.Item2,
            };
            invoices.Add(invoice);
        }



        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeOfCustomer = cboTypeOfCustomer.Text;
            if (typeOfCustomer == "Household customer")
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            cboTypeOfCustomer.SelectedIndex = -1;   // Dùng cho combobox
            txtNumberOfPeople.Text = "";
            txtLastMonth.Text = "";
            txtThisMonth.Text = "";
        }



        // Calculator
        private (double, double) Calculator(string typeOfCustomer, int numberOfPeople,
                                            double lastMoth, double thisMoth)
        {
            double consumption = thisMoth - lastMoth;
            double waterMoney = 0;

            if (typeOfCustomer == "Household customer")
            {
                double averagePerson = consumption / numberOfPeople;

                if (averagePerson <= 10)
                {
                    waterMoney = consumption * 5973;
                }

                else if (averagePerson > 10 && averagePerson <= 20)
                {
                    waterMoney = consumption * 7052;
                }

                else if (averagePerson > 20 && averagePerson <= 30)
                {
                    waterMoney = consumption * 8699;
                }

                else if (averagePerson > 30)
                {
                    waterMoney = consumption * 15929;
                }
            }

            else if (typeOfCustomer == "Administrative agency, public services")
            {
                waterMoney = consumption * 9955;
            }

            else if (typeOfCustomer == "Production units")
            {
                waterMoney = consumption * 11615;
            }

            else if (typeOfCustomer == "Business services")
            {
                waterMoney = consumption * 22068;
            }

            waterMoney += waterMoney * VAT;
            return (consumption, waterMoney);
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            // Dùng để Setup item cho combobox
            //cboTypeOfCustomer.Items.Add("Household customer");
            //cboTypeOfCustomer.Items.Add("Administrative agency, public services");
            //cboTypeOfCustomer.Items.Add("Production units");
            //cboTypeOfCustomer.Items.Add("Business service");


            // Dùng để hiển thị các thành phần trong list view
            lvWaterBill.View = View.Details;
            lvWaterBill.Columns.Add("Customer Name", 130);
            lvWaterBill.Columns.Add("Last Month Water Meter", 130);
            lvWaterBill.Columns.Add("This Month Water Meter", 130);
            lvWaterBill.Columns.Add("Amount Of Consumption", 130);
            lvWaterBill.Columns.Add("Total Water Bill", 122);
        }




        // Search
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            lvWaterBill.Items.Clear();       // xóa đi tt đg có trên màng hình
            bool foundResult = false;

            if (search == "")        // Search không tìm kiếm sẽ hiển thị tất cả, (found) đưa ra ngoài
            {
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());

                    lvWaterBill.Items.Add(item);
                }
                foundResult = true;
            }

            else                                                                                                                                 // Search được tìm kiếm, (found) sẽ đưa vào trong để tìm kiếm 
            {
                foreach (Invoice invoice in invoices)
                {
                    if (invoice.CustomerName.ToLower().Contains(search))
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonth.ToString());
                        item.SubItems.Add(invoice.ThisMonth.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());

                        lvWaterBill.Items.Add(item);
                        foundResult = true;
                    }
                }
            }

            if (!foundResult)          // Nếu tìm kiếm không có sẽ show ra "No results found."
            {
                ListViewItem item = new ListViewItem("No results found.");

                lvWaterBill.Items.Add(item);
            }

        }


        // Ascending or Descending 
        private void cboArrange_SelectedIndexChanged(object sender, EventArgs e)
        {
            string arrange = cboArrange.Text;

            if (arrange.Equals("Consumption (ascending)"))       // Comsuption tăng
            {
                int n = invoices.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (invoices[j].Consumption < invoices[minIndex].Consumption)
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        Invoice temp = invoices[minIndex];
                        invoices[minIndex] = invoices[i];
                        invoices[i] = temp;
                    }
                }

                lvWaterBill.Items.Clear();
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());

                    lvWaterBill.Items.Add(item);
                }
            }

            else if (arrange.Equals("Consumption (descending)"))                   // Consumption giảm
            {
                int n = invoices.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (invoices[j].Consumption > invoices[minIndex].Consumption)
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        Invoice temp = invoices[minIndex];
                        invoices[minIndex] = invoices[i];
                        invoices[i] = temp;
                    }
                }

                lvWaterBill.Items.Clear();
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());

                    lvWaterBill.Items.Add(item);
                }
            }




            else if (arrange.Equals("Water money (ascending)"))        // Water money tăng
            {
                int n = invoices.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (invoices[j].WaterMoney < invoices[minIndex].WaterMoney)
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        Invoice temp = invoices[minIndex];
                        invoices[minIndex] = invoices[i];
                        invoices[i] = temp;
                    }
                }

                lvWaterBill.Items.Clear();
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());

                    lvWaterBill.Items.Add(item);
                }
            }

            else if (arrange.Equals("Water money (descending)"))   // Water money giảm
            {
                int n = invoices.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (invoices[j].WaterMoney > invoices[minIndex].WaterMoney)
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        Invoice temp = invoices[minIndex];
                        invoices[minIndex] = invoices[i];
                        invoices[i] = temp;
                    }
                }

                lvWaterBill.Items.Clear();
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());

                    lvWaterBill.Items.Add(item);
                }
            }


            else if (arrange.Equals("Last month (ascending)"))        // Last month tăng
            {
                int n = invoices.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (invoices[j].LastMonth < invoices[minIndex].LastMonth)
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        Invoice temp = invoices[minIndex];
                        invoices[minIndex] = invoices[i];
                        invoices[i] = temp;
                    }
                }

                lvWaterBill.Items.Clear();
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());

                    lvWaterBill.Items.Add(item);
                }
            }

            else if (arrange.Equals("Last month (descending)"))    // Last month giảm
            {
                int n = invoices.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (invoices[j].LastMonth > invoices[minIndex].LastMonth)
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        Invoice temp = invoices[minIndex];
                        invoices[minIndex] = invoices[i];
                        invoices[i] = temp;
                    }
                }

                lvWaterBill.Items.Clear();
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());

                    lvWaterBill.Items.Add(item);
                }
            }


            else if (arrange.Equals("This month (ascending)"))    // This month tăng
            {
                int n = invoices.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (invoices[j].ThisMonth < invoices[minIndex].ThisMonth)
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        Invoice temp = invoices[minIndex];
                        invoices[minIndex] = invoices[i];
                        invoices[i] = temp;
                    }
                }

                lvWaterBill.Items.Clear();
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());

                    lvWaterBill.Items.Add(item);
                }
            }

            else if (arrange.Equals("This month (descending)"))     // This month giảm
            {
                int n = invoices.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (invoices[j].ThisMonth > invoices[minIndex].ThisMonth)
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        Invoice temp = invoices[minIndex];
                        invoices[minIndex] = invoices[i];
                        invoices[i] = temp;
                    }
                }

                lvWaterBill.Items.Clear();
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());

                    lvWaterBill.Items.Add(item);
                }
            }


            if (arrange.Equals("Name (A-Z)"))
            {
                invoices = invoices.OrderBy(inv => inv.CustomerName).ToList();

                lvWaterBill.Items.Clear();
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());

                    lvWaterBill.Items.Add(item);
                }
            }
        }



        private void lvWaterBill_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvWaterBill.SelectedItems.Count > 0)
            {
                int index = lvWaterBill.SelectedItems[0].Index;
                if (index >= 0 && index < invoices.Count)
                {
                    Bill bill = new Bill(invoices[index].CustomerName, invoices[index].LastMonth,
                                         invoices[index].ThisMonth, invoices[index].Consumption, invoices[index].WaterMoney);
                    bill.Show();
                }
            }            
        }        
    }


    public class Invoice
    {
        public string CustomerName { get; set; }
        public double LastMonth { get; set; }
        public double ThisMonth { get; set; }
        public double Consumption { get; set; }
        public double WaterMoney { get; set; }
    }
}
