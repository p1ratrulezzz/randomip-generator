namespace FileTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialogOpen = new SaveFileDialog();
            dialogOpen.Filter = "Text files|*.txt";
            dialogOpen.FileName = "ip_addresses.txt";
            DialogResult hResult = dialogOpen.ShowDialog();
            if (hResult == DialogResult.OK)
            {
                System.IO.StreamWriter fileWriter;
                if (File.Exists(dialogOpen.FileName))
                {
                    fileWriter = File.CreateText(dialogOpen.FileName);
                }
                else
                {
                    fileWriter = File.AppendText(dialogOpen.FileName);

                }

                IpGenerator ipGenerator = new IpGenerator();
                progressBar1.Visible = true;
                progressBar1.Maximum = (int)quantityUpDown.Value;
                progressBar1.Value = 0;

                for (uint i = 0; i < quantityUpDown.Value; i++)
                {
                    fileWriter.WriteLine(ipGenerator.AnyIp().ToString());
                    progressBar1.Value++;
                }

                fileWriter.Close();
                MessageBox.Show("File was created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
    }
}