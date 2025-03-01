using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace captaçãocliente
{
    public class Cl
    {
        private string nome;
        private string telefone;
        private string email;
        private string rg;
        private string cpf;
        private string cep;
        private string cidade;
        private string uf;
        private string numero;
        private string endereco;

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set =>cpf = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}
