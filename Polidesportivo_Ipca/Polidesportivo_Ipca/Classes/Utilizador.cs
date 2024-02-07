using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using Polidesportivo_Ipca.Classes;

namespace Polidesportivo_Ipca
{
    public class Utilizador : Pessoa,IUtilizador
    {
        
        //Variavel
        /// <summary>
        /// Criacao da lista de Utilizadores
        /// </summary>
        public static List<Utilizador> listaUtilizador = new List<Utilizador>();
        /// <summary>
        /// Delegado para calcular IMC e Massa Magra
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public delegate string Calculo(string peso, string altura);

        //Propriedades

        /// <summary>
        /// Nr de Processo do Aluno
        /// </summary>
        public string NrProcessoEscola { get; set; }
        /// <summary>
        /// Peso do utilizador
        /// </summary>
        public string Peso { get; set; }
        /// <summary>
        /// Massa Gorda do utilizador
        /// </summary>
        public string MassaMagra { get; set; }
        /// <summary>
        /// Altura do utilizador
        /// </summary>
        public string Altura { get; set; }
        /// <summary>
        /// Perímetro dos ombros do utilizador
        /// </summary>
        public string Ombros { get; set; }
        /// <summary>
        /// Perímetros dos membros superiores do utilizador
        /// </summary>
        public string Braco { get; set; }
        /// <summary>
        /// Perímetro do antebraço do utilizador
        /// </summary>
        public string Antebraco { get; set; }
        /// <summary>
        /// Envergadura do Utilizador
        /// </summary>
        public string Envergadura { get; set; }
        /// <summary>
        /// Perímetro dos gluteos do utilizador
        /// </summary>
        public string Gluteos { get; set; }
        /// <summary>
        /// Perímetro da coxa do utilizador
        /// </summary>
        public string Coxa { get; set; }
        /// <summary>
        /// IMC do utilizador
        /// </summary>
        public string IMC { get; set; }

        //Metodos

        /// <summary>
        /// Metodo para adicionar Dados localmente na lista de utilizadores
        /// </summary>
        public static void DadosLista()
        {
            listaUtilizador.Add(new Utilizador()
            {
                Nome = "Daniel",
                Email = "danieldascouves@gmail.com",
                Password = "Daniel1",
                DataNascimento = new DateTime(2003, 05, 31),
                NrProcessoEscola = "23507",
                NumeroTlm = "960424821",
                Peso = "87",
                MassaMagra = "",
                Altura="178",
                Ombros = "60",
                Braco = "60",
                Antebraco = "30",
                Envergadura = "200",
                Gluteos = "50",
                Coxa="40",
                IMC = "",
            });
            listaUtilizador.Add(new Utilizador()
            {
                Nome = "Manuel",
                Email = "manueldascouves@gmail.com",
                Password = "Manuel1",
                DataNascimento = new DateTime(2003, 05, 31),
                NrProcessoEscola = "23502",
                NumeroTlm = "960424821",
                Peso = "87",
                MassaMagra = "",
                Altura = "178",
                Ombros = "60",
                Braco = "60",
                Antebraco = "30",
                Envergadura = "200",
                Gluteos = "50",
                Coxa = "40",
                IMC = "",
            });
            listaUtilizador.Add(new Utilizador()
            {
                Nome = "Diogo",
                Email = "diogodascouves@gmail.com",
                Password = "Diogo1",
                DataNascimento = new DateTime(2003, 05, 31),
                NrProcessoEscola = "21086",
                NumeroTlm = "960424821",
                Peso = "87",
                MassaMagra = "",
                Altura = "178",
                Ombros = "60",
                Braco = "60",
                Antebraco = "30",
                Envergadura = "200",
                Gluteos = "50",
                Coxa = "40",
                IMC ="",
            });
        }
        /// <summary>
        /// Metodo para calcular IMC
        /// </summary>
        /// <param name="altura">Altura do utilizador</param>
        /// <param name="peso">Peso do utilizador</param>
        /// <returns>IMC em string</returns>
        public static string CalculoIMC(string altura,string peso)
        {
            float n1 = float.Parse(altura);
            float n2 = float.Parse(peso);
            float imc = (n2 / (n1/100 * n1/100));
            return imc.ToString();
        }
        /// <summary>
        /// Metodo para calcular massa magra
        /// </summary>
        /// <param name="altura">Altura do utilizador</param>
        /// <param name="peso">Peso do utilizador</param>
        /// <returns>Massa Magra em string</returns>
        public static string CalculoMassaMagra(string altura,string peso)
        {
            float n1 = float.Parse(altura);
            float n2 = float.Parse(peso);
            float mg =n1-n1 + n2 - (n2 * 2/10);
            return mg.ToString();
        }

        /// <summary>
        /// Metodo para filtrar o primeiro utilizador que valida a condição
        /// </summary>
        /// <param name="nrprocesso">Nr de Processo do Utilizador</param>
        /// <param name="pass">Password do Utilizador</param>
        /// <returns>Retorna Utilizador</returns>
        public Utilizador UtilizadorLogin(string nrprocesso, string pass)
        {
            Utilizador utilizador = listaUtilizador.FirstOrDefault(r => r.NrProcessoEscola.Equals(nrprocesso) && r.Password.Equals(pass));
            return utilizador;
        }

        /// <summary>
        /// Metodo para guardar a lista de utilizadores em ficheiro txt
        /// </summary>
        /// <param name="user">Lista de Utilizadores</param>
        public static void GuardarListaUtilizador(List<Utilizador> user)
        {
            string save = JsonConvert.SerializeObject(user);
            File.WriteAllText(Environment.CurrentDirectory + @"\listautilizadores.txt", save);
        }

        /// <summary>
        /// Metodo para guardar a lista de utilizadores em ficheiro .txt
        /// </summary>
        public static void GuardarListaUtilizador()
        {
            string save = JsonConvert.SerializeObject(listaUtilizador);
            File.WriteAllText(Environment.CurrentDirectory + @"\listautilizadores.txt", save);
        }

        /// <summary>
        /// Metodo para filtrar a lista de utilizadores por apenas o seu numero de processo
        /// </summary>
        /// <returns>Retorna Numero de processo de todos os utilizadores na lista</returns>
        public static List<string> ListaUtilizador()
        {
            List<string> listausers = listaUtilizador.Select(r => r.NrProcessoEscola).ToList();
            return listausers;
        }

        /// <summary>
        /// Este método permite carregar o ficheiro listautilizadores.txt na lista de utilizadores
        /// </summary>
        public static void CarregarListaUtilizador()
        {
            if (File.Exists(Environment.CurrentDirectory + @"\listautilizadores.txt"))
                listaUtilizador = JsonConvert.DeserializeObject<List<Utilizador>>(File.ReadAllText(Environment.CurrentDirectory + @"\listautilizadores.txt"));
            else
                File.WriteAllText(Environment.CurrentDirectory + @"\listautilizadores.txt", "[]");
        }
    }
}
