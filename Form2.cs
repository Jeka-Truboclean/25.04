using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25._04
{
    public partial class Form2 : Form
    {
        public Form2(List<Component> components)
        {
            InitializeComponent();
            Components = components;
            listBoxComponents.DataSource = new BindingSource(Components, null);
        }
        public class Component
        {
            public string Name { get; set; }
            public string Specs { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Specs} - {Description}";
            }
        }
        public List<Component> Components { get; private set; }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var component = new Component
            {
                Name = textBoxName.Text,
                Specs = textBoxSpecs.Text,
                Description = textBoxDescription.Text,
                Price = decimal.Parse(textBoxPrice.Text)
            };
            Components.Add(component);
            listBoxComponents.DataSource = null;
            listBoxComponents.DataSource = Components;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxComponents.SelectedItem is Component component)
            {
                component.Name = textBoxName.Text;
                component.Specs = textBoxSpecs.Text;
                component.Description = textBoxDescription.Text;
                component.Price = decimal.Parse(textBoxPrice.Text);
                listBoxComponents.DataSource = null;
                listBoxComponents.DataSource = Components;
            }
        }
        private void listBoxComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxComponents.SelectedItem is Component component)
            {
                textBoxName.Text = component.Name;
                textBoxSpecs.Text = component.Specs;
                textBoxDescription.Text = component.Description;
                textBoxPrice.Text = component.Price.ToString();
            }
        }
    }
}
