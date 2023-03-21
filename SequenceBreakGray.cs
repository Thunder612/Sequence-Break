using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace SequenceBreakGray
{
    public class SequenceBreakGray : Mod
    {



        public override void AddRecipes()
        {
            /*
            // Removing Recipes.
            List<Recipe> rec = Main.recipe.ToList();
            int numberRecipesRemoved = 0;
            







            // The Recipes to remove.
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.CrystalStorm);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.ChlorophyteShotbow);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.Flamethrower);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.WoodenBow);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.MolotovCocktail);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.BluePhaseblade);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.RedPhaseblade);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.YellowPhaseblade);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.GreenPhaseblade);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.PurplePhaseblade);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.WhitePhaseblade);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.TheHorsemansBlade);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.ChlorophyteSaber);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.ChlorophytePartisan);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.MagicalHarp);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.NightsEdge);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.TrueNightsEdge);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.StardustDragonStaff);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.BoneJavelin);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.BoneDagger);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.NebulaArcanum);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.LightDisc);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.SolarEruption);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.Phantasm); 
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.EndlessMusketPouch);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.EndlessQuiver);
            
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.AmethystStaff);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.TopazStaff);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.SapphireStaff);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.EmeraldStaff);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.RubyStaff);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.DiamondStaff);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.WoodenSword);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.SpaceGun);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.MeteorHelmet);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.MeteorLeggings);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.MeteorSuit);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.MoltenFury);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.Excalibur);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.RainbowRod);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.DayBreak);
            numberRecipesRemoved += rec.RemoveAll(x => x.createItem.type == ItemID.VortexBeater);
            

            Main.recipe = rec.ToArray();
            Array.Resize(ref Main.recipe, Recipe.maxRecipes);
            Recipe.numRecipes -= numberRecipesRemoved;
            */
            
            
            // The Recipes to add
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Book);
            recipe.AddIngredient(ItemID.Diamond);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(ItemID.CrystalStorm);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IllegalGunParts);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Flamethrower);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.JungleSpores, 12);
            recipe.AddIngredient(ItemID.Vine, 4);
            recipe.AddIngredient(ItemID.Stinger, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.ChlorophyteShotbow);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.IronBar, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.WoodenBow);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.LeadBar, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.WoodenBow);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddIngredient(ItemID.Gel, 3);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.MolotovCocktail, 3);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddIngredient(ItemID.Sapphire, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.BluePhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddIngredient(ItemID.Emerald, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.GreenPhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddIngredient(ItemID.Amethyst, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.PurplePhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddIngredient(ItemID.Ruby, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.RedPhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddIngredient(ItemID.Diamond, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.WhitePhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddIngredient(ItemID.Topaz, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.YellowPhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TungstenBar, 10);
            recipe.AddIngredient(ItemID.Sapphire, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.BluePhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TungstenBar, 10);
            recipe.AddIngredient(ItemID.Emerald, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.GreenPhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TungstenBar, 10);
            recipe.AddIngredient(ItemID.Amethyst, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.PurplePhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TungstenBar, 10);
            recipe.AddIngredient(ItemID.Ruby, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.RedPhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TungstenBar, 10);
            recipe.AddIngredient(ItemID.Diamond, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.WhitePhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TungstenBar, 10);
            recipe.AddIngredient(ItemID.Topaz, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.YellowPhaseblade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Pumpkin, 10);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.TheHorsemansBlade);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.JungleSpores, 15);
            recipe.AddIngredient(ItemID.Stinger, 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.ChlorophyteSaber);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.JungleSpores, 12);
            recipe.AddIngredient(ItemID.Vine, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.ChlorophytePartisan);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SilverBar, 14);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Katana);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TungstenBar, 14);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Katana);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DemonBow);
            recipe.SetResult(ItemID.DaedalusStormbow);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TendonBow);
            recipe.SetResult(ItemID.DaedalusStormbow);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.GoldBar, 10);
            recipe.AddIngredient(ItemID.Cobweb, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.MagicalHarp);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PlatinumBar, 10);
            recipe.AddIngredient(ItemID.Cobweb, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.MagicalHarp);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LightsBane);
            recipe.AddIngredient(ItemID.CopperShortsword);
            recipe.AddIngredient(ItemID.TheHorsemansBlade);
            recipe.AddIngredient(ItemID.Starfury);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.NightsEdge);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.BloodButcherer);
            recipe.AddIngredient(ItemID.CopperShortsword);
            recipe.AddIngredient(ItemID.TheHorsemansBlade);
            recipe.AddIngredient(ItemID.Starfury);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.NightsEdge);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.NightsEdge);
            recipe.AddIngredient(ItemID.EnchantedSword);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.TrueNightsEdge);
            recipe.AddRecipe();
            //
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SlimeStaff);
            recipe.SetResult(ItemID.StardustDragonStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Vilethorn);
            recipe.SetResult(ItemID.BubbleGun);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CrimsonRod);
            recipe.SetResult(ItemID.RazorbladeTyphoon);
            recipe.AddRecipe();
            //
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Bone);
            recipe.SetResult(ItemID.BoneJavelin);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Bone);
            recipe.SetResult(ItemID.BoneDagger, 2);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.AquaScepter);
            recipe.SetResult(ItemID.NebulaArcanum);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.ShadowScale, 6);
            recipe.AddIngredient(ItemID.DemoniteBar, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.ShadowFlameBow);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TissueSample, 6);
            recipe.AddIngredient(ItemID.CrimtaneBar, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.ShadowFlameBow);
            recipe.AddRecipe();
            //
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TissueSample, 8);
            recipe.AddIngredient(ItemID.CrimtaneBar, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.ShadowFlameHexDoll);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.ShadowScale, 8);
            recipe.AddIngredient(ItemID.DemoniteBar, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.ShadowFlameHexDoll);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.ShadowScale, 2);
            recipe.AddIngredient(ItemID.DemoniteBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.ShadowFlameKnife);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TissueSample, 2);
            recipe.AddIngredient(ItemID.CrimtaneBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.ShadowFlameKnife);
            recipe.AddRecipe();
            // High
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBar, 3);
            recipe.AddIngredient(ItemID.GoldBar, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.LightDisc);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBar, 3);
            recipe.AddIngredient(ItemID.PlatinumBar, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.LightDisc);
            recipe.AddRecipe();
            //
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.FlowerofFire);
            recipe.SetResult(ItemID.ShadowbeamStaff);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Flamelash);
            recipe.SetResult(ItemID.InfernoFork);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Sunfury);
            recipe.SetResult(ItemID.SpectreStaff);
            recipe.AddRecipe();


            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.SolarEruption);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddIngredient(ItemID.Obsidian, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Phantasm);
            recipe.AddRecipe();
            // Low
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.WoodenArrow, 999);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.EndlessQuiver);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MusketBall, 999);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.EndlessMusketPouch);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TitaniumBar, 6);
            recipe.AddIngredient(ItemID.PinkGel, 15);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.Meowmere);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CobaltBar, 5);
            recipe.AddIngredient(ItemID.Amethyst, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.AmethystStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PalladiumBar, 5);
            recipe.AddIngredient(ItemID.Topaz, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.TopazStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MythrilBar, 5);
            recipe.AddIngredient(ItemID.Sapphire, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SapphireStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.OrichalcumBar, 5);
            recipe.AddIngredient(ItemID.Emerald, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SapphireStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.AdamantiteBar, 5);
            recipe.AddIngredient(ItemID.Ruby, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.RubyStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TitaniumBar, 5);
            recipe.AddIngredient(ItemID.Diamond, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.DiamondStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Wood, 7);
            recipe.AddIngredient(ItemID.Pearlwood, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.WoodenSword);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CobaltBar, 5);
            recipe.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SpaceGun);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PalladiumBar, 5);
            recipe.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SpaceGun);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MythrilBar, 3);
            recipe.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MeteorHelmet);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.OrichalcumBar, 3);
            recipe.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MeteorHelmet);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MythrilBar, 3);
            recipe.AddIngredient(ItemID.MeteoriteBar, 18);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MeteorSuit);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.OrichalcumBar, 3);
            recipe.AddIngredient(ItemID.MeteoriteBar, 18);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MeteorSuit);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MythrilBar, 3);
            recipe.AddIngredient(ItemID.MeteoriteBar, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MeteorLeggings);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.OrichalcumBar, 3);
            recipe.AddIngredient(ItemID.MeteoriteBar, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MeteorLeggings);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.BeeKeeper);
            recipe.AddIngredient(ItemID.Meowmere);
            recipe.AddIngredient(ItemID.StarWrath);
            recipe.AddIngredient(ItemID.Muramasa);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.Excalibur);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Excalibur);
            recipe.AddIngredient(ItemID.TrueNightsEdge);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.TrueExcalibur);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LightShard, 2);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddIngredient(ItemID.DarkLance);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.DayBreak);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DarkShard, 2);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddIngredient(ItemID.Musket);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.VortexBeater);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DarkShard, 2);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddIngredient(ItemID.TheUndertaker);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.VortexBeater);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CopperBar);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.MusketBall, 70);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TinBar);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.MusketBall, 70);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddIngredient(ItemID.Bone, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Marrow);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IllegalGunParts);
            recipe.AddIngredient(ItemID.PharaohsMask);
            recipe.AddIngredient(ItemID.PharaohsRobe);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.CoinGun);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Ruby);
            recipe.AddIngredient(ItemID.GoldBar, 7);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.EnchantedSword);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Ruby);
            recipe.AddIngredient(ItemID.PlatinumBar, 7);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.EnchantedSword);
            recipe.AddRecipe();


            //Post Mech Boss
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.BeeWax, 14);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.HornetStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.BeeWax, 8);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BeeHeadgear);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.BeeWax, 12);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BeeBreastplate);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.BeeWax, 10);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BeeGreaves);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.FieryGreatsword);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BladeofGrass);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.BeeWax, 8);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BeeHeadgear);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DjinnLamp);
            recipe.AddIngredient(ItemID.AncientBattleArmorMaterial);
            recipe.AddIngredient(ItemID.HallowedBar, 9);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SpiritFlame);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DefenderMedal);
            recipe.AddIngredient(ItemID.HallowedBar, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MonkStaffT1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DefenderMedal);
            recipe.AddIngredient(ItemID.HallowedBar, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BookStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DefenderMedal);
            recipe.AddIngredient(ItemID.HallowedBar, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.DD2PhoenixBow);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DefenderMedal);
            recipe.AddIngredient(ItemID.HallowedBar, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.DD2SquireDemonSword);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DefenderMedal);
            recipe.AddIngredient(ItemID.HallowedBar, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MonkStaffT2);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Minishark);
            recipe.AddIngredient(ItemID.IllegalGunParts);
            recipe.AddIngredient(ItemID.SharkFin, 5);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.Megashark);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MushroomSpear);
            recipe.SetResult(ItemID.NebulaBlaze);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.NebulaHelmet);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.NebulaBreastplate);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.NebulaLeggings);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SolarFlareHelmet);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SolarFlareBreastplate);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SolarFlareLeggings);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.VortexHelmet);
            recipe.AddRecipe();


            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.VortexBreastplate);
            recipe.AddRecipe();


            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.VortexLeggings);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofSight, 3);
            recipe.AddIngredient(ItemID.SoulofMight, 3);
            recipe.AddIngredient(ItemID.SoulofFright, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.StardustHelmet);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofSight, 3);
            recipe.AddIngredient(ItemID.SoulofMight, 3);
            recipe.AddIngredient(ItemID.SoulofFright, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.StardustBreastplate);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofSight, 3);
            recipe.AddIngredient(ItemID.SoulofMight, 3);
            recipe.AddIngredient(ItemID.SoulofFright, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.StardustLeggings);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 7);
            recipe.AddIngredient(ItemID.JungleSpores, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.Flairon);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 7);
            recipe.AddIngredient(ItemID.Vine, 2);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.Tsunami);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SpellTome);
            recipe.AddIngredient(ItemID.CursedFlame, 20);
            recipe.AddIngredient(ItemID.SoulofNight, 7);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.CursedFlames);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SpellTome);
            recipe.AddIngredient(ItemID.Ichor, 20);
            recipe.AddIngredient(ItemID.SoulofNight, 7);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.GoldenShower);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HallowedBar, 7);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.FlyingKnife);
            recipe.AddRecipe();
            
        }


        public class ItemChanges : GlobalItem
        {

            public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
            {
                // Causes Revolver to fire high velocity bullets when using musket balls
                if (item.type == ItemID.Revolver)
                {
                    if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
                    {
                        type = ProjectileID.BulletHighVelocity; // or ProjectileID.FireArrow;
                    }
                }
                // Causes Flintlock Pistol to fire Explosive Bullets when using musket balls
                if (item.type == ItemID.FlintlockPistol)
                {
                    if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
                    {
                        type = ProjectileID.ExplosiveBullet; // or ProjectileID.FireArrow;
                    }
                }
                // Causes the Dark Lance to launch a projectile when used
                if (item.type == ItemID.DarkLance)
                {
                    Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.DarkLance, damage, knockBack, player.whoAmI);
                }
                return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
            }



            // Code to add "Sequenced" to all changed item's tooltips, doesn't currently work properly
            /*public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
            {
                if (item.type == ItemID.CrystalStorm)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Summons rapid fire crystal shards\nSequenced";
                    }
                }

                if (item.type == ItemID.SpectreStaff)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Summons a lost soul to chase your foes\nSequenced";
                    }
                }

                if (item.type == ItemID.Phantasm)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "66% chance to not consume ammo\nSequenced";
                    }
                }

                if (item.type == ItemID.Blowpipe)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Allows the collection of seeds for ammo\nSequenced";
                    }
                }

                if (item.type == ItemID.Harpoon)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.Katana)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.BeeKeeper)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Summons killer bees after striking your foe\nSmall chance to cause confusion\nSequenced";
                    }
                }

                if (item.type == ItemID.SolarEruption)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "'Strike with the fury of the sun'\nSequenced";
                    }
                }

                if (item.type == ItemID.DaedalusStormbow)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Shoots bullets from the sky\nSequenced";
                    }
                }

                if (item.type == ItemID.LightDisc)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Stacks up to 5\nSequenced";
                    }
                }

                if (item.type == ItemID.Meowmere)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.DarkLance)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.Revolver)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Fires high velocity bullets\nSequenced";
                    }
                }

                if (item.type == ItemID.Flamethrower)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Uses gel for ammo\nSequenced";
                    }
                }

                if (item.type == ItemID.ChlorophyteShotbow)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.WoodenBow)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.MolotovCocktail)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.StarCannon)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Shoots fallen stars\nSequenced";
                    }
                }

                if (item.type == ItemID.WandofSparking)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Shoots a spark\nSequenced";
                    }
                }

                if (item.type == ItemID.EnchantedBoomerang)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.IceBoomerang)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.Flamarang)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.IceBlade)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Shoots an icy bolt\nSequenced";
                    }
                }

                if (item.type == ItemID.BoneSword)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.BloodButcherer)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.LightsBane)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.EndlessQuiver)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.EndlessMusketPouch)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }

                }

                if (item.type == ItemID.ShadowbeamStaff)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Creates a shadow beam that bounces off walls\nSequenced";
                        }
                    }

                    if (item.type == ItemID.ShadowFlameBow)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Shoots Shadowflame Arrows\nSequenced";
                        }
                    }

                    if (item.type == ItemID.ShadowFlameHexDoll)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Summons Shadowflame tentacles to strike your foe\nSequenced";
                        }
                    }

                    if (item.type == ItemID.ShadowFlameKnife)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Inflicts Shadowflame on hit\nSequenced";
                        }
                    }

                    if (item.type == ItemID.NebulaArcanum)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "'Conjure masses of astral energy to chase down your foes'\nSequenced";
                        }
                    }

                if (item.type == itemid.bonedagger)
                {
                    tooltipline line = tooltips.firstordefault(x => x.name == "tooltip0" && x.mod == "terraria");
                    if (line != null)
                    {
                        line.text = "sequenced";
                    }
                }

                if (item.type == itemid.bonejavelin)
                {
                    tooltipline line = tooltips.firstordefault(x => x.name == "tooltip0" && x.mod == "terraria");
                    if (line != null)
                    {
                        line.text = "sequenced";
                    }
                }

                if (item.type == ItemID.RazorbladeTyphoon)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Casts fast moving razorwheels\nSequenced";
                        }
                    }

                    if (item.type == ItemID.BubbleGun)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Rapidly Shoots forceful bubbles\nSequenced";
                        }
                    }

                    if (item.type == ItemID.StardustDragonStaff)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "'Who needs a horde of minions when you have a giant dragon?'\nSequenced";
                        }
                    }

                if (item.type == ItemID.NightsEdge)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.TrueNightsEdge)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.ChlorophytePartisan)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Shoots a spore cloud\nSequenced";
                        }
                    }

                    if (item.type == ItemID.ChlorophyteSaber)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Shoots a spore cloud\nSequenced";
                        }
                    }

                if (item.type == ItemID.MagicalHarp)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.TheHorsemansBlade)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Summons Pumpkin heads to attack your enemies\nSequenced";
                        }
                    }

                if (item.type == ItemID.YellowPhaseblade)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.WhitePhaseblade)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.PurplePhaseblade)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.GreenPhaseblade)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.RedPhaseblade)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.BluePhaseblade)
                {
                    TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                    if (line != null)
                    {
                        line.text = "Sequenced";
                    }
                }

                if (item.type == ItemID.MagicMissile)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Casts a controllable missile\nSequenced";
                        }
                    }

                    if (item.type == ItemID.Handgun)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Sequenced";
                        }
                    }

                    if (item.type == ItemID.InfernoFork)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Launches a ball of fire that explodes into a raging inferno\nSequenced";
                        }
                    }

                    if (item.type == ItemID.AmethystStaff)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Sequenced";
                        }
                    }

                    if (item.type == ItemID.TopazStaff)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Sequenced";
                        }
                    }

                    if (item.type == ItemID.SapphireStaff)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Sequenced";
                        }
                    }

                    if (item.type == ItemID.EmeraldStaff)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Sequenced";
                        }
                    }

                    if (item.type == ItemID.RubyStaff)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Sequenced";
                        }
                    }

                    if (item.type == ItemID.DiamondStaff)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Sequenced";
                        }
                    }

                    if (item.type == ItemID.BeeGun)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Sequenced";
                        }
                    }

                    if (item.type == ItemID.BookofSkulls)
                    {
                        TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                        if (line != null)
                        {
                            line.text = "Sequenced";
                        }
                    }
                }*/
            
            public override void SetDefaults(Item item)
            {

                // The changes to items

                if (item.type == ItemID.CrystalStorm)
                {
                    item.damage = 8;
                }

                if (item.type == ItemID.Flamethrower)
                {
                    item.damage = 20;
                }

                if (item.type == ItemID.ChlorophyteShotbow)
                {
                    item.damage = 10;
                    item.useTime = 30;
                    item.useAnimation = 30;
                }

                if (item.type == ItemID.WoodenBow)
                {
                    item.useTime = 20;
                    item.useAnimation = 20;
                }

                if (item.type == ItemID.Harpoon)
                {
                    item.damage = 75;
                }

                if (item.type == ItemID.Blowpipe)
                {
                    item.damage = 11;
                }

                if (item.type == ItemID.TheHorsemansBlade)
                {
                    item.damage = 10;
                }

                if (item.type == ItemID.LightsBane)
                {
                    item.damage = 25;
                }

                if (item.type == ItemID.BloodButcherer)
                {
                    item.damage = 30;
                }

                if (item.type == ItemID.ChlorophyteSaber)
                {
                    item.damage = 23;
                }

                if (item.type == ItemID.ChlorophytePartisan)
                {
                    item.damage = 19;
                }

                if (item.type == ItemID.Katana)
                {
                    item.damage = 20;
                }

                if (item.type == ItemID.BoneSword)
                {
                    item.knockBack = 10;
                }

                if (item.type == ItemID.IceBlade)
                {
                    item.useTime = 10;
                }

                if (item.type == ItemID.EnchantedBoomerang)
                {
                    item.shootSpeed = 25;
                }

                if (item.type == ItemID.IceBoomerang)
                {
                    item.shootSpeed = 25;
                }

                if (item.type == ItemID.Flamarang)
                {
                    item.shootSpeed = 25;
                }

                if (item.type == ItemID.DaedalusStormbow)
                {
                    item.damage = 7;
                    item.useAmmo = AmmoID.Bullet;
                }

                if (item.type == ItemID.Boomstick)
                {
                    item.useAmmo = AmmoID.Arrow;
                }

                if (item.type == ItemID.Minishark)
                {
                    item.useAmmo = AmmoID.Arrow;
                }

                if (item.type == ItemID.CopperBow)
                {
                    item.useAmmo = AmmoID.Bullet;
                }

                if (item.type == ItemID.TinBow)
                {
                    item.useAmmo = AmmoID.Bullet;
                }

                if (item.type == ItemID.IronBow)
                {
                    item.useAmmo = AmmoID.Bullet;
                }

                if (item.type == ItemID.LeadBow)
                {
                    item.useAmmo = AmmoID.Bullet;
                }

                if (item.type == ItemID.SilverBow)
                {
                    item.useAmmo = AmmoID.Bullet;
                }

                if (item.type == ItemID.TungstenBow)
                {
                    item.useAmmo = AmmoID.Bullet;
                }

                if (item.type == ItemID.GoldBow)
                {
                    item.useAmmo = AmmoID.Bullet;
                }

                if (item.type == ItemID.PlatinumBow)
                {
                    item.useAmmo = AmmoID.Bullet;
                }

                if (item.type == ItemID.WandofSparking)
                {
                    item.damage = 16;

                }

                if (item.type == ItemID.MagicalHarp)
                {
                    item.damage = 12;

                }

                if (item.type == ItemID.NightsEdge)
                {
                    item.damage = 38;

                }

                if (item.type == ItemID.TrueNightsEdge)
                {
                    item.damage = 42;

                }

                if (item.type == ItemID.StardustDragonStaff)
                {
                    item.damage = 1;

                }

                if (item.type == ItemID.BubbleGun)
                {
                    item.damage = 8;

                }

                if (item.type == ItemID.RazorbladeTyphoon)
                {
                    item.damage = 4;

                }

                if (item.type == ItemID.BoneJavelin)
                {
                    item.damage = 32;

                }

                if (item.type == ItemID.BoneDagger)
                {
                    item.damage = 32;

                }

                if (item.type == ItemID.StarCannon)
                {
                    item.damage = 165;
                    item.useTime = 36;
                    item.useAnimation = 36;

                }

                if (item.type == ItemID.BeeKeeper)
                {
                    item.damage = 18;
                    item.useTime = 12;
                    item.useAnimation = 12;
                }

                if (item.type == ItemID.Handgun)
                {
                    item.autoReuse = true;
                }

                if (item.type == ItemID.MagicMissile)
                {
                    item.damage = 40;
                    item.useTime = 40;
                    item.useAnimation = 22;
                    item.shootSpeed = 10;
                }

                if (item.type == ItemID.NebulaArcanum)
                {
                    item.damage = 8;
                    item.mana = 25;
                }

                if (item.type == ItemID.DarkLance)
                {
                    item.shoot = ProjectileID.UnholyTridentFriendly;
                    item.damage = 16;
                }

                if (item.type == ItemID.Meowmere)
                {
                    item.damage = 1;
                    item.useTime = 40;
                    item.useAnimation = 40;
                }

                if (item.type == ItemID.ShadowFlameBow)
                {
                    item.damage = 16;
                }

                if (item.type == ItemID.ShadowFlameHexDoll)
                {
                    item.damage = 12;
                }

                if (item.type == ItemID.ShadowFlameKnife)
                {
                    item.damage = 12;
                }

                if (item.type == ItemID.LightDisc)
                {
                    item.damage = 21;
                }

                if (item.type == ItemID.ShadowbeamStaff)
                {
                    item.damage = 20;
                }

                if (item.type == ItemID.InfernoFork)
                {
                    item.damage = 21;
                }

                if (item.type == ItemID.SolarEruption)
                {
                    item.damage = 11;
                    item.width = 1;
                    item.height = 1;
                    item.scale = .3f;
                }

                if (item.type == ItemID.Phantasm)
                {
                    item.damage = 6;
                    item.value = 5400;
                    item.useTime = 18;
                    item.useAnimation = 18;
                }

                if (item.type == ItemID.SpectreStaff)
                {
                    item.damage = 26;
                }

                if (item.type == ItemID.BeeGun)
                {
                    item.damage = 11;
                }

                if (item.type == ItemID.BookofSkulls)
                {
                    item.mana = 16;
                }

                if (item.type == ItemID.AmethystStaff)
                {
                    item.damage = 110;
                }

                if (item.type == ItemID.TopazStaff)
                {
                    item.damage = 113;
                }

                if (item.type == ItemID.SapphireStaff)
                {
                    item.damage = 118;
                }

                if (item.type == ItemID.EmeraldStaff)
                {
                    item.damage = 121;
                }

                if (item.type == ItemID.RubyStaff)
                {
                    item.damage = 130;
                }

                if (item.type == ItemID.DiamondStaff)
                {
                    item.damage = 133;
                }

                if (item.type == ItemID.WoodenSword)
                {
                    item.damage = 90;
                    item.shoot = ProjectileID.SwordBeam;
                }

                if (item.type == ItemID.Pwnhammer)
                {
                    item.damage = 37;
                }

                if (item.type == ItemID.MoltenFury)
                {
                    item.damage = 45;
                }
                
                if (item.type == ItemID.SpaceGun)
                {
                    item.damage = 37;
                }

                if (item.type == ItemID.WoodenSword)
                {
                    item.damage = 90;
                    item.shoot = ProjectileID.NightBeam;
                }

                if (item.type == ItemID.LaserRifle)
                {
                    item.mana = 4;
                }

                if (item.type == ItemID.MeteorHelmet)
                {
                    item.defense = 7;
                }

                if (item.type == ItemID.MeteorSuit)
                {
                    item.defense = 10;
                }

                if (item.type == ItemID.MeteorLeggings)
                {
                    item.defense = 9;
                }

                if (item.type == ItemID.StarWrath)
                {
                    item.damage = 15;
                }

                if (item.type == ItemID.BreakerBlade)
                {
                    item.damage = 55;
                }

                if (item.type == ItemID.Cutlass)
                {
                    item.useTime = 8;
                    item.useAnimation = 8;
                }

                if (item.type == ItemID.Frostbrand)
                {
                    item.useTime = 23;
                    item.useAnimation = 23;
                }

                if (item.type == ItemID.BeamSword)
                {
                    item.useTime = 20;
                    item.useAnimation = 20;
                }

                if (item.type == ItemID.Marrow)
                {
                    item.damage = 50;
                }

                if (item.type == ItemID.IceBow)
                {
                    item.autoReuse = true;
                }

                if (item.type == ItemID.IceBow)
                {
                    item.autoReuse = true;
                }

                if (item.type == ItemID.ClockworkAssaultRifle)
                {
                    item.useAmmo = AmmoID.Arrow;
                }

                if (item.type == ItemID.Gatligator)
                {
                    item.damage = 28;
                }

                if (item.type == ItemID.Uzi)
                {
                    item.damage = 20;
                    item.useTime = 6;
                    item.useAnimation = 6;
                }

                if (item.type == ItemID.IceRod)
                {
                    item.damage = 50;
                }

                if (item.type == ItemID.FlowerofFrost)
                {
                    item.damage = 65;
                    item.useTime = 12;
                    item.useAnimation = 12;
                    item.mana = 11;
                }

                if (item.type == ItemID.FrostStaff)
                {
                    item.useTime = 14;
                    item.useAnimation = 14;
                    item.mana = 12;
                }

                if (item.type == ItemID.MagicDagger)
                {
                    item.damage = 50;
                }

                if (item.type == ItemID.Excalibur)
                {
                    item.damage = 100;
                }

                if (item.type == ItemID.TrueExcalibur)
                {
                    item.damage = 50;
                    item.autoReuse = true;
                }

                if (item.type == ItemID.FrostStaff)
                {
                    item.useTime = 25;
                    item.useAnimation = 25;
                    item.mana = 21;
                }

                if (item.type == ItemID.DayBreak)
                {
                    item.useTime = 35;
                    item.useAnimation = 35;
                    item.damage = 80;
                }

                if (item.type == ItemID.VortexBeater)
                {
                    item.damage = 5;
                }


                //Post Mech
                if (item.type == ItemID.HornetStaff)
                {
                    item.damage = 60;
                }

                if (item.type == ItemID.BeeHeadgear)
                {
                    item.defense = 10;
                }

                if (item.type == ItemID.BeeBreastplate)
                {
                    item.defense = 10;
                }

                if (item.type == ItemID.BeeGreaves)
                {
                    item.defense = 10;
                }

                if (item.type == ItemID.FieryGreatsword)
                {
                    item.damage = 90;
                }

                if (item.type == ItemID.BladeofGrass)
                {
                    item.damage = 80;
                    item.shoot = ProjectileID.ChlorophyteOrb;
                }

                if (item.type == ItemID.SpiritFlame)
                {
                    item.useTime = 22;
                    item.useAnimation = 22;
                    item.mana = 14;
                }

                if (item.type == ItemID.Megashark)
                {
                    item.useAmmo = AmmoID.Arrow;
                }

                if (item.type == ItemID.NebulaBlaze)
                {
                    item.damage = 50;
                }

                if (item.type == ItemID.NebulaHelmet)
                {
                    item.defense = 10;
                }

                if (item.type == ItemID.NebulaBreastplate)
                {
                    item.defense = 10;
                }

                if (item.type == ItemID.NebulaLeggings)
                {
                    item.defense = 10;
                }

                if (item.type == ItemID.SolarFlareHelmet)
                {
                    item.defense = 15;
                }

                if (item.type == ItemID.SolarFlareBreastplate)
                {
                    item.defense = 20;
                }

                if (item.type == ItemID.SolarFlareLeggings)
                {
                    item.defense = 15;
                }

                if (item.type == ItemID.VortexHelmet)
                {
                    item.defense = 10;
                }

                if (item.type == ItemID.VortexBreastplate)
                {
                    item.defense = 17;
                }

                if (item.type == ItemID.VortexLeggings)
                {
                    item.defense = 13;
                }

                if (item.type == ItemID.StardustHelmet)
                {
                    item.defense = 10;
                }

                if (item.type == ItemID.StardustBreastplate)
                {
                    item.defense = 13;
                }

                if (item.type == ItemID.StardustLeggings)
                {
                    item.defense = 12;
                }

                if (item.type == ItemID.Flairon)
                {
                    item.damage = 45;
                }

                if (item.type == ItemID.Tsunami)
                {
                    item.useAmmo = AmmoID.Bullet;
                    item.damage = 40;
                }

                if (item.type == ItemID.CursedFlames)
                {
                    item.damage = 50;
                    item.useTime = 15;
                    item.useAnimation = 15;
                    item.mana = 3;
                }

                if (item.type == ItemID.GoldenShower)
                {
                    item.useTime = 10;
                    item.useAnimation = 10;
                    item.mana = 2;
                }

                if (item.type == ItemID.FlyingKnife)
                {
                    item.damage = 90;
                }
            }
            
            
        }

        
    }


    public class ModGlobalNPC : GlobalNPC
    {
        public override bool PreNPCLoot(NPC npc)
        {
            // Changes the drops of the Hallowed mimic to instead drop the Rainbow Rod, the Star Wrath, and the Molten Fury
            if (npc.type == NPCID.BigMimicHallow)
            {
                NPCLoader.blockLoot.Add(ItemID.CrystalVileShard);
                NPCLoader.blockLoot.Add(ItemID.DaedalusStormbow);
                NPCLoader.blockLoot.Add(ItemID.FlyingKnife);
                if (Main.rand.Next(3) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.RainbowRod);
                }
                else
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.StarWrath);
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.MoltenFury);
                    }
                }

            }
            return true;
        }
    }
}


    