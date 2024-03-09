# CI/CD con Microservicios en .NET y Azure Kubernetes Services

En esta demo podrá encontrar los archivos necesarios para desplegar una infraestructura con AKS, desplegar los microservicios de la solución y generar su proceso CI/CD para automatizar la integración y el despliegue.

## Pasos

1) Ir a la carpeta infrastructure/Terraform
2) Seguir las instrucciones del archivo Readme.md

Luego de tener la infraestructura disponible, realizar los despliegues de aplicaciones en el cluster. 
Utilizando los archivos de la carpeta Kubernetes

## NOTA:
La demo utiliza una aplicación de demostración, la cual encontrará en el repositorio: 

https://github.com/yovafree/order-system-demo

## ** Conocimientos previos para conocer el proyecto: **  
* C#
* Conocimientos básicos de programación orientada a objetos
* Conocimientos básicos de Docker

# Arquitectura y comunicación del proyecto

![image info](./img/arquitectura.png)

# Obtener credenciales
az aks get-credentials --resource-group demo --name demo-aks1
