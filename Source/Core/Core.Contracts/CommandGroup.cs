using System.Collections.Generic;

namespace Confluxx.ScriptingToolkit.Core
{
	public class CommandGroup: Command
	{
		public List<Command> Commands { get; set; }
 
		public CommandGroup()
		{
			this.Commands = new List<Command>();
		}

		public override void Execute()
		{
			foreach (var command in this.Commands)
			{
				command.Execute();
			}
		}
	}
}