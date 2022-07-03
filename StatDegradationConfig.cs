using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace StatDegradation
{
    [Label("Server Config")]
    public class StatDegradationConfig : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        public static StatDegradationConfig Instance;
		
        [Header("Stat Degredation")]
		
        [Label("[i:LifeCrystal] Enable Life Degredation")]
        [Tooltip("If false, Players will not lose Life over time.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableLifeLoss {get; set;}
		
        [Label("[i:ManaCrystal]Enable Mana Degredation")]
        [Tooltip("If false, Players will not lose Mana over time.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableManaLoss {get; set;}
		
        [Label("Life Loss Timer")]
        [Tooltip("How long until Life degrades.\n(3600 is 1 minute.)\n[Default: 7200]")]
        [Slider]
        [DefaultValue(7200)]
        [Range(360, 10800)]
        [Increment(360)]
        public int lifeLossTimer {get; set;}
		
        [Label("Mana Loss Timer")]
        [Tooltip("How long until Mana degrades.\n(3600 is 1 minute.)\n[Default: 7200]")]
        [Slider]
        [DefaultValue(7200)]
        [Range(360, 10800)]
        [Increment(360)]
        public int manaLossTimer {get; set;}
		
        [Label("Minimum Life Loss")]
        [Tooltip("The minimum value for Life Loss.\n[Default: 20]")]
        [Slider]
        [DefaultValue(20)]
        [Range(20, 100)]
        [Increment(5)]
        public int lifeLossMinimum {get; set;}
		
        [Label("Minimum Life Loss")]
        [Tooltip("The minimum value for Mana Loss.\n[Default: 20]")]
        [Slider]
        [DefaultValue(20)]
        [Range(20, 100)]
        [Increment(5)]
        public int manaLossMinimum {get; set;}
		
		
        [Header("Stat Exercise")]
		
        [Label("[i:Vitamins][i:LifeCrystal] Enable Life Exercise")]
        [Tooltip("If false, Players will not be able to increase their Life through damage.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableLifeExercise {get; set;}
		
        [Label("[i:Vitamins][i:ManaCrystal] Enable Mana Exercise")]
        [Tooltip("If false, Players will not be able to increase their Mana through damage.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableManaExercise {get; set;}
		
        [Label("Quarter of Life Required")]
        [Tooltip("The portion (divisor) of Life required for Stat Exercise.\n(4 is 25% of the Player's Max Life.)\n[Default: 4]")]
        [Slider]
        [DefaultValue(4)]
        [Range(2, 4)]
        [Increment(1)]
        public int lifeDivisorRequired {get; set;}
		
        [Label("Life Exercise Amount")]
        [Tooltip("The amount of Life increased from Stat Exercise.\n[Default: 3]")]
        [Slider]
        [DefaultValue(3)]
        [Range(0, 10)]
        [Increment(1)]
        public int lifeExerciseAmount {get; set;}
		
        [Label("Mana Exercise Amount")]
        [Tooltip("The amount of Mana increased from Stat Exercise.\n[Default: 2]")]
        [Slider]
        [DefaultValue(2)]
        [Range(0, 10)]
        [Increment(1)]
        public int manaExerciseAmount {get; set;}
		
        [Header("Recipes")]
		
        [Label("Enable Recipes")]
        [Tooltip("If false, the custom recipes for Life Crystals, Mana Crystals and Life Fruits will not be enabled.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableRecipes {get; set;}
		
        [Label("[i:LifeCrystal] Life Crystal Output")]
        [Tooltip("The amount of Life Crystals to receive from its crafting recipe.\n(REQUIRES MOD RELOAD.)\n[Default: 1]")]
        [Slider]
        [DefaultValue(1)]
        [Range(0, 10)]
        [Increment(1)]
        public int lifeCrystalOutput {get; set;}
		
        [Label("[i:LifeCrystal][i:StoneBlock] Life Crystal Stone Amount")]
        [Tooltip("The amount of Stone involved in the Life Crystal recipe.\n(REQUIRES MOD RELOAD.)\n[Default: 10]")]
        [Slider]
        [DefaultValue(10)]
        [Range(0, 20)]
        [Increment(1)]
        public int lifeCrystalStone {get; set;}
		
        [Label("[i:LifeCrystal][i:Ruby] Life Crystal Ruby Amount")]
        [Tooltip("The amount of Rubies involved in the Life Crystal recipe.\n(REQUIRES MOD RELOAD.)\n[Default: 1]")]
        [Slider]
        [DefaultValue(1)]
        [Range(0, 20)]
        [Increment(1)]
        public int lifeCrystalRuby {get; set;}
		
        [Label("[i:ManaCrystal] Mana Crystal Output")]
        [Tooltip("The amount of Mana Crystals to receive from its crafting recipe.\n(REQUIRES MOD RELOAD.)\n[Default: 1]")]
        [Slider]
        [DefaultValue(1)]
        [Range(0, 10)]
        [Increment(1)]
        public int manaCrystalOutput {get; set;}
		
        [Label("[i:ManaCrystal][i:StoneBlock] Mana Crystal Stone Amount")]
        [Tooltip("The amount of Stone involved in the Mana Crystal recipe.\n(REQUIRES MOD RELOAD.)\n[Default: 10]")]
        [Slider]
        [DefaultValue(10)]
        [Range(0, 20)]
        [Increment(1)]
        public int manaCrystalStone {get; set;}
		
        [Label("[i:ManaCrystal][i:Sapphire] Mana Crystal Sapphire Amount")]
        [Tooltip("The amount of Sapphire involved in the Mana Crystal recipe.\n(REQUIRES MOD RELOAD.)\n[Default: 1]")]
        [Slider]
        [DefaultValue(1)]
        [Range(0, 20)]
        [Increment(1)]
        public int manaCrystalSapphire {get; set;}
		
        [Label("[i:LifeFruit] Life Fruit Output")]
        [Tooltip("The amount of Life Fruits to receive from its crafting recipe.\n(REQUIRES MOD RELOAD.)\n[Default: 1]")]
        [Slider]
        [DefaultValue(1)]
        [Range(0, 10)]
        [Increment(1)]
        public int lifeFruitOutput {get; set;}
		
        [Label("[i:LifeFruit][i:HallowedBar] Life Fruit Hallowed Bar Amount")]
        [Tooltip("The amount of Hallowed Bars involved in the Life Fruit recipe.\n(REQUIRES MOD RELOAD.)\n[Default: 1]")]
        [Slider]
        [DefaultValue(1)]
        [Range(0, 20)]
        [Increment(1)]
        public int lifeFruitHallowedBar {get; set;}
		
        [Label("[i:LifeFruit][i:Vine] Life Fruit Vine Amount")]
        [Tooltip("The amount of Vine involved in the Life Fruit recipe.\n(REQUIRES MOD RELOAD.)\n[Default: 10]")]
        [Slider]
        [DefaultValue(10)]
        [Range(0, 20)]
        [Increment(1)]
        public int lifeFruitVine {get; set;}
		
        [Header("Debug")]
		
        [Label("Enable Debug Features")]
        [Tooltip("If true, every 5 seconds, Players will have their Max Life reset to 100, and their Max Mana reset to 20.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool enableDebug {get; set;}
    }
}