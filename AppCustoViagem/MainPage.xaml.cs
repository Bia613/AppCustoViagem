namespace AppCustoViagem
{
    public partial class MainPage : TabbedPage
    {
 

        public MainPage()
        {
            InitializeComponent();
        }

        private void btncal_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtdis.Text);
            double b = Convert.ToDouble(txtren.Text);
            double c = Convert.ToDouble(txtcom.Text);

            double resu = (a/b)*c ;

            string msg = $"O custo total da viagem é R${resu}";


            DisplayAlert("Resultado", msg, "Fechar");
        }

        private void btnadd_Clicked(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(txtval.Text);
           //double val = ;//
            string msg = $"O custo total da viagem com o pedagio é R$";
            DisplayAlert("Resultado", msg, "Fechar");

        }

        private void btnped_Clicked(object sender, EventArgs e)
        {

        }
    }

}
