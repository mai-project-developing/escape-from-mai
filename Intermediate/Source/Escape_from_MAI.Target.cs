using UnrealBuildTool;

public class Escape_from_MAITarget : TargetRules
{
	public Escape_from_MAITarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Escape_from_MAI");
	}
}
