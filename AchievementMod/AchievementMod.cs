using OWML.ModHelper;
using OWML.Common;

namespace AchievementMod
{
    public class AchievementMod : ModBehaviour
    {
        public static AchievementMod Instance;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.HarmonyHelper.AddPostfix<Achievements>
                ("Earn",
                typeof(Patches),
                nameof(Patches.AchievementEarned));
            ModHelper.Console.WriteLine($"{nameof(AchievementMod)} is ready to go!", MessageType.Success);
        }
    }

    public static class Patches
    {
        public static void AchievementEarned(Achievements.Type type)
        {
            string name = "";
            if (type == Achievements.Type.TERRIBLE_FATE)
                name = "You've met a terrible fate.";
            else if (type == Achievements.Type.WHATS_THIS_BUTTON)
                name = "Hey, what's this button do?";
            else if (type == Achievements.Type.ALPHA_PILOT)
                name = "Archaeologist";
            else if (type == Achievements.Type.YOU_TRIED)
                name = "It was worth a shot.";
            else if (type == Achievements.Type.BEGINNERS_LUCK)
                name = "Beginner's Luck";
            else if (type == Achievements.Type.SATELLITE)
                name = "Rigidbody";
            else if (type == Achievements.Type.HEARTH_TO_MOON)
                name = "From the Hearth to the Moon";
            else if (type == Achievements.Type.DEEP_IMPACT)
                name = "Deep Impact";
            else if (type == Achievements.Type.HARMONIC_CONVERGENCE)
                name = "Harmonic Convergence";
            else if (type == Achievements.Type.MUSEUM)
                name = "It belongs in a museum!";
            else if (type == Achievements.Type.DIEHARD)
                name = "Die Hard";
            else if (type == Achievements.Type.PCHOOOOOOO)
                name = "Pchooooooo!";
            else if (type == Achievements.Type.GONE_IN_60_SECONDS)
                name = "Gone In 60 Seconds";
            else if (type == Achievements.Type.CARCINOGENS)
                name = "Mmmm, Carcinogens";
            else if (type == Achievements.Type.CUTTING_IT_CLOSE)
                name = "Cutting it Close";
            else if (type == Achievements.Type.MICAS_WRATH)
                name = "Mica's Wrath";
            else if (type == Achievements.Type.STUDIOUS) // This achievement is not listed, you get it every time you start the game?
                name = "_";
            else if (type == Achievements.Type.AROUND_THE_WORLD)
                name = "Around the world in 90 seconds";
            else if (type == Achievements.Type.SILENCED_CARTOGRAPHER)
                name = "The Silenced Cartographer";
            else if (type == Achievements.Type.TUBULAR)
                name = "Tubular!";
            else if (type == Achievements.Type.EARLY_ADOPTER)
                name = "Early Adopter";
            else if (type == Achievements.Type.GRATE_FILTER)
                name = "The Grate Filter";
            else if (type == Achievements.Type.FLAT_HEARTHER)
                name = "Flat Hearther";
            else if (type == Achievements.Type.CELCIUS)
                name = "Celsius 232.78";
            else if (type == Achievements.Type.GHOSTS)
                name = "Ghosts in the Machine";
            else if (type == Achievements.Type.SLEEP_WAKE_REPEAT)
                name = "Sleep. Wake. Repeat.";
            else if (type == Achievements.Type.SIMULATION)
                name = "Simulation Hypothesis";
            else if (type == Achievements.Type.FIRE_ARROWS)
                name = "Fire Arrows";
            else if (type == Achievements.Type.ONE_NINE)
                name = "1 / 900";
            else if (type == Achievements.Type.TAKEMEALIVE)
                name = "You'll Never Take Me Alive!";
            else if (type == Achievements.Type.OOFMYBONES)
                name = "Oof Ouch, My Bones";
            else if (type == Achievements.Type.FOUND_SIGNAL)
            {
                name = "_";
                AchievementMod.Instance.ModHelper.Console.WriteLine($"FOUND_SIGNAL");
            }
            else if (type == Achievements.Type.TOTAL)
            {
                name = "_";
                AchievementMod.Instance.ModHelper.Console.WriteLine($"TOTAL");
            }
            if (name == "_") return;
            AchievementMod.Instance.ModHelper.Console.WriteLine($"Achievement \"{name}\" earned!", MessageType.Success);
        }
    }
}
