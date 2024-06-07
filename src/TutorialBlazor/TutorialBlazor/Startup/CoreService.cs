namespace TutorialBlazor.Startup;

public static class CoreService
{
    /// <summary>
    /// 加入核心服務
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        #region 加入支援 Web API 的註冊 & 支援 Swagger
        services.AddConnections();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        #endregion

        #region 加入支援 Razor 元件與互動式的 Server SSR
        services.AddRazorComponents()
            .AddInteractiveServerComponents();
        #endregion
       
        return services;
    }
}
