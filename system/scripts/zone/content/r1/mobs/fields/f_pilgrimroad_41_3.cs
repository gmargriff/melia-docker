//--- Melia Script -----------------------------------------------------------
// Rasvoy Lake Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_pilgrimroad_41_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad413MobScript : GeneralScript
{
	protected override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_41_3.Id1", MonsterId.Rootcrystal_01, min: 9, max: 12, respawn: Seconds(5));
		AddSpawner("f_pilgrimroad_41_3.Id2", MonsterId.Minos_Green, min: 53, max: 70);
		AddSpawner("f_pilgrimroad_41_3.Id3", MonsterId.Minos_Bow_Green, min: 15, max: 20);
		AddSpawner("f_pilgrimroad_41_3.Id4", MonsterId.Lapasape_Mage_Brown, min: 23, max: 30);
		AddSpawner("f_pilgrimroad_41_3.Id5", MonsterId.Lapasape_Mage_Brown, min: 23, max: 30);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-1097, 680, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-1020, 443, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-839, 634, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-1082, -109, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-984, -393, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-772, -178, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-1252, -972, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-891, -821, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-936, -1131, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-320, -833, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-48, -882, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-81, -169, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(85, 164, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(248, -160, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-326, 880, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(-18, 910, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(722, -320, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(931, -574, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(1066, -320, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(795, 316, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(1130, 362, 50));
		AddSpawnPoint("f_pilgrimroad_41_3.Id1", "f_pilgrimroad_41_3", Rectangle(1094, 1086, 50));

		// 'Minos_Green' GenType 100 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-184, -115, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-136, 97, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-52, 187, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(44, 41, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(52, -94, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(137, -271, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(301, -178, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(237, 111, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-297, 815, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-330, 1012, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-168, 944, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(17, 835, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1166, 311, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-969, 371, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1165, 758, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1095, 422, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1165, 545, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-962, -92, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1140, -200, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-856, -196, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-948, -385, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1195, -819, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-962, -833, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-860, -957, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-958, -1126, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1112, -1029, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1289, -1047, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-395, -814, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-231, -755, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-242, -878, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-185, -1020, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-54, -956, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(729, -522, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(920, -443, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(985, -292, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1060, -437, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(950, -564, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(823, -613, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1108, 1272, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1272, 935, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1112, -644, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1165, -446, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(820, 1025, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(924, 900, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1178, 944, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1207, 1102, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(912, 1226, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1176, -1197, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1153, -1152, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1235, -1138, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1205, -1055, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1157, -986, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1221, -928, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1233, -1002, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1156, -927, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1233, -853, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1170, -877, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1328, -984, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1290, -851, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-881, -769, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-839, -790, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-847, -851, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-915, -944, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-920, -896, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-891, -1013, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-801, -1072, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-848, -1158, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-903, -1193, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-868, -1129, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-871, -1078, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-801, -1010, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-779, -884, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-808, -944, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-951, -1007, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-844, -899, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-961, -1209, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-801, -1121, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1123, -436, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1120, -371, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1161, -411, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1143, -334, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1113, -274, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1079, -319, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1038, -226, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1086, -215, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1061, -138, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1094, -81, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1039, -53, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-903, -141, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-993, -106, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-954, -451, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-903, -425, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-914, -468, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-831, -460, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-772, -390, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-696, -264, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-757, -279, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-719, -142, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-815, -134, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-828, -84, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-773, -37, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-736, -84, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-914, -83, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1003, -22, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1147, 366, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1185, 465, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1198, 522, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1209, 576, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1106, 816, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-872, 806, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-807, 789, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-934, 798, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1066, 644, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-1005, 667, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-993, 583, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-996, 488, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-979, 428, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-928, 451, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-859, 502, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-884, 572, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-908, 643, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-784, 652, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-750, 524, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-737, 433, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-816, 451, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-792, 567, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-939, 659, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-264, 1114, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-191, 1066, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-237, 1019, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-375, 1020, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-249, 956, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-274, 928, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-212, 857, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-346, 824, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-238, 790, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-177, 816, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-19, 755, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(55, 797, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(73, 871, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(51, 919, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(60, 981, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(39, 1027, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(14, 1078, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-16, 1109, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-509, 810, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-582, 761, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-322, 878, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-238, 888, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-279, 752, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-228, 742, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-128, 708, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(40, 737, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-34, 799, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-146, 594, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(68, 234, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(213, 230, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(65, 174, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(39, 81, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-72, 10, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-130, 27, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-106, -49, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-23, -63, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-154, -173, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-243, -159, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-289, -99, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-57, -155, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(56, -32, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(135, -8, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(333, 16, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(191, 82, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(19, -286, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(-19, -218, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(121, -180, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(231, -212, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(284, -250, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(200, -286, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(195, -221, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(89, -284, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(29, -323, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(950, -315, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1043, -224, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1063, -317, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1164, -368, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1071, -482, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1131, -584, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1057, -663, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1015, -585, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(832, -693, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(885, -604, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(780, -572, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(948, -510, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(848, -384, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(768, -324, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(800, -250, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(953, -255, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(718, -470, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(794, -510, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(914, -483, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(900, -354, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(887, 1179, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(985, 1227, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(765, 1213, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(709, 1068, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(768, 1013, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(740, 906, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(785, 928, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(889, 979, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(947, 964, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(871, 1039, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1166, 872, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1178, 992, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1271, 1086, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1175, 1137, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1071, 1183, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1030, 877, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(844, 926, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1049, 1069, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1028, 1120, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id2", "f_pilgrimroad_41_3", Rectangle(1130, 1038, 25));

		// 'Minos_Bow_Green' GenType 101 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-1227, 719, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-955, 846, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-1112, 685, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-843, 366, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-1266, 481, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-338, -925, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-249, -773, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-100, -805, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-180, -888, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-209, -1034, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-384, -742, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-574, -516, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-469, -639, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-1019, 82, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-1041, 233, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-559, 793, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-632, 759, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(862, -534, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(1084, 858, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(969, 1314, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(1234, 1176, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(1059, -584, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(924, -661, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(1107, -260, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(827, -294, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(720, 1123, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(440, 194, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-212, -46, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(9, -155, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(184, -84, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(118, 203, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(1, 34, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id3", "f_pilgrimroad_41_3", Rectangle(-109, 214, 25));

		// 'Lapasape_Mage_Brown' GenType 102 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(1173, -321, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(1206, 884, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(996, 849, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(1076, 923, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(1285, 1040, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(1127, -528, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(-153, -80, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(88, -69, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(34, -198, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(-53, 92, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(119, 171, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(304, 78, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(-178, 131, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(-403, 939, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(-289, 877, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(-157, 917, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(-344, 1119, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(-69, 1047, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(-4, 851, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(-188, 755, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(674, -416, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(773, -422, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(693, -305, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(884, -225, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(1104, -345, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(973, -389, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(1003, -497, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(992, -643, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(849, 1127, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(1158, 1190, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(813, 1255, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(722, 978, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(838, 873, 20));
		AddSpawnPoint("f_pilgrimroad_41_3.Id4", "f_pilgrimroad_41_3", Rectangle(994, -188, 20));

		// 'Lapasape_Mage_Brown' GenType 103 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-374, -938, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-252, -802, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-201, -939, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-117, -725, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-434, -736, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(0, -914, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-682, -499, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-886, -346, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1166, -1077, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-944, -1104, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1318, -913, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1065, -897, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1188, -766, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-934, -784, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-771, -969, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1081, -1205, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1274, -1087, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1088, -481, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1201, -344, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-836, -326, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1135, -155, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-973, -161, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1051, 11, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-863, -10, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-714, -193, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1012, 95, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1011, 329, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1176, 405, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1223, 623, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1075, 506, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-1052, 792, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-955, 534, 25));
		AddSpawnPoint("f_pilgrimroad_41_3.Id5", "f_pilgrimroad_41_3", Rectangle(-898, 380, 25));
	}
}
