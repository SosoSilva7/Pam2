namespace Pam2;

public partial class ListaProdutoPage : ContentPage
{
	public ListaProdutoPage()
	{
        List<Produto> lista = Produto.Lista;

        InitializeComponent();
		lstProduto.ItemsSource = lista; // update na lista da pagina

	}

    private void ViewCell_Tapped(object sender, EventArgs e)
    {
        
        Navigation.PushAsync(new ProdutoPage() { BindingContext = (((ViewCell)sender).BindingContext as Produto) }); // fala q o sender deve ser lido como um viewcell, afinal sender é um nome generico
    }
}