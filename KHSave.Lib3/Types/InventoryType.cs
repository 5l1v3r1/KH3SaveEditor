﻿/*
    Kingdom Hearts Save Editor
    Copyright (C) 2019 Luciano Ciccariello

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using KHSave.Attributes;

namespace KHSave.Types
{
	public enum InventoryType
	{
		Empty,
		[Consumable("Potion")] Potion,
		[Consumable("Hi-Potion")] HiPotion,
		[Consumable("Mega-Potion")] MegaPotion,
		[Consumable("Ether")] Ether,
		[Consumable("Mega-Ether")] MegaEther,
		[Consumable("Elixir")] Elixir,
		[Consumable("Megalixir")] Megalixir,
		[Consumable("Refocuser")] Refocuser,
		[Consumable("Hi-Refocuser")] HiRefocuser,
		[Consumable("Panacea")] Panacea,
		[Consumable("Hi-Ether")] HiEther,
		[Unused] UnusedItem0d,
		[Unused] UnusedItem0e,
		[Unused] UnusedItem0f,
		[Unused] UnusedItem10,
		[Unused] UnusedItem11,
		[Tent("Tent")] Tent,
		[Tent("Strength boost")] StrengthBoost,
		[Tent("Magic boost")] MagicBoost,
		[Tent("Defense boost")] DefenseBoost,
		[Tent("AP boost")] ApBoost,
		[Unused] UnusedBoost17,
		[Unused] UnusedBoost18,
		[Unused] UnusedBoost19,
		[Keyblade("Kingdom Key")] KingdomKey,
		[Keyblade("Hero's Origin")] HeroOrigin,
		[Keyblade("Shooting Star")] ShootingStar,
		[Keyblade("Favorite Deputy")] FavoriteDeputy,
		[Keyblade("Even After")] EvenAfter,
		[Keyblade("Happy Gear")] HappyGear,
		[Keyblade("Crystal Snow")] CrystalSnow,
		[Keyblade("Hunny Spout")] HunnySpout,
		[Keyblade("Nano Gear")] NanoGear,
		[Keyblade("Wheel of Fate")] WheelOfFate,
		[Keyblade("Grand Chef")] GrandChef,
		[Keyblade("Classic Tone")] ClassicTone,
		[Unused] UnusedKeyblade26,
		[Unused] UnusedKeyblade27,
		[Keyblade("Ultima Weapon")] UltimaWeapon,
		[Keyblade("Midnight Blue")] MidnightBlue,
		[Unused] UnusedKeyblade2a,
		[Keyblade("Starlight")] Starlight,
		[Keyblade("Dawn Till Dusk")] DawnTillDusk,
		[Unused] UnusedKeyblade2b,
		[Staff("Mage's Staff")] Weapon15,
		[Staff("Mage's Staff+")] Weapon16,
		[Staff("Warhammer")] Weapon17,
		[Staff("Warhammer+")] Weapon18,
		[Staff("Magician's Wand")] Weapon19,
		[Staff("Magician's Wand+")] Weapon1a,
		[Staff("Nirvana")] Weapon1b,
		[Staff("Nirvana+")] Weapon1c,
		[Staff("Astroblade")] Weapon1d,
		[Staff("Astroblade+")] Weapon1e,
		[Staff("Heartless Maul")] Weapon1f,
		[Staff("Heartless Maul+")] Weapon20,
		[Staff("Save the Queen")] Weapon21,
		[Staff("Save the Queen+")] SaveTheQueenPlus,
		[Unused] UnusedStaff3c,
		[Unused] UnusedStaff3d,
		[Unused] UnusedStaff3e,
		[Unused] UnusedStaff3f,
		[Unused] UnusedStaff40,
		[Unused] UnusedStaff41,
		[Shield("Knight Shield")] Weapon29,
		[Shield("Knight Shield+")] Weapon2a,
		[Shield("Clockwork Shield")] Weapon2b,
		[Shield("Clockwork Shield+")] Weapon2c,
		[Shield("Star Shield")] Weapon2d,
		[Shield("Star Shield+")] Weapon2e,
		[Shield("Aegis Shield")] Weapon2f,
		[Shield("Aegis Shield+")] Weapon30,
		[Shield("Storm Anchor")] Weapon31,
		[Shield("Storm Anchor+")] Weapon32,
		[Shield("Nobody Guard")] Weapon33,
		[Shield("Nobody Guard+")] Weapon34,
		[Shield("Save the King")] Weapon35,
		[Shield("Save the King+")] SaveTheKingPlus,
		[Unused] Unused50,
		[Unused] Unused51,
		[Unused] Unused52,
		[Unused] Unused53,
		[Unused] Unused54,
		[Unused] Unused55,
		[Unused] Unused56,
		[Unused] Unused57,
		[Unused] Unused58,
		[Unused] Unused59,
		[Unused] Unused5a,
		[Unused] Unused5b,
		[Unused] Unused5c,
		[Unused] Unused5d,
		[Weapon("Heart of Hero")] HeartOfHero,
		[Weapon("Cowboy's Pride")] CowboyPride,
		[Weapon("Space Ranger Suit")] SpaceRangerSuit,
		[Weapon("Golden Hair")] GoldenHair,
		[Weapon("Frying Pan")] FryingPan,
		[Weapon("Skill & Crossbones")] SkillAndCrossbones,
		[Weapon("Ice Claws")] IceClaws,
		[Weapon("Powered Suit")] PoweredSuit,
		[Weapon("Claws")] Claws,
		[Weapon("Knockout Body")] KnockoutBody,

		[Armor("Hero's Belt")] HeroBelt = 125,
		[Armor("Hero's Glove")] HeroGlove,
		[Armor("Shield Belt")] ShieldBelt,
		[Armor("Defense Belt")] DefensedBelt,
		[Armor("Guardian's Belt")] GuardianBelt,
		[Armor("Power Band")] PowerBand,
		[Armor("Buster Band")] BusterBand,
		[Armor("Buster Band+")] BusterBandPlus,
		[Armor("Cosmic Belt")] CosmicBelt,
		[Armor("Cosmic Belt+")] CosmicBeltPlus,
		[Armor("Fire Bangle")] FireBangle,
		[Armor("Firaga Bangle")] FiragaBangle,
		[Armor("Firaza Bangle")] FirazaBangle,
		[Armor("Fire Chain")] FireChain,
		[Armor("Blizzard Choker")] BlizzardChocker,
		[Armor("Blizzara Choker")] BlizzaraChocker,
		[Armor("Blizzaga Choker")] BlizzagaChocker,
		[Armor("Blizzard Chain")] BlizzardChain,
		[Armor("Thunder Trinket")] ThunderTrinker,
		[Armor("Thundaga Trinket")] ThundagaTrinker,
		[Armor("Thundaza Trinket")] ThundazaTrinker,
		[Armor("Thunder Chain")] ThunderChain,
		[Armor("Dark Anklet")] DarkAnklet,
		[Armor("Midnight Anklet")] MidnightAnklet,
		[Armor("Chaos Anklet")] ChaosAnklet,
		[Armor("Dark Chain")] DarkChain,
		[Armor("Divine Bandanna")] DivineBandanna,
		[Armor("Elven Bandanna")] ElvenBandanna,
		[Armor("Aqua Chaplet")] AquaChaplet,
		[Armor("Wind Fan")] WindFan,
		[Armor("Storm Fan")] StormFan,
		[Armor("Aero Armlet")] AeroArmlet,
		[Armor("Aegis Chain")] AegisChain,
		[Armor("Acrisius")] Acrisius,
		[Armor("Cosmic Chain")] CosmicChain,
		[Armor("Petite Ribbon")] PetiteRibbon,
		[Armor("Ribbon")] Ribbon,
		[Armor("Fira Bangle")] FiraBangle,
		[Armor("Blizzaza Choker")] BlizzazaChocker,
		[Armor("Thundara Trinket")] BlizzazaTrinker,
		[Armor("Shadow Anklet")] ShadowAnklet,
		[Armor("Abas Chain")] AbasChain,
		[Armor("Acrisius+")] AcrisiusPlus,
		[Armor("Royal Ribbon")] RoyalRibbon,
		[Armor("Firefighter Rosette")] FirefighterRosette,
		[Armor("Umbrella Rosette")] UmbrellaRosette,
		[Armor("Mask Rosette")] MaskRosette,
		[Armor("Snowman Rosette")] SnowmanRosette,
		[Armor("Insulator Rosette")] InsulatorRosette,

        [Accessory("Laughter Pin")] LaughterPin = 225,
        [Accessory("Forest Clasp")] ForestClasp,
        [Accessory("Ability Ring")] AbilityRing,
        [Accessory("Ability Ring+")] AbilityRingPlus,
        [Accessory("Technician's Ring")] TechnicianRing,
        [Accessory("Technician's Ring+")] TechnicianRingPlus,
        [Accessory("Skill Ring")] SkillRing,
        [Accessory("Skill Ring+")] SkillRingPlus,
        [Accessory("Expert's Ring")] ExpertRing,
        [Accessory("Master's Ring")] MasterRing,
        [Accessory("Cosmic Ring")] CosmicRing,
        [Accessory("Power Ring")] PowerRing,
        [Accessory("Buster Ring")] BusterRing,
        [Accessory("Valor Ring")] ValorRing,
        [Accessory("Phantom Ring")] PhantomRing,
        [Accessory("Orichalcum Ring")] OrichalcumRing,
        [Accessory("Magic Ring")] MagicRing,
        [Accessory("Rune Ring")] RuneRing,
        [Accessory("Force Ring")] ForceRing,
        [Accessory("Sorcerer's Ring")] SorcererRing,
        [Accessory("Wisdom Ring")] WisdomRing,
        [Accessory("Bronze Necklace")] BronzeNecklace,
        [Accessory("Silver Necklace")] SilverNecklace,
        [Accessory("Master's Necklace")] MasterNecklace,
        [Accessory("Bronze Amulet")] BronzeAmulet,
        [Accessory("Silver Amulet")] SilverAmulet,
        [Accessory("Gold Amulet")] GoldAmulet,
        [Accessory("Junior Medal")] JuniorMedal,
        [Accessory("Master Medal")] MasterMedal,
        [Accessory("Star Medal")] StarMedal,
        [Accessory("Mickey Clasp")] MickeyClasp,
        [Accessory("Soldier's Earring")] SoldierEarring,
        [Accessory("Fencer's Earring")] FencerEarring,
        [Accessory("Mage's Earring")] MageEarring,
        [Accessory("Slayer's Earring")] SlayerEarring,
        [Accessory("Moon Amulet")] MoonAmulet,
        [Accessory("Star Charm")] StarCharm,
        [Accessory("Cosmic Arts")] CosmicArts,
        [Accessory("Crystal Regalia")] CrystalRegalia,
        [Accessory("Water Cufflink")] WaterCufflink,
        [Accessory("Thunder Cufflink")] ThunderCufflink,
        [Accessory("Fire Cufflink")] FireCufflink,
        [Accessory("Aero Cufflink")] AeroCufflink,
        [Accessory("Blizzard Cufflink")] BlizzardCufflink,
        [Accessory("Celestriad")] Celestriad,
        [Accessory("Yin-Yang Cufflink")] YinYangCufflink,
        [Accessory("Gourmand's Ring")] GourmandRing,
        [Accessory("Draw Ring")] DrawRing,
        [Accessory("Lucky Ring")] LuckyRing,
        [Accessory("Flanniversary Badge")] FlanniversaryBadge,
        [Accessory("Bronze Necklace")] BronzeNecklace_33,
        [Accessory("Bronze Necklace")] BronzeNecklace_34,
        [Accessory("Bronze Necklace")] BronzeNecklace_35,
        [Accessory("Bronze Necklace")] BronzeNecklace_36,
        [Accessory("Bronze Necklace")] BronzeNecklace_37,
        [Accessory("Bronze Necklace")] BronzeNecklace_38,
        [Accessory("Bronze Necklace")] BronzeNecklace_39,
        [Accessory("Bronze Necklace")] BronzeNecklace_3A,
        [Accessory("Bronze Necklace")] BronzeNecklace_3B,
        [Accessory("Bronze Necklace")] BronzeNecklace_3C,
        [Accessory("Bronze Necklace")] BronzeNecklace_3D,
        [Accessory("Bronze Necklace")] BronzeNecklace_3E,
        [Accessory("Silver Necklace")] SilverNecklace_3F,
        [Accessory("Silver Necklace")] SilverNecklace_40,
        [Accessory("Silver Necklace")] SilverNecklace_41,
        [Accessory("Silver Necklace")] SilverNecklace_42,
        [Accessory("Silver Necklace")] SilverNecklace_43,
        [Accessory("Silver Necklace")] SilverNecklace_44,
        [Accessory("Silver Necklace")] SilverNecklace_45,
        [Accessory("Silver Necklace")] SilverNecklace_46,
        [Accessory("Silver Necklace")] SilverNecklace_47,
        [Accessory("Silver Necklace")] SilverNecklace_48,
        [Accessory("Silver Necklace")] SilverNecklace_49,
        [Accessory("Master's Necklace")] MasterNecklace_4A,
        [Accessory("Master's Necklace")] MasterNecklace_4B,
        [Accessory("Master's Necklace")] MasterNecklace_4C,
        [Accessory("Master's Necklace")] MasterNecklace_4D,
        [Accessory("Master's Necklace")] MasterNecklace_4E,
        [Accessory("Master's Necklace")] MasterNecklace_4F,
        [Accessory("Master's Necklace")] MasterNecklace_50,
        [Accessory("Master Medal")] MasterMedal_51,
        [Accessory("Master Medal")] MasterMedal_52,
        [Accessory("Junior Medal")] JuniorMedal_53,
        [Accessory("Master Medal")] MasterMedal_54,
        [Accessory("Junior Medal")] JuniorMedal_55,
        [Accessory("Junior Medal")] JuniorMedal_56,
        [Accessory("Junior Medal")] JuniorMedal_57,
        [Accessory("Junior Medal")] JuniorMedal_58,
        [Accessory("Junior Medal")] JuniorMedal_59,
        [Accessory("Junior Medal")] JuniorMedal_5A,
        [Accessory("Junior Medal")] JuniorMedal_5B,
        [Accessory("Junior Medal")] JuniorMedal_5C,
        [Accessory("Star Medal")] StarMedal_5D,
        [Accessory("Master Medal")] MasterMedal_5E,
        [Accessory("Master Medal")] MasterMedal_5F,
        [Accessory("Star Medal")] StarMedal_60,
        [Accessory("Master Medal")] MasterMedal_61,
        [Accessory("Star Medal")] StarMedal_62,
        [Accessory("Master Medal")] MasterMedal_63,
        [Accessory("Master Medal")] MasterMedal_64,
        [Accessory("Master Medal")] MasterMedal_65,
        [Accessory("Master Medal")] MasterMedal_66,
        [Accessory("Master Medal")] MasterMedal_67,
        [Accessory("Master Medal")] MasterMedal_68,
        [Accessory("Star Medal")] StarMedal_69,
        [Accessory("Star Medal")] StarMedal_6A,
        [Accessory("Star Medal")] StarMedal_6B,
        [Accessory("Star Medal")] StarMedal_6C,
        [Accessory("Star Medal")] StarMedal_6D,
        [Accessory("Star Medal")] StarMedal_6E,

        [Snack("Pumpkin Velouté")] PumpkinVeloute = 425,
        [Snack("Consomé")] Consome,
        [Snack("Carrot Potage")] CarrotPotage,
        [Snack("Crab Bisque")] CrabBisque,
        [Snack("Cold Tomato Soup")] ColdTomatoSoup,
        [Snack("Scallop Poêlé")] ScallopPoele,
        [Snack("Lobster Mousse")] LobsterMousse,
        [Snack("Mushroom Terrine")] MushroomTerrine,
        [Snack("Ratatouille")] Ratatouille,
        [Snack("Caprese Salad")] CapreseSalad,
        [Snack("Sole Meunière")] SoleMeuniere,
        [Snack("Eel Matelote")] EelMatelote,
        [Snack("Sea Bass en Papillote")] SeaBassEnPapillote,
        [Snack("Bouillabaisse")] Bouillabaisse,
        [Snack("Seafood Tartare")] SeafoodTartare,
        [Snack("Sea Bass Poêlé")] SeaBassPoele,
        [Snack("Sweetbread Poêlé")] SweetbreadPoele,
        [Snack("Beef Sauté")] BeefSaute,
        [Snack("Beef Bourguignon")] BeefBourguignon,
        [Snack("Stuffed Quail")] StuffedQuail,
        [Snack("Filet Mignon Poêlé")] FiletMignonPoele,
        [Snack("Crêpes Suzette")] CrepesSuzette,
        [Snack("Chocolate Mousse")] ChocolateMousse,
        [Snack("Fresh Fruit Compote")] FreshFruitCompote,
        [Snack("Berries au Fromage")] BerriesAuFromage,
        [Snack("Warm Banana Soufflé")] WarmBananaSouffle,
        [Snack("Fruit Gelée")] FruitGelee,
        [Snack("Tarte aux Fruits")] TarteAuxFruits,
        [Snack("Pumpkin Velouté+")] PumpkinVeloutePlus,
        [Snack("Consomé+")] ConsomePlus,
        [Snack("Carrot Potage+")] CarrotPotagePlus,
        [Snack("Crab Bisque+")] CrabBisquePlus,
        [Snack("Cold Tomato Soup+")] ColdTomatoSoupPlus,
        [Snack("Scallop Poêlé+")] ScallopPoelePlus,
        [Snack("Lobster Mousse+")] LobsterMoussePlus,
        [Snack("Mushroom Terrine+")] MushroomTerrinePlus,
        [Snack("Ratatouille+")] RatatouillePlus,
        [Snack("Caprese Salad+")] CapreseSaladPlus,
        [Snack("Sole Meunière+")] SoleMeunierePlus,
        [Snack("Eel Matelote+")] EelMatelotePlus,
        [Snack("Sea Bass en Papillote+")] SeaBassEnPapillotePlus,
        [Snack("Bouillabaisse+")] BouillabaissePlus,
        [Snack("Seafood Tartare+")] SeafoodTartarePlus,
        [Snack("Sea Bass Poêlé+")] SeaBassPoelePlus,
        [Snack("Sweetbread Poêlé+")] SweetbreadPoelePlus,
        [Snack("Beef Sauté+")] BeefSautePlus,
        [Snack("Beef Bourguignon+")] BeefBourguignonPlus,
        [Snack("Stuffed Quail+")] StuffedQuailPlus,
        [Snack("Filet Mignon Poêlé+")] FiletMignonPoelePlus,
        [Snack("Crêpes Suzette+")] CrepesSuzettePlus,
        [Snack("Chocolate Mousse+")] ChocolateMoussePlus,
        [Snack("Fresh Fruit Compote+")] FreshFruitCompotePlus,
        [Snack("Berries au Fromage+")] BerriesAuFromagePlus,
        [Snack("Warm Banana Soufflé+")] WarmBananaSoufflePlus,
        [Snack("Fruit Gelée+")] FruitGeleePlus,
        [Snack("Tarte aux Fruits+")] TarteAuxFruitsPlus,

        [Synthesis("Blazing Shard")] BlazingShard = 489,
        [Synthesis("Blazing Stone")] BlazingStone,
        [Synthesis("Blazing Gem")] BlazingGem,
        [Synthesis("Blazing Crystal")] BlazingCrystal,
        [Synthesis("Frost Shard")] FrostShard,
        [Synthesis("Frost Stone")] FrostStone,
        [Synthesis("Frost Gem")] FrostGem,
        [Synthesis("Frost Crystal")] FrostCrystal,
        [Synthesis("Lightning Shard")] LightningShard,
        [Synthesis("Lightning Stone")] LightningStone,
        [Synthesis("Lightning Gem")] LightningGem,
        [Synthesis("Lightning Crystal")] LightningCrystal = 500,
        [Synthesis("Lucid Shard")] LucidShard,
        [Synthesis("Lucid Stone")] LucidStone,
        [Synthesis("Lucid Gem")] LucidGem,
        [Synthesis("Lucid Crystal")] LucidCrystal,
        [Synthesis("Pulsing Shard")] PulsingShard,
        [Synthesis("Pulsing Stone")] PulsingStone,
        [Synthesis("Pulsing Gem")] PulsingGem,
        [Synthesis("Pulsing Crystal")] PulsingCrystal,
		[Synthesis("Writhing Shard")] WrithingShard,
		[Synthesis("Writhing Stone")] WrithingStone,
		[Synthesis("Writhing Gem")] WrithingGem,
		[Synthesis("Writhing Crystal")] WrithingCrystal,
		[Synthesis("Betwixt Shard")] BetwixtShard,
		[Synthesis("Betwixt Stone")] BetwixtStone,
		[Synthesis("Betwixt Gem")] BetwixtGem,
		[Synthesis("Betwixt Crystal")] BetwixtCrystal,
		[Synthesis("Twilight Shard")] TwilightShard,
		[Synthesis("Twilight Stone")] TwilightStone,
		[Synthesis("Twilight Gem")] TwilightGem,
		[Synthesis("Twilight Crystal")] TwilightCrystal,
        [Synthesis("Mythril Shard")] MythrilShard,
        [Synthesis("Mythril Stone")] MythrilStone,
        [Synthesis("Mythril Gem")] MythrilGem,
        [Synthesis("Mythril Crystal")] MythrilCrystal,
        [Synthesis("Sinister Shard")] SinisterShard,
        [Synthesis("Sinister Stone")] SinisterStone,
        [Synthesis("Sinister Gem")] SinisterGem,
        [Synthesis("Sinister Crystal")] SinisterCrystal,
        [Synthesis("Soothing Shard")] SoothingShard,
        [Synthesis("Soothing Stone")] SoothingStone,
        [Synthesis("Soothing Gem")] SoothingGem,
        [Synthesis("Soothing Crystal")] SoothingCrystal,
        [Synthesis("Wellspring Shard")] WellspringShard,
        [Synthesis("Wellspring Stone")] WellspringStone,
        [Synthesis("Wellspring Gem")] WellspringGem,
        [Synthesis("Wellspring Crystal")] WellspringCrystal,
        [Synthesis("Hungry Shard")] HungryShard,
        [Synthesis("Hungry Stone")] HungryStone,
        [Synthesis("Hungry Gem")] HungryGem,
        [Synthesis("Hungry Crystal")] HungryCrystal,
        [Synthesis("Fluorite")] Fluorite,
        [Synthesis("Damascus")] Damascus,
        [Synthesis("Adamantite")] Adamantite,
        [Synthesis("Orichalcum")] Orichalcum,
        [Synthesis("Orichalcum+")] OrichalcumPlus,
        [Synthesis("Electrum")] Electrum,
        [Synthesis("Evanescent Crystal")] EvanescentCrystal,
        [Synthesis("Illusory Crystal")] IllusoryCrystal,

        [Food("Crab")] Crab = 589,
        [Food("Scallop")] Scallop,
        [Food("Lobster")] Lobster,
        [Food("Sole")] Sole,
        [Food("Eel")] Eel,
        [Food("Sea Bass")] SeaBass,
        [Food("Mussel")] Mussel,
        [Food("Cod")] Cod,
        [Food("Pumpkin")] Pumpkin,
        [Food("Zucchini")] Zucchini,
        [Food("Onion")] Onion,
        [Food("")] Tomato,
        [Food("")] Eggplant,
        [Food("")] Carrot,
        [Food("")] Garlic,
        [Food("")] Celery,
        [Food("")] Morel,
        [Food("")] Porcini,
        [Food("")] Chanterelle,
        [Food("")] Portobello,
        [Food("Black Truffle")] BlackTruffle,
        [Food("King Oyster Mushroom")] KingOysterMushroom,
        [Food("Black Trumpet")] BlackTrumpet,
        [Food("Miller Mushroom")] MillerMushroom,
        [Food("")] Cloves,
        [Food("")] Rosemary,
        [Food("")] Thyme,
        [Food("Bay Leaf")] BayLeaf,
        [Food("")] Basil,
        [Food("")] Dill,
        [Food("")] Parsley,
        [Food("")] Saffron,
        [Food("")] Apricot,
        [Food("")] Gooseberry,
        [Food("")] Lemon,
        [Food("")] Orange,
        [Food("")] Raspberry,
        [Food("")] Pear,
        [Food("")] Blackberry,
        [Food("")] Apple,
        [Food("")] Cheese,
        [Food("")] Chocolate,
        [Food("")] Caviar,
        [Food("")] Butter,
        [Food("Olive Oil")] OliveOil,
        [Food("")] Cornichon,
        [Food("")] Rice,
        [Food("")] Honey,
        [Food("Sour Cherry")] SourCherry,
        [Food("")] Strawberry,
        [Food("Blood Orange")] BloodOrange,
        [Food("")] Banana,
        [Food("")] Grapes,
        [Food("")] Melon,
        [Food("")] Watermelon,
        [Food("")] Veal,
        [Food("")] Beef,
        [Food("")] Quail,
        [Food("Filet Mignon")] FiletMignon,

        [KeyItem("Gummiphone")] Gummiphone = 654,
        [KeyItem("AR Device")] ARDevice,
        [KeyItem("Prize Postcard")] PrizePostcard,
        [KeyItem("M.O.G. Card")] MOGCard,
        [KeyItem("Dream Heartbinder")] DreamHeartbinder,
        [KeyItem("Pixel Heartbinder")] PixelHeartbinder,
        [KeyItem("'Ohana Heartbinder")] OhanaHeartbinder,
        [KeyItem("Pride Heartbinder")] PrideHeartbinder,
        [KeyItem("Ocean Heartbinder")] OceanHeartbinder,
        [KeyItem("Golden Herc Figure")] GoldenHercFigure,
        
        [MogItem("Kupo Coin")] KupoCoin = 677,

        [Info("Angular/G-01")] Item833 = 833,
        [Info("Angular/G-02")] Item834,
        [Info("Angular/G-03")] Item835,
        [Info("Angular/G-04")] Item836,
        [Info("Angular/G-05")] Item837,
        [Info("Angular/G-06")] Item838,
        [Info("Angular/G-07")] Item839,
        [Info("Angular/G-08")] Item840,
        [Info("Angular/G-09")] Item841,
        [Info("Angular/G-10")] Item842,
        [Info("Angular/G-11")] Item843,
        [Info("Angular/G-12")] Item844,
        [Info("Rounded/G-01")] Item845,
        [Info("Rounded/G-02")] Item846,
        [Info("Rounded/G-03")] Item847,
        [Info("Rounded/G-04")] Item848,
        [Info("Rounded/G-05")] Item849,
        [Info("Rounded/G-06")] Item850,
        [Info("Rounded/G-07")] Item851,
        [Info("Rounded/G-08")] Item852,
        [Info("Rounded/G-09")] Item853,
        [Info("Rounded/G-10")] Item854,
        [Info("Rounded/G-11")] Item855,
        [Info("Rounded/G-12")] Item856,
        [Info("Rounded/G-13")] Item857,
        [Info("Rounded/G-14")] Item858,
        [Info("Rounded/G-15")] Item859,
        [Info("Cylindrical/G-01")] Item860,
        [Info("Cylindrical/G-02")] Item861,
        [Info("Cylindrical/G-03")] Item862,
        [Info("Cylindrical/G-04")] Item863,
        [Info("Cylindrical/G-05")] Item864,
        [Info("Cylindrical/G-06")] Item865,
        [Info("Cylindircal/G-07")] Item866,
        [Info("Cylindrical/G-08")] Item867,
        [Info("Cylindrical/G-09")] Item868,
        [Info("Aero/G-01")] Item869,
        [Info("Aero/G-02")] Item870,
        [Info("Aero/G-03")] Item871,
        [Info("Aero/G-04")] Item872,
        [Info("Aero/G-05")] Item873,
        [Info("Aero/G-06")] Item874,
        [Info("Aero/G-07")] Item875,
        [Info("Aero/G-08")] Item876,
        [Info("Aero/G-09")] Item877,
        [Info("Aero/G-10")] Item878,
        [Info("Aero/G-11")] Item879,
        [Info("Aero/G-12")] Item880,

        [Info("Fire/G")] Item907 = 907,
        [Info("Fira/G")] Item908,
        [Info("Firaga/G-01")] Item909,
        [Info("Firaga/G-02")] Item910,
        [Info("Blizzard/G")] Item911,
        [Info("Blizzara/G")] Item912,
        [Info("Blizzaga/G-01")] Item913,
        [Info("Blizzaga/G-02")] Item914,
        [Info("Gravity/G")] Item915,
        [Info("Gravira/G")] Item916,
        [Info("Graviga/G-01")] Item917,
        [Info("Graviga/G-02")] Item918,
        [Info("Water/G")] Item919,
        [Info("Watera/G")] Item920,
        [Info("Waterga/G-01")] Item921,
        [Info("Waterga/G-02")] Item922,
        [Info("Comet/G")] Item923,
        [Info("Meteor/G")] Item924,
        [Info("Thunder/G")] Item925,
        [Info("Thundara/G")] Item926,
        [Info("Thundaga/G")] Item927,
        [Info("Ultima/G")] Item928,
        [Info("Masamune/G")] Item929,
        [Info("Excalibur/G")] Item930,
        [Info("Drill/G")] Item931,
        [Info("Saw/G")] Item932,
        [Info("Gungnir/G")] Item933,
        [Info("Laser Blade/G")] Item934,
        [Info("Knuckle/G")] Item935,
        [Info("Manipulator/G")] Item936,
        [Info("Vernier/G")] Item937,
        [Info("Thruster/G")] Item938,
        [Info("Booster/G")] Item939,
        [Info("Rocket/G")] Item940,
        [Info("Mini-Propeller/G")] Item941,
        [Info("Propeller/G")] Item942,
        [Info("Screw Propeller/G")] Item943,
        [Info("Small Rotor/G")] Item944,
        [Info("Rotor/G")] Item945,
        [Info("Large Rotor/G")] Item946,
        [Info("Mast/G")] Item947,
        [Info("Cyclone/G")] Item948,
        [Info("Storm/G")] Item949,
        [Info("Tempest/G")] Item950,
        [Info("Typhoon/G")] Item951,
        [Info("Hurricane/G")] Item952,
        [Info("Vortex/G")] Item953,
        [Info("Sonic Turbo/G")] Item954,
        [Info("Darkness/G")] Item955,
        [Info("Angel/G")] Item956,
        [Info("Butterfly/G")] Item957,
        [Unused] Item958,
        [Info("Tire/G")] Item959,
        [Info("Caterpillar/G")] Item960,
        [Info("Triple Wheel/G")] Item961,
        [Info("Bubble Helm/G")] Item962,
        [Info("Flat Helm/G")] Item963,
        [Info("Solid Helm/G")] Item964,
        [Info("Sphere Helm/G")] Item965,
        [Info("Bridge/G")] Item966,
        [Info("Big Bridge/G")] Item967,
        [Info("Mini-Helm/G")] Item968,
        [Info("Long Helm/G")] Item969,
        [Unused] Item970,
        [Info("Wall/G")] Item971,
        [Info("Large Wall/G")] Item972,
        [Info("Shield/G")] Item973,
        [Info("Large Shield/G")] Item974,
        [Info("Radome/G")] Item975,
        [Info("Antenna/G")] Item976,
        [Info("Parabola/G")] Item977,
        [Info("Neon Orb/G")] Item978,
        [Info("Neon Bar/G")] Item979,
        [Info("Neon Chain/G")] Item980,
        [Info("Round Light/G")] Item981,
        [Info("Square Light/G")] Item982,
        [Info("Strobe Light/G")] Item983,
        [Info("Flag/G")] Item984,
        [Info("Muffler/G")] Item985,
        [Info("Chimney/G")] Item986,
        [Info("Beetle Horn/G")] Item987,
        [Info("Cat Ear/G")] Item988,
        [Info("Cat Tail/G")] Item989,
        [Info("")] Item990,
        [Info("Dog/G-01")] Item991,
        [Info("Cat/G")] Item992,
        [Info("Chocochick/G")] Item993,
        [Info("Dog/G-02")] Item994,
        [Info("Bunny/G")] Item995,
        [Info("Bird/G")] Item996,
        [Info("Meow Wow/G")] Item997,
        [Info("Flantastic Seven/G-01")] Item998,
        [Info("Flantastic Seven/G-02")] Item999,
        [Info("Flantastic Seven/G-03")] Item1000,
        [Info("Present/G")] Item1001,
        [Info("Cake/G")] Item1002,
        [Info("Treasure Chest/G")] Item1003,
        [Info("Lantern/G")] Item1004,
    }
}
