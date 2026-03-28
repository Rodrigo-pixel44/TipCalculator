using System.Diagnostics;

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

            try
            {
                // outra forma de realizar conversão
                // double refeicao = Convert.ToDouble(RefeicaoEntry.Text);
                double refeicao = Double.Parse(RefeicaoEntry.Text);
                double porcentagem = Double.Parse(PorcentagemEntry.Text);
                int qtdPessoas = Int32.Parse(QuantidadedePessoaEntry.Text);

                double gorjeta = refeicao * (porcentagem / 100);
                double valortotal = refeicao + gorjeta;
                double valorPorPessoa = valortotal / qtdPessoas;
               
                

                GorjetaEntry.Text = gorjeta.ToString("C");
                ValorporPessoaEntry.Text = valorPorPessoa.ToString("C");
                ValortotalEntry.Text = valortotal.ToString("C");

            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

        }

        //  private void CalcularButton_Clicked(object sender, EventArgs e);

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            PorcentagemEntry.Text = value.ToString();
        }

    }



}
