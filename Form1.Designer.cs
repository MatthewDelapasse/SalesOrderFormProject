
namespace SalesOrderFormProject
{
    partial class frmKWSales
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
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.grpOrder.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.grpCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblDate);
            this.grpOrder.Controls.Add(this.lblOrderID);
            this.grpOrder.Controls.Add(this.btnExit);
            this.grpOrder.Controls.Add(this.btnSubmitOrder);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpOrder.Location = new System.Drawing.Point(18, 25);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(726, 155);
            this.grpOrder.TabIndex = 0;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(154, 98);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 28);
            this.lblDate.TabIndex = 5;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderID.Location = new System.Drawing.Point(160, 44);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(0, 28);
            this.lblOrderID.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(608, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitOrder.Location = new System.Drawing.Point(472, 36);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(112, 44);
            this.btnSubmitOrder.TabIndex = 2;
            this.btnSubmitOrder.Text = "Submit";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIDware Order";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnCancel);
            this.grpCustomer.Controls.Add(this.btnSave);
            this.grpCustomer.Controls.Add(this.btnNew);
            this.grpCustomer.Controls.Add(this.txtZip);
            this.grpCustomer.Controls.Add(this.txtCity);
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.txtState);
            this.grpCustomer.Controls.Add(this.txtLastName);
            this.grpCustomer.Controls.Add(this.txtFirstName);
            this.grpCustomer.Controls.Add(this.label8);
            this.grpCustomer.Controls.Add(this.label7);
            this.grpCustomer.Controls.Add(this.label6);
            this.grpCustomer.Controls.Add(this.label5);
            this.grpCustomer.Controls.Add(this.label4);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.cboCustomers);
            this.grpCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCustomer.Location = new System.Drawing.Point(18, 203);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(726, 317);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(597, 34);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(472, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(349, 34);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 36);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.Color.White;
            this.txtZip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtZip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtZip.Location = new System.Drawing.Point(154, 276);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(290, 34);
            this.txtZip.TabIndex = 12;
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZip_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCity.Location = new System.Drawing.Point(154, 201);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(545, 34);
            this.txtCity.TabIndex = 11;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Location = new System.Drawing.Point(154, 164);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(545, 34);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.White;
            this.txtState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtState.Location = new System.Drawing.Point(154, 239);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(290, 34);
            this.txtState.TabIndex = 9;
            this.txtState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtState_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLastName.Location = new System.Drawing.Point(154, 124);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(545, 34);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(154, 86);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(545, 34);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Zip:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Name:";
            // 
            // cboCustomers
            // 
            this.cboCustomers.BackColor = System.Drawing.Color.White;
            this.cboCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCustomers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(14, 34);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(318, 36);
            this.cboCustomers.Sorted = true;
            this.cboCustomers.TabIndex = 0;
            this.cboCustomers.SelectedIndexChanged += new System.EventHandler(this.cboCustomers_SelectedIndexChanged);
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.btnAdd);
            this.grpProducts.Controls.Add(this.nudQuantity);
            this.grpProducts.Controls.Add(this.lblTotal);
            this.grpProducts.Controls.Add(this.label10);
            this.grpProducts.Controls.Add(this.label9);
            this.grpProducts.Controls.Add(this.cboProducts);
            this.grpProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpProducts.Location = new System.Drawing.Point(18, 532);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(294, 244);
            this.grpProducts.TabIndex = 2;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Products";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(43, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudQuantity.Location = new System.Drawing.Point(141, 79);
            this.nudQuantity.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(138, 34);
            this.nudQuantity.TabIndex = 3;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(160, 185);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 42);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(14, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantity";
            // 
            // cboProducts
            // 
            this.cboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(6, 30);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(282, 36);
            this.cboProducts.TabIndex = 3;
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.btnRemove);
            this.grpCart.Controls.Add(this.lstCart);
            this.grpCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCart.Location = new System.Drawing.Point(340, 532);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(404, 243);
            this.grpCart.TabIndex = 3;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Shopping Cart";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(75, 198);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(262, 39);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove from Cart";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 21;
            this.lstCart.Location = new System.Drawing.Point(17, 33);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(370, 151);
            this.lstCart.Sorted = true;
            this.lstCart.TabIndex = 0;
            // 
            // frmKWSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 787);
            this.ControlBox = false;
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpProducts);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKWSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KWSales Order Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKWSales_FormClosing);
            this.Load += new System.EventHandler(this.frmKWSales_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpProducts.ResumeLayout(false);
            this.grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.grpCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstCart;
    }
}

