using HarmonyLib;
using VoxelTycoon.Buildings;

public class KamikazeFishFasterMinesMod : VoxelTycoon.Modding.Mod
{
    protected override void Initialize()
    {
        var harmony = new Harmony("kamikaze_fish.faster_mines");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(MineSharedData), "OutputInterval", MethodType.Getter)]
class MineSharedData_getOutputInterval_FasterMinesPatch
{
    static void Postfix(ref float __result)
    {
        __result = __result / 30;
    }
}
