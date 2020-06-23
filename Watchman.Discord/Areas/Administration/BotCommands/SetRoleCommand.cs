﻿using System.Collections.Generic;
using Devscord.DiscordFramework.Framework.Commands;
using Devscord.DiscordFramework.Framework.Commands.PropertyAttributes;

namespace Watchman.Discord.Areas.Administration.BotCommands
{
    public class SetRoleCommand : IBotCommand
    {
        [List]
        public List<string> Roles { get; set; }

        [Optional]
        [Bool]
        public bool Safe { get; set; }

        [Optional]
        [Bool]
        public bool Unsafe { get; set; }
    }
}
