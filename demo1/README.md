# Order System Demo

Es un conjunto de microservicios que emulan un sistema de ordenes y envío de notificaciones entre Backend y Frontend. Implementa componentes de Logging distribuido y gestor de colas por medio de Rabbit MQ

## **Conocimientos previos**  
* C#
* Conocimientos básicos de programación orientada a objetos
* Conocimientos básicos de Docker

# Arquitectura

![image info](./img/arquitectura.png)

# Compilar imagenes
```
docker build -t yovafree/demo-system-order:frontend2.0 .
docker build -t yovafree/demo-system-order:notifications2.0 .
docker build -t yovafree/demo-system-order:order2.0 .
docker build -t yovafree/demo-system-order:payment2.0 .
```

# Subir imagenes
```
docker push yovafree/demo-system-order:frontend2.0
docker push yovafree/demo-system-order:notifications2.0
docker push yovafree/demo-system-order:order2.0
docker push yovafree/demo-system-order:payment2.0
```