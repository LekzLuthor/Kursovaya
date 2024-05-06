using System.Reflection;

namespace KursovayaLast
{
    public partial class Form1 : Form
    {
        public const string PATH_WAY = "C:/TextFiles/";

        public Form1()
        {

            InitializeComponent();

            listBox1.Items.Clear();
            List<string> filesDir1 = (from a in Directory.GetFiles(PATH_WAY) select Path.GetFileName(a)).ToList();

            foreach (string file in filesDir1)
            {
                listBox1.Items.Add(file);
            }

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var selectedFileName = listBox1.SelectedItem as string;
            selectedFileName = PATH_WAY + selectedFileName;

            String fileText;
            String line;
            try
            {
                StreamReader sr = new StreamReader(selectedFileName);
                line = sr.ReadLine();

                fileText = line;
                while (line != null)
                {
                    fileText = fileText + line;
                    line = sr.ReadLine();
                }
                textBox1.Text = fileText;
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                textBox1.Text = "Ошибка: Такого файла не существет!";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedFileName = listBox1.SelectedItem as string;
            selectedFileName = PATH_WAY + selectedFileName;

            try
            {
                System.IO.File.Delete(selectedFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newFileName = nameInput.Text;
            newFileName = PATH_WAY + newFileName + ".txt";

            try
            {
                System.IO.File.Create(newFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            listBox1.Items.Add(nameInput.Text + ".txt");

        }



        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}