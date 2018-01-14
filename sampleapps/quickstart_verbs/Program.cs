using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandLine;

namespace quickstart_verbs
{
	[Verb("add", HelpText = "Add file contents to the index.")]
	class AddOptions
	{
		//normal options here
	}
	[Verb("commit", HelpText = "Record changes to the repository.")]
	class CommitOptions
	{
		//normal options here
	}
	[Verb("clone", HelpText = "Clone a repository into a new directory.")]
	class CloneOptions
	{
		//normal options here
	}


	class Program
	{
		static int Main(string[] args)
		{
			return CommandLine.Parser.Default.ParseArguments<AddOptions, CommitOptions, CloneOptions>(args)
			  .MapResult(
				(AddOptions opts) => RunAddAndReturnExitCode(opts),
				(CommitOptions opts) => RunCommitAndReturnExitCode(opts),
				(CloneOptions opts) => RunCloneAndReturnExitCode(opts),
				errs => 1);
		}

		static int RunAddAndReturnExitCode(AddOptions opts)
		{
			throw new NotImplementedException();
		}

		private static int RunCommitAndReturnExitCode(CommitOptions opts)
		{
			throw new NotImplementedException();
		}

		private static int RunCloneAndReturnExitCode(CloneOptions opts)
		{
			throw new NotImplementedException();
		}


	}
}
