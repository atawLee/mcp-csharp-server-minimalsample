var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddHttpClient(); // ← 이 줄 추가

builder.Services                            // MCP 서버 & 도구 등록
    .AddMcpServer()
    .WithHttpTransport()                // HTTP 전송 프로토콜 사용
    .WithToolsFromAssembly();               // 현재 어셈블리에서 [McpTool] 검색


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
