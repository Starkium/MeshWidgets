
using UnrealBuildTool;
using System.Collections.Generic;

public class MeshWidgetsTarget : TargetRules
{
	public MeshWidgetsTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
        Type = TargetType.Game;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;

		ExtraModuleNames.AddRange( new string[] { "MeshWidgets" } );
	}
}
