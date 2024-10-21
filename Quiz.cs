using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Quiz
    {
       public string Spørgmål { get; }

       public string Svar_1 {  get; }
       public string Svar_2 {  get; }
       public string Svar_3 { get; }
       public  int Rigtigsvar {  get; }

        public Quiz(string spørgmål, string svar_1, string svar_2, string svar_3,int rigtigsvar) 
        {
            Spørgmål = spørgmål;
            Svar_1 = svar_1;
            Svar_2 = svar_2;
            Svar_3 = svar_3;
            Rigtigsvar = rigtigsvar;

        }



    }
}
