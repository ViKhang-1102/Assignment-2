namespace Assignment_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnReset = new Button();
            btnCalculator = new Button();
            lvWaterBill = new ListView();
            cboTypeOfCustomer = new ComboBox();
            txtCustomerName = new TextBox();
            txtNumberOfPeople = new TextBox();
            txtLastMonth = new TextBox();
            txtThisMonth = new TextBox();
            txtSearch = new TextBox();
            cboArrange = new ComboBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(37, 403);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(116, 29);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCalculator
            // 
            btnCalculator.Location = new Point(197, 403);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(119, 29);
            btnCalculator.TabIndex = 0;
            btnCalculator.Text = "Calculator";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // lvWaterBill
            // 
            lvWaterBill.FullRowSelect = true;
            lvWaterBill.GridLines = true;
            lvWaterBill.Location = new Point(367, 167);
            lvWaterBill.Name = "lvWaterBill";
            lvWaterBill.Size = new Size(637, 265);
            lvWaterBill.TabIndex = 1;
            lvWaterBill.UseCompatibleStateImageBehavior = false;
            lvWaterBill.SelectedIndexChanged += lvWaterBill_SelectedIndexChanged_1;
            // 
            // cboTypeOfCustomer
            // 
            cboTypeOfCustomer.FormattingEnabled = true;
            cboTypeOfCustomer.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            cboTypeOfCustomer.Location = new Point(37, 119);
            cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            cboTypeOfCustomer.Size = new Size(279, 28);
            cboTypeOfCustomer.TabIndex = 3;
            cboTypeOfCustomer.SelectedIndexChanged += cboTypeOfCustomer_SelectedIndexChanged;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(37, 44);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Enter Customer name";
            txtCustomerName.Size = new Size(279, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // txtNumberOfPeople
            // 
            txtNumberOfPeople.Enabled = false;
            txtNumberOfPeople.Location = new Point(37, 190);
            txtNumberOfPeople.Name = "txtNumberOfPeople";
            txtNumberOfPeople.PlaceholderText = "Enter number of people ";
            txtNumberOfPeople.Size = new Size(279, 27);
            txtNumberOfPeople.TabIndex = 4;
            // 
            // txtLastMonth
            // 
            txtLastMonth.Location = new Point(37, 264);
            txtLastMonth.Name = "txtLastMonth";
            txtLastMonth.PlaceholderText = "Enter last month's water meter readings ";
            txtLastMonth.Size = new Size(279, 27);
            txtLastMonth.TabIndex = 4;
            // 
            // txtThisMonth
            // 
            txtThisMonth.Location = new Point(37, 340);
            txtThisMonth.Name = "txtThisMonth";
            txtThisMonth.PlaceholderText = "Enter this month's water meter readings ";
            txtThisMonth.Size = new Size(279, 27);
            txtThisMonth.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(367, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(157, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cboArrange
            // 
            cboArrange.FormattingEnabled = true;
            cboArrange.Items.AddRange(new object[] { "Name (A-Z)", "Last month (ascending)", "Last month (descending)", "This month (ascending)", "This month (descending)", "Consumption (ascending)", "Consumption (descending)", "Water money (ascending)", "Water money (descending)" });
            cboArrange.Location = new Point(367, 119);
            cboArrange.Name = "cboArrange";
            cboArrange.Size = new Size(305, 28);
            cboArrange.TabIndex = 3;
            cboArrange.SelectedIndexChanged += cboArrange_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtThisMonth);
            groupBox1.Controls.Add(lvWaterBill);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(txtLastMonth);
            groupBox1.Controls.Add(cboArrange);
            groupBox1.Controls.Add(txtNumberOfPeople);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(cboTypeOfCustomer);
            groupBox1.Controls.Add(btnCalculator);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1039, 462);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(808, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(321, 497);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 489);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "ASM2";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReset;
        private Button btnCalculator;
        private ListView lvWaterBill;
        private ComboBox cboTypeOfCustomer;
        private TextBox txtCustomerName;
        private TextBox txtNumberOfPeople;
        private TextBox txtLastMonth;
        private TextBox txtThisMonth;
        private TextBox txtSearch;
        private ComboBox cboArrange;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}
