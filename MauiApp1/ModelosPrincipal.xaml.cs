namespace SysVeiculosApp;

public partial class ModelosPrincipal : ContentPage
{
    public ModelosPrincipal()
    {
        InitializeComponent();
    }

    private async void btnInserirOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ModelosInserir());
    }

    private async void btnAlterar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ModelosAlterar());
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