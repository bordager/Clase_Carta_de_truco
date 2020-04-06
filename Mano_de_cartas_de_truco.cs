using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Mano_de_cartas_de_truco
    {
        
        string numerodecarta1 = "";
        string palodecarta1 = "";
        string numerodecarta2 = "";
        string palodecarta2 = "";
        string numerodecarta3 = "";
        string palodecarta3 = "";
        bool envido = false;
        bool envido1 = false;
        bool envido2 = false;
        bool envido3 = false;
        bool truco = false;

     
        public bool repartirmano(string respuesta)
        {
            if (respuesta == "Y" || respuesta == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void setnumerodecarta()
        {
            var random = new Random();
            var value = random.Next(1, 12);

            do
            {
                value = random.Next(1, 12);
                numerodecarta1 = value.ToString();
            } while (numerodecarta1 == "8" || numerodecarta1 == "9");

            do 
            { 
            value = random.Next(1, 12);
            numerodecarta2 = value.ToString();
            } while (numerodecarta2 == "8" || numerodecarta2 == "9");

            do
            {
             value = random.Next(1, 12);
            numerodecarta3 = value.ToString();
            } while (numerodecarta3 == "8" || numerodecarta3 == "9");
         
        }

        public void setpalodecarta()
        {
            var random = new Random();
            var value = random.Next(1, 4);
            if (value == 1)
            {
                palodecarta1 = "Basto";
            }
            if (value == 2)
            {
                palodecarta1 = "Oro";
            }
            if (value == 3)
            {
                palodecarta1 = "Copa";
            }
            if (value == 4)
            {
                palodecarta1 = "Espadas";
            }

            value = random.Next(1, 4);
            if (value == 1)
            {
                palodecarta2 = "Basto";
            }
            if (value == 2)
            {
                palodecarta2 = "Oro";
            }
            if (value == 3)
            {
                palodecarta2 = "Copa";
            }
            if (value == 4)
            {
                palodecarta2 = "Espadas";
            }

            value = random.Next(1, 4);
            if (value == 1)
            {
                palodecarta3 = "Basto";
            }
            if (value == 2)
            {
                palodecarta3 = "Oro";
            }
            if (value == 3)
            {
                palodecarta3 = "Copa";
            }
            if (value == 4)
            {
                palodecarta3 = "Espadas";
            }
            value = random.Next(1, 4);
        }

        public string getcarta()
        {
            if (numerodecarta1 == "")
            {
                return "Jugamos la proxima";
           
            }
            else
            {
                return "Tenes un " + numerodecarta1 + " de " + palodecarta1 + " , un " + numerodecarta2 + " de "
                    + palodecarta2 + " y un " + numerodecarta3 + " de " + palodecarta3;
            }
        }

        public void tengoenvido()
        {
            if (numerodecarta1 != "")
            {
                if (palodecarta1 == palodecarta2 && int.Parse(numerodecarta1) < 10 && int.Parse(numerodecarta2) < 10)
                {
                    envido = true;
                    envido1 = true;
                }
                if (palodecarta1 == palodecarta3 && int.Parse(numerodecarta1) < 10 && int.Parse(numerodecarta3) < 10)
                {
                    envido = true;
                    envido2 = true;
                }
                if (palodecarta2 == palodecarta3 && int.Parse(numerodecarta3) < 10 && int.Parse(numerodecarta2) < 10)
                {
                    envido = true;
                    envido3 = true;
                }
            }
        }
        public string cantarenvido(string respuesta)
        {
            if (envido == true)
            {
                if (respuesta == "y" || respuesta == "Y")
                {
                    if (envido1 == true)
                    {
                        int result = int.Parse(numerodecarta1) + int.Parse(numerodecarta2) + 20;
                        return "Tengo " + (result).ToString() + " de mano ";
                    }
                    else
                    {
                        if (envido2 == true)
                        {
                            int result = int.Parse(numerodecarta1) + int.Parse(numerodecarta3) + 20;
                            return "Tengo " + (result).ToString() + " de mano ";
                        }
                        else
                        {
                            if (envido3 == true)
                            {
                                int result = int.Parse(numerodecarta2) + int.Parse(numerodecarta3) + 20;
                                return "Tengo " + (result).ToString() + " de mano ";
                            }
                            else
                            {
                                return "No Tenes Envido";
                            }
                        }
                    }


                }
                else
                {
                    return "No Cantaste Envido";
                }
            }
            else
            {
                return "No tenes Envido";
             }
            
        }

        public void tengotruco ()
        {
            if (
                (numerodecarta1 == "1" && palodecarta1 == "Espadas") ||
                (numerodecarta1 == "1" && palodecarta1 == "Basto") ||
                (numerodecarta1 == "7" && palodecarta1 == "Espada") ||
                (numerodecarta1 == "7" && palodecarta1 == "Oro") ||
                (numerodecarta2 == "1" && palodecarta2 == "Espadas") ||
                (numerodecarta2 == "1" && palodecarta2 == "Basto") ||
                (numerodecarta2 == "7" && palodecarta2 == "Espada") ||
                (numerodecarta2 == "7" && palodecarta2 == "Oro") ||
                (numerodecarta3 == "1" && palodecarta3 == "Espadas") ||
                (numerodecarta3 == "1" && palodecarta3 == "Basto") ||
                (numerodecarta3 == "7" && palodecarta3 == "Espada") ||
                (numerodecarta3 == "7" && palodecarta3 == "Oro")
                )
            {
                truco = true;
            }
            
            
            
        }

        public string cantartruco (string respuesta)
        {
            if (truco == true)
            {
                if (respuesta == "y" || respuesta == "Y")
                {
                    if (
                        (numerodecarta1 == "1" && palodecarta1 == "Espadas") ||
                        (numerodecarta2 == "1" && palodecarta2 == "Espadas") ||
                        (numerodecarta3 == "1" && palodecarta3 == "Espadas")
                        )
                    {
                        return "Tu mejor carta es el 1 de Espadas";
                    }
                    else
                    {
                        if (
                            (numerodecarta1 == "1" && palodecarta1 == "Basto") ||
                            (numerodecarta2 == "1" && palodecarta2 == "Basto") ||
                            (numerodecarta3 == "1" && palodecarta3 == "Basto")
                            )
                        {
                            return "Tu mejor carta es el 1 de Basto";
                        }
                        else
                        {
                            if (
                                (numerodecarta1 == "7" && palodecarta1 == "Espadas") ||
                                (numerodecarta2 == "7" && palodecarta2 == "Espadas") ||
                                (numerodecarta3 == "7" && palodecarta3 == "Espadas")
                                )
                            {
                                return "Tu mejor carta es el 7 de Espadas";
                            }
                            else
                            {
                                if (
                                    (numerodecarta1 == "7" && palodecarta1 == "Oro") ||
                                    (numerodecarta2 == "7" && palodecarta2 == "Oro") ||
                                    (numerodecarta3 == "7" && palodecarta3 == "Oro")
                                    )
                                {
                                    return "Tu mejor carta es el 7 de Oro";
                                }
                                else
                                {
                                    return "No tenes Truco";
                                }
                            }
                        }
                    }

                }
                else
                {
                    return "No Cantaste Truco";
                }
            }
            else
            {
                return "No tenes Truco";
            }
        }
    }
}
