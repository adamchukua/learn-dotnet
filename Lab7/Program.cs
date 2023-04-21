using Lab6.Services.CommentData;
using Lab6.Services.LikeData;
using Lab6.Services.PostData;

var builder = WebApplication.CreateBuilder(args);

// AddSingleton is used, because we need ONLY ONE object of data - List
builder.Services.AddSingleton<IPostData, PostData>();
builder.Services.AddSingleton<ICommentData, CommentData>();
builder.Services.AddSingleton<ILikeData, LikeData>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
