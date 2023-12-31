using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //added service which is MVC 
var app = builder.Build(); // this service is building 

// MVS  ; added servce of this
// Rest API ; we will add  different services for rest api
// Razor pages  ; we eill add different service for razor pages

//app.MapGet("/", () => "Hello World!");
//app.MapGet("/yaz", () => "alperen");    --> alperen yazacakt�r /yaz �a��r�ld��� zaman 

//app.MapDefaultControllerRoute();   //  yani �u �emay� kullan demek. --> {Controller=Home}/{Action=Index}/�d?

app.MapControllerRoute(
    name:"Defaullt",                           // elle yazmak istersek de  pattern i falan manuel yaz�yoruz.
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run(); // and running 
