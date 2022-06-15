using aspnetserver.Data;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Set up CORS Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder.AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:3000", "https://tylers-react-music-library.netlify.app");
    });
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(swaggerGenOptions =>
{
    swaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo
    { Title = "Music portfolio web API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(swaggerUiOptions =>
{
    swaggerUiOptions.DocumentTitle = "Music Portfolio Web API";
    swaggerUiOptions.SwaggerEndpoint("/swagger/v1/swagger.json", "Music Portfolio Web API");
    swaggerUiOptions.RoutePrefix = String.Empty;
});

app.UseHttpsRedirection();

app.UseCors("CORSPolicy");

app.MapGet("/get-all-songs", async () => await SongsRepository.GetSongsAsync())
    .WithTags("Songs Endpoint");

app.MapGet("/get-song-by-id/{songId}", async (int songId) =>
{
    Song songToReturn = await SongsRepository.GetSongsByIdAsync(songId);
    if (songToReturn != null)
    {
        return Results.Ok(songToReturn);
    }
    else return Results.BadRequest();
}).WithTags("Songs Endpoint");

app.MapPost("/create-song", async (Song songToCreate) =>
{
    bool createSuccesful = await SongsRepository.CreateSongAsync(songToCreate);

    if (createSuccesful)
    {
        return Results.Ok("Create Successful");
    }
    else return Results.BadRequest();
}).WithTags("Songs Endpoint");

app.MapPut("/update-song", async (Song songToUpdate) =>
{
    bool updateSuccesful = await SongsRepository.UpdateSongAsync(songToUpdate);

    if (updateSuccesful)
    {
        return Results.Ok("Update Successful");
    }
    else return Results.BadRequest();
}).WithTags("Songs Endpoint");

app.MapDelete("/delete-song-by-id/{songId}", async (int songId) =>
{
    bool deleteSuccesful = await SongsRepository.DeleteSongAsync(songId);

    if (deleteSuccesful)
    {
        return Results.Ok("Delete Successful");
    }
    else return Results.BadRequest();
}).WithTags("Songs Endpoint");

app.Run();
