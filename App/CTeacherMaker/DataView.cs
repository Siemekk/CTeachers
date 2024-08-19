using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTeacherMaker
{
    public class DataView
    {
        private bool _active;
        private string _talent;
        private int _max;
        private int _multipler;

        public bool active
        {
            get { return _active; }
            set { _active = value; }
        }
        public string talent
        {
            get { return _talent; }
            set { _talent = value; }
        }
        public int max
        {
            get
            {
                if (_talent == "Br. Jednor."
                || _talent == "Br. Dwurecz."
                || _talent == "Łuk"
                || _talent == "Kusza")
                {
                    if (_max < 5)
                        return 5;
                    else if (_max > 100)
                        return 100;
                    else
                        return _max;
                }
                return _max;
            }
            set { _max = value; }
        }
        public int multipler
        {
            get { return _multipler; }
            set { _multipler = value; }
        }


        public DataView()
        {
            _talent = "";
        }

        public DataView(bool _active, string _talent, int _max, int _multipler)
        {
            this.active = _active;
            this._talent = _talent;
            this._max = _max;
            this._multipler = _multipler;
        }
    } 

}
