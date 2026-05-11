using Microsoft.EntityFrameworkCore;
using MiniPMS.Api.Data;
using MiniPMS.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// B1: Dang ky Database Context vao DI Container
var connString = builder.Configuration.GetConnectionString("MiniPMSDb");
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connString));

// B2: Dang ky cac Service
builder.Services.AddScoped<IThemCongViecService, ThemCongViecService>();

// B3: Dang ky Controller va Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// B4: Tu dong tao Database neu chua co
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated(); 
}

// B5: Cau hinh Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();
