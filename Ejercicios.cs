using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRLG_EstructuraDATOS
{
    public class Ejercicios
    {
        //tabla de vendedores
        public void Vendedores()
        {
            int[,] dinero = 
//vendedores |  1      2     3      4     //total producto x son 5
            { { 500,  3000, 100,   400 }, //4000
              { 1000, 150,  200,   500},  //1850
              { 250,  1800, 2900,  300},  //5250
              { 400,  130,  90,    2400}, //3020
              { 60,   20,   4000,  3600}  //7680
            };//2210, 5100, 7290,  7200 
            //total vendedor x son 4
            Console.WriteLine("Tabla en consola: ");
            for (int i = 0; i < dinero.GetLength(0); i++)
            {
                for (int j = 0; j < dinero.GetLength(1); j++)
                {
                    Console.Write(dinero[i, j] + "  ");
                }
                Console.WriteLine();
            }
            int sumaVendedor1 = 0;
            int sumaProducto1 = 0;
            //imprimir ganacia
            for (int fila = 0; fila < dinero.GetLength(0); fila++)
            {
                for (int columna = 0; columna < dinero.GetLength(1); columna++)
                {
                    if (fila == 0)
                    {
                        sumaProducto1 += dinero[fila, columna];
                    }
                    if (columna == 0)
                    {
                        sumaVendedor1 += dinero[fila, columna];
                    }
                }
            }
            Console.WriteLine($"La ganancia total del producto 1 es: {sumaProducto1}");
            Console.WriteLine($"La ganancia total del Vendedor 1 es: {sumaVendedor1}");
            Console.WriteLine();
            int sumaVendedor2 = 0;
            int sumaProducto2 = 0;
            //imprimir ganacia
            for (int fila = 0; fila < dinero.GetLength(0); fila++)
            {
                for (int columna = 0; columna < dinero.GetLength(1); columna++)
                {
                    if (fila == 1)
                    {
                        sumaProducto2 += dinero[fila, columna];
                    }
                    if (columna == 1)
                    {
                        sumaVendedor2 += dinero[fila, columna];
                    }
                }
            }
            Console.WriteLine($"La ganancia total del producto 2 es: {sumaProducto2}");
            Console.WriteLine($"La ganancia total del Vendedor 2 es: {sumaVendedor2}");
            Console.WriteLine();
            int sumaVendedor3 = 0;
            int sumaProducto3 = 0;
            //imprimir ganacia
            for (int fila = 0; fila < dinero.GetLength(0); fila++)
            {
                for (int columna = 0; columna < dinero.GetLength(1); columna++)
                {
                    if (fila == 2)
                    {
                        sumaProducto3 += dinero[fila, columna];
                    }
                    if (columna == 2)
                    {
                        sumaVendedor3 += dinero[fila, columna];
                    }
                }
            }
            Console.WriteLine($"La ganancia total del producto 3 es: {sumaProducto3}");
            Console.WriteLine($"La ganancia total del Vendedor 3 es: {sumaVendedor3}");
            Console.WriteLine();
            int sumaVendedor4 = 0;
            int sumaProducto4 = 0;
            //imprimir ganacia
            for (int fila = 0; fila < dinero.GetLength(0); fila++)
            {
                for (int columna = 0; columna < dinero.GetLength(1); columna++)
                {
                    if (fila == 3)
                    {
                        sumaProducto4 += dinero[fila, columna];
                    }
                    if (columna == 3)
                    {
                        sumaVendedor4 += dinero[fila, columna];
                    }
                }
            }
            Console.WriteLine($"La ganancia total del producto 4 es: {sumaProducto4}");
            Console.WriteLine($"La ganancia total del Vendedor 4 es: {sumaVendedor4}");
            Console.WriteLine();
            int sumaProducto5 = 0;
            //imprimir ganacia
            for (int fila = 0; fila < dinero.GetLength(0); fila++)
            {
                for (int columna = 0; columna < dinero.GetLength(1); columna++)
                {
                    if (fila == 4)
                    {
                        sumaProducto5 += dinero[fila, columna];
                    }
                }
            }
            Console.WriteLine($"La ganancia total del producto 5 es: {sumaProducto5}");
        }
        //otro ejercicio
        public void Calificaciones()
        {
            int[] lista = new int[10];
            //utilizar clase random
            Random random = new Random();
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = random.Next(100);
            }
            //imprimir matriz unidemensional desordenada
            Console.WriteLine("Matriz desordenada: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine();
            //ordenar de forma descendente utilizando metodo burbuja
            for (int i = 0; i < lista.Length; i++)
            {
                int pos = i;
                int menor = lista[i];

                for (int j = i+1; j < lista.Length; j++)
                {
                    if (menor < lista[j])
                    {
                        menor = lista[j];
                        pos = j;
                    }
                }
                if (pos!=i)
                {
                    int tem = lista[i];
                    lista[i] = lista[pos]; 
                    lista[pos] = tem;
                }
                
            }
            //imprimir la matriz ordenada
            Console.WriteLine("Lista ordenada de forma descendente:");
            for (int k = 0; k<lista.Length; k++)
            {
                Console.Write(lista[k] + " ");
            }
            //busqueda
            Console.WriteLine( );
            Console.WriteLine("Dame el numero buscado:");
            int buscado = int.Parse(Console.ReadLine());
            for (int i=0; i<lista.Length;i++)
            {
                if (lista[i] == buscado)
                {
                    Console.WriteLine($"Tu numero {buscado} buscado si esta!");
                }
                if(buscado == 75)
                {
                    Console.WriteLine("Posicion del numero 75 es: "+i);
                }
                else
                {
                    Console.WriteLine("El valor no se encuentra en la matriz!");
                }
            }


        }
    }
}
