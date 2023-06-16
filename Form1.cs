namespace prova2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tx_box3.Text);
            double icms = Convert.ToDouble(tx_box4.Text);
            double lucro = Convert.ToDouble(tx_box5.Text);
            double pis = Convert.ToDouble(tx_box6.Text);
            double confins = Convert.ToDouble(tx_box7.Text);
            string unidade = Convert.ToString(cb_8.Text);
            

            Cadastro c = new Cadastro(valor, icms, lucro, pis, confins);
            double teste = c.CalculaTudo(valor, pis, icms, confins, lucro);

            unidade = unidade.ToUpper();

            if (unidade != "UN")
            {
                if (unidade == "LT" || unidade == "KL")
                {
                    
                    double teste4 = teste * (5 / 100);
                    
                    
                    label11.Text = Convert.ToString(c.CalculaTudo(valor, pis, icms, confins, lucro) + teste4);
                }
                
                    
                
                
                
                //nnnn
            }
            label11.Text = Convert.ToString(c.CalculaTudo(valor, pis, icms, confins, lucro));

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}