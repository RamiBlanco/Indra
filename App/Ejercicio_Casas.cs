using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationIndra.App
{
    public class Ejercicio_Casas
    {
        public Casas_Output Ejercicio1(Casas_Input consulta)
        {
            Casas_Output output = new Casas_Output();
            output.Entrada = consulta.lstCasas;
            output.dias = consulta.dias;

            List<int> result = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < consulta.dias; i++)
            {
                result = Result_Output(consulta.lstCasas);
                consulta.lstCasas = result;
            }            
            
            output.Salida = result;
            return output;
        }


        public List<int> Result_Output(List<int> lstCasas)
        {
            List<int> result_tmp = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 8; i++)
            {
                result_tmp[i] = Analize_Data(lstCasas, i);
            }
            return result_tmp;
        }


        public int Analize_Data(List<int> lstCasas, int i)
        {
            int x = 0;
            switch (i)
            {
                case 0:
                    x = lstCasas[i + 1] == 0 ? 0 : 1;
                    break;
                case 7:
                    x = lstCasas[i - 1] == 0 ? 0 : 1;
                    break;
                default:
                    x = lstCasas[i - 1] == lstCasas[i + 1] ? 0 : 1;
                    break;
            }
            return x;
        }
    }
}
