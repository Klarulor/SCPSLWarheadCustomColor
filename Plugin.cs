using System.Linq;
using Exiled.API.Enums;
using Exiled.API.Features;

namespace WarheadCustomColor
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        internal EventHandlers EventHandlers = new EventHandlers();
        public override PluginPriority Priority { get; } = PluginPriority.Last;
        public Plugin() => Instance = this;
        public string PluginName => typeof(Plugin).Namespace;
        public override void OnEnabled()
        {
            RegisterEvents(); 
            Log.Info($"Plugin {PluginName} started");
        }
        public override void OnDisabled() => UnregisterEvents();
        private void RegisterEvents()
        {
            Exiled.Events.Handlers.Server.WaitingForPlayers += EventHandlers.OnWaitingForPlayers;
            Exiled.Events.Handlers.Warhead.Detonated += EventHandlers.OnDetonated;
            Exiled.Events.Handlers.Warhead.Starting += EventHandlers.OnWarheadStarting;
            Exiled.Events.Handlers.Warhead.Stopping += EventHandlers.OnWarheadStopping;
            Exiled.Events.Handlers.Player.Shooting += (ev => Log.Info(Room.List.ToArray()[0].Color));
        }
        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Server.WaitingForPlayers -= EventHandlers.OnWaitingForPlayers;
            Exiled.Events.Handlers.Warhead.Detonated -= EventHandlers.OnDetonated;
            Exiled.Events.Handlers.Warhead.Starting -= EventHandlers.OnWarheadStarting;
            Exiled.Events.Handlers.Warhead.Stopping -= EventHandlers.OnWarheadStopping;
        }
    }
}
