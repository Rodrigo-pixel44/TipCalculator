namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void CalcularButton_Clicked(object sender, EventArgs e)
        {
            // outra forma de realizar conversão
            // double refeicao = Convert.ToDouble(RefeicaoEntry.Text);
            double refeicao = Double.Parse(RefeicaoEntry.Text);
            double porcentagem = Double.Parse(PorcentagemEntry.Text);
            int qtdPessoas = Int32.Parse(QuantidadedePessoaEntry.Text);

            double gorjeta = refeicao * (porcentagem / 100);
            double valortotal = refeicao + gorjeta;
            double valorPorPessoa = valortotal / qtdPessoas;

            GorjetaEntry.Text = gorjeta.ToString();
            ValorporPessoaEntry.Text = valorPorPessoa.ToString();
            ValortotalEntry.Text = valortotal.ToString();




        }



    }
}
