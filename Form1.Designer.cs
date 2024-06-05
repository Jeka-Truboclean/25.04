namespace _25._04
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
            comboBoxComponents = new ComboBox();
            listBoxSales = new ListBox();
            textBoxPrice = new TextBox();
            textBoxTotalPrice = new TextBox();
            AddButton = new Button();
            EditButton = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBoxComponents
            // 
            comboBoxComponents.FormattingEnabled = true;
            comboBoxComponents.Location = new Point(10, 67);
            comboBoxComponents.Name = "comboBoxComponents";
            comboBoxComponents.Size = new Size(121, 23);
            comboBoxComponents.TabIndex = 0;
            comboBoxComponents.SelectedIndexChanged += comboBoxComponents_SelectedIndexChanged;
            // 
            // listBoxSales
            // 
            listBoxSales.FormattingEnabled = true;
            listBoxSales.ItemHeight = 15;
            listBoxSales.Location = new Point(137, 29);
            listBoxSales.Name = "listBoxSales";
            listBoxSales.Size = new Size(172, 94);
            listBoxSales.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(315, 67);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 2;
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(510, 67);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(100, 23);
            textBoxTotalPrice.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(10, 155);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += buttonAdd_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(537, 155);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 5;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += buttonEditComponents_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 49);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 12;
            label4.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 11);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 13;
            label1.Text = "Sales:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 49);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 14;
            label2.Text = "Total Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 49);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 15;
            label3.Text = "Components:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 190);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(textBoxTotalPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(listBoxSales);
            Controls.Add(comboBoxComponents);
            Name = "Form1";
            Text = "My program ^_^";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxComponents;
        private ListBox listBoxSales;
        private TextBox textBoxPrice;
        private TextBox textBoxTotalPrice;
        private Button AddButton;
        private Button EditButton;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
