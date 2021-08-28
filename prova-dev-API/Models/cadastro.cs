

using System;

namespace prova_dev_API.Models
{
    public class cadastro
    {
        public cadastro(string nome)
        {
            this.nome = nome;
        }
        public cadastro(string nome, string email, int cpf, string renda, string dtnasc, string celular, string profissao)
        {
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.renda = renda;
            this.dtnasc = dtnasc;
            this.celular = celular;
            this.profissao = profissao;

        }
        private string nome { get; set; }
        public string email { get; set; }
        public int cpf { get; set; }
        public string renda { get; set; }
        public string dtnasc { get; set; }
        public string celular { get; set; }
        public string profissao { get; set; }

    }
}