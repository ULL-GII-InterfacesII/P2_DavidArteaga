# Práctica 2: Introducción a los scripts en Unity

Autor: David Arteaga Sánchez

## 1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo

### Ninguno de los objetos será físico

![Error](/images/NoPhysics.png)

Tan solo debemos insertar los objetos con el plano, como podemos ver ninguno reacciona a las físicas del motor por lo que se quedan flotando en el aire.

### La esfera tiene físicas, el cubo no

![Error](/images/SphereWithPhysics.png)

Como se puede apreciar en la imagen esta vez la esfera sí se ve afectada por la gravedad, cayendo al plano por su propio peso.

### La esfera y el cubo tienen físicas 

![Error](/images/BothWithPhysics.png)

Al tener ambos físicas se caen por su propio peso

### La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo

Para aumentar la masa incrementamos el valor de la variable Mass del Component RigidBody en el inspector de objetos

![Error](/images/SphereMass.png)

### La esfera tiene físicas y el cubo es de tipo IsTrigger

Para convertir al cubo en tipo IsTrigger seleccionamos la casilla del Component BoxCollider que encontraremos también en el inspector de objetos

![Error](/images/CubeIsTrigger.png)

Al no contar con físicas el cubo se quedara flotando igual que antes:

![Error](/images/CubeIsTriggerWithNoPhysics.png)

### La esfera tiene físicas, el cubo es de tipo IsTrigger y tiene físicas

![Error](/images/CubeIsTriggerWithPhysics.gif)

Como podemos apreciar al aplicar físicas al cubo de tipo IsTrigger este cae porque se le aplica la fuerza de la gravedad, sin embargo no colisiona 
con ningún objeto en su recorrido.

### La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ

Para poder aplicar restriccciones a la rotación de un objeto accedemos al Component RigidBody desde el inspector de objetos como hemos hecho anteriormente 
y en la sección `constraints` marcamos las casillas correspondientes.

![Error](/images/FreezeRotation.png)

El resultado será este: 

![Error](/images/CubeRotationFreezed.gif)

El cubo cae y colisiona en el plano sin embargo al no poder rotar en el plano XZ este se queda quieto sobre su esquina.

## 2. Sobre la escena que has trabajado ubica un cubo que represente un personaje que vas a mover. Se debe implementar un script que haga de CharacterController. Cuando el jugador pulse las teclas de flecha (o aswd) el jugador se moverá en la dirección que estos ejes indican. 

### Crear un script para el personaje que lo desplace por la pantalla, sin aplicar simulación física

![Error](/images/PlayerControllerScript.png)

Debido a que el jugador no cuenta con físicas, Utilizamos el Transform del gameObject del jugador para moverlo por la escena

### Agregar un campo público que permita graduar la velocidad del movimiento desde el inspector de objetos

![Error](/images/PlayerSpeed.png)

## 3. Sobre la escena que has trabajado programa los scripts necesarios para las siguientes acciones:

### Se deben incluir varias esferas sobre la escena. Cada vez que el objeto jugador colisione con una esfera se debe cambiar su color, y si se trata de una esfera de tipo A, y se pulsa la barra espaciadora el jugador impulsa la esfera hacia fuera de él. 

![Error](/images/SphereScript.png)

Primero crearemos el script que asociaremos a todas las esferas, este debe hacer que el gameObject al que esté asociado cambie de color cuando el jugador colisione. Para ello usaremos la función `OnTriggerEnter(Collider other)`. 
Una vez llamada a la función debemos comprobar que el objeto que haya colisionado sea el jugador. Utilizamos su tag para compararlo.

El enunciado también nos pide que si una esfera es tipo A pueda ser empujada por el jugador pulsando el espacio, así que crearemos un nuevo tag `SphereA` y utilizaremos la función OnTriggerStay(), comprobamos que el tag 
del objeto que colisiona sea "Player" y el del objeto que tiene el script asociado sea "SphereA" y calculamos la dirección a la que debe moverse la esfera. 

![Error](/images/SphereChangingColor.gif)

### Se deben incluir cilindros que se alejen del jugador cuando esté próximo. 

![Error](/images/CylinderScript.png)

Aquí simplemente debemos comprobar si el objeto con el tag "Jugador" se encuentra más cerca que una distancia mínima (que hemos inicializado en una variable y podemos cambiar en el inspector), si lo está, aplicamos una 
fuerza con la función AddForce() en la dirección calculada.

![Error](/images/CylinderScript.gif)

### Ubicar un tercer objeto que sea capaz de detectar colisiones y que se mueva con las teclas: I, L, J, M 

Primero deberemos crear nuevas entradas en el Input Manager, las llamaremos `Horizontal-IJ` y `Vertical-IM` y crearemos un script similar al del primer player

![Error](/images/SecondPlayerControllerScript.png)

### Debes ubicar cubos que que aumentan de tamaño cuando se le acerca una esfera y que disminuye cuando se le acerca el jugador. 

![Error](/images/ExpandScript.png)

Igual que con los cilindros, comprobamos que los objetos correspondientes se encuentren a la distancia mínima establecida y si es así utilizamos la variable Transform.localScale para modificar su tamaño según un 
parámetro que podemos modificar en el inspector de objetos.

![Error](/images/CubeIncreasing.gif)

![Error](/images/CubeReducing.gif)










