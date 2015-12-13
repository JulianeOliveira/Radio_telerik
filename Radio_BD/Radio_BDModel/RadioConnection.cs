using Radio_BDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_BDModel
{
    public class RadioConnection
    {
        public static string StringConexao =
            "Persist Security Info=False;server=localhost;database=radiocorredor;uid=root;pwd=juliane";

        private static RadioModel _instance = null;

        public static RadioModel Model
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RadioModel(StringConexao);
                }

                return _instance;
            }
        }
    }
}


