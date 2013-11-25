﻿
namespace SteamMobile.Commands
{
    public class Default : Command
    {
        public override string Type { get { return ""; } }

        public override string Format(string type) { return ""; }

        public override void Handle(CommandTarget target, string type, string[] parameters)
        {
            if (target.IsSession || target.IsPrivateChat)
                target.Send("Unknown command.");
        }
    }
}
