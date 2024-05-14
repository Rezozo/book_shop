namespace book_shop
{
    partial class AdminOrdersForm
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
            this.ordersView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersView
            // 
            this.ordersView.AllowUserToAddRows = false;
            this.ordersView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ordersView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DateFrom,
            this.Status,
            this.Books,
            this.Client});
            this.ordersView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.ordersView.Location = new System.Drawing.Point(12, 73);
            this.ordersView.Name = "ordersView";
            this.ordersView.RowHeadersWidth = 51;
            this.ordersView.RowTemplate.Height = 24;
            this.ordersView.Size = new System.Drawing.Size(869, 461);
            this.ordersView.TabIndex = 84;
            this.ordersView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер ";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 75;
            // 
            // DateFrom
            // 
            this.DateFrom.HeaderText = "Дата";
            this.DateFrom.MinimumWidth = 6;
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ReadOnly = true;
            this.DateFrom.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Books
            // 
            this.Books.HeaderText = "Книги";
            this.Books.MinimumWidth = 6;
            this.Books.Name = "Books";
            this.Books.ReadOnly = true;
            this.Books.Width = 250;
            // 
            // Client
            // 
            this.Client.HeaderText = "Заказчик";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "Все заказы";
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxt.Location = new System.Drawing.Point(12, 37);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(305, 30);
            this.searchTxt.TabIndex = 89;
            this.searchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTxt_KeyPress);
            // 
            // datePick
            // 
            this.datePick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.datePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.datePick.Location = new System.Drawing.Point(356, 37);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(238, 28);
            this.datePick.TabIndex = 90;
            this.datePick.ValueChanged += new System.EventHandler(this.datePick_ValueChanged);
            // 
            // AdminOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 546);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordersView);
            this.Name = "AdminOrdersForm";
            this.Text = "Все заказы";
            this.Load += new System.EventHandler(this.AdminOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Books;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
    }
}