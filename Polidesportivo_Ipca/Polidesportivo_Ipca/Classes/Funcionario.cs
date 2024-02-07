using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Polidesportivo_Ipca.Enums;
using System.Xml.Linq;
using System.Collections;
using Polidesportivo_Ipca.Classes;

namespace Polidesportivo_Ipca.Classes
{
    public class Funcionario : Pessoa, IFuncionario
    {
        //Variaveis

        /// <summary>
        /// Criação da lista de funcionários
        /// </summary>
        public static List<Funcionario> listaFuncionario = new List<Funcionario>();

        //Propriedades

        /// <summary>
        /// Nr de Processo do funcionário
        /// </summary>
        public string NrProcessoEscola { get; set; }

        //Metodos

        /// <summary>
        /// Metodo para adicionar dados localmente na lista de funcionarios
        /// </summary>
        public static void DadosLista()
        {
            listaFuncionario.Add(new Funcionario()
            {
                Nome = "Lurdes",
                Email = "lurdesdascouves@gmail.com",
                Password = "Lurdes1",
                DataNascimento = new DateTime(2003, 05, 31),
                NrProcessoEscola = "1",
                NumeroTlm = "960424821",

            });
        }


        /// <summary>
        /// Metodo para filtrar o primeiro funcionario que valida a condição
        /// </summary>
        /// <param name="nrprocesso">Numero de Processo do funcionário</param>
        /// <param name="pass">Password do funcionario</param>
        /// <returns></returns>
        public Funcionario FuncionarioLogin(string nrprocesso, string pass)
        {
            Funcionario funcionario = listaFuncionario.FirstOrDefault(r => r.NrProcessoEscola.Equals(nrprocesso) && r.Password.Equals(pass));
            return funcionario;
        }

        /// <summary>
        /// Metodo para guardar a lista de funcionários em ficheiro .txt
        /// </summary>
        public static void GuardarListaFuncionario()
        {
            string save = JsonConvert.SerializeObject(listaFuncionario);
            File.WriteAllText(Environment.CurrentDirectory + @"\listafuncionarios.txt", save);
        }

        /// <summary>
        /// Metodo para carregar o ficheiro listafuncionarios.txt para a lista de funcionários
        /// </summary>
        public static void CarregarListaFuncionario()
        {
            if (File.Exists(Environment.CurrentDirectory + @"\listafuncionarios.txt"))
                listaFuncionario = JsonConvert.DeserializeObject<List<Funcionario>>(File.ReadAllText(Environment.CurrentDirectory + @"\listafuncionarios.txt"));
            else
                File.WriteAllText(Environment.CurrentDirectory + @"\listafuncionarios.txt", "[]");
        }
    }
}
