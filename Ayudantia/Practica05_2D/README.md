# Proyecto 2D - Práctica 5 (Unity)
 
## Descripcion
Este proyecto corresponde a la **Práctica 5 de Ayudantía en Unity 2D**, donde se 
introducen conceptos de Enemigos, Patrullaje por Colision e Inteligencia Artificial Basica con Herencia.
 
## Requisitos 
- Unity Hub instalado.
- Repositorio del curso configurado.
- Spritesheet proporcionado o descargado.
 
## Pasos para ejecutar 
1. Clonar el repositorio:
```bash
git clone <https://github.com/ToprakShakur/Programacion_Videojuegos.git>```
2. Abrir Unity Hub y seleccionar el proyecto de la carpeta
	Programacion_Videojuegos/Ayudantia/Practica05_2D
3. Ejecutar la escena desde el editor 
	Demostracion
	- El personaje esta creado como Prefab con:
	- Sprite Renderer
	- BoxCollider2D
	- Rigidbody2D

	- Se detectan inputs básicos:
		- Movimiento laterales (flechas).
		- Salto (barra espaciadora) = Salto detectado
	- Con movimiento,frenado progresivo,cambio de direccion suave.
	- Tiene animacion al momemto de caminar y saltar con sus respectivos sonidos.
	- La actualizacion se crea a un enemigo que hereda de Jugador.
		- El enemigo tiene la capacidad de detectar al Jugador y este puede moverse, si detecta algun obtaculo caminara al lado contrario.
	

