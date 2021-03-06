﻿using VRage.Game.ModAPI.Interfaces;
using VRage.ModAPI;

namespace Sandbox.Game.Entities
{
    public partial class MyShipController
    {
        IMyEntity VRage.Game.ModAPI.Interfaces.IMyControllableEntity.Entity
        {
            get { return Entity; }
        }

        void VRage.Game.ModAPI.Interfaces.IMyControllableEntity.DrawHud(IMyCameraController camera, long playerId)
        {
                DrawHud(camera, playerId);
        }
    }
}
