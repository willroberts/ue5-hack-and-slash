// ? 2023 Will Roberts

using UnrealBuildTool;
using System.Collections.Generic;

public class HackAndSlash_UE5Target : TargetRules
{
	public HackAndSlash_UE5Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "HackAndSlash_UE5" } );
	}
}
