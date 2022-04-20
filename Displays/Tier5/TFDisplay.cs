﻿using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;

namespace CardMonkey.Displays.Tier5
{
    public class TFDisplay : ModTowerDisplay<CardMonkey>
    {
        public override string BaseDisplay => GetDisplay(TowerType.BoomerangMonkey, 0, 0, 4);

        public override bool UseForTower(int[] tiers)
        {
            return tiers[2] == 5;
        }

        public override float Scale => 1.2f;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            node.SaveMeshTexture(1); // used this to get the texture to edit
            //node.PrintInfo(); // used this to get the bone names and other info
            
            node.RemoveBone("SuperMonkeyRig:Dart");

            SetMeshTexture(node, Name, 1);
        }
    }
}