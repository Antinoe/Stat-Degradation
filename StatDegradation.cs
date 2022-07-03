using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace StatDegradation
{
	public class StatDegradation : Mod
	{
		public override void AddRecipes()
		{
			if (StatDegradationConfig.Instance.enableRecipes)
			{
				Recipe.Create(ItemID.LifeCrystal, StatDegradationConfig.Instance.lifeCrystalOutput)
				.AddIngredient(ItemID.Ruby, StatDegradationConfig.Instance.lifeCrystalRuby)
				.AddIngredient(ItemID.StoneBlock, StatDegradationConfig.Instance.lifeCrystalStone)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.ManaCrystal, StatDegradationConfig.Instance.manaCrystalOutput)
				.AddIngredient(ItemID.Sapphire, StatDegradationConfig.Instance.manaCrystalSapphire)
				.AddIngredient(ItemID.StoneBlock, StatDegradationConfig.Instance.manaCrystalStone)
				.AddTile(TileID.WorkBenches)
				.Register();
				
				Recipe.Create(ItemID.LifeFruit, StatDegradationConfig.Instance.lifeFruitOutput)
				.AddIngredient(ItemID.HallowedBar, StatDegradationConfig.Instance.lifeFruitHallowedBar)
				.AddIngredient(ItemID.Vine, StatDegradationConfig.Instance.lifeFruitVine)
				.AddTile(TileID.WorkBenches)
				.Register();
			}
		}
    }
}
