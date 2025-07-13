using RimWorld;

using Verse;

namespace MiscRobotsPlusPlus
{
	public class MiscPlusPlusSettings : ModSettings
	{

		public static SettingsPages currentPage;

		private static bool cleanerTweaks = false;
		private static bool crafterTweaks = false;
		private static bool builderTweaks = false;
		private static bool kitchenTweaks = false;
		private static bool eRTweaks = false;
		private static bool omniTweaks = false;

		private static bool cleanerStationTweaks = false;
		private static bool haulerStationTweaks = false;
		private static bool crafterStationTweaks = false;
		private static bool builderStationTweaks = false;
		private static bool kitchenStationTweaks = false;
		private static bool eRStationweaks = false;
		private static bool omniStationTweaks = false;

		// private static bool DevTweaks = false;

		//Contains list of all bots by DefName
		//Remember to keep same names as in XML files
		//It throws error if it does not match
		#region Def Robot Names
		private static readonly string[] cleanerList = ["AIRobot_Cleaner", "AIRobot_Cleaner_II", "AIRobot_Cleaner_III", "AIRobot_Cleaner_IV", "AIRobot_Cleaner_V"];
		private static readonly string[] crafterList = ["RPP_Bot_Crafter_I", "RPP_Bot_Crafter_II", "RPP_Bot_Crafter_III", "RPP_Bot_Crafter_IV", "RPP_Bot_Crafter_V"];
		private static readonly string[] kitchenList = ["RPP_Bot_Kitchen_I", "RPP_Bot_Kitchen_II", "RPP_Bot_Kitchen_III", "RPP_Bot_Kitchen_IV", "RPP_Bot_Kitchen_V"];
		private static readonly string[] buildersList = ["RPP_Bot_Builder_I", "RPP_Bot_Builder_II", "RPP_Bot_Builder_III", "RPP_Bot_Builder_IV", "RPP_Bot_Builder_V"];
		private static readonly string[] ERList = ["RPP_Bot_ER_I", "RPP_Bot_ER_II", "RPP_Bot_ER_III", "RPP_Bot_ER_IV", "RPP_Bot_ER_V"];
		private static readonly string[] omniList = ["RPP_Bot_Omni_I", "RPP_Bot_Omni_II", "RPP_Bot_Omni_III", "RPP_Bot_Omni_IV", "RPP_Bot_Omni_V"];
		#endregion

		/// <summary>
		/// Settings are saved in same order as stats
		/// </summary>
		#region Robots  Settings

		#region Cleaner Compleated Settings
		private static readonly StatDef[] cleanerStats = [StatDefOf.CleaningSpeed, StatDefOf.MarketValue];

		private readonly static float[,] cleanerDefaultSettings = new float[5, 2] {

				{ 1f, 1500  },
				{ 2f, 1500  },
				{ 2.5f, 1500  },
				{ 3f, 1500  },
				{ 4f, 1500  }
		};
		private static readonly float[,] cleanerSettings = new float[5, 2] {

				{ 1f, 1500  },
				{ 2f, 1500  },
				{ 2.5f, 1500  },
				{ 3f, 1500  },
				{ 4f, 1500  }
		};

		private static readonly bool[,] CleanerisPrecent = new bool[5, 2]
		{
			{true,false },
			{true,false },
			{true,false },
			{true,false },
			{true,false }
		};
		#endregion

		#region Crafter Compleated Match
		private static readonly StatDef[] crafterStats = [StatDefOf.WorkSpeedGlobal, StatDefOf.MarketValue];
		// Must be saved in same order as List of Stats in float table;
		private readonly static float[,] crafterDefaultSettings = new float[5, 2] {

				{ 1f,  1500  },
				{ 2f,  1500  },
				{ 2.5f,1500  },
				{ 3f,  1500  },
				{ 4f, 1500  }
		};
		private static readonly float[,] crafterSettings = new float[5, 3] {

				{ 1f,1f,  1500  },
				{ 2f, 2f, 1500  },
				{ 2.5f, 2.5f ,1500  },
				{ 3f,  3f, 1500  },
				{ 4f, 4f, 1500  }
		};
		private static readonly bool[,] crafterIsPrecent = new bool[5, 3]
		{
			{true,true,false },
			{true,true,false },
			{true,true,false },
			{true,true,false },
			{true,true,false }
		};
		#endregion

		#region Kitchen Compleated Match

		private static readonly StatDef[] kitchenStats = [StatDefOf.GeneralLaborSpeed, StatDefOf.PlantWorkSpeed, StatDefOf.PlantHarvestYield, StatDefOf.DrugHarvestYield, StatDefOf.MarketValue,];
		// Must be saved in same order as List of Stats in float table;
		private readonly static float[,] kitchenDefaultSettings = new float[5, 5] {

				{ 1f, 1f, 1f , 1f, 1500 },
				{ 2f, 2f, 1.25f , 1.25f, 1500 },
				{ 2.5f, 1.5f, 1.5f , 1.5f, 1500 },
				{ 3f, 3f, 1.75f , 1.75f, 1500 },
				{ 4f, 4f, 2f , 2f, 1500 }
		};
		private static readonly float[,] kitchenSettings = new float[5, 5] {

				{ 1f, 1f, 1f , 1f, 1500 },
				{ 2f, 2f, 1.25f , 1.25f, 1500 },
				{ 2.5f, 1.5f, 1.5f , 1.5f, 1500 },
				{ 3f, 3f, 1.75f , 1.75f, 1500 },
				{ 4f, 4f, 2f , 2f, 1500 }
		};
		private static readonly bool[,] kitchenIsPrecent = new bool[5, 5]
	{
			{true,true,true,true,false },
			{true,true,true,true,false },
			{true,true,true,true,false },
			{true,true,true,true,false },
			{true,true,true,true,false }
	};
		#endregion

		#region Builder Compleated Match

		private static readonly StatDef[] builderStats = [StatDefOf.ConstructionSpeed, StatDefOf.DeepDrillingSpeed, StatDefOf.SmoothingSpeed, StatDefOf.MiningYield, StatDefOf.MarketValue,];
		// Must be saved in same order as List of Stats in float table;
		private readonly static float[,] builderDefaultSettings = new float[5, 5] {

				{ 1f, 1f, 1f , 1f, 1500 },
				{ 2f, 2f, 2f , 1.25f, 1500 },
				{ 2.5f, 2.5f, 1.5f , 1.5f, 1500 },
				{ 3f, 3f, 3f , 1.75f, 1500 },
				{ 4f, 4f, 4f , 2f, 1500 }
		};
		private static readonly float[,] builderSettings = new float[5, 5] {

				{ 1f, 1f, 1f , 1f, 1500 },
				{ 2f, 2f, 2f , 1.25f, 1500 },
				{ 2.5f, 2.5f, 1.5f , 1.5f, 1500 },
				{ 3f, 3f, 3f , 1.75f, 1500 },
				{ 4f, 4f, 4f , 2f, 1500 }
		};
		private static readonly bool[,] builderIsPrecent = new bool[5, 5]
		{
			{true,true,true,true,false },
			{true,true,true,true,false },
			{true,true,true,true,false },
			{true,true,true,true,false },
			{true,true,true,true,false }
		};
		#endregion

		#region ER Compleated Match
		private static readonly StatDef[] ERStats = [StatDefOf.MedicalTendSpeed, StatDefOf.MedicalSurgerySuccessChance, StatDefOf.MarketValue,];

		private readonly static float[,] ERDefaultSettings = new float[5, 3] {

				{ 1f, 1f, 1500  },
				{ 2f, 1.25f, 1500  },
				{ 2.5f, 1.5f, 1500  },
				{ 3f, 1.75f, 1500  },
				{ 4f, 2f, 1500  }
		};
		private static readonly float[,] ERSettings = new float[5, 3] {

				{ 1f, 1f, 1500  },
				{ 2f, 1.25f, 1500  },
				{ 2.5f, 1.5f, 1500  },
				{ 3f, 1.75f, 1500  },
				{ 4f, 2f, 1500  }
		};

		private static readonly bool[,] eRIsPrecent = new bool[5, 3]
		{
			{true,true,false },
			{true,true,false },
			{true,true,false },
			{true,true,false },
			{true,true,false }
		};
		#endregion

		#region Omni Compleated Match

		private static readonly StatDef[] OmniStats = [StatDefOf.WorkSpeedGlobal, StatDefOf.MiningYield, StatDefOf.PlantHarvestYield, StatDefOf.MedicalSurgerySuccessChance, StatDefOf.DrugHarvestYield, StatDefOf.MarketValue,];
		private readonly static float[,] OmniDefaultSettings = new float[5, 6] {

			 {0.5f,  1f, 1f, 1f, 1f, 1500 },
			 {1f, 1.1f, 1.1f, 1.1f, 1.1f, 1500 },
			 {1.25f, 1.2f, 1.2f, 1.2f, .2f, 1500 },
			 {1.5f, 1.3f, 1.3f, 1.3f,1.3f, 1500 },
			 {2f, 1.4f, 1.4f, 1.4f, 1.4f, 1500 }
		};
		private static readonly float[,] OmniSettings = new float[5, 6] {

			 {0.5f,  1f, 1f, 1f, 1f, 1500 },
			 {1f, 1.1f, 1.1f, 1.1f, 1.1f, 1500 },
			 {1.25f, 1.2f, 1.2f, 1.2f, .2f, 1500 },
			 {1.5f, 1.3f, 1.3f, 1.3f,1.3f, 1500 },
			 {2f, 1.4f, 1.4f, 1.4f, 1.4f, 1500 }
		};
		private static readonly bool[,] OmniPrecent = new bool[5, 6]
		{
			{true,true,true,true,true,false },
			{true,true,true,true,true,false },
			{true,true,true,true,true,false },
			{true,true,true,true,true,false },
			{true,true,true,true,true,false },
		};

		#endregion

		#region Robots Data

		private static readonly RobotsData cleanerData = new(cleanerList, cleanerStats, cleanerSettings, CleanerisPrecent);
		private static readonly RobotsData crafterData = new(crafterList, crafterStats, crafterSettings, crafterIsPrecent);
		private static readonly RobotsData kitchensData = new(kitchenList, kitchenStats, kitchenDefaultSettings, kitchenIsPrecent);
		private static readonly RobotsData buildersData = new(buildersList, builderStats, builderSettings, builderIsPrecent);
		private static readonly RobotsData eRData = new(ERList, ERStats, ERSettings, eRIsPrecent);
		private static readonly RobotsData omniData = new(omniList, OmniStats, OmniSettings, OmniPrecent);

		#endregion

		#endregion

		#region Stations Data
		private static readonly bool[,] GeneralStationIsPrecent = new bool[5, 2]
		{
			{false,false },
			{false,false },
			{false,false },
			{false,false },
			{false,false },
		};

		#region cleaner Stations
		private static readonly float[,] cleanerStationSettings = new float[5, 2]
		{
			{100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};

		private static readonly float[,] cleanerStationDefaultSettings = new float[5, 2]
		{
			{100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};
		#endregion

		#region hauler Stations
		private static readonly float[,] haulerStationSettings = new float[5, 2]
	   {
			 {100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
	   };

		private static readonly float[,] haulerStationDefaultSettings = new float[5, 2]
		{
			 {100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};
		#endregion

		#region Crafter Stations
		private static readonly float[,] CrafterStationSettings = new float[5, 2]
		{
			{100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};

		private static readonly float[,] CrafterStationDefaultSettings = new float[5, 2]
		{
			 {100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};
		#endregion

		#region Kitchen Stations
		private static readonly float[,] kitchenStationSettings = new float[5, 2]
		{
			 {100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};

		private static readonly float[,] kitchenStationDefaultSettings = new float[5, 2]
		{
			 {100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};
		#endregion

		#region builder Stations
		private static readonly float[,] builderStationSettings = new float[5, 2]
	   {
			 {100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
	   };

		private static readonly float[,] builderStationDefaultSettings = new float[5, 2]
		{
			{100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};
		#endregion

		#region ER Stations
		private static readonly float[,] erStationSettings = new float[5, 2]
	   {
			{100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
	   };

		private static readonly float[,] erStationDefaultSettings = new float[5, 2]
		{
			{100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};
		#endregion

		#region Omni Stations
		private static readonly float[,] OmniStationSettings = new float[5, 2]
		{
			{100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};

		private static readonly float[,] OmniStationDefaultSettings = new float[5, 2]
		{
			{100, 1050 },
			{150f, 1900 },
			{200f, 5000 },
			{250f, 11250 },
			{300f, 26250 }
		};
		#endregion

		#endregion

		private static readonly RobotsData cleanerStationData = new(["AIRobot_RechargeStation_Cleaner", "AIRobot_RechargeStation_Cleaner_II", "AIRobot_RechargeStation_Cleaner_III", "AIRobot_RechargeStation_Cleaner_IV", "AIRobot_RechargeStation_Cleaner_V"], [StatDefOf.MaxHitPoints, StatDefOf.MarketValue], cleanerStationSettings, GeneralStationIsPrecent);
		private static readonly RobotsData haulerStationData = new(["AIRobot_RechargeStation_Hauler", "AIRobot_RechargeStation_Hauler_II", "AIRobot_RechargeStation_Hauler_III", "AIRobot_RechargeStation_Hauler_IV", "AIRobot_RechargeStation_Hauler_V"], [StatDefOf.MaxHitPoints, StatDefOf.MarketValue], haulerStationSettings, GeneralStationIsPrecent);
		private static readonly RobotsData crafterStationData = new(["RPP_RechargeStation_Crafter_I", "RPP_RechargeStation_Crafter_II", "RPP_RechargeStation_Crafter_III", "RPP_RechargeStation_Crafter_IV", "RPP_RechargeStation_Crafter_V"], [StatDefOf.MaxHitPoints, StatDefOf.MarketValue], CrafterStationSettings, GeneralStationIsPrecent);
		private static readonly RobotsData builderStationData = new(["RPP_RechargeStation_Builder_I", "RPP_RechargeStation_Builder_II", "RPP_RechargeStation_Builder_III", "RPP_RechargeStation_Builder_IV", "RPP_RechargeStation_Builder_V"], [StatDefOf.MaxHitPoints, StatDefOf.MarketValue], builderStationSettings, GeneralStationIsPrecent);
		private static readonly RobotsData erStationData = new(["RPP_RechargeStation_ER_I", "RPP_RechargeStation_ER_II", "RPP_RechargeStation_ER_III", "RPP_RechargeStation_ER_IV", "RPP_RechargeStation_ER_V"], [StatDefOf.MaxHitPoints, StatDefOf.MarketValue], erStationSettings, GeneralStationIsPrecent);
		private static readonly RobotsData kitchenStationData = new(["RPP_RechargeStation_Kitchen_I", "RPP_RechargeStation_Kitchen_II", "RPP_RechargeStation_Kitchen_III", "RPP_RechargeStation_Kitchen_IV", "RPP_RechargeStation_Kitchen_V"], [StatDefOf.MaxHitPoints, StatDefOf.MarketValue], kitchenStationSettings, GeneralStationIsPrecent);
		private static readonly RobotsData omniStationData = new(["RPP_RechargeStation_Omni_I", "RPP_RechargeStation_Omni_II", "RPP_RechargeStation_Omni_III", "RPP_RechargeStation_Omni_IV", "RPP_RechargeStation_Omni_V"], [StatDefOf.MaxHitPoints, StatDefOf.MarketValue], OmniStationSettings, GeneralStationIsPrecent);

		public override void ExposeData()
		{
			//Stored in XML config file
			base.ExposeData();
			//Robots Settings
			ExposeValues(cleanerData);
			ExposeValues(buildersData);
			ExposeValues(crafterData);
			ExposeValues(kitchensData);
			ExposeValues(eRData);
			ExposeValues(omniData);

			// Robots Stations Settings
			ExposeValues(cleanerStationData);
			ExposeValues(haulerStationData);
			ExposeValues(erStationData);
			ExposeValues(crafterStationData);
			ExposeValues(builderStationData);
			ExposeValues(omniStationData);
		}
		public static void WriteSettings()
		{
			//Robots Settings
			WriteStatSettings(cleanerData);
			WriteStatSettings(crafterData);
			WriteStatSettings(buildersData);
			WriteStatSettings(kitchensData);
			WriteStatSettings(eRData);
			WriteStatSettings(omniData);

			// Robots Stations Settings
			WriteStatSettings(cleanerStationData);
			WriteStatSettings(haulerStationData);
			WriteStatSettings(erStationData);
			WriteStatSettings(crafterStationData);
			WriteStatSettings(builderStationData);
			WriteStatSettings(omniStationData);
		}

		public static List<ThingDef> database;

		public static void ExposeValues(RobotsData data)
		{
			for (int i = 0; i < data.defThing.Length; i++)
			{
				for (int x = 0; x < data.statsData.Length; x++)
				{
					Scribe_Values.Look(ref data.settingsValue[i, x], data.defThing[i] + "_" + data.statsData[x].defName, data.defaultValues[i, x]);
				}
			}
		}

		private static void WriteStatSettings(RobotsData data)
		{
			StatModifier statModifier = null;
			for (int i = 0; i < data.defThing.Length; i++)
			{
				for (int x = 0; x < data.statsData.Length; x++)
				{
					foreach (StatModifier pawnStat in DefDatabase<ThingDef>.GetNamed(data.defThing[i]).statBases)
					{
						if (pawnStat.stat == data.statsData[x])
						{
							statModifier = pawnStat;
							break; //Break For each
						}
					}

					if (statModifier != null)
						statModifier.value = data.settingsValue[i, x];
				}
			}
		}

		/// <summary>
		/// Drawing SettingsGUI
		/// </summary>
		public static void DoOptionsCategoryContents(Listing_Standard listing_Standard)
		{
			listing_Standard.DropDownSettings("Current Page".Translate(), "", currentPage, listing_Standard.ColumnWidth);
			listing_Standard.GapLine();
			switch (currentPage)
			{
				case SettingsPages.Robots_Tweaks:
					RobotsSettings(listing_Standard);
					break;
				case SettingsPages.Station_Tweaks:
					//RobotsStationSettings(listing_Standard);
					break;
				default:
					break;
			}
		}
		private static void RobotsSettings(Listing_Standard listing_Standard)
		{
			listing_Standard.Label("These settings apply runtime");

			listing_Standard.CheckboxLabeled("Cleaner_Settings".Translate(), ref cleanerTweaks);
			if (cleanerTweaks)
				RobotsData.DrawingSettings(listing_Standard, cleanerData);

			listing_Standard.CheckboxLabeled("Crafter_Settings".Translate(), ref crafterTweaks);
			if (crafterTweaks)
				RobotsData.DrawingSettings(listing_Standard, crafterData);

			listing_Standard.CheckboxLabeled("Builder_Settings".Translate(), ref builderTweaks);
			if (builderTweaks)
				RobotsData.DrawingSettings(listing_Standard, buildersData);

			listing_Standard.CheckboxLabeled("Kitchen_Settings".Translate(), ref kitchenTweaks);
			if (kitchenTweaks)
				RobotsData.DrawingSettings(listing_Standard, kitchensData);

			listing_Standard.CheckboxLabeled("ER_Settings".Translate(), ref eRTweaks);
			if (eRTweaks)
				RobotsData.DrawingSettings(listing_Standard, eRData);

			listing_Standard.CheckboxLabeled("Omni_Settings".Translate(), ref omniTweaks);
			if (omniTweaks)
				RobotsData.DrawingSettings(listing_Standard, omniData);
		}
		private static void RobotsStationSettings(Listing_Standard listing_Standard)
		{
			listing_Standard.Label("These settings apply After Reset");

			listing_Standard.CheckboxLabeled("Cleaner_Station_Settings".Translate(), ref cleanerStationTweaks);
			if (cleanerStationTweaks)
				RobotsData.DrawingSettings(listing_Standard, cleanerStationData);

			listing_Standard.CheckboxLabeled("Hauler_Station_Settings".Translate(), ref haulerStationTweaks);
			if (haulerStationTweaks)
				RobotsData.DrawingSettings(listing_Standard, haulerStationData);

			listing_Standard.CheckboxLabeled("Crafter_Station_Settings".Translate(), ref crafterStationTweaks);
			if (crafterStationTweaks)
				RobotsData.DrawingSettings(listing_Standard, crafterStationData);

			listing_Standard.CheckboxLabeled("Builder_Station_Settings".Translate(), ref builderStationTweaks);
			if (builderStationTweaks)
				RobotsData.DrawingSettings(listing_Standard, builderStationData);

			listing_Standard.CheckboxLabeled("Kitchen_Station_Settings".Translate(), ref kitchenStationTweaks);
			if (kitchenStationTweaks)
				RobotsData.DrawingSettings(listing_Standard, kitchenStationData);

			listing_Standard.CheckboxLabeled("ER_Station_Settings".Translate(), ref eRStationweaks);
			if (eRStationweaks)
				RobotsData.DrawingSettings(listing_Standard, erStationData);

			listing_Standard.CheckboxLabeled("Omni_Station_Settings".Translate(), ref omniStationTweaks);
			if (omniStationTweaks)
				RobotsData.DrawingSettings(listing_Standard, omniStationData);
		}
	}
}

public enum SettingsPages
{
	Robots_Tweaks,
	Station_Tweaks,
	Others_Tweaks
}