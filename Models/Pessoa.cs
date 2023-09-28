using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome,out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        private string _nome,_sobrenome;        
        private int _idade;
        public string Nome 
        { 
            get => _nome.ToUpper(); 
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O Nome não pode ser em branco");
                }
                _nome = value;
            }
        }
        public string Sobrenome 
        {
            get => _sobrenome.ToUpper(); 
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O Sobrenome não pode ser em branco");
                }
                _sobrenome = value;
            }
        }
        public int Idade 
        { 
            get => _idade; 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }
        public string NomeCompleto { get => $"{Nome} {Sobrenome}".ToUpper(); }
        
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}