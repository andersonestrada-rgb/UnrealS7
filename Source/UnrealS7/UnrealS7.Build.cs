// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnrealS7 : ModuleRules
{
	public UnrealS7(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"UnrealS7",
			"UnrealS7/Variant_Platforming",
			"UnrealS7/Variant_Platforming/Animation",
			"UnrealS7/Variant_Combat",
			"UnrealS7/Variant_Combat/AI",
			"UnrealS7/Variant_Combat/Animation",
			"UnrealS7/Variant_Combat/Gameplay",
			"UnrealS7/Variant_Combat/Interfaces",
			"UnrealS7/Variant_Combat/UI",
			"UnrealS7/Variant_SideScrolling",
			"UnrealS7/Variant_SideScrolling/AI",
			"UnrealS7/Variant_SideScrolling/Gameplay",
			"UnrealS7/Variant_SideScrolling/Interfaces",
			"UnrealS7/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
