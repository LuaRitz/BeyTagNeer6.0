using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProModelo
    {
        private int codigoproduto;
        private string nomeproduto;
        private int stock;
        private string preco;
        private string imagem;


        public ProModelo()
        {
            codigoproduto = 0;
            nomeproduto = "";
            stock = 0;
            preco = "0,00";
            imagem = "//Fotos/Action_figures/default.png";
        }

        public int codProduto
        {
            get { return codigoproduto; }
            set { codigoproduto = value; }
        }
        public string NomePro
        {
            get { return nomeproduto; }
            set { nomeproduto = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public string Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public string Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }
    }
}
