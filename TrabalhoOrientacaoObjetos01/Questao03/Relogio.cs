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
        public string HoraInformada;
        public string MinutoInformado;

        public string Obter_Hora_Por_Extenso()
        {

            HoraInformada = Convert.ToString(Hora.ToString("HH:mm:ss")); // .ToString("HH:mm:ss")
            var posicaoHora1 = Convert.ToInt32(HoraInformada.Substring(0, 1)); //minuto: (3, 1) / segundo: (6, 1)
            var posicaoHora2 = Convert.ToInt32(HoraInformada.Substring(1, 1)); //minuto: (4, 1) / segundo: (7, 1)
            var horaExtenso = "";

            if (posicaoHora1 == 0 && posicaoHora2 == 0)
            {
                horaExtenso = "Zero horas";
            }
            else if (posicaoHora1 == 0 && posicaoHora2 == 1)
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
            else if (posicaoHora1 == 1 && posicaoHora2 == 1)
            {
                horaExtenso = "Onze horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 2)
            {
                horaExtenso = "Doze horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 3)
            {
                horaExtenso = "Treze horas";
            }
            else if (posicaoHora1 == 1 && posicaoHora2 == 4)
            {
                horaExtenso = "Quatorze horas";
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
                horaExtenso = "Vinte e uma horas";
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

        public string Obter_Minuto_Por_Extenso()
        {
            var minutoInformado = Convert.ToString(Hora.ToString("HH:mm:ss"));
            var posicaoMinuto1 = Convert.ToInt32(Console.ReadLine().Substring(3, 1));
            var posicaoMinuto2 = Convert.ToInt32(Console.ReadLine().Substring(4, 1));
            var minutoPorExtenso = "";
            if (posicaoMinuto1 == 0 && posicaoMinuto2 == 0)
            {
                minutoPorExtenso = "Zero minuto";
            }
            else if (posicaoMinuto1 == 0 && posicaoMinuto2 == 1)
            {
                minutoPorExtenso = "Um minuto";
            }
            else if (posicaoMinuto1 == 0 && posicaoMinuto2 == 2)
            {
                minutoPorExtenso = "Dois minutos";
            }
            else if (posicaoMinuto1 == 0 && posicaoMinuto2 == 3)
            {
                minutoPorExtenso = "Três minutos";
            }
            else if (posicaoMinuto1 == 0 && posicaoMinuto2 == 4)
            {
                minutoPorExtenso = "Quatro minutos";
            }
            else if (posicaoMinuto1 == 0 && posicaoMinuto2 == 5)
            {
                minutoPorExtenso = "Cinco minutos";
            }
            else if (posicaoMinuto1 == 0 && posicaoMinuto2 == 6)
            {
                minutoPorExtenso = "Seis minutos";
            }
            else if (posicaoMinuto1 == 0 && posicaoMinuto2 == 7)
            {
                minutoPorExtenso = "Sete minutos";

            }
            else if (posicaoMinuto1 == 0 && posicaoMinuto2 == 8)
            {
                minutoPorExtenso = "Oito minutos";
            }
            else if (posicaoMinuto1 == 0 && posicaoMinuto2 == 9)
            {
                minutoPorExtenso = "Nove minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 0)
            {
                minutoPorExtenso = "Dez minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 2)
            {
                minutoPorExtenso = "Onze minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 3)
            {
                minutoPorExtenso = "Treze minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 4)
            {
                minutoPorExtenso = "Quartoze minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 5)
            {
                minutoPorExtenso = "Quinze minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 6)
            {
                minutoPorExtenso = "Dezesseis minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 7)
            {
                minutoPorExtenso = "Dezessete minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 8)
            {
                minutoPorExtenso = "Dezoito minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 9)
            {
                minutoPorExtenso = "Dezenove minutos";
            }
            else if (posicaoMinuto1 == 2 && posicaoMinuto2 == 0)
            {
                minutoPorExtenso = "Vinte minutos";
            }
            else if (posicaoMinuto1 == 2 && posicaoMinuto2 == 1)
            {
                minutoPorExtenso = "Vinte e uma minutos";
            }
            else if (posicaoMinuto1 == 2 && posicaoMinuto2 == 2)
            {
                minutoPorExtenso = "Vinte e dois minutos";
            }
            else if (posicaoMinuto1 == 2 && posicaoMinuto2 == 3)
            {
                minutoPorExtenso = "Vinte e três minutos";
            }
            else if (posicaoMinuto1 == 2 && posicaoMinuto2 == 4)
            {
                minutoPorExtenso = "Vinte e quatro minutos";


            }
            else if (posicaoMinuto1 == 2 && posicaoMinuto2 == 5)
            {
                minutoPorExtenso = "Vinte e cinco minutos";
            }
            else if (posicaoMinuto1 == 2 && posicaoMinuto2 == 6)
            {
                minutoPorExtenso = "Vinte e seis minutos";
            }
            else if (posicaoMinuto1 == 2 && posicaoMinuto2 == 7)
            {
                minutoPorExtenso = "Vinte e sete minutos";

            }
            else if (posicaoMinuto1 == 2 && posicaoMinuto2 == 8)
            {
                minutoPorExtenso = "Vinte e oito minutos";
            }
            else if (posicaoMinuto1 == 2 && posicaoMinuto2 == 9)
            {
                minutoPorExtenso = "Vinte e nova minutos";
            }
            else if (posicaoMinuto1 == 3 && posicaoMinuto2 == 0)
            {
                minutoPorExtenso = "Trinta minutos";
            }
            else if (posicaoMinuto1 == 3 && posicaoMinuto2 == 1)
            {
                minutoPorExtenso = "Trinta e um minutos";
            }
            else if (posicaoMinuto1 == 3 && posicaoMinuto2 == 2)
            {
                minutoPorExtenso = "Trinta e dois minutos";
            }
            else if (posicaoMinuto1 == 3 && posicaoMinuto2 == 3)
            {
                minutoPorExtenso = "Trinta e três minutos";
            }
            else if (posicaoMinuto1 == 3 && posicaoMinuto2 == 4)
            {
                minutoPorExtenso = "Trinta e quatro minutos";

            }
            else if (posicaoMinuto1 == 3 && posicaoMinuto2 == 5)
            {
                minutoPorExtenso = "Trinta e cinco minutos";
            }
            else if (posicaoMinuto1 == 3 && posicaoMinuto2 == 6)
            {
                minutoPorExtenso = "Trinta e seis minutos";
            }
            else if (posicaoMinuto1 == 3 && posicaoMinuto2 == 7)
            {
                minutoPorExtenso = "Trinta e sete minutos";
            }
            else if (posicaoMinuto1 == 3 && posicaoMinuto2 == 8)
            {
                minutoPorExtenso = "Trinta e oito minutos";
            }
            else if (posicaoMinuto1 == 3 && posicaoMinuto2 == 9)
            {
                minutoPorExtenso = "Trinta e nove minutos";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 0)
            {
                minutoPorExtenso = "Quarenta minutos";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 1)
            {
                minutoPorExtenso = "Quarenta um minutos";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 2)
            {
                minutoPorExtenso = "Quanrenta e dois minutoss";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 3)
            {
                minutoPorExtenso = "Quarenta e três minutos";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 4)
            {
                minutoPorExtenso = "Quarenta e quatro minutos";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 5)
            {
                minutoPorExtenso = "Quarenta e cinco minutos";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 6)
            {
                minutoPorExtenso = "Quarenta e seis minutos";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 7)
            {
                minutoPorExtenso = "Quarenta e sete minutos";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 8)
            {
                minutoPorExtenso = "Quarenta e oito minutos";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 9)
            {
                minutoPorExtenso = "Quarenta e nove minutos";
            }
            else if (posicaoMinuto1 == 5 && posicaoMinuto2 == 0)
            {
                minutoPorExtenso = "Cinquenta minutos";

            }
            else if (posicaoMinuto1 == 5 && posicaoMinuto2 == 1)
            {
                minutoPorExtenso = "Cinquenta e um minutos";
            }
            else if (posicaoMinuto1 == 5 && posicaoMinuto2 == 2)
            {
                minutoPorExtenso = "Cinquenta e dois minutos";
            }
            else if (posicaoMinuto1 == 5 && posicaoMinuto2 == 3)
            {
                minutoPorExtenso = "Cinquenta e três minutos";

            }
            else if (posicaoMinuto1 == 5 && posicaoMinuto2 == 4)
            {
                minutoPorExtenso = "Cinquenta e quatro minutos";
            }
            else if (posicaoMinuto1 == 5 && posicaoMinuto2 == 5)
            {
                minutoPorExtenso = "Cinquenta e cinco minutos";
            }
            else if (posicaoMinuto1 == 5 && posicaoMinuto2 == 6)
            {
                minutoPorExtenso = "Cinquenta e seis minutos";
            }
            else if (posicaoMinuto1 == 5 && posicaoMinuto2 == 7)
            {
                minutoPorExtenso = "Cinquenta e sete minutos";
            }
            else if (posicaoMinuto1 == 5 && posicaoMinuto2 == 8)
            {
                minutoPorExtenso = "Cinquenta e oito minutos";
            }
            else if (posicaoMinuto1 == 5 && posicaoMinuto2 == 9)
            {
                minutoPorExtenso = "Cinquenta e nove minutos";
            }
            return minutoPorExtenso;

        }

        public void Obter_Segundo_Por_Extenso()
        {

        }

        public void Obter_Hora_Completa_Por_Extenso()
        {


        }


    }
}
