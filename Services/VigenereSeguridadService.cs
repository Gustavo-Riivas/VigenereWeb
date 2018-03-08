using System.Text;

namespace VigenereWeb.Services
{

    public class VigenereSeguridadService : ISeguridadService<string>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        int yolo=0;
            int g=0;
            
            

        ///  Aquí deben hacer la parte del código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, string clave)
        {
            clave=clave.ToUpper();
            /// sirve para construir una cadena de manera dinamica
            StringBuilder msjDesEnc = new StringBuilder();
             
            foreach (var letra in Mensaje)
            {
                if (char.IsLetter(letra))
                {
                    if(g>=clave.Length){
                        g=0;
                    }
                    for(int i=0;i<ABECEDARIO.Length;i++){
                        if(clave[g]==ABECEDARIO[i]){
                        yolo=i;
                        }
                    }
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraDesEnc = (posLetra - yolo) % ABECEDARIO.Length;
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
                    g++;
                }
                else
                {
                    msjDesEnc.Append(letra);
                }
        }return msjDesEnc.ToString();
        }
        //  Aquí deben hacer la parte del código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
            StringBuilder msjEncriptado = new StringBuilder();
            yolo=0;
            g=0;
            clave=clave.ToUpper();
            foreach (var letra in Mensaje)
            {
                if (char.IsLetter(letra))
                {
                    if(g>=clave.Length){
                        g=0;
                    }
                    for(int i=0;i<ABECEDARIO.Length;i++){
                        if(clave[g]==ABECEDARIO[i]){
                            yolo=i;
                        }
                    }
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraEnc = (posLetra + yolo) % ABECEDARIO.Length;
                    var letrEnc = ABECEDARIO[posLetraEnc];
                    if (char.IsUpper(letra))
                    {
                        msjEncriptado.Append(letrEnc);
                    }
                    else
                    {
                        msjEncriptado.Append(char.ToLower(letrEnc));
                    }
                    g++;

                }
                else
                {
                    msjEncriptado.Append(letra);
                }
           
        }
         return msjEncriptado.ToString();
    }
}
}