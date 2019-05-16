using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Matematica.ViewModels
{
    public class AboutViewModel
    {
        public Decimal? InputSuma1 { set; get; }
        public Decimal? InputSuma2 { set; get; }
        public Decimal? InputResta1 { set; get; }
        public Decimal? InputResta2 { set; get; }
        public Decimal? InputMultiplicacion1 { set; get; }
        public Decimal? InputMultiplicacion2 { set; get; }
        public Decimal? InputDivision1 { set; get; }
        public Decimal? InputDivision2 { set; get; }


        public Decimal? ResultSuma { set; get; }
        public Decimal? ResultResta { set; get; }
        public Decimal? ResultMultiplicacion { set; get; }
        public Decimal? ResultDivision { set; get; }

        public void Fill(Decimal? input1, Decimal? input2, Decimal? resultado, String tipo) {
            switch (tipo) {
                case "S":
                    InputSuma1 = input1;
                    InputSuma2 = input2;
                    ResultSuma = resultado;
                    break;
                case "R":
                    InputResta1 = input1;
                    InputResta2 = input2;
                    ResultResta = resultado;
                    break;
                case "M":
                    InputMultiplicacion1 = input1;
                    InputMultiplicacion2 = input2;
                    ResultMultiplicacion = resultado;
                    break;
                case "D":
                    InputDivision1 = input1;
                    InputDivision2 = input2;
                    ResultDivision = resultado;
                    break;
            }
        }
    }
}