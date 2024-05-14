namespace book_shop
{
    partial class BookListForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.orderBtn = new System.Windows.Forms.Button();
            this.allOrdersBtn = new System.Windows.Forms.Button();
            this.newBookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // sortBox
            // 
            this.sortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.sortBox.FormattingEnabled = true;
            this.sortBox.ItemHeight = 24;
            this.sortBox.Items.AddRange(new object[] {
            "По умолчанию",
            "По автору(А-Я)",
            "По автору(Я-А)",
            "По стоимости (по возрастанию)",
            "По стоимости (по убыванию)"});
            this.sortBox.Location = new System.Drawing.Point(337, 12);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(294, 32);
            this.sortBox.TabIndex = 30;
            this.sortBox.Text = "Сортировка";
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.sortBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Для совершения действий нажмите правой кнопкой мыши по товару";
            // 
            // flowLayoutPanelBooks
            // 
            this.flowLayoutPanelBooks.AutoScroll = true;
            this.flowLayoutPanelBooks.Location = new System.Drawing.Point(16, 116);
            this.flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            this.flowLayoutPanelBooks.Size = new System.Drawing.Size(1031, 564);
            this.flowLayoutPanelBooks.TabIndex = 33;
            // 
            // flowLayoutPanelPagination
            // 
            this.flowLayoutPanelPagination.Location = new System.Drawing.Point(810, 698);
            this.flowLayoutPanelPagination.Name = "flowLayoutPanelPagination";
            this.flowLayoutPanelPagination.Size = new System.Drawing.Size(237, 45);
            this.flowLayoutPanelPagination.TabIndex = 34;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(766, 12);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(281, 39);
            this.orderBtn.TabIndex = 35;
            this.orderBtn.Text = "Перейти к заказу";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // allOrdersBtn
            // 
            this.allOrdersBtn.Location = new System.Drawing.Point(766, 64);
            this.allOrdersBtn.Name = "allOrdersBtn";
            this.allOrdersBtn.Size = new System.Drawing.Size(281, 39);
            this.allOrdersBtn.TabIndex = 36;
            this.allOrdersBtn.Text = "Перейти к заказам";
            this.allOrdersBtn.UseVisualStyleBackColor = true;
            this.allOrdersBtn.Click += new System.EventHandler(this.allOrdersBtn_Click);
            // 
            // newBookBtn
            // 
            this.newBookBtn.Location = new System.Drawing.Point(766, 11);
            this.newBookBtn.Name = "newBookBtn";
            this.newBookBtn.Size = new System.Drawing.Size(281, 39);
            this.newBookBtn.TabIndex = 37;
            this.newBookBtn.Text = "Добавить товар";
            this.newBookBtn.UseVisualStyleBackColor = true;
            this.newBookBtn.Click += new System.EventHandler(this.newBookBtn_Click);
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 755);
            this.Controls.Add(this.newBookBtn);
            this.Controls.Add(this.allOrdersBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.flowLayoutPanelPagination);
            this.Controls.Add(this.flowLayoutPanelBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(1084, 802);
            this.MinimumSize = new System.Drawing.Size(1084, 802);
            this.Name = "BookListForm";
            this.Text = "Все продукты";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBooks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPagination;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button allOrdersBtn;
        private System.Windows.Forms.Button newBookBtn;
    }
}