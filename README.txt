README
-----------


Demostración de Conocimiento de Desarrollo ASP.NET con C#, MVC, WebAPI y AngularJS.

Archivos Importantes:

/Views/Shared/_Layout.cshtml: Plantilla maestra, junto con /Views/Home/Index.cshtml (vacia).
/Lib: repositorio de bower (angular, jquery, etc...)
/App_Js: aplicacion angular JS que interactua con la WebAPI local
/Controllers/
  - ArticlesConttroller: Controlador para Artículos
  - StoresConttroller: Controlador para Tiendas
/Exceptions: Excepciones de Aplicacion
/Results: Clases contenedoras de los resultados, y errores
/ActionFilters: Filtros para Manejo de Errores y Autenticación Básica.

Migraciones

La aplicacion utiliza el sistema de migraciones nativo de .NET, que es muy basico.
Basta ejecutar la aplicacion para que la base de datos se construya. 
Para insertar los datos se debe ejecutar el comando

PM>Update-Database

En la consola de administracion de Paquetes Nuget.

La aplicación hace uso de una base de datos SQL Server 2015, aunque no descarto que se pueda 
adaptar a algo mas portable, asi es como lo he hecho durante mucho tiempo.