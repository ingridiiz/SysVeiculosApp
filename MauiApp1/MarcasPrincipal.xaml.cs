namespace SysVeiculosApp;

public partial class MarcasPrincipal : ContentPage
{
    public MarcasPrincipal()
    {
        InitializeComponent();
    }

    private async void btnInserir_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MarcasInserir());
    }

    private async void btnAlterar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MarcasAlterar());
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