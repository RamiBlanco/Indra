using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationIndra.Models;

namespace WebApplicationIndra.App
{
    public class Ejercicio_Camion
    {

        public List<int> Ejercicio2 (Camion_Input consulta)
        {
            int capacidad = consulta.tamanioCamion - 30;
            List<int> lstPaquetesSorted = new List<int> { };
            lstPaquetesSorted = Ordenar_Paquetes(consulta.lstPaquetes);
            List<int> response = Analize_Data(lstPaquetesSorted, capacidad);
            return response;

        }
        public List<int> Ordenar_Paquetes(List<int> lstPaquetes)
        {
            lstPaquetes.Sort((a, b) => b.CompareTo(a));
            return lstPaquetes;
        }

        public List<int> Analize_Data(List<int> lstPaquetes, int tamanioCamion)
        {
            for (int i = 0; i < lstPaquetes.Count; i++)
            {
                for (int j = 0; j < lstPaquetes.Count; j++)
                {
                    if (i == j)
                        continue;
                    else if ((lstPaquetes[i] + lstPaquetes[j]) == tamanioCamion)
                    {
                        List<int> Response = new List<int> { lstPaquetes[i], lstPaquetes[j] };
                        return Response;
                    }
                }
            }
            return new List<int> { 0 };
        }



    }
}
