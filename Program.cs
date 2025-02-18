using System;

namespace ListaGenericaDoble1
{
    // Clase principal que representa una lista doblemente enlazada
    class ListaGenericaDoble
   
    {
        class Nodo
        {
            public int info;
            public Nodo ant, sig;
        }

        private Nodo raiz;

        public ListaGenericaDoble()
        {
            raiz = null;
        }

        void Insertar(int pos, int x)
        {
            if (pos <= Cantidad() + 1)
            {
                Nodo nuevo = new Nodo();
                nuevo.info = x;
                if (pos == 1)
                {
                    nuevo.sig = raiz;
                    if (raiz != null)
                        raiz.ant = nuevo;
                    raiz = nuevo;
                }
                else if (pos == Cantidad() + 1)
                {
                    Nodo reco = raiz;
                    while (reco.sig != null)
                    {
                        reco = reco.sig;
                    }
                    reco.sig = nuevo;
                    nuevo.ant = reco;
                    nuevo.sig = null;
                }
                else
                {
                    Nodo reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo siguiente = reco.sig;
                    reco.sig = nuevo;
                    nuevo.ant = reco;
                    nuevo.sig = siguiente;
                    siguiente.ant = nuevo;
                }
            }
        }
        // Método para extraer un valor de una posición específica
        public int Extraer(int pos)
        {
            if (pos <= Cantidad())
            {
                int informacion;
                if (pos == 1)
                {
                    informacion = raiz.info;
                    raiz = raiz.sig;
                    if (raiz != null)
                        raiz.ant = null;
                }
                else
                {
                    Nodo reco;
                    reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo prox = reco.sig;
                    reco.sig = prox.sig;
                    Nodo siguiente = prox.sig;
                    if (siguiente != null)
                        siguiente.ant = reco;
                    informacion = prox.info;
                }
                return informacion;
            }
            else
                return int.MaxValue;
        }

        public void Borrar(int pos)
        {
            if (pos <= Cantidad())
            {
                if (pos == 1)
                {
                    raiz = raiz.sig;
                    if (raiz != null)
                        raiz.ant = null;
                }
                else
                {
                    Nodo reco;
                    reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo prox = reco.sig;
                    prox = prox.sig;
                    reco.sig = prox;
                    if (prox != null)
                        prox.ant = reco;
                }
            }
        }

        // Nuevo método para eliminar por valor
        public void BorrarPorValor(int valor)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.info == valor)
                {
                    if (reco.ant == null) // Es el primer nodo
                    {
                        raiz = reco.sig;
                        if (raiz != null)
                            raiz.ant = null;
                    }
                    else
                    {
                        reco.ant.sig = reco.sig;
                        if (reco.sig != null)
                            reco.sig.ant = reco.ant;
                    }
                    Console.WriteLine($"Elemento {valor} eliminado.");
                    return;
                }
                reco = reco.sig;
            }
            Console.WriteLine($"Elemento {valor} no encontrado.");
        }

        public void Intercambiar(int pos1, int pos2)
        {
            if (pos1 <= Cantidad() && pos2 <= Cantidad())
            {
                Nodo reco1 = raiz;
                for (int f = 1; f < pos1; f++)
                    reco1 = reco1.sig;
                Nodo reco2 = raiz;
                for (int f = 1; f < pos2; f++)
                    reco2 = reco2.sig;
                int aux = reco1.info;
                reco1.info = reco2.info;
                reco2.info = aux;
            }
        }

        public int Mayor()
        {
            if (!Vacia())
            {
                int may = raiz.info;
                Nodo reco = raiz.sig;
                while (reco != null)
                {
                    if (reco.info > may)
                        may = reco.info;
                    reco = reco.sig;
                }
                return may;
            }
            else
                return int.MaxValue;
        }

        public int PosMayor()
        {
            if (!Vacia())
            {
                int may = raiz.info;
                int x = 1;
                int pos = x;
                Nodo reco = raiz.sig;
                while (reco != null)
                {
                    if (reco.info > may)
                    {
                        may = reco.info;
                        pos = x;
                    }
                    reco = reco.sig;
                    x++;
                }
                return pos;
            }
            else
                return int.MaxValue;
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                reco = reco.sig;
                cant++;
            }
            return cant;
        }

        public bool Ordenada()
        {
            if (Cantidad() > 1)
            {
                Nodo reco1 = raiz;
                Nodo reco2 = raiz.sig;
                while (reco2 != null)
                {
                    if (reco2.info < reco1.info)
                    {
                        return false;
                    }
                    reco2 = reco2.sig;
                    reco1 = reco1.sig;
                }
            }
            return true;
        }

        public bool Existe(int x)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.info == x)
                    return true;
                reco = reco.sig;
            }
            return false;
        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ListaGenericaDoble lg = new ListaGenericaDoble();
            int opcion;
            do
            {
                Console.WriteLine("\n--- Menú de Lista Interactiva ---");
                Console.WriteLine("1. Insertar elemento");
                Console.WriteLine("2. Borrar elemento por posición");
                Console.WriteLine("3. Borrar elemento por valor");
                Console.WriteLine("4. Extraer elemento");
                Console.WriteLine("5. Intercambiar elementos");
                Console.WriteLine("6. Imprimir lista");
                Console.WriteLine("7. Verificar si existe un elemento");
                Console.WriteLine("8. Encontrar el mayor elemento");
                Console.WriteLine("9. Verificar si la lista está ordenada");
                Console.WriteLine("10. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la posición: ");
                        int pos = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor: ");
                        int valor = int.Parse(Console.ReadLine());
                        lg.Insertar(pos, valor);
                        break;
                    case 2:
                        Console.Write("Ingrese la posición a borrar: ");
                        int posBorrar = int.Parse(Console.ReadLine());
                        lg.Borrar(posBorrar);
                        break;
                    case 3:
                        Console.Write("Ingrese el valor a borrar: ");
                        int valorBorrar = int.Parse(Console.ReadLine());
                        lg.BorrarPorValor(valorBorrar);
                        break;
                    case 4:
                        Console.Write("Ingrese la posición a extraer: ");
                        int posExtraer = int.Parse(Console.ReadLine());
                        int extraido = lg.Extraer(posExtraer);
                        Console.WriteLine("Elemento extraído: " + extraido);
                        break;
                    case 5:
                        Console.Write("Ingrese la primera posición: ");
                        int pos1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la segunda posición: ");
                        int pos2 = int.Parse(Console.ReadLine());
                        lg.Intercambiar(pos1, pos2);
                        break;
                    case 6:
                        Console.WriteLine("Lista actual:");
                        lg.Imprimir();
                        break;
                    case 7:
                        Console.Write("Ingrese el valor a buscar: ");
                        int buscar = int.Parse(Console.ReadLine());
                        if (lg.Existe(buscar))
                            Console.WriteLine("El valor existe en la lista.");
                        else
                            Console.WriteLine("El valor no existe en la lista.");
                        break;
                    case 8:
                        int mayor = lg.Mayor();
                        Console.WriteLine("El mayor elemento es: " + mayor);
                        break;
                    case 9:
                        if (lg.Ordenada())
                            Console.WriteLine("La lista está ordenada.");
                        else
                            Console.WriteLine("La lista no está ordenada.");
                        break;
                    case 10:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 10);
        }
    }
}