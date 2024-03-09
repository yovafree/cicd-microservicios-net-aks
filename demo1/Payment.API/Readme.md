## Actualizar Modelos

dotnet ef dbcontext scaffold "Server=tcp:localhost,1433;Database=Ecommerce;user id=SA;password=_SqLr0ck_" Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Models --context DemoContext --force