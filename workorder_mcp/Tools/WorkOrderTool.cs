using ModelContextProtocol.Server;
using System.ComponentModel;
using System.ServiceModel.Syndication;
using System.Xml;

[McpServerToolType]
public class WorkOrderTool
{
    private readonly HttpClient _http;
    public WorkOrderTool(IHttpClientFactory factory) => _http = factory.CreateClient();

    [McpServerTool(Name = "todayWorkOrder"), Description("오늘의 작업지시를 반환합니다.")]
    public async Task<IEnumerable<WorkOrderDto>> GetWorkOrder()
    {
        var a1 = new WorkOrderDto("P1", 100);
        return [a1];
    }
}
public record WorkOrderDto(string ProductCode, int Count);
