using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InfoAmbiente
{
	public partial class Home : ContentPage
	{
		public Home (bool logged)
		{
			InitializeComponent ();

            MontaAcesso(logged);
        }

        public void MontaAcesso(bool logged)
        {
            if (!logged)
                cvPropAbsolvidas.IsVisible = cvPropAcusadas.IsVisible = cvPropInterditadas.IsVisible = false;
        }

        protected override bool OnBackButtonPressed()
        {
            // Sai do app al clicar em Voltar
            return true;
        }
    }
}