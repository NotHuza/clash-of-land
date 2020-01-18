/*using System;
using Discord;
using Discord.WebSocket;
using ClashLand.Extensions;

namespace Magic.ClashOfClans.Core.API.Discord
{
    internal static class Client
    {
        internal static DiscordSocketClient _Client;
        internal static CommandHandler CommandHandler;

        internal static async void Initialize()
        {
            try
            {
                _Client = new DiscordSocketClient(
                    new DiscordSocketConfig
                    {
                        LogLevel = LogSeverity.Error,
                    });

                CommandHandler = new CommandHandler();
                CommandHandler.InstallAsync(_Client).Wait();

                await _Client.LoginAsync(TokenType.Bot, Constants.DiscordToken);
                await _Client.StartAsync();
                await _Client.SetGameAsync("Waiting for Status request");
            }
            catch (Exception ex)
            {
                ExceptionLogger.Log(ex, "Failed to connect to the Discord API server.");
            }
        }
        internal static async void Deinitialize()
        {
            try
            {
                await _Client.LogoutAsync();
                await _Client.StopAsync();
            }
            catch (Exception ex)
            {
                ExceptionLogger.Log(ex, "Failed to diconnect from the Discord API server.");
            }
        }
    }
}*/