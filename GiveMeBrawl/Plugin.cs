using BepInEx;
using Utilla;

namespace GiveMeBrawl
{
    [ModdedGamemode("PAINTBRAWL","PAINT BRAWL", Utilla.Models.BaseGamemode.Battle)]
    [BepInDependency("org.legoandmars.gorillatag.utilla")]
    [BepInPlugin("GiveMeBrawl", "Give Me Brawl", "1.0.0")]
    public class Plugin : BaseUnityPlugin{}
}
