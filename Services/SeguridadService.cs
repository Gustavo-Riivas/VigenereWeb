using System.Text;

namespace VigenereWeb.Services
{

    public class SeguridadService : ISeguridadService<string>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, string clave)
        {
            StringBuilder msjDesEnc = new StringBuilder();
            /* 
            foreach (var letra in Mensaje)
            {
                if (char.IsLetter(letra))
                {
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraDesEnc = (posLetra - clave) % ABECEDARIO.Length;
                    /// Esto es lo mismo que un if(posLetraDesEnc < 0){posLetraDesEnc += ABECEDARIO.Length} else {posLetraDesEnc}
                    posLetraDesEnc = posLetraDesEnc < 0 ? posLetraDesEnc = ABECEDARIO.Length + posLetraDesEnc : posLetraDesEnc;
                    var letraDesEnc = ABECEDARIO[posLetraDesEnc];
                    if (char.IsUpper(letra))
                    {
                        msjDesEnc.Append(letraDesEnc);
                    }
                    else
                    {
                        msjDesEnc.Append(char.ToLower(letraDesEnc));
                    }
                }
                else
                {
                    msjDesEnc.Append(letra);
                }

            }*/
            return msjDesEnc.ToString();
        }



        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
            StringBuilder msjEncriptado = new StringBuilder();
/* 
            foreach (var letra in Mensaje)
            {
                if (char.IsLetter(letra))
                {
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraEnc = (posLetra + clave) % ABECEDARIO.Length;
                    var letrEnc = ABECEDARIO[posLetraEnc];
                    if (char.IsUpper(letra))
                    {
                        msjEncriptado.Append(letrEnc);
                    }
                    else
                    {
                        msjEncriptado.Append(char.ToLower(letrEnc));
                    }


                }
                else
                {
                    msjEncriptado.Append(letra);
                }
            }*/
            return msjEncriptado.ToString();
        }
    }


}