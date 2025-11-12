using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificador_Titulo_Eleitor
{
    internal class Verifica_titulo
    {

    public static class Verificar_eleitor
        {
            public static Boolean Verificar(string titulo)
            {
                int[] codigosEstados = new int[]
                {
                    1,  2,  3,  4,  5,  6,  7,
                    8,  9, 10, 11, 12, 13, 14,
                    15, 16, 17, 18, 19, 20, 21,
                    22, 23, 24, 25, 26, 27, 28
                };

                // Lista de UFs correspondentes aos códigos acima
                /*string[] nomesEstados = new string[]
                {
                    "SP", "MG", "RJ", "RS", "BA", "PR", "CE",
                    "PE", "SC", "GO", "MA", "PB", "PA", "ES",
                    "PI", "RN", "AL", "MT", "MS", "DF", "SE",
                    "AM", "RO", "AC", "AP", "RR", "TO", "ZZ" // ZZ = Exterior
                };
                string nomeEst;*/
                int Soma = 0;
                int Resto = 0;
                titulo = titulo.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "").Trim();
                if (titulo.Length != 12)
                    for (int i = 0; i < 13 - titulo.Length; i++)
                    {
                        titulo = titulo.Insert(i, "0");
                    }
                if ((titulo.Substring(1, 1) == "0") && (titulo.Substring(11, 1) == "1" || titulo.Substring(11, 1) == "2"))
                {
                    StringBuilder sb = new StringBuilder(titulo);
                    sb[1] = '1';
                    titulo = sb.ToString();
                }
                for (int i = 0; i < 9; i++)
                {
                    Soma += (int.Parse(titulo.Substring(i, 1)) * (i + 2));
                }
                Resto = Soma % 11;
                if (Resto == 0) {
                    Soma = 0;
                    for (int j = 9; j < 12; j++)
                    {
                        Soma += (int.Parse(titulo.Substring(j, 1)) * (j - 2));
                    }
                    Resto = Soma % 11;
                    if (codigosEstados.Contains(Resto))
                    {
                        return true;
                    }
                }
                return false;


            }
    }

}
}
