// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class CloudWorks : ModuleRules
{
    public CloudWorks(TargetInfo Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

	}
}
