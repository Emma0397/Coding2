using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Coding2
{
    internal class Espressione
    {
        private string esp1 = "(ciao)";
        private string esp2 = "[ciao]";
        private string esp3 = "[a-oA-O]";

        private bool Match1(Alunno alunno)
        {
            bool ris = false;
            Match result = Regex.Match(alunno.cognome, esp1);
            if (result.Success)
            {
                ris = true;
            }
            return ris;
        }
        private bool Match2(Alunno alunno)
        {
            bool ris = false;
            Match result = Regex.Match(alunno.cognome, esp2);
            if (result.Success)
            {
                ris = true;
            }
            return ris;
        }
        private bool Match3(Alunno alunno)
        {
            bool ris = false;
            Match result = Regex.Match(alunno.cognome, esp3);
            if (result.Success)
            {
                ris = true;
            }
            return ris;
        }
    }
}
