namespace book_shop
{
    partial class OrderForm
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
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.finishBtn = new System.Windows.Forms.Button();
            this.comment = new System.Windows.Forms.Label();
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBooks
            // 
            this.flowLayoutPanelBooks.AutoScroll = true;
            this.flowLayoutPanelBooks.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            this.flowLayoutPanelBooks.Size = new System.Drawing.Size(820, 421);
            this.flowLayoutPanelBooks.TabIndex = 34;
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCostLbl.Location = new System.Drawing.Point(12, 524);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(261, 29);
            this.totalCostLbl.TabIndex = 35;
            this.totalCostLbl.Text = "Итоговая стоимость: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Адрес доставки";
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTxt.Location = new System.Drawing.Point(246, 460);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(293, 30);
            this.addressTxt.TabIndex = 37;
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(588, 460);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(244, 29);
            this.finishBtn.TabIndex = 38;
            this.finishBtn.Text = "Сформировать заказ";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comment.Location = new System.Drawing.Point(535, 493);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(129, 20);
            this.comment.TabIndex = 39;
            this.comment.Text = "Комментарий:";
            // 
            // commentTxt
            // 
            this.commentTxt.Enabled = false;
            this.commentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentTxt.Location = new System.Drawing.Point(539, 516);
            this.commentTxt.Multiline = true;
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(293, 56);
            this.commentTxt.TabIndex = 40;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 581);
            this.Controls.Add(this.commentTxt);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.flowLayoutPanelBooks);
            this.MaximumSize = new System.Drawing.Size(862, 628);
            this.MinimumSize = new System.Drawing.Size(862, 628);
            this.Name = "OrderForm";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBooks;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Label comment;
        private System.Windows.Forms.TextBox commentTxt;
    }
}