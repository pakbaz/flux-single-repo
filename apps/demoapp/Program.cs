var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync( $"Environment:{Environment.NewLine}");
                    await context.Response.WriteAsync( $"----------------------------------------------{Environment.NewLine}");
                    await context.Response.WriteAsync( $"OS Version: {Environment.OSVersion} {Environment.NewLine}");
                    await context.Response.WriteAsync( $"Machine Name: {Environment.MachineName} {Environment.NewLine}");
                    await context.Response.WriteAsync( $"Current Directory: {Environment.CurrentDirectory} {Environment.NewLine}");
                    await context.Response.WriteAsync( $"Process Path, ID and Count: {Environment.ProcessPath} | {Environment.ProcessId} | {Environment.ProcessorCount} {Environment.NewLine}");
                    await context.Response.WriteAsync( $"Managed Thread ID: {Environment.CurrentManagedThreadId} {Environment.NewLine}");
                    await context.Response.WriteAsync( $"User Domain Name: {Environment.UserDomainName} {Environment.NewLine}");
                    await context.Response.WriteAsync( $"System Start Up Time: {Environment.TickCount64} {Environment.NewLine}");
                    await context.Response.WriteAsync( $"NET CLI Version: {Environment.Version} {Environment.NewLine}");
                    await context.Response.WriteAsync( Environment.NewLine );
                    await context.Response.WriteAsync( Environment.NewLine );
                    await context.Response.WriteAsync( Environment.NewLine );

                    await context.Response.WriteAsync($"Host and Client Information:{Environment.NewLine}");
                    await context.Response.WriteAsync($"----------------------------------------------{Environment.NewLine}");
                    await context.Response.WriteAsync($"Request Host Information: {context.Request.Host} {Environment.NewLine}");
                    await context.Response.WriteAsync($"Server IP Address and Port: {context.Connection.LocalIpAddress} : {context.Connection.LocalPort} {Environment.NewLine}");
                    await context.Response.WriteAsync($"Client IP address and Port: {context.Connection.RemoteIpAddress} : {context.Connection.RemotePort} {Environment.NewLine}");
                    await context.Response.WriteAsync($"Client Certificate: {context.Connection.ClientCertificate} {Environment.NewLine}");
                    await context.Response.WriteAsync(Environment.NewLine);
                    await context.Response.WriteAsync(Environment.NewLine);

                    await context.Response.WriteAsync($"Stack Trace:{Environment.NewLine}");
                    await context.Response.WriteAsync($"----------------------------------------------{Environment.NewLine}");
                    await context.Response.WriteAsync($"{Environment.StackTrace} {Environment.NewLine}");
                });
app.Run();
