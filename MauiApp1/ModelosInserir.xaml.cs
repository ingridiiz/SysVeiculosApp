namespace SysVeiculosApp;

public partial class ModelosInserir : ContentPage
{
    public ModelosInserir()
    {
        InitializeComponent();
    }

    private async void btnSalvarOnClick(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Sucesso", "Modelo salvo com sucesso!", "OK");
        await Navigation.PopAsync();
    }

    private async void btnVoltarOnClick(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}