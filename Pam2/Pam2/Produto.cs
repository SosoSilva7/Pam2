using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pam2
{
    internal class Produto
    {
        public double Preco { get; set; }
        public string Nome { get; set; }

        public string Categoria { get; set; }

        public static List<Produto> Lista
        {
            get
            {
                List<Produto> lista = new List<Produto>();
                lista.Add(new Produto() { Nome = "Picanha", Preco = 9999, Categoria = "Alimento" });
                lista.Add(new Produto() { Nome = "Coleira", Preco = 22, Categoria = "Pet" });
                lista.Add(new Produto() { Nome = "Teclado", Preco = 55, Categoria = "Informática" });
                lista.Add(new Produto() { Nome = "Uno", Preco = 20, Categoria = "Brinquedos" });
                lista.Add(new Produto() { Nome = "Carro", Preco = 300000, Categoria = "Automóvel" });
                lista.Add(new Produto() { Nome = "Jaleco", Preco = 80, Categoria = "Roupa" });
                return lista;
            }
        }
    }
}
