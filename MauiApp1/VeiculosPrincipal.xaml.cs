namespace SysVeiculosApp;

public partial class VeiculosPrincipal : ContentPage
{
    public VeiculosPrincipal()
    {
        InitializeComponent();
    }

    private async void btnInserirOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VeiculosInserir());
    }

    private async void btnAlterar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VeiculosAlterar());
    }

    private async void btnExcluir_Clicked(object sender, EventArgs e)
    {
        bool confirmar = await DisplayAlertAsync("Excluir", "Deseja realmente excluir?", "Sim", "Não");
        if (confirmar)
        {
            await DisplayAlertAsync("Sucesso", "Excluído com sucesso!", "OK");
        }
    }
}