using System.Net.NetworkInformation;
using BepInEx; //mod loader library
using UnityEngine; //engine library that ror2 uses

[BepInPlugin("com.yourname.highjump", "High Jump Mod", "1.0.0")]//mod unique id, mod name, version number
public class HighJumpMod : BaseUnityPlugin//new class which extends BaseUnityPlugin (used by BepInEx)
{
    void Start()//runs when mod starts (when game loads)
    {
        On.RoR2.CharacterBody.Start += (orig, self) =>//when character is created
        {
            orig(self);//original game method
            self.baseJumpPower *= 2f; //double jump height
        };
    }
}




