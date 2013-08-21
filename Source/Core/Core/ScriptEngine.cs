using System;

namespace Confluxx.ScriptingToolkit.Core
{
	public class ScriptEngine: IScriptEngine
	{
		public void Execute(Script script)
		{
			if (script == null)
			{
				throw new ArgumentNullException("script");
			}

			script.Execute();
		}
	}
}