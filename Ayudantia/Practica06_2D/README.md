# Proyecto 2D - Práctica 6 (Unity)
 
## Descripcion
Este proyecto corresponde a la **Práctica 6 de Ayudantía en Unity 2D**, donde se 
introducen conceptos de Proyectiles, Colisiones Avanzadas y Plataformas
 
## Requisitos 
- Unity Hub instalado.
- Repositorio del curso configurado.
- Spritesheet proporcionado o descargado.
 
## Pasos para ejecutar 
1. Clonar el repositorio:
```bash
git clone <https://github.com/ToprakShakur/Programacion_Videojuegos.git>```
2. Abrir Unity Hub y seleccionar el proyecto de la carpeta
	Programacion_Videojuegos/Ayudantia/Practica06_2D
3. Ejecutar la escena desde el editor 
	Demostracion
	- El personaje esta creado como Prefab con:
	- Sprite Renderer
	- BoxCollider2D
	- Rigidbody2D

	- Se detectan inputs básicos:
		- Movimiento laterales (flechas).
		- Salto (barra espaciadora) = Salto detectado
		- El personaje ahora puede disparar un proyectil con click izquierdo.
	- Con movimiento,frenado progresivo,cambio de direccion suave.
	- Tiene animacion al momemto de caminar y saltar con sus respectivos sonidos.
	- Se crea a un enemigo que hereda de Jugador.
		- El enemigo tiene la capacidad de detectar al Jugador y este puede moverse, si detecta algun obtaculo caminara al lado contrario.
	- La actualizacion se implementa un sistema de disparo para el jugador, colisiones avanzadas con proyectiles (con su sonido respectivo) y plataformas moviles.
	

