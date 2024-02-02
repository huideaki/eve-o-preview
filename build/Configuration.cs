﻿namespace Build
{
	static class Configuration
	{
		public const string SolutionName = @"./src/EVE-O-Preview.sln";

		public const string BinFolder = @"./bin";
		public const string ToolsFolder = @"./tools";
		public const string PublishFolder = @"./publish";
		public const string BuildConfiguration = @"Release";

		public const string BuildToolPath = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools\MSBuild\Current\Bin\MSBuild.exe"; // Set to NULL to let Cake to try to use the default MSBuild instance
	}
}
