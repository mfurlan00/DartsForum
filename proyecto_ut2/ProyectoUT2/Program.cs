//Proyecto UT2 - Mario Furlan
using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace DartsMall
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
        }
        static void MenuPrincipal() //Función que genera la estructura del menú principal
        {
            Console.WriteLine("----- DartsForum -----");
            Console.WriteLine("--- Menú Principal ---");
            //Opciones comunes a todos los usuarios
            Console.WriteLine("1. Sobre nosotros");
            Console.WriteLine("2. Iniciar sesión");
            Console.WriteLine("3. Crear perfil");
            Console.WriteLine("4. Comprar productos");
            Console.WriteLine("5. ¿Dónde jugar?");
            Console.WriteLine("6. Eventos próximos");
            //Opciones de admins
            Console.WriteLine("7. Ver perfiles");
            Console.WriteLine("8. Ver pedidos");
            //Salida
            Console.WriteLine("9. Salir");
        }
        static void Init()
        {
            bool exit = false;
            while (!exit)
            {
                MenuPrincipal();
                Console.WriteLine("Selecciona una opción:");
                int opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 1)
                {
                    //POR ESCRIBIR "SOBRE NOSOSTROS"
                    //Console.WriteLine("");
                }
                else if (opt == 2)
                {
                    Console.WriteLine("--- Inicio de sesión ---");
                    Console.WriteLine("Nombre de usuario: ");
                    string userInicioSesion = Console.ReadLine();
                    Console.WriteLine("Contraseña: ");
                    string passInicioSesion = Console.ReadLine();
                    Console.WriteLine("Bienvenido, " + userInicioSesion);
                }
                else if (opt == 3)
                {
                    Console.WriteLine("--- Crear perfil ---");
                    Console.WriteLine("Nombre completo: ");
                    string nombreCompleto = Console.ReadLine();
                    Console.WriteLine("Ciudad: ");
                    string ciudadNuevo = Console.ReadLine();
                    Console.WriteLine("Edad: ");
                    int edadNuevo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Correo electrónico: ");
                    string correoNuevo = Console.ReadLine();
                    Console.WriteLine("Nº de teléfono: ");
                    int telefonoNuevo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nombre de usuario: ");
                    string userNuevo = Console.ReadLine();
                    Console.WriteLine("Crea tu contraseña: ");
                    string passNueva = Console.ReadLine();
                    Console.WriteLine("Repite la contrseña: ");
                    string passNuevaConfirmacion = Console.ReadLine();
                    // DA FALLOS
                    /*if (passNueva != passNuevaConfirmacion)
                    {
                        Console.WriteLine("Las contraseñas no coinciden. Inténtalo otra vez");
                        
                    }
                    else if (passNueva = passNuevaConfirmacion)
                    {
                        Console.WriteLine("Bienvenido a DartsForum, " + userNuevo);
                    }*/
                }
            }
        }
    }
}