// ? 2023 Will Roberts

using UnrealBuildTool;
using System.Collections.Generic;

public class HackAndSlash_UE5EditorTarget : TargetRules
{
	public HackAndSlash_UE5EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "HackAndSlash_UE5" } );
	}
}
