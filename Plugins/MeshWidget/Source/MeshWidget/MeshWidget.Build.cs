// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class MeshWidget : ModuleRules
{
	public MeshWidget(ReadOnlyTargetRules Target) : base(Target)
	{

        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[] {
                "Core",
                "CoreUObject",
                "Engine",
                "InputCore",
                "Slate",
                "SlateCore",
                "SlateRHIRenderer",
                //"UnrealEd",
                "UMG",
                "RenderCore",
                "RHI"
            }
        );

		//PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		 PrivateDependencyModuleNames.AddRange(new string[] { "CoreUObject","Engine", "Slate", "SlateCore", "SlateRHIRenderer", "UMG" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
