using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

// O .NET vai criar os objetos (Inteção e dependencia
//  AddTransiente - O C# cria uma instancia nova, toda vez que um metodo e chamado
// AddScoped - O x# cria uma instancia nova, toda vez que cruar um controller
// AddSingleton 
builder.Services.AddDbContext<EcommerceContext>();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IPagamentoRepository, PagamentoRepository>();
//builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();
//builder.Services.AddTransient<IItemPedidoRepository, IItemPedidoRepository>();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Run();