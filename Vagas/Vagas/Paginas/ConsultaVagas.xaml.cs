using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vagas.Banco;
using Vagas.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultaVagas : ContentPage
	{
		public ConsultaVagas ()
		{
			InitializeComponent ();
            Database database = new Database();
            var Lista = database.Consultar();
            ListaVagas.ItemsSource = Lista;

            lblCount.Text = Lista.Count.ToString();
        }

        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVaga());
        }
        public void GoMinhasVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }
        public void MaisDetalheAction(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]).CommandParameter as Vaga;
            Navigation.PushAsync(new DetalheVaga(vaga));
        }
    }
}