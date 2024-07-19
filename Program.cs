
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto Web - Lh Pets versão 1.0.0");	

app.UseStaticFiles();
app.MapGet("/index",(HttpContext http) => {contexto.Redirect("/index.html",false);});

Banco banco = new Banco();
app.MapGet("/Lista", (HttpContext http) => {
    contexto.Response.WriteAsync(banco.GetListaString());
});
app.Run();
