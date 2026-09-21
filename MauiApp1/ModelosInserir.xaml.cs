using Microsoft.Maui.Controls;
using SysVeiculosApp;

namespace SysVeiculosApp
{
    public partial class ModelosInserir : ContentPage
    {
        public ModelosInserir()
        {
            InitializeComponent();
        }

        private async void btnSalvarOnClick(object sender, EventArgs e)
        {
            Modelo novoModelo = new Modelo();
            novoModelo.modnome = txtNomeModelo.Text;
            novoModelo.modobservacoes = txtMarcaModelo.Text;

            await App.Database.SalvarModeloAsync(novoModelo);
            await DisplayAlertAsync("Sucesso", "Modelo salvo com sucesso!", "OK");
            await Navigation.PopAsync();
        }

        private async void btnVoltarOnClick(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}