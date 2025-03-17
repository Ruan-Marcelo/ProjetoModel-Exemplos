var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Usuario}/{action=ExibirUsuario}");


//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Curso}/{action=ExibirCurso}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Pessoa}/{action=ExibirCafeteria}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Jogos}/{action=ExibirJogo}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Pessoa}/{action=ExibirListaPessoa}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
