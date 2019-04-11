// Copyright (c) 2013-2019 7Mersenne All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UE4PluginProjectEditorTarget : TargetRules
{
	public UE4PluginProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "UE4PluginProject", "SeptemServo" } );
	}
}
