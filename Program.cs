using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //added service which is MVC 
var app = builder.Build(); // this service is building 

// MVS  ; added servce of this
// Rest API ; we will add  different services for rest api
// Razor pages  ; we eill add different service for razor pages

//app.MapGet("/", () => "Hello World!");
//app.MapGet("/yaz", () => "alperen");    --> alperen yazacaktýr /yaz çaðýrýldýðý zaman 

//app.MapDefaultControllerRoute();   //  yani þu þemayý kullan demek. --> {Controller=Home}/{Action=Index}/Ýd?

app.MapControllerRoute(
    name:"Defaullt",                           // elle yazmak istersek de  pattern i falan manuel yazýyoruz.
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run(); // and running 
