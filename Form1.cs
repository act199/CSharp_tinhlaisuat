using System.Globalization;

namespace CSharp_tinhlaisuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lsbKetqua.Items.Clear();
            double sotien = Convert.ToInt64(txtSotien.Text);
            int sonam = (int)nupSonam.Value;
            double laiSuat = Double.Parse(cbBLaixuat.SelectedItem.ToString().Replace("%", "")) / 100;
            MessageBox.Show("lai Suat " + laiSuat);
            for (int i = 1; i <= sonam; i++)
            {
                double tienlai = sotien * laiSuat;
                lsbKetqua.Items.Add("Năm " + i + " Tiền gốc: " + sotien.ToString("N", new CultureInfo("en-US")) + " - Lãi: " + tienlai.ToString("N", new CultureInfo("en-US")));
                sotien += tienlai;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            for (double i = 0.01; i <= 0.101; i += 0.001)
            {
                cbBLaixuat.Items.Add(string.Format("{0:P1}", Math.Round(i, 3)));
            }
            txtSotien.Text = "10000000";
            cbBLaixuat.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
