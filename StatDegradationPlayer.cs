using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace StatDegradation
{
    public class StatDegradationPlayer : ModPlayer
    {
		public int lifeLossTimer = 0;
		public int manaLossTimer = 0;
		public int debugTimer = 0;
		public static StatDegradationPlayer ModPlayer(Player Player)
		{
			return Player.GetModPlayer<StatDegradationPlayer>();
		}
		
		public override void PostUpdate()
		{
			//Stat Loss over time.
			//1200 is 20 seconds. 2400 is 40 seconds. 3600 is 1 minute. 7200 is 2 minutes. 10800 is 3 minutes.
			if(lifeLossTimer < StatDegradationConfig.Instance.lifeLossTimer && StatDegradationConfig.Instance.enableLifeLoss)
			{
				lifeLossTimer++;
			}
			if(manaLossTimer < StatDegradationConfig.Instance.manaLossTimer && StatDegradationConfig.Instance.enableManaLoss)
			{
				manaLossTimer++;
			}
			
			if(lifeLossTimer >= StatDegradationConfig.Instance.lifeLossTimer)
			{
				lifeLossTimer = 0;
				if(Player.statLifeMax > StatDegradationConfig.Instance.lifeLossMinimum)
				{
					Player.statLifeMax -= 1;
				}
			}
			if(manaLossTimer >= StatDegradationConfig.Instance.manaLossTimer)
			{
				manaLossTimer = 0;
				if(Player.statManaMax > StatDegradationConfig.Instance.manaLossMinimum)
				{
					Player.statManaMax -= 1;
				}
			}
			
			//Debug
			if (StatDegradationConfig.Instance.enableDebug)
			{
				if (debugTimer >= 360)
				{
					Player.statLifeMax = 100;
					Player.statManaMax = 20;
					debugTimer = 0;
				}
				else
				{
					debugTimer++;
				}
			}
		}
		
		public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
			//Stat Exercise
			if (damage >= Player.statLifeMax / StatDegradationConfig.Instance.lifeDivisorRequired)
			{
				if (StatDegradationConfig.Instance.enableLifeExercise)
				{
					Player.statLifeMax += StatDegradationConfig.Instance.lifeExerciseAmount;
				}
				if (StatDegradationConfig.Instance.enableManaExercise)
				{
					Player.statManaMax += StatDegradationConfig.Instance.manaExerciseAmount;
				}
			}
        }
    }
}