# Tarjetas
modulo Arquitectura de software

## Descripcion del problema
Sistema donde se puede hacer recargas de montos en dolares a una determinada tarjetas.
Cada tarjeta tiene un codigo único, a traves de este se hace las recargas.
Un cliente puede comprar muchas tarjetas.

Tarjetas recargables (juegos electronicos) a un determinado codigo de tarjeta a aumentar el saldo.

##### Proyecto desarrollado con tecnologia .Net.
Herramientas utilizadas:
 * visual studio
 * Sql Server
 

##### El proyecto esta dividido:
* Core: proyecto librerira donde se encuentra las clases entidades, interfaces y los value object.
* Infraestructure: proyecto libreria que maneja la persistencia de datos con el patron repositorio.
* Api: proyecto web que interectua como api utilizando las dos anteriores librerias

##### Instrucciones de ejecucion.
```
 * clone el repositorio
 * utilice visual studio para abrir el proyecto
 * ejecute proyecto API
 * corra los script que se encuentran en el directorio root /script-base-dato en sql sever 
```
