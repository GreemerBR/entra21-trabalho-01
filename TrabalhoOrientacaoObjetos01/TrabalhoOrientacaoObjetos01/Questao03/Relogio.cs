using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Tests.Questao03
{
    public class Relogio
    {
        public DateTime Hora;

        public string Obter_Hora_Por_Extenso()
        {
            var parteteHora = Convert.ToString(Hora.Hour); // .ToString("HH:mm:ss")
            var posicaoHora1 = Convert.ToInt32(Console.ReadLine().Substring(0, 1)); //minuto: (3, 1) / segundo: (6, 1)
            var posicaoHora2 = Convert.ToInt32(Console.ReadLine().Substring(1, 1)); //minuto: (4, 1) / segundo: (7, 1)
            var horaExtenso = "";

            if (posicaoHora1 == 0)
            {
                horaExtenso = "Uma hora";
            }
            else if (posicaoHora1 == 0 && posicaoHora2 == 2)
            {
                horaExtenso = "Duas horas";
            }
            else if (posicaoHora1 == 0 && posicaoHora2 == 3)
            {
                horaExtenso = "Três horas";
            }
            else if (posicaoHora1 == 0 && posicaoHora2 == 4)
            {
                horaExtenso = "Quatro horas";
            }
            else if (posicaoHora1 == 0 && posicaoHora2 == 5)
            {
                horaExtenso = "Cinco horas";
            }
            else if (posicaoHora1 == 0 && posicaoHora2 == 6)
            {
                horaExtenso = "Seis horas";
            }
            else if (posicaoHora1 == 0 && posicaoHora2 == 7)
            {
                horaExtenso = "Sete horas";

            }
            else if (posicaoHora1 == 0 && posicaoHora2 == 8)
            {
                horaExtenso = "Oito horas";
            }
            else if (posicaoHora1 == 0 && posicaoHora2 == 9)
            {
                horaExtenso = "Nove horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 0)
            {
                horaExtenso = "Dez horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 2)
            {
                horaExtenso = "Onze horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 3)
            {
                horaExtenso = "Treze horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 4)
            {
                horaExtenso = "Quartoze horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 5)
            {
                horaExtenso = "Quinze horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 6)
            {
                horaExtenso = "Dezesseis horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 7)
            {
                horaExtenso = "Dezessete horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 8)
            {
                horaExtenso = "Dezoito horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 9)
            {
                horaExtenso = "Dezenove horas";
            }
            else if (posicaoHora1 == 2 && posicaoHora2 == 0)
            {
                horaExtenso = "Vinte horas";
            }
            else if (posicaoHora1 == 2 && posicaoHora2 == 1)
            {
                horaExtenso = "Vinte e uma Horas";
            }
            else if (posicaoHora1 == 2 && posicaoHora2 == 2)
            {
                horaExtenso = "Vinte e duas horas";
            }
            else if (posicaoHora1 == 2 && posicaoHora2 == 3)
            {
                horaExtenso = "Vinte e três horas";
            }
            return horaExtenso;
        }

        public void Obter_Minuto_Por_Extenso()
        {
            
        }

        public void Obter_Segundo_Por_Extenso()
        {

        }

        public void Obter_Hora_Completa_Por_Extenso()
        {


        }


    }
}
