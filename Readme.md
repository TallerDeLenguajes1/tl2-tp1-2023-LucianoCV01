# TP01 - Cosentino Luciano
## Ejercicio 2.a
- ¿Cuál de estas relaciones considera que se realiza por composición y cuál por agregación?

Por composición, la relación entre Cliente y Pedido, el cliente es parte del Pedido.
Por agregación, la relación entre Pedido y Cadete, el cadete tiene un pedido y también la relación entre Cadete y Cadetería, la cadetería tiene un cadete.

- ¿Qué métodos considera que debería tener la clase Cadetería y la clase Cadete?

Cadete: agregarPedido, buscarPedido.
Cadeteria: crearPedido.

- Teniendo en cuenta los principios de abstracción y ocultamiento, que atributos, propiedades y métodos deberían ser públicos y cuáles privados.

Todos los atributos serían privados.

- ¿Cómo diseñaría los constructores de cada una de las clases?

Con sobrecarga de datos.

- ¿Se le ocurre otra forma que podría haberse realizado el diseño de clases?    

Crear una relación de agregación entre cliente y pedido.