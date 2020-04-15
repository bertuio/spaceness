using UnrealBuildTool;

public class SPACENESSTarget : TargetRules
{
	public SPACENESSTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SPACENESS");
	}
}
