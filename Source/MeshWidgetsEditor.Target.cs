
using UnrealBuildTool;
using System.Collections.Generic;

public class MeshWidgetsEditorTarget : TargetRules
{
	public MeshWidgetsEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
        Type = TargetType.Editor;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;

		ExtraModuleNames.AddRange( new string[] { "MeshWidgets" } );
	}
}
