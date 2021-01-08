using ArbolB;
using System;

namespace ArbolRamas
{
    class Program
    {
        static void Main(string[] args)
        {

            var opcion = 0;
            do
            {
                Console.Clear();
             
                Console.WriteLine("Arbol Binario");
               
                Console.WriteLine("1 Arbol Binario");
                Console.WriteLine("2 Arbol Multiples Hijos");
                Console.WriteLine("3 Contar Niveles del arbol ");
                Console.WriteLine("4 Contar Hojas del arbol ");
                Console.WriteLine("5 Contar Nodos totales del arbol");
                Console.WriteLine("6 Navegación Horizontal a traves del arbol");
                Console.WriteLine("7 Expresiones matemáticas  + , - , * , /");
                Console.WriteLine("8 Salir");
                Console.WriteLine("Seleccione una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Contruir Arbol Cinario");
                        Program.construirArbolB();
                        Console.WriteLine(" Presiona para continuar");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Contruir Arbol multiples Hijos");
                        Program.construirArbolMultiplesHijos();
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Contar niveles Arbol Mutiples Hijos");
                        Program.contarNiveles();
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Contar hojas Arbol Mutiples Hijos");
                        Program.contarHojas();
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Contar nodos Arbol Mutiples Hijos");
                        Program.contarNodos();
                        Console.WriteLine("Presiona enterpara continuar");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Navegación horizontal ");
                        Program.NavegarHorizontalmente();
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Operar mediante expresión matematica");
                        Program.OperarExpresion();
                        Console.WriteLine(" Presiona enter para continuar");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Gracias");
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                        opcion = 8;
                        break;
                    default:
                        Console.WriteLine("La opción  no es correcta, vuelve a intentarlo por favor");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 8);


        }
        public static void construirArbolB()
        {
            var raiz = new Nodo("*",
            new Nodo("1",
                new Nodo("1.1",
                    new Nodo("1.1.1"),
                    new Nodo("1.1.2")),
                new Nodo("1.2",
                    new Nodo("1.2.1"),
                    new Nodo("1.2.2"))),
            new Nodo("2",
                new Nodo("2.1",
                    new Nodo("2.1.1"),
                    new Nodo("2.1.2")),
                new Nodo("2.2",
                    new Nodo("2.2.1"),
                    new Nodo("2.2.2"))));


            Administrador admin = new Administrador();
            admin.RecorrerArbol(raiz);
        }
        public static void construirArbolMultiplesHijos()
        {
            NodoExt nodo1 = new NodoExt("1");
            NodoExt nodo2 = new NodoExt("2");
            NodoExt nodo3 = new NodoExt("3");
            NodoExt nodo4 = new NodoExt("4");
            NodoExt nodo5 = new NodoExt("5");
            NodoExt nodo6 = new NodoExt("6");
            NodoExt nodo7 = new NodoExt("7");

         
            nodo1.Hijos.Add(nodo2);
            nodo1.Hijos.Add(nodo3);

            
            nodo2.Hijos.Add(nodo4);
            nodo2.Hijos.Add(nodo5);
            
            nodo3.Hijos.Add(nodo6);
            nodo3.Hijos.Add(nodo7);
            
            nodo4.Hijos.Add(new NodoExt("8"));
            nodo4.Hijos.Add(new NodoExt("9"));
            nodo5.Hijos.Add(new NodoExt("10"));
            nodo5.Hijos.Add(new NodoExt("11"));

            nodo6.Hijos.Add(new NodoExt("12"));
            nodo6.Hijos.Add(new NodoExt("13"));
            nodo7.Hijos.Add(new NodoExt("14"));
            nodo7.Hijos.Add(new NodoExt("15"));

            NodoExt.ImprmirArbolMultiplesHijos(nodo1);
        }
        public static void contarNiveles()
        {
            NodoExt nodo1 = new NodoExt("1");
            NodoExt nodo2 = new NodoExt("2");
            NodoExt nodo3 = new NodoExt("3");
            NodoExt nodo4 = new NodoExt("4");
            NodoExt nodo5 = new NodoExt("5");
            NodoExt nodo6 = new NodoExt("6");
            NodoExt nodo7 = new NodoExt("7");

            NodoExt nodo10 = new NodoExt("10");
            NodoExt nodo11 = new NodoExt("11");

            
            nodo1.Hijos.Add(nodo2);
            nodo1.Hijos.Add(nodo3);

            
            nodo2.Hijos.Add(nodo4);
            nodo2.Hijos.Add(nodo5);
            
            nodo3.Hijos.Add(nodo6);
            nodo3.Hijos.Add(nodo7);
            
            nodo4.Hijos.Add(new NodoExt("12"));
            nodo4.Hijos.Add(new NodoExt("13"));
            
            nodo5.Hijos.Add(new NodoExt("14"));
            nodo5.Hijos.Add(new NodoExt("15"));
            
            nodo6.Hijos.Add(new NodoExt("16"));
            nodo6.Hijos.Add(new NodoExt("17"));
            
            nodo7.Hijos.Add(nodo10);
            nodo7.Hijos.Add(new NodoExt("18"));
            
            nodo10.Hijos.Add(nodo11);

            NodoExt.ImprmirArbolMultiplesHijos(nodo1);

            Console.WriteLine("EL ARBOL TIENE {0} NIVELES !!!", NodoExt.ContarNiveles(nodo1));
        }
        public static void contarHojas()
        {
            NodoExt nodo1 = new NodoExt("1");
            NodoExt nodo2 = new NodoExt("2");
            NodoExt nodo3 = new NodoExt("3");
            NodoExt nodo4 = new NodoExt("4");
            NodoExt nodo5 = new NodoExt("5");
            NodoExt nodo6 = new NodoExt("6");
            NodoExt nodo7 = new NodoExt("7");

            
            nodo1.Hijos.Add(nodo2);
            nodo1.Hijos.Add(nodo3);

            
            nodo2.Hijos.Add(nodo4);
            nodo2.Hijos.Add(nodo5);
            //
            nodo3.Hijos.Add(nodo6);
            nodo3.Hijos.Add(nodo7);
            
            nodo4.Hijos.Add(new NodoExt("8"));
            nodo4.Hijos.Add(new NodoExt("9"));
            nodo5.Hijos.Add(new NodoExt("10"));
            nodo5.Hijos.Add(new NodoExt("11"));

            nodo6.Hijos.Add(new NodoExt("12"));
            nodo6.Hijos.Add(new NodoExt("13"));
            nodo7.Hijos.Add(new NodoExt("14"));
            nodo7.Hijos.Add(new NodoExt("15"));

            NodoExt.ImprmirArbolMultiplesHijos(nodo1);
            Console.WriteLine("EL ARBOL TIENES {0} HOJAS !!!", NodoExt.ContarHojas(nodo1));

        }
        public static void contarNodos()
        {
            NodoExt nodo1 = new NodoExt("1");
            NodoExt nodo2 = new NodoExt("2");
            NodoExt nodo3 = new NodoExt("3");
            NodoExt nodo4 = new NodoExt("4");
            NodoExt nodo5 = new NodoExt("5");
            NodoExt nodo6 = new NodoExt("6");
            NodoExt nodo7 = new NodoExt("7");

            
            nodo1.Hijos.Add(nodo2);
            nodo1.Hijos.Add(nodo3);

            
            nodo2.Hijos.Add(nodo4);
            nodo2.Hijos.Add(nodo5);
            
            nodo3.Hijos.Add(nodo6);
            nodo3.Hijos.Add(nodo7);
            
            nodo4.Hijos.Add(new NodoExt("8"));
            nodo4.Hijos.Add(new NodoExt("9"));
            nodo5.Hijos.Add(new NodoExt("10"));
            nodo5.Hijos.Add(new NodoExt("11"));

            nodo6.Hijos.Add(new NodoExt("12"));
            nodo6.Hijos.Add(new NodoExt("13"));
            nodo7.Hijos.Add(new NodoExt("14"));
            nodo7.Hijos.Add(new NodoExt("15"));

            NodoExt.ImprmirArbolMultiplesHijos(nodo1);
            Console.WriteLine("EL ARBOL TIENE {0} NODOS!!", NodoExt.ContarNodos(nodo1));
        }
        public static void NavegarHorizontalmente()
        {
            var raiz = new Nodo("*",
            new Nodo("1",
                new Nodo("1.1",
                    new Nodo("1.1.1"),
                    new Nodo("1.1.2")),
                new Nodo("1.2",
                    new Nodo("1.2.1"),
                    new Nodo("1.2.2"))),
            new Nodo("2",
                new Nodo("2.1",
                    new Nodo("2.1.1"),
                    new Nodo("2.1.2")),
                new Nodo("2.2",
                    new Nodo("2.2.1"),
                    new Nodo("2.2.2"))));


            Administrador admin = new Administrador();
            admin.NavegarHorizontal(raiz);
        }
        public static void OperarExpresion()
        {

            Administrador admin = new Administrador();

         
            var arbolOperaciones = new Nodo("+",
                new Nodo("5"),
                new Nodo("+",
                    new Nodo("6"),
                    new Nodo("+",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            Console.WriteLine("LA SUMA DEL ARBOL ES: " + admin.SumarArbol(arbolOperaciones));
            Console.WriteLine("\n");

            Nodo nodoOperacion = new Nodo();
            admin.CrearArbol(nodoOperacion, "5+6+2+1");
            admin.RecorrerArbol(nodoOperacion);
            
        }
    }
}
