//Proyecto UT2 - Mario Furlan
using System;
using System.Collections;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
namespace DartsForum
{
    class Program
    {
        static void Main(string[] args) //Punto de inicio
        {
            Init();
        }

        //Array comunidades

        static string[] Comunities = new string[] { "Navarra", "Madrid", "La Rioja", "Aragón" };

        //Lugares para jugar
        static ArrayList PlacesNavarra = BuildPlacesNavarra();
        static ArrayList PlacesMadrid = BuildPlacesMadrid();
        static ArrayList PlacesLaRioja = BuildPlacesLaRioja();
        static ArrayList PlacesAragon = BuildPlacesAragon();


        //Listas de listas en eventos
        static ArrayList Events = BuildEvents();

        //Listas de listas en perfiles
        static ArrayList Profiles = BuildProfiles();

        //Listas de listas en pedidos
        static ArrayList Orders = BuildOrders();

        //Funciones

        static ArrayList BuildPlacesNavarra() //Función que crea la lista de listas de lugares de Navarra
        {
            ArrayList lista = new ArrayList();

            void Add(int numero, string nombre, string zona, string horario)
            {
                ArrayList fila = new ArrayList() {numero, nombre, zona, horario};
                lista.Add(fila);
            }

            //Definición de los sitios
            Add(1, "Bar Tábata", "Villava", "18:00 - 02:00");
            Add(2, "Bar Coyote", "Iturrama", "17:00 - 01:00");
            Add(3, "Bar Motobomba", "Casco Antigüo", "19:00 - 03:00");

            return lista;
        }

        static void ShowPlacesNavarra(ArrayList PlacesNavarra)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("| Nº | Nombre              | Lugar          | Horario               |");
            Console.WriteLine("|----|---------------------|----------------|-----------------------|");

            foreach (ArrayList fila in PlacesNavarra)
            {
                int number  = (int)fila[0];
                string name = (string)fila[1];
                string zone = (string)fila[2];
                string schedule = (string)fila[3];

                Console.WriteLine("| " + number + "  | " + name + " | " + zone + " | " + schedule + " |");
                Console.WriteLine("|----|---------------------|----------------|-----------------------|");
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }

        static void ShowPlacesNavarra()
        {
            ShowPlacesNavarra(PlacesNavarra);
        }

        static ArrayList BuildPlacesMadrid()
        {
            ArrayList lista = new ArrayList();

            void Add(int numero, string nombre, string zona, string horario)
            {
                ArrayList fila = new ArrayList() { numero, nombre, zona, horario };
                lista.Add(fila);
            }

            Add(1, "Entre Darts Rock", "Carabanchel", "20:00 - 03:00");
            Add(2, "Bar Bodegas Riojanas","Centro, Madrid", "18:00 - 02:00");

            return lista;
        }

        static void ShowPlacesMadrid(ArrayList PlacesMadrid)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("| Nº | Nombre              | Lugar          | Horario               |");
            Console.WriteLine("|----|---------------------|----------------|-----------------------|");

            foreach (ArrayList fila in PlacesMadrid)
            {
                int number  = (int)fila[0];
                string name = (string)fila[1];
                string zone = (string)fila[2];
                string schedule = (string)fila[3];

                Console.WriteLine("| " + number + "  | " + name + " | " + zone + " | " + schedule + " |");
                Console.WriteLine("|----|---------------------|----------------|-----------------------|");
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }

        static void ShowPlacesMadrid()
        {
            ShowPlacesMadrid(PlacesMadrid);
        }

        static ArrayList BuildPlacesLaRioja()
        {
            ArrayList lista = new ArrayList();

            void Add(int numero, string nombre, string zona, string horario)
            {
                ArrayList fila = new ArrayList() { numero, nombre, zona, horario };
                lista.Add(fila);
            }

            Add(1, "Bar Bola Ocho", "Logroño (centro)", "18:00 - 02:00");
            Add(2, "El Bunker Pub Musical", "Logroño (centro)", "20:00 - 04:00");
            Add(3, "Cervecería Dante O'Neal", "Logroño", "18:00 - 02:00");
            Add(4, "Pause&Play Berceo", "C.C. Berceo, Logroño", "10:00 - 00:00");
            Add(5, "Bar Viñas", "Calahorra", "18:00 - 02:00");

            return lista;
        }

        static void ShowPlacesLaRioja(ArrayList PlacesLaRioja)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("| Nº | Nombre              | Lugar          | Horario               |");
            Console.WriteLine("|----|---------------------|----------------|-----------------------|");

            foreach (ArrayList fila in PlacesLaRioja)
            {
                int number  = (int)fila[0];
                string name = (string)fila[1];
                string zone = (string)fila[2];
                string schedule = (string)fila[3];

                Console.WriteLine("| " + number + "  | " + name + " | " + zone + " | " + schedule + " |");
                Console.WriteLine("|----|---------------------|----------------|-----------------------|");
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }

        static void ShowPlacesLaRioja()
        {
            ShowPlacesLaRioja(PlacesLaRioja);
        }

        static ArrayList BuildPlacesAragon()
        {
            ArrayList lista = new ArrayList();

            void Add(int numero, string nombre, string zona, string horario)
            {
                ArrayList fila = new ArrayList() { numero, nombre, zona, horario };
                lista.Add(fila);
            }

            Add(1, "Club Billar Aldayo", "Zaragoza", "17:00 - 02:00");
            Add(2, "Buenos Tiempos en el Royale", "Casco Antiguo, Zaragoza", "18:00 - 03:00");
            Add(3, "Drinks & Pool", "Zaragoza", "18:00 - 02:00");
            Add(4, "The Strad Club", "Centro Comercial Grancasa, Zaragoza", "12:00 - 01:00");
            Add(5, "Invictus Sport Tavern", "Zaragoza", "18:00 - 02:00");

            return lista;
        }

        static void ShowPlacesAragon(ArrayList PlacesAragon)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("| Nº | Nombre              | Lugar          | Horario               |");
            Console.WriteLine("|----|---------------------|----------------|-----------------------|");

            foreach (ArrayList fila in PlacesAragon)
            {
                int number  = (int)fila[0];
                string name = (string)fila[1];
                string zone = (string)fila[2];
                string schedule = (string)fila[3];

                Console.WriteLine("| " + number + "  | " + name + " | " + zone + " | " + schedule + " |");
                Console.WriteLine("|----|---------------------|----------------|-----------------------|");
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }

        static void ShowPlacesAragon()
        {
            ShowPlacesAragon(PlacesAragon);
        }

        static ArrayList BuildEvents()
        {
            ArrayList lista = new ArrayList();

            void Add(int numero, string nombre, string fecha, string lugar)
            {
                ArrayList fila = new ArrayList();
                fila.Add(numero);
                fila.Add(nombre);
                fila.Add(fecha);
                fila.Add(lugar);
                lista.Add(fila);
            }

            Add(1, "Liga de dardos", "15/11/2025", "Bar Tábata");
            Add(2, "Torneo nocturno", "22/11/2025", "Bar Coyote");
            Add(3, "Open torneo de fin de semana", "05/12/2025", "Bar Coyote");
            Add(4, "Torneo de navidad", "25/12/2025", "Bar Tábata");

            return lista;
        }

        static ArrayList BuildProfiles()
        {
            ArrayList lista = new ArrayList();

            void Add(int id, string usuario, string ciudad, int edad)
            {
                ArrayList fila = new ArrayList();
                fila.Add(id);
                fila.Add(usuario);
                fila.Add(ciudad);
                fila.Add(edad);
                lista.Add(fila);
            }

            Add(001, "jose202", "Pamplona", 19);
            Add(002, "triple20", "Logroño", 21);
            Add(003, "Husky", "Pamplona", 28);
            Add(004, "Tato", "Pamplona", 28);
            Add(005, "Alberto", "Madrid", 22);
            Add(006, "Marcos", "Logroño", 38);
            Add(007, "Aradia", "Pamplona", 29);
            Add(008, "Miren", "Zaragoza", 19);
            Add(009, "Pol", "Madrid", 25);
            Add(010, "gork203", "Zaragoza", 17);
            Add(011, "Mike", "Logroño", 21);
            Add(012, "Yuri", "Pamplona", 24);
            Add(013, "Josean", "Pamplona", 26);
            Add(014, "Javier", "Pamplona", 28);

            return lista;
        }

        static ArrayList BuildOrders()
        {
            ArrayList lista = new ArrayList();

            void Add(int id, string usuario, string referencia, double total)
            {
                ArrayList fila = new ArrayList();
                fila.Add(id);
                fila.Add(usuario);
                fila.Add(referencia);
                fila.Add(total);
                lista.Add(fila);
            }

            Add(1, "Husky", "CD001", 54.99);
            Add(2, "jose202", "BL011", 9.99);
            Add(3, "triple20", "PL005", 2.50);

            return lista;
        }

        static void ShowEventsTable(ArrayList Events)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("| Nº | Nombre del evento          | Fecha       | Lugar             |");
            Console.WriteLine("|----|----------------------------|-------------|-------------------|");
        
            foreach (ArrayList fila in Events)
            {
                int numero = (int)fila[0];
                string nombre = (string) fila[1];
                string fecha = (string)fila[2];
                string lugar = (string)fila[3];

                Console.WriteLine("| " + numero + " | " + nombre + " | " + fecha + " | " + lugar + " |");
                Console.WriteLine("|----|----------------------------|-------------|-------------------|");
            }

            Console.WriteLine("---------------------------------------------------------------------");
        }

        static void ShowProfilesTable(ArrayList Profiles)
        {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("| ID | Usuario        | Ciudad       | Edad |");
        Console.WriteLine("|----|----------------|--------------|------|");

        foreach (ArrayList fila in Profiles)
            {
                int id = (int)fila[0];
                string usuario = (string)fila[1];
                string ciudad = (string)fila[2];
                int edad = (int)fila[3];

                Console.WriteLine("| " + id + " | " + usuario + " | " + ciudad + " | " + edad + " |");
                Console.WriteLine("|----|----------------|--------------|------|");
            }
            Console.WriteLine("---------------------------------------------");
        }

        static void ShowOrdersTable (ArrayList Orders)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("| ID | Usuario        | Ref. producto | Total (€) |");
            Console.WriteLine("|----|----------------|---------------|-----------|");

            foreach (ArrayList fila in Orders)
            {
                int id = (int)fila[0];
                string usuario = (string)fila[1];
                string referencia = (string)fila[2];
                double total = (double)fila[3];

                Console.WriteLine("| " + id + " | " + usuario + " | " + referencia + " | " + total + " |");
                Console.WriteLine("|----|----------------|--------------|-----------|");
            }

            Console.WriteLine("---------------------------------------------------");
        }

        static void ShowEvents()
        {
            Console.WriteLine("--- Eventos próximos ---");
            ShowEventsTable(Events);
        }

        static void ShowProfiles()
        {
            Console.WriteLine("--- Perfiles registrados ---");
            ShowProfilesTable(Profiles);
        }

        static void ShowOrders()
        {
            Console.WriteLine("--- Pedidos ---");
            ShowOrdersTable(Orders);
        }

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
            Console.WriteLine("DartsForum es una comunidad local para jugadores de dardos.");
            Console.WriteLine("Aquí puedes consultar productos, lugares donde jugar y próximos eventos.");
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
            string? passNueva = Console.ReadLine();
            string? passNuevaConfirmacion = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Crea tu contraseña: ");
                passNueva = Console.ReadLine();
                Console.WriteLine("Repite la contrseña: ");
                passNuevaConfirmacion = Console.ReadLine();

                if (passNueva != passNuevaConfirmacion)
                {
                    Console.WriteLine("Las contraseñas no coinciden. Inténtalo otra vez.\n");
                } 
                else
                {
                    Console.WriteLine("Bienvenido a DartsForum, " + userNuevo);
                    break; // salimos del while cuando las contraseñas coinciden
                }

            }
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
            Console.WriteLine("9. Salir");
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
                case 4:
                    ShowBarrels();
                    break;
                case 5:
                    ShowTips();
                    break;
                case 6:
                    ShowCases();
                    break;
                case 7: 
                    ShowOthers();
                    break;
                case 8:
                    ShowAllProducts();
                    break;
                case 9:
                    Init();
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
            Console.WriteLine("---------------------------------------------------------------------");
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
            Console.WriteLine("---------------------------------------------------------------------");
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
            Console.WriteLine("---------------------------------------------------------------------");
        }
        static void ShowBarrels()
        {
            // Estructura -> Ref/Brand/Name/Model/Price
            Console.WriteLine("---------------------------- Barriletes ------------------------------");
            Console.WriteLine("|Ref.  | Marca     | Modelo                                | Precio  |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL001 | Harrows   | Barrilete silver edition 16g          | 5.50    |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL002 | Harrows   | Barrilete tungsten edition 18g        | 6.00    |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL003 | Harrows   | Barrilete tungsten edition 20g        | 6.50    |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL004 | Canaveral | Barrilete SN90 16g                    | 6.50    |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL005 | Canaveral | Barrilete SN90 18g                    | 7.50    |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL006 | Canaveral | Barrilete SN90 20g                    | 8.50    |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL007 | Winmau    | Barrilete Gold 16g                    | 5.50    |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL008 | Winmau    | Barrilete Gold 18g                    | 6.50    |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL009 | Winmau    | Barrilete Gold 19g                    | 7.50    |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL010 | Winmau    | Barrilete Gold 20g                    | 8.50    |");
            Console.WriteLine("|------|-----------|---------------------------------------|---------|");
            Console.WriteLine("|BL011 | Winmau    | Barrilete Deluxe edition 22g          | 9.99    |");
            Console.WriteLine("----------------------------------------------------------------------");
        }

        static void ShowTips()
        {
            // Estructura -> Ref/Brand/Name/Model/Price
            Console.WriteLine("------------------------------ Puntas -------------------------------");
            Console.WriteLine("|Ref.  | Marca    | Modelo                                | Precio  |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PT001 | Winmau   | 50 Puntas pro soft tips cortas        | 3.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PT002 | Winmau   | 100 Puntas pro soft tips cortas       | 5.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PT003 | Winmau   | 50 Puntas pro soft tips largas        | 4.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PT004 | Winmau   | 100 Puntas pro soft tips largas       | 6.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PT005 | Winmau   | 50 Puntas pro hard tips cortas        | 4.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PT006 | Winmau   | 100 Puntas pro hard tips cortas       | 6.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PT007 | Winmau   | 50 Puntas pro hard tips largas        | 5.50    |");
            Console.WriteLine("|------|----------|---------------------------------------|---------|");
            Console.WriteLine("|PT008 | Winmau   | 100 Puntas pro hard tips largas       | 7.50    |");
            Console.WriteLine("---------------------------------------------------------------------");
        }

        static void ShowCases()
        {
            // Estructura -> Ref/Brand/Name/Model/Price
            Console.WriteLine("---------------------------- Darderas ----------------------------------");
            Console.WriteLine("|Ref.  | Marca    | Modelo                                  | Precio   |");
            Console.WriteLine("|------|----------|-----------------------------------------|----------|");
            Console.WriteLine("|DT001 | Winmau   | Dardera Iron Maiden 3 dardos            | 18.50    |");
            Console.WriteLine("|------|----------|-----------------------------------------|----------|");
            Console.WriteLine("|DT002 | Winmau   | Dardera pro pack 3 dardos               | 18.50    |");
            Console.WriteLine("|------|----------|-----------------------------------------|----------|");
            Console.WriteLine("|DT003 | Winmau   | Dardera pro pack 6 dardos               | 19.50    |");
            Console.WriteLine("|------|----------|-----------------------------------------|----------|");
            Console.WriteLine("|DT004 | Winmau   | Dardera pro pack anti impactos 3 dardos | 25.50    |");
            Console.WriteLine("|------|----------|-----------------------------------------|----------|");
            Console.WriteLine("|DT005 | Winmau   | Dardera pro pack anti impactos 6 dardos | 35.50    |");
            Console.WriteLine("------------------------------------------------------------------------");
        }


        static void ShowOthers()
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
            Console.WriteLine("---------------------------------------------------------------------");
        }

        static void ShowAllProducts()
        {
            ShowAllDarts();
            ShowFlights();
            ShowCanes();
            ShowBarrels();
            ShowTips();
            ShowCases();
            ShowOthers();
        }
        static void WhereToPlay()
        {
            Console.WriteLine("------- Dónde jugar ------");
            Console.WriteLine("--- Elija su comunidad ---");
            for (int i = 0; i < Comunities.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Comunities[i]}");
            }
            Console.WriteLine("Escoja su comunidad: ");
            string input = Console.ReadLine();

            //Validar si el usuario introduce un numero
            bool isNumber = false;
            foreach (char c  in input)
            {
                if (!Char.IsDigit(c)) // Verifica que el input no es un numero
                {
                    isNumber = false;
                    break; //Si no es numero salgo del bucle directamente
                }
                isNumber = true; //Si no se cumple la condición del if, significa que el input es un numero
            }
            
            if (!isNumber) //Si el input no es número -> mensaje de error
            {
                Console.WriteLine("Lo siento, no has intruducido una opción correcta");
                return;
            }

            int option = Convert.ToInt32(input);

            //Valido el rango
            if (option < 1 || option > Comunities.Length) //La condición es que o sea menor que uno o mayor que el largo del array
            {
                Console.WriteLine("Lo siento, no has intruducido una opción correcta");
                return;
            }

            string selection = Comunities[option - 1];
            Console.WriteLine($"--- {selection} ---");
            if (selection == "Navarra")
            {
                ShowPlacesNavarra();
            }
            else if (selection == "Madrid")
            {
                ShowPlacesMadrid();
            }
            else if (selection == "La Rioja")
            {
                ShowPlacesLaRioja();
            }
            else if (selection == "Aragón")
            {
                ShowPlacesAragon();
            }
            else
            {
                Console.WriteLine("Todavía no hay lugares registrados para esta comunidad.");
            }
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
                    AboutUs();
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
                    WhereToPlay();
                }
                else if (opt == 6) //Eventos próximos
                {
                    ShowEvents();
                }
                else if (opt == 7) //Ver perfiles
                {
                    ShowProfiles();
                }
                else if (opt == 8) //Ver pedidos
                {
                    ShowOrders();
                }
                else if (opt == 9) //Salir
                {
                    Console.WriteLine("Saliendo... ¡Gracias por usar DartsForum!");
                    exit = true;
                }
                else //Si no se introduce ningún carácter contemplado
                {
                    Console.WriteLine("Opción incorrecta");
                }
            }
        }
    }
}