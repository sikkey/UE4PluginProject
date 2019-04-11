// Copyright (c) 2013-2019 7Mersenne All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UE4PluginProjectTarget : TargetRules
{
	public UE4PluginProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "UE4PluginProject", "SeptemServo" } );
	}
}
