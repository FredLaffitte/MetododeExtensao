using System;
using System.Collections.Generic;
using System.Text;

namespace MetododeExtensao
{
    static class MetodoExtendido

    {

        ///
        /// Método que trocara letras Maiusculas por minusculas
        ///
        ///
        ///

        public static String InverteCase(this string str)
        {
            //variavel para guardar o valor temporario
            string temp = "";
            //percorro a lista de caracteres no texto str
            foreach (char ch in str)
            {
                //realizo a inversão de maiuscula e minuscula
                if (Char.IsLower(ch))
                    temp += Char.ToUpper(ch);
                else
                    temp += Char.ToLower(ch);
            }
            //retorno
            return temp;
        }
    }

}