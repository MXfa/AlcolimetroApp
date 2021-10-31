using System.Reflection.Metadata;
using System;

namespace AlcoholimetroSSP.Domain
{
    public class CalAlcoholemia: IopeSegPub
    {
        private string _bebida;
        private double _cantidad;
        private double _peso;
        private double _resultado;

        public double calcular(string bebida, double cantidad, double peso)
        {
            _bebida = bebida;
            _cantidad = cantidad;
            _peso = peso;
            double gradoEth=0;
            double Eth_consumido= 0.0;
            double Eth_en_sangre_persona=0.0;
            double Factor_Eth=0.15;
            double masa=0.0;
            double dencidadEth= 0.789;
            double FactorvolumenSangre=0.08;
            double volumen_sangre_Persona=0.0;
            double Alcoholemia=0.0;

            switch (bebida)
            {
                case "CERVEZA":
                gradoEth = 5;
                break;
                case "VINO":
                gradoEth = 12;
                break;
                case "VERMU":
                gradoEth = 17;
                break;
                case "LICOR":
                gradoEth = 23;
                break;

                case "BRANDY":
                case "COMBINADO":
                gradoEth = 38;
                break;

            }

            // PASO 1 CALCULAR CONSUMO DE ALCOHOL
            Eth_consumido = (gradoEth / 100) * _cantidad;
            
                //2.- Calcular cantidad de alcohol que pasa directo a la sangre
             Eth_en_sangre_persona=(Factor_Eth*Eth_consumido);
                
                //3.- calcular la masa
            masa= dencidadEth * Eth_en_sangre_persona;
                // 4.- calcular volumen de la sangre de la persona-peso
                
             volumen_sangre_Persona=FactorvolumenSangre*_peso;

                //calcular el volumen de alcohol en la sangre
             Alcoholemia= masa/volumen_sangre_Persona;
           
            return Alcoholemia;

        }



    }
}