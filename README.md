# Práctica 2: Introducción a los scripts en Unity

Autor: David Arteaga Sánchez

## Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo

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

Al no contar con físicas el cubo se quedara flotando igual que antes

![Error](/images/CubeIsTriggerNoPhysics.png)


