using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using myfirstapi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    //opt.SaveToken = true;
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidIssuer = "http://localhost:7168/",
        ValidAudience = "http://localhost:7168/",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bunagöresifrele")),
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});


//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//}). 
//    AddJwtBearer(opt =>
//    {
//        opt.TokenValidationParameters = new TokenValidationParameters
//        {
//            ValidIssuer = builder.Configuration["Jwt:Issuer"],
//            ValidAudience = builder.Configuration["Jwt:Audience"],
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
//            ValidateIssuer = true,
//            ValidateAudience = true,
//            ValidateLifetime = false,
//            ValidateIssuerSigningKey = true
//        };
//    });

//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("Admin", policy =>
//        policy.RequireAssertion(context =>
//        {
//            bool isApiUserFullAccess = context.User.HasClaim(c => c.Type == "ApiAccess" && c.Value == "FullAccess");
//            bool isAdmin = context.User.IsInRole("ADMIN_ROLE");
//            return isAdmin || isApiUserFullAccess;
//        })
//    );
//});

//var Issuer = builder.Configuration["JWTConfiguration:Issuer"];
//var Audience = builder.Configuration["JWTConfiguration:Audience"];
//var SigningKey = builder.Configuration["JWTConfiguration:SigningKey"];

//builder.Services.AddAuthentication(auth =>
//{
//    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//    auth.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//}).
//    AddJwtBearer(opt =>
//    {
//        opt.Audience = "api://local-unit-test";
//        opt.RequireHttpsMetadata = false;
//        opt.SaveToken = true;
//        opt.TokenValidationParameters = new TokenValidationParameters()
//        {
//            ValidateIssuer = true,
//            ValidIssuer = "Issuer",
//            ValidateAudience = true,
//            ValidAudience = "Audience",
//            ValidateIssuerSigningKey = true,
//            ValidateLifetime = true,
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("12345@4321"))
//        };
//    });

//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("adminara",
//         policy => policy.RequireRole("Admin"));
//});

//------------------------------------------------------------

//var Issuer = builder.Configuration["JwtConfig:Issuer"];
//var Audience = builder.Configuration["JwtConfig:Audience"];
//var SigningKey = builder.Configuration["JwtConfig:SigningKey"];

//builder.Services.AddAuthentication(auth =>
//{
//    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).
//    AddJwtBearer(opt =>
//    {
//        opt.SaveToken = true;
//        opt.TokenValidationParameters = new TokenValidationParameters()
//        {
//            ValidateIssuer = true,
//            ValidIssuer = Issuer,
//           //ValidIssuers = "issuerdeðeri",
//            ValidateAudience = true,
//            ValidAudience = Audience,
//            ValidateIssuerSigningKey = true,
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SigningKey))
//        };
//    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication(); // Önce olmasý önemli
app.UseAuthorization();

app.UseStatusCodePages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

