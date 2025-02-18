README - Lista Generica Doble
Este proyecto implementa una Lista Doblemente Enlazada Genérica en C#. La lista permite manipular una secuencia de elementos a través de operaciones como insertar, borrar, intercambiar, y extraer elementos, entre otras funcionalidades comunes en listas enlazadas.

Estructura del Código
Clase Nodo: Representa un nodo de la lista que contiene un valor (info) y dos referencias: una al nodo anterior (ant) y otra al siguiente nodo (sig).

Clase ListaGenericaDoble: Representa la lista doblemente enlazada que contiene métodos para manipular la lista. La lista tiene un puntero raiz que apunta al primer nodo.

Métodos Principales
Insertar: Permite insertar un elemento en una posición específica de la lista.

Extraer: Extrae el valor en una posición específica de la lista y lo devuelve.

Borrar: Elimina el nodo en una posición específica.

BorrarPorValor: Elimina el primer nodo que contiene el valor especificado.

Intercambiar: Intercambia los valores de los nodos en las posiciones dadas.

Mayor: Devuelve el valor más grande de la lista.

PosMayor: Devuelve la posición del valor más grande en la lista.

Cantidad: Devuelve la cantidad de elementos en la lista.

Ordenada: Verifica si la lista está ordenada de menor a mayor.

Existe: Verifica si un valor dado existe en la lista.

Vacia: Verifica si la lista está vacía.

Imprimir: Muestra todos los elementos de la lista en la consola.

Menú Interactivo
El programa incluye un menú interactivo que permite al usuario realizar las siguientes acciones:

Insertar un elemento en la lista.
Borrar un elemento por posición.
Borrar un elemento por valor.
Extraer un elemento de una posición específica.
Intercambiar dos elementos de la lista.
Imprimir la lista completa.
Verificar si un elemento existe en la lista.
Encontrar el mayor elemento de la lista.
Verificar si la lista está ordenada.
Salir del programa.
Ejemplo de Uso
El usuario puede seleccionar una opción del menú.
Dependiendo de la opción seleccionada, el programa solicitará información adicional (como la posición o el valor del elemento).
La lista será modificada o consultada según la operación seleccionada, y se mostrará el resultado en la consola.
Compilación y Ejecución
Este código está escrito en C# y puede ejecutarse en cualquier entorno compatible con .NET, como Visual Studio.

Copia y pega el código en un proyecto de consola en Visual Studio o en cualquier otro editor C#.
Compílalo y ejecútalo.
Sigue las instrucciones del menú interactivo.
Requerimientos
.NET Framework (recomendado 4.7 o superior).
Contribuciones
Si deseas contribuir a este proyecto, por favor abre un pull request con los cambios propuestos.
