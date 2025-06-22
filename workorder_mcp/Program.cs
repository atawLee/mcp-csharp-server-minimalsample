var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddHttpClient(); // �� �� �� �߰�

builder.Services                            // MCP ���� & ���� ���
    .AddMcpServer()
    .WithHttpTransport()                // HTTP ���� �������� ���
    .WithToolsFromAssembly();               // ���� ��������� [McpTool] �˻�


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapMcp();

app.UseAuthorization();

app.MapControllers();

app.Run("http://localhost:5100");
