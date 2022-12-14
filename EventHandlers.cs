using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using UnityEngine;

namespace WarheadCustomColor
{
    internal class EventHandlers
    {
        private readonly Color _baseColor = new Color(1f, 1f, 1f, 1f);
        internal void OnWaitingForPlayers()
        {
            
        }

        internal void OnDetonated()
        {
            if (Plugin.Instance.Config.WarheadBlackoutDelay > 0)
                Map.TurnOffAllLights(Plugin.Instance.Config.WarheadBlackoutDelay, ZoneType.Surface);
        }

        internal void OnWarheadStarting(StartingEventArgs ev)
        {
            Color targetColor = (Vector4)Plugin.Instance.Config.WarheadColor / Plugin.Instance.Config.DivideValue;
            foreach (var room in Room.List)
            {
                room.Color = targetColor;
                room.LightIntensity = Plugin.Instance.Config.LightIntensity;
            }
        }

        internal void OnWarheadStopping(StoppingEventArgs ev)
        {
            foreach (var room in Room.List)
                room.Color = _baseColor;
        }
    }
}
