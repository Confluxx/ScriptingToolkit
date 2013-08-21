namespace Confluxx.ScriptingToolkit.Core.TestCommands
{
	public class CountCommand: Command
	{
		public int ExecutionCount { get; protected set; }

		public override void Execute()
		{
			ExecutionCount++;
		}
	}
}