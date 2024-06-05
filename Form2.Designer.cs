namespace _25._04
{
    partial class Form2
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
            listBoxComponents = new ListBox();
            textBoxName = new TextBox();
            textBoxSpecs = new TextBox();
            textBoxDescription = new TextBox();
            textBoxPrice = new TextBox();
            EditButton = new Button();
            AddButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBoxComponents
            // 
            listBoxComponents.FormattingEnabled = true;
            listBoxComponents.ItemHeight = 15;
            listBoxComponents.Location = new Point(12, 12);
            listBoxComponents.Name = "listBoxComponents";
            listBoxComponents.Size = new Size(600, 139);
            listBoxComponents.TabIndex = 1;
            listBoxComponents.SelectedIndexChanged += listBoxComponents_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 279);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(138, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxSpecs
            // 
            textBoxSpecs.Location = new Point(156, 279);
            textBoxSpecs.Name = "textBoxSpecs";
            textBoxSpecs.Size = new Size(133, 23);
            textBoxSpecs.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(295, 235);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(211, 112);
            textBoxDescription.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(512, 279);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 5;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(12, 438);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 6;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += buttonEdit_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(537, 438);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 7;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 261);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 261);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Specs:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 217);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 10;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 261);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 11;
            label4.Text = "Price:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 473);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Controls.Add(EditButton);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxSpecs);
            Controls.Add(textBoxName);
            Controls.Add(listBoxComponents);
            Name = "Form2";
            Text = "My program '-'";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxComponents;
        private TextBox textBoxName;
        private TextBox textBoxSpecs;
        private TextBox textBoxDescription;
        private TextBox textBoxPrice;
        private Button EditButton;
        private Button AddButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}