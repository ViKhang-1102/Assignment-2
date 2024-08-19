namespace Assignment_2
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCustomerName = new TextBox();
            txtLastMonth = new TextBox();
            txtThisMonth = new TextBox();
            txtConsumption = new TextBox();
            txtWaterMoney = new TextBox();
            btnPayment = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(434, 44);
            label1.TabIndex = 0;
            label1.Text = "Customer Water Bill";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 138);
            label2.Name = "label2";
            label2.Size = new Size(316, 27);
            label2.TabIndex = 0;
            label2.Text = "Last month's water meter readings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 236);
            label3.Name = "label3";
            label3.Size = new Size(312, 27);
            label3.TabIndex = 0;
            label3.Text = "This month's water meter readings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 336);
            label4.Name = "label4";
            label4.Size = new Size(221, 27);
            label4.TabIndex = 0;
            label4.Text = "Amount of consumption";
            // 
            // label5
            // 
            label5.Font = new Font("Viner Hand ITC", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(156, 436);
            label5.Name = "label5";
            label5.Size = new Size(150, 29);
            label5.TabIndex = 0;
            label5.Text = "Water momey";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(113, 70);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(242, 27);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLastMonth
            // 
            txtLastMonth.Location = new Point(156, 168);
            txtLastMonth.Name = "txtLastMonth";
            txtLastMonth.Size = new Size(150, 27);
            txtLastMonth.TabIndex = 1;
            txtLastMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtThisMonth
            // 
            txtThisMonth.Location = new Point(156, 266);
            txtThisMonth.Name = "txtThisMonth";
            txtThisMonth.Size = new Size(150, 27);
            txtThisMonth.TabIndex = 1;
            txtThisMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtConsumption
            // 
            txtConsumption.Location = new Point(156, 366);
            txtConsumption.Name = "txtConsumption";
            txtConsumption.Size = new Size(150, 27);
            txtConsumption.TabIndex = 1;
            txtConsumption.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWaterMoney
            // 
            txtWaterMoney.Location = new Point(156, 468);
            txtWaterMoney.Name = "txtWaterMoney";
            txtWaterMoney.Size = new Size(150, 27);
            txtWaterMoney.TabIndex = 1;
            txtWaterMoney.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.Lime;
            btnPayment.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(156, 532);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(150, 29);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(460, 573);
            Controls.Add(btnPayment);
            Controls.Add(txtWaterMoney);
            Controls.Add(txtConsumption);
            Controls.Add(txtThisMonth);
            Controls.Add(txtLastMonth);
            Controls.Add(txtCustomerName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bill";
            Text = "ASM2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCustomerName;
        private TextBox txtLastMonth;
        private TextBox txtThisMonth;
        private TextBox txtConsumption;
        private TextBox txtWaterMoney;
        private Button btnPayment;
    }
}