using System;

namespace Proyecto1_1127821_1049321
{
    class Program
{
    static void Main(string[] args)
    {
            bool registro_hecho = false;
            int calefaccion_opcion,opcion_menu_inicial, cantidad_cuartos=0, encender=0, apagar=0, maxima = 0, minima = 0, temperatura_momento=0, maxima_sistema=33, minima_sistema=11, suma_temperaturas=0, cantidadtemperaturas=0;
            string nombre_casa="", todas_temperaturas="",cuartos_iluminados="";
            string s_n; 
            
            double promedio=0;
             
        menu_inicial:
            Console.Clear();
            Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                    Menú Inicial                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                         1. Base de datos de la casa                                                  █");
            Console.WriteLine("█                                         2. Personalizar ventilación                                                  █");
            Console.WriteLine("█                                         3. Personalizar calefacción                                                  █");
            Console.WriteLine("█                                         4. Personalizar iluminación                                                  █");
            Console.WriteLine("█                                         5. Ver datos ingresados                                                      █");
            Console.WriteLine("█                                         6. Salir                                                                     █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                  Ingrese una opción (realizar registro primero)                                      █");
            Console.WriteLine("█                                                _______________                                                       █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            menu_prin_opcion:
            Console.SetCursorPosition(58, 17);
            try
            {
                opcion_menu_inicial = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(45, 18);
                Console.WriteLine("Debe ingresar un número");
                goto menu_prin_opcion;
            }
            if (opcion_menu_inicial > 6)
            {
                Console.SetCursorPosition(45, 18);
                Console.WriteLine("La opción debe ser entre 1 y 6.");
                goto menu_prin_opcion;
            }
            if (opcion_menu_inicial < 1)
            {
                Console.SetCursorPosition(45, 18);
                Console.WriteLine("La opción debe ser entre 1 y 6.");
                goto menu_prin_opcion;
            }

            if (registro_hecho== false & opcion_menu_inicial != 1 & opcion_menu_inicial != 6)
            {
                Console.SetCursorPosition(45, 18);
                Console.WriteLine("El registro se debe realizar antes de hacer modificaciones.");
                goto menu_prin_opcion;
            }

            if (opcion_menu_inicial == 1) { goto base_de_datos; }
            if (opcion_menu_inicial == 2) { goto personalizar_ventilacion; }
            if (opcion_menu_inicial == 3) { goto personalizar_calefaccion; }
            if (opcion_menu_inicial == 4) { goto personalizar_iluminacion; }
            if (opcion_menu_inicial == 5) { goto registro_de_datos; }
            if (opcion_menu_inicial == 6) { return; }
        base_de_datos:
            Console.Clear();
            Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                    Menú Inicial                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                         1. Nombre de la casa                                                         █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                         2. Cuartos de la casa                                                        █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                        Ingrese la opción que se le solicita                                          █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.SetCursorPosition(50, 10);
            nombre_casa = Convert.ToString(Console.ReadLine());
            cuartos:
            Console.SetCursorPosition(50, 12);
            try
            {
                cantidad_cuartos = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("Recuerde ingresar un número.             ");
                goto cuartos;
            }
            if (cantidad_cuartos < 1)
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("El número de cuartos debe ser al menos 1.");
                goto cuartos;
            }
            registro_hecho = true;
            Console.SetCursorPosition(35, 18);
            Console.WriteLine("Presione cualquier tecla para volver al inicio");
            Console.ReadKey();
            goto menu_inicial;


        personalizar_ventilacion:
            Console.Clear();
            Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                             Área de Ventilación                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                         1. Hora cuando se enciende                                                   █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                         2. Hora cuando se apaga                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                          La hora se guarda en formato 24.            █");
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            encendido_hora:

            Console.SetCursorPosition(50, 10);
            try
            {
                encender = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("Recuerde ingresar un número.             ");
                goto encendido_hora;
            }
            if (encender < 0 || encender > 23)
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("Recuerde ingresar la hora en formato 24.");
                goto encendido_hora;
            }
            apagado_hora:
            Console.SetCursorPosition(50, 12);
            try
            {
                apagar = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("Recuerde ingresar un número.             ");
                goto apagado_hora;
            }
            if (apagar < 0 || apagar> 23)
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("Recuerde ingresar la hora en formato 24.");
                goto apagado_hora;
            }

            Console.SetCursorPosition(35, 18);
            Console.WriteLine("Presione cualquier tecla para volver al inicio");
            Console.ReadKey();
            goto menu_inicial;




        personalizar_calefaccion:
            Console.Clear();
            Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                              Área de calefacción                                                     █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                         1. Temperatura máxima                                                        █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                         2. Temperatura mínima                                                        █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                         3. Temperatura actual                                                        █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                               Ingrese una opción                                                     █");
            Console.WriteLine("█                                                _______________                                                       █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                         4. Volver a inicio                                                           █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                 El termostato va desde 11° hasta 33°                 █");
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
        select_calefaccion:
            Console.SetCursorPosition(58, 18);
            try
            {
                calefaccion_opcion = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(45, 19);
                Console.WriteLine("Debe ingresar un número");
                goto select_calefaccion;
            }
            if (calefaccion_opcion > 4)
            {
                Console.SetCursorPosition(45, 19);
                Console.WriteLine("La opción debe ser entre 1 y 4.");
                goto select_calefaccion;
            }
            if (calefaccion_opcion < 1)
            {
                Console.SetCursorPosition(45, 19);
                Console.WriteLine("La opción debe ser entre 1 y 4.");
                goto select_calefaccion;
            }
            if (calefaccion_opcion == 4) { goto menu_inicial; }
            if (calefaccion_opcion == 1) { goto max; }
            if (calefaccion_opcion == 2) { goto min; }
            if (calefaccion_opcion == 3&maxima==0||minima==0) 
            {
                Console.SetCursorPosition(45, 19);
                Console.WriteLine("Debe ingresar opciones 1 y 2 antes.");
                goto select_calefaccion;
            }
            else
            { goto actual; }
            

        max:
            Console.SetCursorPosition(50, 10);
            try
            {
                maxima = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("Recuerde ingresar un número.                                        ");
                goto max;
            }
            if (maxima > maxima_sistema || maxima < minima_sistema + 1)
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("La temperatura máxima debe ser mayor a 12 y menor " + maxima_sistema);
                goto max;
            }
            goto select_calefaccion;
        min:
            Console.SetCursorPosition(50, 12);
            try
            {
                minima = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("Recuerde ingresar un número.                                                              ");
                goto min;
            }
            if (minima > maxima_sistema - 1 || minima < minima_sistema)
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("La temperatura mínima debe ser mayor a " + minima_sistema + " y menor a 32");
                goto min;
            }
            goto select_calefaccion;
        actual:
            Console.SetCursorPosition(50, 14);
            try
            {
                temperatura_momento = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("Recuerde ingresar un número.                                           ");
                goto actual;
            }
            if (temperatura_momento > maxima || temperatura_momento < minima)
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("La temperatura actual debe ser mayor a "+ minima + "y menor " + maxima);
                goto actual;
            }

            todas_temperaturas = todas_temperaturas + temperatura_momento + "°, ";
            suma_temperaturas = suma_temperaturas + temperatura_momento;
            cantidadtemperaturas = ++cantidadtemperaturas;
            promedio = suma_temperaturas / cantidadtemperaturas;
            goto select_calefaccion;

        personalizar_iluminacion:
            Console.Clear();
            Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                              Área de calefacción                                                     █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                          ¿Hay personas en este cuarto?                                               █");
            Console.WriteLine("█                                                  s = s  n = no                                                       █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                                                                      █");
            Console.WriteLine("█                                                                 Se preguntará personas por cuarto.                   █");
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            string[] r = new string[cantidad_cuartos];
            int c = 1;
            for (int i = 0; i < cantidad_cuartos; i++)
            {
            r_si_no:
                Console.SetCursorPosition(55, 13);
                Console.WriteLine("Cuarto no. "+c);
                Console.SetCursorPosition(55, 14);
                try
                {
                    s_n = Convert.ToString(Console.ReadLine());
                }
                catch
                {

                    Console.SetCursorPosition(40, 20);
                    Console.WriteLine("Debe ingresar solo un caracter. ");
                    goto r_si_no;

                }
                if (s_n!="s"& s_n != "n" & s_n != "S" & s_n != "N")
                {
                    Console.SetCursorPosition(40, 20);
                    Console.WriteLine("No ingresó una respuesta válida.");
                    goto r_si_no;
                }
                if (s_n == "s" || s_n == "S") 
                {    
                cuartos_iluminados = cuartos_iluminados  +"\t"+" Cuarto no. " +c +"\t" + "Luces encendidas" + "\n";
                }
                if (s_n == "n" || s_n == "N")
                {
                    cuartos_iluminados = cuartos_iluminados + "\t" + " Cuarto no. " + c + "\t" + "Luces apagadas" + "\n";
                }
                c++;

            }
            Console.Clear();
            Console.WriteLine("\n" + "\t" + "Reporte de iluminación cuartos:" +"\n"+"\n" + "\n" +cuartos_iluminados +"\n" + "\t" + "\t" + "Presione cualquier tecla para volver al menú principal");
            Console.ReadKey();
            goto menu_inicial;


        registro_de_datos:
            string on_off = "";
            DateTime hora = DateTime.Now;
            int ahora = hora.Hour;
            if (encender < 23 & apagar >= encender)
            {
                if (encender >= ahora& apagar > ahora)
                {
                    on_off = "Encendida";
                }
                else
                {
                    on_off = "Apagada";
                }
            }
            else
            {
                if (encender <= ahora& apagar< ahora)
                {
                    on_off = "Encendida";
                }
                else
                {
                    on_off= "Apagada";
                }
            }

            Console.Clear();
            Console.WriteLine("   Nombre de la casa: "+nombre_casa+"                                              "+hora+"                           ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                 Registro de actividades                                              ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("      Ventilación:                                                                                                    ");
            Console.WriteLine("      Hora de encendido: "+encender+"                        Hora de apagado: "+apagar+"                        Estado: "+on_off+"                  ");
            Console.WriteLine("      Calefacción:                                                                                                    ");
            Console.WriteLine("      Temperatura mínima: " + minima + "°                  Temperatura máxima: " + maxima + "°              Temperatura actual: " + temperatura_momento + "°                     ");
            Console.WriteLine("      Temperaturas ingresadas: "+todas_temperaturas+"                                                                                                                ");
            Console.WriteLine("      Promedio: "+promedio+"°                                                                                                                ");
            Console.WriteLine("      Iluminación:                                                                                                    ");
            Console.WriteLine("      Cantidad de cuartos:"+cantidad_cuartos+"                                                                        ");
            Console.WriteLine("      "+cuartos_iluminados+"                                                                                          ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                   Presione cualquier tecla para volver al menú principal             ");
            Console.WriteLine("                                                                                                                      ");
            Console.ReadKey();
            goto menu_inicial;
        }
}
}