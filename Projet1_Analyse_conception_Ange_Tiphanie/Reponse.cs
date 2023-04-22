using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_Analyse_conception_Ange_Tiphanie
{
    public class Reponse
    {
        public ReponseCode Code { get; set; }
        public string Message { get; set; }
        public object? Data { get; set; }

        public Reponse(ReponseCode code, string message, object? data = null)
        {
            Code = code;
            Message = message;  
            Data = data;    
        }
    }

    public enum ReponseCode
    {
        Erreur = 0,
        Succes
    }
}
