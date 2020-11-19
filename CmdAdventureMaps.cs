//	Auto-generated command skeleton class.
//	Use this as a basis for custom MCGalaxy commands.
//	File and class should be named a specific way. For example, /update is named 'CmdUpdate.cs' for the file, and 'CmdUpdate' for the class.
// As a note, MCGalaxy is designed for .NET 4.0

// To reference other assemblies, put a "Reference [assembly filename]" at the top of the file
//   e.g. to reference the System.Data assembly, put "Reference System.Data.dll"

// Add any other using statements you need after this
using System;

namespace MCGalaxy 
{
	public class CmdAdventureMaps : Command
	{
		// The command's name (what you put after a slash to use this command)
		public override string name { get { return "AdventureMaps"; } }

		// Command's shortcut (please take care not to use an existing one, or you may have issues.)
		public override string shortcut { get { return "ADM"; } }

		// Determines which submenu this command displays in under /Help.
		public override string type { get { return "world"; } }

		// Determines whether or not this command can be used in a museum. Block/map altering commands should be made false to avoid errors.
		public override bool museumUsable { get { return false; } }

		// Determines the default rank required to use this command. Valid values are:
		// LevelPermission.Nobody, LevelPermission.Banned, LevelPermission.Guest
		// LevelPermission.Builder, LevelPermission.AdvBuilder, LevelPermission.Operator, LevelPermission.Admin
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }

		// This is where the magic happens, naturally.
		// p is the player object for the player executing the command. message is everything after the command invocation itself.
		public override void Use(Player p, string message)
		{
			p.Message("Some Adventure Maps We Currently Have are "Lyso (/g lyso) and currently working on LightOut which will be released to play soon!");
		}

		// This one controls what happens when you use /Help [commandname].
		public override void Help(Player p)
		{
			p.Message("/AdventureMaps - %eShows The Current Adventure Maps You can play!");
		}
	}
}
