using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.TrabalhoOrientacaoObjetos01.Questao03
{
    // Cristyan Alvir Alexandrino
    public class Relogio
    {
        public DateTime Hora;       

        public string ObterHoraPorExtenso()
        {

            var horaInformada = Hora.ToString("HH");
            var posicaoHora1 = Convert.ToInt32(horaInformada.Substring(0, 1)); 
            var posicaoHora2 = Convert.ToInt32(horaInformada.Substring(1, 1)); 
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

        public string ObterMinutoPorExtenso()
        {
            var minutoInformado = Hora.ToString("mm");
            var posicaoMinuto1 = Convert.ToInt32(minutoInformado.Substring(0, 1));
            var posicaoMinuto2 = Convert.ToInt32(minutoInformado.Substring(1, 1));
            var minutoPorExtenso = "";
            if (posicaoMinuto1 == 0 && posicaoMinuto2 == 0)
            {
                minutoPorExtenso = "Zero minutos";
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
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 1)
            {
                minutoPorExtenso = "Onze minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 2)
            {
                minutoPorExtenso = "Doze minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 3)
            {
                minutoPorExtenso = "Treze minutos";
            }
            else if (posicaoMinuto1 == 1 && posicaoMinuto2 == 4)
            {
                minutoPorExtenso = "Quatorze minutos";
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
                minutoPorExtenso = "Vinte e um minutos";
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
                minutoPorExtenso = "Vinte e nove minutos";
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
                minutoPorExtenso = "Quarenta e um minutos";
            }
            else if (posicaoMinuto1 == 4 && posicaoMinuto2 == 2)
            {
                minutoPorExtenso = "Quarenta e dois minutos";
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

        public string ObterSegundoPorExtenso()
        {

            var segundoInfomardo = Hora.ToString("ss");
            var posicaoSegundo1 = Convert.ToUInt32(segundoInfomardo.Substring(0, 1));
            var posicaoSegundo2 = Convert.ToUInt32(segundoInfomardo.Substring(1, 1));
            var segundoPorExtenso = "";

            if (posicaoSegundo1 == 0 && posicaoSegundo2 == 0)
            {
                segundoPorExtenso = "Zero segundos";                
            }
            else if (posicaoSegundo1 == 0 && posicaoSegundo2 == 1)
            {
                segundoPorExtenso = "Um segundo";
            }
            else if (posicaoSegundo1 == 0 && posicaoSegundo2 == 2)
            {
                segundoPorExtenso = "Dois segundos";
            }
            else if (posicaoSegundo1 == 0 && posicaoSegundo2 == 3)
            {
                segundoPorExtenso = "Três segundos";
            }
            else if (posicaoSegundo1 == 0 && posicaoSegundo2 == 4)
            {
                segundoPorExtenso = "Quatro segundos";
            }
            else if (posicaoSegundo1 == 0 && posicaoSegundo2 == 5)
            {
                segundoPorExtenso = "Cinco segundos";
            }
            else if (posicaoSegundo1 == 0 && posicaoSegundo2 == 6)
            {
                segundoPorExtenso = "Seis segundos";
            }
            else if (posicaoSegundo1 == 0 && posicaoSegundo2 == 7)
            {
                segundoPorExtenso = "Sete segundos";
            }
            else if (posicaoSegundo1 == 0 && posicaoSegundo2 == 8)
            {
                segundoPorExtenso = "Oito segundos";
            }
            else if (posicaoSegundo1 == 0 && posicaoSegundo2 == 9)
            {
                segundoPorExtenso = "Nove segundos";
            }
            else if (posicaoSegundo1 == 1 && posicaoSegundo2 == 0)
            {
                segundoPorExtenso = "Dez segundos";
            }
            else if (posicaoSegundo1 == 1 && posicaoSegundo2 == 1)
            {
                segundoPorExtenso = "Onze segundos";
            }
            else if (posicaoSegundo1 == 1 && posicaoSegundo2 == 2)
            {
                segundoPorExtenso = "Doze segundos";
            }
            else if (posicaoSegundo1 == 1 && posicaoSegundo2 == 3)
            {
                segundoPorExtenso = "Treze segundos";
            }
            else if (posicaoSegundo1 == 1 && posicaoSegundo2 == 4)
            {
                segundoPorExtenso = "Quatorze segundos";
            }
            else if (posicaoSegundo1 == 1 && posicaoSegundo2 == 5)
            {
                segundoPorExtenso = "Quinze segundos";
            }
            else if (posicaoSegundo1 == 1 && posicaoSegundo2 == 6)
            {
                segundoPorExtenso = "Dezesseis segundos";
            }
            else if (posicaoSegundo1 == 1 && posicaoSegundo2 == 7)
            {
                segundoPorExtenso = "Dezessete segundos";
            }
            else if (posicaoSegundo1 == 1 && posicaoSegundo2 == 8)
            {
                segundoPorExtenso = "Dezoito segundos";
            }
            else if (posicaoSegundo1 == 1 && posicaoSegundo2 == 9)
            {
                segundoPorExtenso = "Dezenove segundos";
            }
            else if (posicaoSegundo1 == 2 && posicaoSegundo2 == 0)
            {
                segundoPorExtenso = "Vinte segundos";
            }
            else if (posicaoSegundo1 == 2 && posicaoSegundo2 == 1)
            {
                segundoPorExtenso = "Vinte e um segundos";
            }
            else if (posicaoSegundo1 == 2 && posicaoSegundo2 == 2)
            {
                segundoPorExtenso = "Vinte e dois segundos";
            }
            else if (posicaoSegundo1 == 2 && posicaoSegundo2 == 3)
            {
                segundoPorExtenso = "Vinte e três segundos";
            }
            else if (posicaoSegundo1 == 2 && posicaoSegundo2 == 4)
            {
                segundoPorExtenso = "Vinte e quatro segundos";
            }
            else if (posicaoSegundo1 == 2 && posicaoSegundo2 == 5)
            {
                segundoPorExtenso = "Vinte e cinco segundos";
            }
            else if (posicaoSegundo1 == 2 && posicaoSegundo2 == 6)
            {
                segundoPorExtenso = "Vinte e seis segundos";
            }
            else if (posicaoSegundo1 == 2 && posicaoSegundo2 == 7)
            {
                segundoPorExtenso = "Vinte e sete segundos";
            }
            else if (posicaoSegundo1 == 2 && posicaoSegundo2 == 8)
            {
                segundoPorExtenso = "Vinte e oito segundos";
            }
            else if (posicaoSegundo1 == 2 && posicaoSegundo2 == 9)
            {
                segundoPorExtenso = "Vinte e nove segundos";
            }
            else if (posicaoSegundo1 == 3 && posicaoSegundo2 == 0)
            {
                segundoPorExtenso = "Trinta segundos";
            }
            else if (posicaoSegundo1 == 3 && posicaoSegundo2 == 1)
            {
                segundoPorExtenso = "Trinta e um segundos";
            }
            else if (posicaoSegundo1 == 3 && posicaoSegundo2 == 2)
            {
                segundoPorExtenso = "Trinta e dois segundos";
            }
            else if (posicaoSegundo1 == 3 && posicaoSegundo2 == 3)
            {
                segundoPorExtenso = "Trinta e três segundos";
            }
            else if (posicaoSegundo1 == 3 && posicaoSegundo2 == 4)
            {
                segundoPorExtenso = "Trinta e quatro segundos";
            }
            else if (posicaoSegundo1 == 3 && posicaoSegundo2 == 5)
            {
                segundoPorExtenso = "Trinta e cinco segundos";
            }
            else if (posicaoSegundo1 == 3 && posicaoSegundo2 == 6)
            {
                segundoPorExtenso = "Trinta e seis segundos";
            }
            else if (posicaoSegundo1 == 3 && posicaoSegundo2 == 7)
            {
                segundoPorExtenso = "Trinta e sete segundos";
            }
            else if (posicaoSegundo1 == 3 && posicaoSegundo2 == 8)
            {
                segundoPorExtenso = "Trinta e oito segundos";
            }
            else if (posicaoSegundo1 == 3 && posicaoSegundo2 == 9)
            {
                segundoPorExtenso = "Trinta e nove segundos";
            }
            else if (posicaoSegundo1 == 4 && posicaoSegundo2 == 0)
            {
                segundoPorExtenso = "Quarenta segundos";
            }
            else if (posicaoSegundo1 == 4 && posicaoSegundo2 == 1)
            {
                segundoPorExtenso = "Quarenta e um segundos";
            }
            else if (posicaoSegundo1 == 4 && posicaoSegundo2 == 2)
            {
                segundoPorExtenso = "Quarenta e dois segundos";
            }
            else if (posicaoSegundo1 == 4 && posicaoSegundo2 == 3)
            {
                segundoPorExtenso = "Quarenta e três segundos";
            }
            else if (posicaoSegundo1 == 4 && posicaoSegundo2 == 4)
            {
                segundoPorExtenso = "Quarenta e quatro segundos";
            }
            else if (posicaoSegundo1 == 4 && posicaoSegundo2 == 5)
            {
                segundoPorExtenso = "Quarenta e cinco segundos";
            }
            else if (posicaoSegundo1 == 4 && posicaoSegundo2 == 6)
            {
                segundoPorExtenso = "Quarenta e seis segundos";
            }
            else if (posicaoSegundo1 == 4 && posicaoSegundo2 == 7)
            {
                segundoPorExtenso = "Quarenta e sete segundos";
            }
            else if (posicaoSegundo1 == 4 && posicaoSegundo2 == 8)
            {
                segundoPorExtenso = "Quarenta e oito segundos";
            }
            else if (posicaoSegundo1 == 4 && posicaoSegundo2 == 9)
            {
                segundoPorExtenso = "Quarenta e nove segundos";
            }
            else if (posicaoSegundo1 == 5 && posicaoSegundo2 == 0)
            {
                segundoPorExtenso = "Cinquenta segundos";
            }
            else if (posicaoSegundo1 == 5 && posicaoSegundo2 == 1)
            {
                segundoPorExtenso = "Cinquenta e um segundos";
            }
            else if (posicaoSegundo1 == 5 && posicaoSegundo2 == 2)
            {
                segundoPorExtenso = "Cinquenta e dois segundos";
            }
            else if (posicaoSegundo1 == 5 && posicaoSegundo2 == 3)
            {
                segundoPorExtenso = "Cinquenta e três segundos";
            }
            else if (posicaoSegundo1 == 5 && posicaoSegundo2 == 4)
            {
                segundoPorExtenso = "Cinquenta e quatro segundos";
            }
            else if (posicaoSegundo1 == 5 && posicaoSegundo2 == 5)
            {
                segundoPorExtenso = "Cinquenta e cinco segundos";
            }
            else if (posicaoSegundo1 == 5 && posicaoSegundo2 == 6)
            {
                segundoPorExtenso = "Cinquenta e seis segundos";
            }
            else if (posicaoSegundo1 == 5 && posicaoSegundo2 == 7)
            {
                segundoPorExtenso = "Cinquenta e sete segundos";
            }
            else if (posicaoSegundo1 == 5 && posicaoSegundo2 == 8)
            {
                segundoPorExtenso = "Cinquenta e oito segundos";
            }
            else if (posicaoSegundo1 == 5 && posicaoSegundo2 == 9)
            {
                segundoPorExtenso = "Cinquenta e nove segundos";
            }
            return segundoPorExtenso;
        }

        public string ObterHoraCompletaPorExtenso()
        {
            var hora = ObterHoraPorExtenso();
            var minuto = ObterMinutoPorExtenso();
            var segundo = ObterSegundoPorExtenso();

            var horaCompletaPorExtenso = hora + " e " + minuto + " e " + segundo;

            return horaCompletaPorExtenso;
        }
    }
}
