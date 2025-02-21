using UnrealBuildTool;

public class MeshWidgets : ModuleRules
{
	public MeshWidgets(ReadOnlyTargetRules Target) : base(Target)
	{
        bEnforceIWYU = true;

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        MinFilesUsingPrecompiledHeaderOverride = 1;
        bFasterWithoutUnity = true;

        PublicDependencyModuleNames.AddRange(
            new string[] {
                "Core",
                "CoreUObject",
                "Engine",
                "InputCore",
                "UnrealEd",
            }
        );

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
