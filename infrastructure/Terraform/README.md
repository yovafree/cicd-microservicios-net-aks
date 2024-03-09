# IaC para clúster de Azure Kubernetes Service

Crear credenciales con Azure CLI, se necesitarán para la creación del cluster.

```
az ad sp create-for-rbac --skip-assignment
```

Ejemplo de salida:
```
{
  "appId": "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
  "displayName": "azure-cli-2019-04-11-00-46-05",
  "name": "http://azure-cli-2019-04-11-00-46-05",
  "password": "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
  "tenant": "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"
}
```

Levantar infraestructura como código, primero se inicializan los módulos de terraform con:

```
terraform init
```

Para verificar la configuración de la IaC se recomienda generar el "plan" antes de realizar el despliegue:
```
terraform plan
```

Se aplica la infraestructura deseada, terraform emplezará a realizar el despliegue y aprovisionamiento de infraestructura:
```
terraform apply
```

### Obtener el Kube Config del clúster, permitirá realizar los despliegues en AKS
```
az aks get-credentials --resource-group $(terraform output -raw resource_group_name) --name $(terraform output -raw kubernetes_cluster_name)
```

### Destruir infraestructura

```
terraform destroy
```