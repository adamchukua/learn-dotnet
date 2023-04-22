using Lab6.Services.CommentData;
using Lab6.Services.LikeData;
using Lab6.Services.PasswordHasher;
using Lab6.Services.PostData;
using Lab6.Services.UserData;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Lab6.Swagger;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Lab6;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using DocumentFormat.OpenXml.Drawing.Charts;
using Lab6.Services.ApiVersion;

[assembly: Microsoft.AspNetCore.Mvc.ApiController]

var builder = WebApplication.CreateBuilder(args);

// AddSingleton is used, because we need ONLY ONE object of data - List
builder.Services.AddSingleton<IPostData, PostData>();
builder.Services.AddSingleton<ICommentData, CommentData>();
builder.Services.AddSingleton<ILikeData, LikeData>();
builder.Services.AddSingleton<IUserData, UserData>();
builder.Services.AddSingleton<IPasswordHasher, PasswordHasher>();

builder.Services.AddSingleton<IApiVersionData, ApiVersionData>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "ValidIssuer",
            ValidAudience = "ValidAudience",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("IssuerSigningKey"))
        };
    });

builder.Services.AddAuthorization();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    options =>
    {
        // add a custom operation filter which sets default values
        options.OperationFilter<SwaggerDefaultValues>();
        options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    });
builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

builder.Services.AddApiVersioning(
        options =>
        {
            options.ReportApiVersions = true;
        })
    .AddMvc();
// Add ApiExplorer to discover versions
builder.Services.AddVersionedApiExplorer(setup =>
{
    setup.GroupNameFormat = "'v'VVV";
    setup.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                description.GroupName.ToUpperInvariant());
        }
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
