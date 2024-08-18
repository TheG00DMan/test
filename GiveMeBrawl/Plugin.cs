using BepInEx;
using Utilla;

namespace Test
{
    [ModdedGamemode("TEST","test", Utilla.Models.BaseGamemode.Battle)]
    [BepInDependency("org.legoandmars.gorillatag.utilla")]
    [BepInPlugin("GiveMeTest", "Give Me Test", "1.0.0")]
    public class Plugin : BaseUnityPlugin{}
}
