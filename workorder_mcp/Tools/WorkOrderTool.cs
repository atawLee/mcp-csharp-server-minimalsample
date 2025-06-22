using ModelContextProtocol.Server;
using System.ComponentModel;
using System.ServiceModel.Syndication;
using System.Xml;

[McpServerToolType]
public class WorkOrderTool
{
    private readonly HttpClient _http;
    public WorkOrderTool(IHttpClientFactory factory) => _http = factory.CreateClient();

    [McpServerTool(Name = "todayWorkOrder"), Description("������ �۾����ø� ��ȯ�մϴ�.")]
    public async Task<IEnumerable<WorkOrderDto>> GetWorkOrder()
    {
        var a1 = new WorkOrderDto("P1", 100);
        return [a1];
    }
}
public record WorkOrderDto(string ProductCode, int Count);
