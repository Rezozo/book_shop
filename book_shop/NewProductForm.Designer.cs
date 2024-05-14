namespace book_shop
{
    partial class NewProductForm
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
            this.newBookBtn = new System.Windows.Forms.Button();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // newBookBtn
            // 
            this.newBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newBookBtn.Location = new System.Drawing.Point(112, 533);
            this.newBookBtn.Name = "newBookBtn";
            this.newBookBtn.Size = new System.Drawing.Size(281, 39);
            this.newBookBtn.TabIndex = 38;
            this.newBookBtn.Text = "Сохранить товар";
            this.newBookBtn.UseVisualStyleBackColor = true;
            this.newBookBtn.Click += new System.EventHandler(this.newBookBtn_Click);
            // 
            // productImage
            // 
            this.productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImage.Image = global::book_shop.Properties.Resources.basebook;
            this.productImage.Location = new System.Drawing.Point(145, 89);
            this.productImage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(196, 181);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 39;
            this.productImage.TabStop = false;
            this.productImage.Click += new System.EventHandler(this.productImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(203, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Книга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Изображение";
            // 
            // titleTxt
            // 
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTxt.Location = new System.Drawing.Point(112, 316);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(281, 27);
            this.titleTxt.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Стоимость";
            // 
            // costTxt
            // 
            this.costTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTxt.Location = new System.Drawing.Point(112, 370);
            this.costTxt.Name = "costTxt";
            this.costTxt.Size = new System.Drawing.Size(281, 27);
            this.costTxt.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Количество";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTxt.Location = new System.Drawing.Point(112, 424);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(281, 27);
            this.quantityTxt.TabIndex = 46;
            // 
            // authorBox
            // 
            this.authorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.authorBox.FormattingEnabled = true;
            this.authorBox.ItemHeight = 24;
            this.authorBox.Location = new System.Drawing.Point(112, 473);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(281, 32);
            this.authorBox.TabIndex = 48;
            this.authorBox.Text = "Автор";
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 598);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productImage);
            this.Controls.Add(this.newBookBtn);
            this.MaximumSize = new System.Drawing.Size(521, 645);
            this.MinimumSize = new System.Drawing.Size(521, 645);
            this.Name = "NewProductForm";
            this.Text = "Новый продукт";
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBookBtn;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.ComboBox authorBox;
    }
}