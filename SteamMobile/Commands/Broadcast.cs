﻿
namespace SteamMobile.Commands
{
    public class Broadcast : Command
    {
        public override string Type { get { return "broadcast"; } }

        public override string Format(string type) { return "]"; }

        public override void Handle(CommandTarget target, string type, string[] parameters)
        {
            if (!Util.IsSuperAdmin(target) || parameters.Length < 1)
                return;

            Program.RoomManager.Broadcast("Broadcast: " + parameters[0]);
        }
    }
}
