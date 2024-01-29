using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gruppo2
    {
        private string _name;
        private string _surname;
        private string _valutazione;

        public string Name
        { get { return _name; } set {  _name = value; } }
        public string Surname
        { get { return _surname; } set { _surname = value; } }
        public string Valutazione
        { get { return _valutazione; } set { _valutazione = value; } }  
    }
}
