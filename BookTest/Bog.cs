using System;

namespace BookTest
{
    public class Bog
    {
        private string _titel;

        public string Titel
        {
            get { return _titel; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Titlen er for kort");
                }
                _titel = value;
            }
        }

        public string Forfatter { get; set; }

        private int _sidetal;

        public int Sidetal
        {
            get { return _sidetal; }
            set
            {
                if (value > 1000 || value < 10)
                {
                    throw new ArgumentOutOfRangeException("Sidetallet er for kort eller for langt");
                }
                _sidetal = value;
            }
        }

        private string _isbn;

        public string Isbn
        {
            get { return _isbn; }
            set
            {
                if (value.Length != 13)
                {
                    throw new ArgumentException("ISBN nummeret skal være på præcis 13 tegn");
                }
                _isbn = value;
            }
        }

        public Bog()
        {
            
        }

        public Bog(string forfatter, string titel, int sidetal, string isbn)
        {
            Forfatter = forfatter;
            _titel = titel;
            _sidetal = sidetal;
            _isbn = isbn;
        }
    }
}
