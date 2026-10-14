# Proyecto 3D - Práctica 5 (Unity)

##  Descripción
Este proyecto corresponde a la *Práctica 5 de Laboratorio en Unity 3D* donde se introducen conceptos 
de Camara TPS Avanzada (Orbit, Follow, Collision)
Se descargo un modelo 3D y animaciones para poder unir y modificar.

##  Requisitos
- Unity Hub instalado.
- Editor de Unity 
- Repositorio del alumno configurado.

##  Pasos para ejecutar
1. Clonar el repositorio:
   ```bash
   git clone https://github.com/ToprakShakur/Programacion_Videojuegos.git ```
2. Abrir Unity Hub y seleccionar el proyecto de la carpeta
	Laboratorio/Practica05_3D
3. Ejecutar la escena desde el editor El proposito de la practica es introducir los 
	Fundamentos de Animacion de Personaje. 
	- El objeto PlayerBody podra activar las animaciones mediante Root Motion.
		- Idle -> Walk -> Run
		- Idle -> Jump
	- Se implmento un sistema de camara en tercera persona que permite seguir al personaje suavemente, rotal alrededor del personaje, ajustar sensibilidad y limites verticales y evitar atravesar paredes mediante colision de camara.
