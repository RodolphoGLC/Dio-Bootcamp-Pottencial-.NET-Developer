// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Newtonsoft.Json;

// namespace ExemplosExplorando.Models
// {
//     public class VendaDescentralização //Cria uma Classe para o arquivo - mesmo nome
//     {
//         public int ID { get; set; }

//         [JsonProperty("Nome_Produto")] //Atributo - é usado quando o Arquivo enviado não respeita a convenção do C#
//         public string Produto { get; set; }
//         public decimal Preco { get; set; }
//         public DateTime DataVenda { get; set; }
//     }
// }