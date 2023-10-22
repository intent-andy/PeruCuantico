# Perú Cuántico
Perú es una propuesta que busca mejorar el turismo mediante un juego que intenta educar sobre prácticas turísticas eficientes que reduzcan la huella de carbono y que además enseñe mecánica cuántica.

El objetivo del proyecto es disminuir el impacto ambiental de la presencia de turistas en sitios de interés ambiental y arqueológico/cultural, y mejorar las condiciones económicas de los prestadores de servicios.

## Procedimiento
Una vez hecha la revisión de los recursos se procedió a hacer un análisis de los datos. De dicho análisis se decidió trabajar sobre el departamento de Madre de Dios, que cuenta con 5 lugares turísticos de importancia, de los cuales el Parque Nacional del Manu tiene una relevancia particular y por esta razón fue tomado como objeto principal de estudio para el desarrollo del software y de las estrategias para un turismo eficiente.

A partir de los datos de posición de estos lugares se crearon tres notebooks que utilizan lenguaje de programación python.
En los dos primeros notebooks titulados “[Ruta](Rutas/Ruta.ipynb)” y “[Ruta-interna](Rutas/Ruta-interna.ipynb)”, se importan diversas bibliotecas y módulos necesarios para el procesamiento de datos y visualización, así como para la resolución del Problema del Viajante de Comercio (TSP) usando Qiskit el cual proporciona el uso de algóritmos cánticos. El procedimiento en ambos es el siguiente:

1. Se lee un archivo Excel que contiene información sobre las ubicaciones de zonas turísticas de Madre de Dios y del Parque Nacional Manu respectivamente  y se almacenan estos datos en un DataFrame llamado "df".

2. Se convierten las coordenadas de las ciudades, originalmente en formato de texto, en tuplas de números para su procesamiento posterior.
   
3. Se calcula las distancias entre todas las posibles combinaciones de lugares y se almacenan estos valores en un diccionario llamado "distancia_arcos".
   
4. Se crea un grafo utilizando la biblioteca NetworkX, donde los nodos representan lugares y los bordes entre los nodos tienen pesos correspondientes a las distancias entre los lugares.
   
5. Se realiza una representación gráfica de este grafo, lo que proporciona una visualización de las ubicaciones de los lugares y las distancias entre ellas.

6. Se resuelve el Problema del Viajante de Comercio (TSP) utilizando un enfoque de "fuerza bruta", lo que implica calcular todas las posibles permutaciones de los lugares y se selecciona la ruta más corta.

7. Se muestra la solución óptima del TSP en el grafo, destacando el orden en el que se deben visitar los lugares. 

8. Se almacena la información relevante, como la mejor secuencia de lugares para visitar y las coordenadas de los lugares, para su posterior uso. 

9. Se crea un mapa interactivo utilizando la biblioteca Folium para mostrar la ruta óptima del TSP.

Posteriormente la información de la ruta de lugares a recorrer para ambos casos son exportados a un [tercer notebook](Rutas/Esqueleto.ipynb), el cual, presenta una interfaz de usuario:

1. Se identifica el nombre del usuario.

2. Se presenta la ruta que debes tomar destacando la ubicación y al llegar al Parque Nacional Manu muestra la ruta interna del parque.

De forma paralela a esto, se diseñó un [juego piloto](Test for CO-Afina 2023) en donde el jugador, partiendo de un punto inicial, tiene la opción de seleccionar un destino. Si el destino cumple con una ruta eficiente, se observa en la pantalla un Gallito de las Rocas. Si se escoge una ruta que no es eficiente, se observa nuevamente un Gallito de las Rocas, pero esta vez con una expresión de molestia. El juego piloto está diseñado con el punto inicial en el Parque Nacional del Manu, y se pueden escoger otros cuatro destinos finales.

A partir de todos estos datos y recursos, se propone un juego basado en el dilema del prisionero. El juego clásico está restringido dos respuestas: "Sí" y "No". La propuesta de juego cuántico añade una tercera posibilidad: "Sí, bajo ciertas condiciones". De esta forma, el juego busca que el turista pueda escoger una de las tres opciones: "Viajar a toda costa", ""Viajar, considerando ciertos factores" y "No viajar". Similarmente sucede con el prestador de servicio, que puede escoger entre: "Prestar el servicio", "Prestar el servicio cuidando detalles" y "No prestar el servicio". Así, agregando ese entrelazamiento de factores, que fácilmente se puede comparar al cuántico, se describe de manera más adecuada el complejo comportamiento humano.

A partir de este juego, incluyendo todos los factores que afectan que uno u otro jugador tomen determinada decisión, es posible educar a los turistas para que hagan un viaje más eficiente, sino que también aprende de mecánica cuántica en el proceso.
