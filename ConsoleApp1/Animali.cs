using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animali
    {
        private string _name;
        private string _razza;
        private string _habitat;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Razza
        {
            get
            {
                return _razza;
            }
            set
            {
                _razza = value;
            }
        }
            
            public string Habitat
        {
            get
            {
                return _habitat;
            }
            set {
                _habitat = value;
            }
        }
    }
}

