# Proyecto 3D - Práctica 6 (Unity)

##  Descripción
Este proyecto corresponde a la *Práctica 6 de Laboratorio en Unity 3D* donde se introducen conceptos 
de Movimiento Relativo a la Camara (Camera-Relative Movement)
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
	- Se modifico el sistema de movimiento del personaje para que:
		- El input W-A-S-D se interprete segun la orientacion de la camara.
		- El personaje se mueva hacia donde la camara mira.
		- La rotacion del personaje diga la direccion del movimiento.
		- Root Motion continue funcionando correctamente.

