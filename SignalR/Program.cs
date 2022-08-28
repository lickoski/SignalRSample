using Microsoft.AspNetCore.Mvc;
using SignalR.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddSignalR();

builder.Services.Configure<MvcOptions>(opts => opts.EnableEndpointRouting = false);
var app = builder.Build();

app.MapHub<MessageHub>("/messages");

app.UseStaticFiles();
app.UseMvc();


app.Run();

