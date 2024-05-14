namespace book_shop
{
    partial class AdminEditForm
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
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.comment = new System.Windows.Forms.Label();
            this.finishBtn = new System.Windows.Forms.Button();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // commentTxt
            // 
            this.commentTxt.Enabled = false;
            this.commentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentTxt.Location = new System.Drawing.Point(538, 513);
            this.commentTxt.Multiline = true;
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(293, 56);
            this.commentTxt.TabIndex = 47;
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comment.Location = new System.Drawing.Point(534, 490);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(129, 20);
            this.comment.TabIndex = 46;
            this.comment.Text = "Комментарий:";
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(587, 418);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(244, 29);
            this.finishBtn.TabIndex = 45;
            this.finishBtn.Text = "Сохранить заказ";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTxt.Location = new System.Drawing.Point(245, 418);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(293, 30);
            this.addressTxt.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Адрес доставки";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCostLbl.Location = new System.Drawing.Point(12, 471);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(261, 29);
            this.totalCostLbl.TabIndex = 42;
            this.totalCostLbl.Text = "Итоговая стоимость: ";
            // 
            // flowLayoutPanelBooks
            // 
            this.flowLayoutPanelBooks.AutoScroll = true;
            this.flowLayoutPanelBooks.Location = new System.Drawing.Point(12, 10);
            this.flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            this.flowLayoutPanelBooks.Size = new System.Drawing.Size(820, 390);
            this.flowLayoutPanelBooks.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "Статус:";
            // 
            // sortBox
            // 
            this.sortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.sortBox.FormattingEnabled = true;
            this.sortBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.sortBox.ItemHeight = 24;
            this.sortBox.Items.AddRange(new object[] {
            "Новый",
            "Сформирован",
            "Подтвержден",
            "Выполнен"});
            this.sortBox.Location = new System.Drawing.Point(138, 523);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(294, 32);
            this.sortBox.TabIndex = 49;
            this.sortBox.Text = "Статус";
            // 
            // AdminEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 581);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commentTxt);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.flowLayoutPanelBooks);
            this.MaximumSize = new System.Drawing.Size(862, 628);
            this.MinimumSize = new System.Drawing.Size(862, 628);
            this.Name = "AdminEditForm";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.AdminEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commentTxt;
        private System.Windows.Forms.Label comment;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortBox;
    }
}