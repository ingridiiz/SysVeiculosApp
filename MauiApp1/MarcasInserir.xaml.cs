namespace SysVeiculosApp;

public partial class MarcasInserir : ContentPage
{
    public MarcasInserir()
    {
        InitializeComponent();
    }

    private async void btnSalvarOnClick(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Sucesso", "Marca salva com sucesso!", "OK");
        await Navigation.PopAsync();
    }

    private async void btnVoltarOnClick(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}