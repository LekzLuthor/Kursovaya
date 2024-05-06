using System.Reflection;

namespace KursovayaLast
{
    public partial class Form1 : Form
    {
        public const string PATH_WAY = "C:/TextFiles/";

        public Form1()
        {
            InitializeComponent();
           
        }
            
        private void openButton_Click(object sender, EventArgs e)
        {
            var selectedFileName = listBox1.SelectedItem as string;
            textBox1.Text = PATH_WAY + selectedFileName;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nameInput.Text);
        }



        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}