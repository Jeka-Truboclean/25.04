using System.Windows.Forms;

namespace _25._04
{
    public partial class Form1 : Form
    {
        private List<Form2.Component> component;
        private List<Form2.Component> sales;
        public Form1()
        {
            InitializeComponent();
            component= new List<Form2.Component>();
            sales = new List<Form2.Component>();
            UpdateComponentsDropdown();
        }
        private void UpdateComponentsDropdown()
        {
            comboBoxComponents.DataSource = null;
            comboBoxComponents.DataSource = component;
            comboBoxComponents.DisplayMember = "Name";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxComponents.SelectedItem is Form2.Component selectedComponent)
            {
                sales.Add(selectedComponent);
                listBoxSales.Items.Add(selectedComponent.Name + " - " + selectedComponent.Price.ToString("C"));
                UpdateTotalPrice();
            }
        }
        private void buttonEditComponents_Click(object sender, EventArgs e)
        {
            var editForm = new Form2(component);
            editForm.ShowDialog();
            UpdateComponentsDropdown();
        }
        private void comboBoxComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxComponents.SelectedItem is Form2.Component selectedComponent)
            {
                textBoxPrice.Text = selectedComponent.Price.ToString("C");
            }
        }
        private void UpdateTotalPrice()
        {
            decimal totalPrice = sales.Sum(s => s.Price);
            textBoxTotalPrice.Text = totalPrice.ToString("C");
        }
    }
}
