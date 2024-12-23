var builder = WebApplication.CreateBuilder(args);

//Add Service to the container.
builder.Services.AddCatalogModule(builder.Configuration).
    AddBasketModule(builder.Configuration).AddOrderingModule(builder.Configuration);


var app = builder.Build();

//Configure the HTTP request pipeline.

app.UseCatalogModule();
app.UseOrderingModule();
app.UseBasketModule();


app.Run();
