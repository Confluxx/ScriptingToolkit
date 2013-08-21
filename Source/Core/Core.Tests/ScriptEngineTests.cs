using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Confluxx.ScriptingToolkit.Core.TestCommands;
namespace Confluxx.ScriptingToolkit.Core
{
	[TestClass]
	public class ScriptEngineTests
	{
		private IScriptEngine sut;

		[TestInitialize]
		public void Initialize()
		{
			sut = new ScriptEngine();
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Execute_ScriptIsNull()
		{
			sut.Execute(null);
		}

		[TestMethod]
		public void Execute_EmptyScript()
		{
			sut.Execute(new Script());
		}

		[TestMethod]
		public void Execute_OneCountCommand()
		{
			var command = new CountCommand();
			sut.Execute(new Script
							{
								Commands = { command }
							});

			Assert.AreEqual(1, command.ExecutionCount);
		}

		[TestMethod]
		public void Execute_FourCountCommands()
		{
			var command = new CountCommand();
			sut.Execute(new Script
			{
				Commands = { command, command, command, command }
			});

			Assert.AreEqual(4, command.ExecutionCount);
		}
	}
}