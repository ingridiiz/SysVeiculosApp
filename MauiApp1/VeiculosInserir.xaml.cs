namespace SysVeiculosApp;

public partial class VeiculosInserir : ContentPage
{
    public VeiculosInserir()
    {
        InitializeComponent();
    }

    private async void btnSalvarOnClick(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Sucesso", "Veículo salvo com sucesso!", "OK");
        await Navigation.PopAsync();
    }

    private async void btnVoltarOnClick(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}