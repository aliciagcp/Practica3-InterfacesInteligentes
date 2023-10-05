# Practica3-InterfacesInteligentes
## Movimiento - Físicas
### Alicia Guadalupe Cruz Pérez
Se han realizado varios ejercicios de script en unity:

- **a) Se pide agregar un campo velocidad al cubo de la [práctica anterior](https://github.com/aliciagcp/Practica2-InterfacesInteligentes.git) y asígnarle un valor que se pueda cambiar en el inspector de objetos. Mostrar en la consola el resultado de multiplicar la velocidad por el valor del eje vertical y por el valor del eje horizontal cada vez que se pulsan las teclas flecha arriba-abajo ó flecha izquierda-derecha. El mensaje debe comenzar por el nombre de la flecha pulsada.**

![ejercicio_1](gifs/ejercicio_1.gif)

Para ello se han seguido los siguientes pasos:
1. Creación de un [script](scripts/ejercicio1_script.cs) asociado al cubo (Ejerccicio_1).
   
Dentro del script:
1. Declaración de una variable pública de tipo float (speed) con un valor predeterminado de 2f.
2. Verificación de las teclas de flecha hacia arriba y hacia abajo usando **Input.GetKeyDown(KeyCode.UpArrow)** e **Input.GetKeyDown(KeyCode.DownArrow)**.
3. Obtención de la entrada vertical del eje usando **Input.GetAxis("Vertical")** y creación de un vector de movimiento en el eje X con la velocidad multiplicada por la entrada vertical (new Vector3(verticalInput * speed, 0, 0)).
4. Muestra de mensajes por consola indicando el nombre de la flecha presionada ("up" o "down") y la velocidad en el eje X cuando se presionan las teclas de flecha hacia arriba o hacia abajo.
5. Verificación de las teclas de flecha izquierda y derecha usando **Input.GetKeyDown(KeyCode.LeftArrow)** e **Input.GetKeyDown(KeyCode.RightArrow)**.
6. Obtención de la entrada horizontal del eje usando **Input.GetAxis("Horizontal")** y creación de un vector de movimiento en el eje X con la velocidad multiplicada por la entrada horizontal (new Vector3(horizontalInput * speed, 0, 0)).
7. Muestra de mensajes por consola indicando el nombre de la flecha presionada ("left" o "right") y la velocidad en el eje X cuando se presionan las teclas de flecha hacia la izquierda o hacia la derecha.

<br><br>
