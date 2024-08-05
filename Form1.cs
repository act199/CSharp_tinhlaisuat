namespace CSharp_tinhlaisuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (double i= 0.01; i<= 0.101; i+= 0.001)
                cbBLaixuat.Items.Add(string.Format("{0:P1}",Math.Round(i,3)));
        }
        txtSotien.Text = "10000000";
            cbBLaixuat.DropDownStyle = ComboBoxStyle.DropDownList;
        private void btnTinh_Click(object sender, EventArgs e)
        {
            lblKetqua.Items.Clear();
            double sotien = Convert.ToInt64(txtSotien.Text);
            int sonam = (int)sotien;    
        }
    }
}
