namespace SysVeiculosApp;

public partial class VeiculosAlterar : ContentPage
{
    public VeiculosAlterar()
    {
        InitializeComponent();
    }

    private async void btnSalvarOnClick(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Sucesso", "Alteração salva com sucesso!", "OK");
        await Navigation.PopAsync();
    }

    private async void btnVoltarOnClick(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}