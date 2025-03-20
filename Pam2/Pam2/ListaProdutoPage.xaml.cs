namespace Pam2;

public partial class ListaProdutoPage : ContentPage
{
	public ListaProdutoPage()
	{
        List<Produto> lista = Produto.Lista;

        InitializeComponent();
		lstProduto.ItemsSource = lista;

	}
}