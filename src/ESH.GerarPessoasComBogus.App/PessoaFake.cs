using Bogus;
using Bogus.Extensions.Brazil;
using Bogus.Extensions.Denmark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.GerarPessoasComBogus.App
{
    public static class PessoaFake
    {
        public static List<PessoaJson> Listar(int quantidade)
        {
            string [] sexo = { "Masculino", "Feminino" };

            var pessoaFake = new Faker<PessoaJson>("pt_BR")
                .RuleFor(c => c.Nome, f => f.Person.FullName)
                .RuleFor(c => c.Sexo, f => f.PickRandom(sexo))
                .RuleFor(c => c.Data_nasc, f => f.Person.DateOfBirth.ToString())
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.Telefone_fixo, f => f.Person.Phone.ToString())
                .RuleFor(c => c.Endereco, f => f.Person.Address.Street)
                .RuleFor(c => c.CEP, f => f.Address.ZipCode())
                .RuleFor(c => c.Celular, f => f.Person.Phone.ToString())
                .RuleFor(c => c.Bairro, f => f.Address.County())
                .RuleFor(c => c.Cidade, f => f.Address.City())
                .RuleFor(c => c.CPF, f => f.Person.Cpf())
                .RuleFor(c => c.RG, f => f.Person.Cpr());
            

              return pessoaFake.Generate(quantidade);            
        }
    }
}
