using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CarrinhoModelo
    {
        private long carrinho;
        private int uscode;
        private int cep;
        private DateTime data;

        public CarrinhoModelo()
        {
            carrinho = 0;
            uscode = 0;
            cep = 0;
        }

        public long carrinhoCom
        {
            get { return carrinho; }
            set { carrinho = value; }
        }
        public int usucode
        {
            get { return uscode; }
            set { uscode = value; }
        }
        public int CepL
        {
            get { return cep; }
            set { cep = value; }
        }
        public DateTime dataT
        {
            get { return data; }
            set { data = value; }
        }
    }
}
