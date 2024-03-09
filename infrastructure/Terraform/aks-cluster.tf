provider "azurerm" {
  features {}
}

resource "azurerm_resource_group" "default" {
  name     = "demo"
  location = "West Europe"
}

resource "azurerm_kubernetes_cluster" "default" {
  name                = "demo-aks1"
  location            = azurerm_resource_group.default.location
  resource_group_name = azurerm_resource_group.default.name
  dns_prefix          = "demoaks1"

  default_node_pool {
    name       = "default"
    node_count = 3
    vm_size    = "Standard_D2_v2"
  }

  identity {
    type = "SystemAssigned"
  }

  tags = {
    Environment = "Production"
  }
}

output "client_certificate" {
  value     = azurerm_kubernetes_cluster.default.kube_config[0].client_certificate
  sensitive = true
}

output "kube_config" {
  value = azurerm_kubernetes_cluster.default.kube_config_raw

  sensitive = true
}