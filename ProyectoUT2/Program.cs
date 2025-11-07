//Proyecto UT2 - Mario Furlan
using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace DartsForum
{
    class Program
    {
        static void Main(string[] args) //Punto de inicio
        {
            Init();
        }

        //Funciones

        static void MenuPrincipal() //Función que genera la estructura del menú principal
        {
            Console.WriteLine("----- DartsForum -----");
            Console.WriteLine("--- Menú Principal ---");
            //Opciones comunes a todos los usuarios
            Console.WriteLine("1. Sobre nosotros");
            Console.WriteLine("2. Iniciar sesión");
            Console.WriteLine("3. Crear perfil");
            Console.WriteLine("4. Ver productos");
            Console.WriteLine("5. ¿Dónde jugar?");
            Console.WriteLine("6. Eventos próximos");
            //Opciones de admin
            Console.WriteLine("7. Ver perfiles");
            Console.WriteLine("8. Ver pedidos");
            //Salida
            Console.WriteLine("9. Salir");
        }

        static void AboutUs()
        {
            //POR ESCRIBIR
        }
        static void Login()
        {
            Console.WriteLine("--- Inicio de sesión ---");
            Console.WriteLine("Nombre de usuario: ");
            string? userInicioSesion = Console.ReadLine();
            Console.WriteLine("Contraseña: ");
            string? passInicioSesion = Console.ReadLine();
            Console.WriteLine("Bienvenido, " + userInicioSesion);
        }
        static void CreateUser()
        {
            Console.WriteLine("--- Crear perfil ---");
            Console.WriteLine("Nombre completo: ");
            string? nombreCompleto = Console.ReadLine();
            Console.WriteLine("Ciudad: ");
            string? ciudadNuevo = Console.ReadLine();
            Console.WriteLine("Edad: ");
            int? edadNuevo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Correo electrónico: ");
            string? correoNuevo = Console.ReadLine();
            Console.WriteLine("Nº de teléfono: ");
            int? telefonoNuevo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre de usuario: ");
            string? userNuevo = Console.ReadLine();
            Console.WriteLine("Crea tu contraseña: ");
            string? passNueva = Console.ReadLine();
            Console.WriteLine("Repite la contrseña: ");
            string? passNuevaConfirmacion = Console.ReadLine();
            // DA FALLOS
            /*if (passNueva != passNuevaConfirmacion)
            {
                Console.WriteLine("Las contraseñas no coinciden. Inténtalo otra vez");
                continue;
                        
            }
            if (passNueva = passNuevaConfirmacion)
            {
                Console.WriteLine("Bienvenido a DartsForum, " + userNuevo);
            }
            break;*/
        }
        static void ShopInit()
        {
            Console.WriteLine("--- Ver productos ---");
            Console.WriteLine("--- Categorías ---");
            Console.WriteLine("1. Dardos completos");
            Console.WriteLine("2. Plumas");
            Console.WriteLine("3. Cañas");
            Console.WriteLine("4. Barriletes");
            Console.WriteLine("5. Puntas");
            Console.WriteLine("6. Darderas");
            Console.WriteLine("7. Otros");
            Console.WriteLine("8. Listar todos los productos");
            Console.WriteLine();
            Console.WriteLine("Escoja su opción: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ShowAllDarts();
                    break;
                case 2:
                    ShowFlights();
                    break;
                case 3:
                    ShowCanes();
                    break;
            }
        }
        static void ShowAllDarts()
        {
            // Estructura -> Ref/Brand/Name/Model/Price
            Console.WriteLine("------------------------- Dardos completos --------------------------");
            Console.WriteLine("|Ref.  | Marca    | Modelo                                | Precio  |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CD001 | Winmau   | Professional dart set #01             | 54,99   |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CD002 | Winmau   | Professional dart set #02             | 64,99   |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CD003 | Winmau   | Professional dart set #03             | 69,99   |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CD004 | Impact   | Professional darts Special Edition    | 69,99   |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CD005 | Impact   | Metallica Special set                 | 79,99   |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CD006 | Impact   | Iron Maiden Special set               | 79,99   |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CD007 | Impact   | Megadeth Special set                  | 79,99   |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CD008 | Impact   | Motorhead Special ser                 | 99,99   |");
        }
        static void ShowFlights()
        {
            // Estructura -> Ref/Brand/Name/Model/Price
            Console.WriteLine("------------------------------ Plumas -------------------------------");
            Console.WriteLine("|Ref.  | Marca    | Modelo                                | Precio  |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PL001 | Winmau   | Plumas Iron Maiden                    | 1.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PL002 | Winmau   | Plumas Slayer                         | 1.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PL003 | Winmau   | Plumas Motorhead                      | 1.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PL004 | Winmau   | Plumas Motley Crew                    | 1.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PL005 | Winmau   | Plumas Modern Cut                     | 2.50    |");
        }
        static void ShowCanes()
        {
            // Estructura -> Ref/Brand/Name/Model/Price
            Console.WriteLine("------------------------------ Cañas --------------------------------");
            Console.WriteLine("|Ref.  | Marca    | Modelo                                | Precio  |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA001 | Harrows  | Cañas Midi Blancas 40mm               | 3.00    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA001 | Harrows  | Cañas Midi Negras  40mm               | 3.00    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA004 | Harrows  | Cañas Dimplex M Blancas 45mm          | 5.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA004 | Harrows  | Cañas Dimplex M Negras 45mm           | 5.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA002 | Harrows  | Cañas Alamo Negras  47mm              | 3.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA002 | Harrows  | Cañas Alamo Blancas 47mm              | 3.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA003 | Harrows  | Cañas Speedline Blancas 47mm          | 4.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA003 | Harrows  | Cañas Speedline Negras 47mm           | 4.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA005 | Harrows  | Cañas Supergrip M Smokey 49mm         | 6.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA005 | Harrows  | Cañas Supergrip M Blancas 49mm        | 6.50    |"); 
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|CA005 | Harrows  | Cañas Supergrip M Negras 49mm         | 6.50    |");
        }
        static void Init()
        {
            bool exit = false;
            while (!exit)
            {
                MenuPrincipal(); //Llamo a la funcion del meunú
                Console.WriteLine("Selecciona una opción:");
                int opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 1)   //Sobre nosostros
                {
                    //POR ESCRIBIR "SOBRE NOSOSTROS"
                    AboutUs(); //Sobre nosotros
                }
                else if (opt == 2)  //Inicio de sesión
                {
                    Login();
                }
                else if (opt == 3)  //Crear perfil
                {
                    CreateUser();
                }
                else if (opt == 4)  //Tienda
                {
                    ShopInit();
                }
                else if (opt == 5) //Donde jugar
                {
                    
                }
                else //Si no se introduce ningún carácter contemplado
                {
                    Console.WriteLine("Opción incorrecta");
                }
            }
        }
    }
}

/*Funciones 
Init
MenuPrincipal
AboutUs
Login
CreateUser
ShopInit
ShowAllDarts
ShowFlights
ShowCanes
*/