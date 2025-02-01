//--- Melia Script -----------------------------------------------------------
// Resident Quarter Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_underfortress_67'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress67MobScript : GeneralScript
{
	protected override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_underfortress_67", MonsterId.Rambear_Brown, Properties("MHP", 303247, "MINPATK", 4400, "MAXPATK", 5310, "MINMATK", 4400, "MAXMATK", 5310, "DEF", 21908, "MDEF", 21908));
		AddPropertyOverrides("d_underfortress_67", MonsterId.Dandel_White, Properties("MHP", 305461, "MINPATK", 4429, "MAXPATK", 5345, "MINMATK", 4429, "MAXMATK", 5345, "DEF", 22318, "MDEF", 22318));
		AddPropertyOverrides("d_underfortress_67", MonsterId.Rambear_Bow_Brown, Properties("MHP", 307725, "MINPATK", 4458, "MAXPATK", 5381, "MINMATK", 4458, "MAXMATK", 5381, "DEF", 22738, "MDEF", 22738));
		AddPropertyOverrides("d_underfortress_67", MonsterId.Rambear_Mage_Brown, Properties("MHP", 310039, "MINPATK", 4488, "MAXPATK", 5418, "MINMATK", 4488, "MAXMATK", 5418, "DEF", 23167, "MDEF", 23167));

		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_67.Id1", MonsterId.Rambear_Brown, min: 15, max: 20, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_67.Id2", MonsterId.Dandel_White, min: 57, max: 75, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_67.Id3", MonsterId.Rambear_Bow_Brown, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_67.Id4", MonsterId.Rambear_Mage_Brown, min: 9, max: 12, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_67.Id5", MonsterId.Rootcrystal_03, min: 18, max: 23, respawn: Seconds(20), tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_67.Id6", MonsterId.Dandel_White, min: 6, max: 8, respawn: Minutes(1), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rambear_Brown' GenType 19 Spawn Points
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1004, 782, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-339, 1522, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-379, 348, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-641, -274, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-958, -525, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1374, -1128, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-366, -1011, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(327, -729, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(786, -893, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-176, -1073, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(494, -1054, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(310, -907, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(275, 928, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(469, 990, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-295, 936, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(334, 661, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1113, 711, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1400, 357, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1275, -106, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1338, -265, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1310, 108, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1591, -612, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1259, -761, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1410, -838, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-901, -738, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-725, -487, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-656, 168, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-661, 588, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1438, 853, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1160, 759, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-316, 599, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-185, 1396, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(836, 589, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(117, 119, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(83, -93, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(417, 0, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(565, 84, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(159, 320, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1686, -1684, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1781, -1425, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1714, -1344, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1638, -1384, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1488, -850, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1369, -815, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1231, -648, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1725, -651, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1607, -248, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1295, 415, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1444, 451, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1515, 332, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1181, 831, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1222, 776, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1311, 785, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1376, 828, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1684, 664, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1861, 638, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1944, 663, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(1780, 681, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(916, 605, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(427, 691, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(352, 948, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(294, 866, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(373, 879, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(480, 680, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(471, 611, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(344, -762, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(376, -853, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(512, -949, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(633, -1021, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(463, -999, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(419, -911, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(434, -854, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(579, -951, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-16, -1044, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(61, -1152, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(76, -982, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(57, -907, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(29, -1006, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-306, -1059, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-301, -1012, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1198, -1166, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1079, -1022, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1105, -1166, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1320, -1165, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1266, -1137, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1528, -1117, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1502, -992, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1644, -1079, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-897, 481, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-803, 449, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-669, 526, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-638, 553, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-824, 784, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-886, 779, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-893, 863, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-827, 865, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1418, 696, 30));
		AddSpawnPoint("d_underfortress_67.Id1", "d_underfortress_67", Rectangle(-1364, 729, 30));

		// 'Dandel_White' GenType 20 Spawn Points
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1087, -1091, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-703, -489, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(676, -932, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1420, 569, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1362, -666, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1522, 275, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1725, -1476, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(336, 815, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(945, 541, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-638, 615, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1408, 754, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-278, 1862, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(404, -977, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-596, 61, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1555, -1289, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(506, -864, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(71, -1059, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(157, 205, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(233, 554, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(809, 506, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(89, -940, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-974, -716, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-216, -1050, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1353, -872, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1623, -968, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1633, -1644, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1837, -1672, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1787, -1556, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1276, 838, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1342, 298, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1261, 70, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1276, -232, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1541, -290, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(697, 600, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(455, 641, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(418, 910, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(286, 969, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(141, 362, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(951, -785, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1223, -725, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1582, -437, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1597, -680, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1273, 554, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1641, 814, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1826, 550, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-358, 1576, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-203, 1323, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-281, 919, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-397, 436, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-672, 197, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-666, -261, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-436, 259, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-865, 813, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1051, 733, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1446, 653, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-962, -545, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-374, -1062, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(94, -754, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(107, -40, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-588, 4, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(165, -463, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-339, 1289, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(43, -373, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-713, -292, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1762, -1697, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1645, -1581, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1717, -1551, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1832, -1478, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1843, -1603, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1823, -1385, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1822, -1330, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1664, -1427, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1625, -1489, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1597, -1431, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1543, -905, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1464, -890, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1425, -856, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1533, -809, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1385, -769, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1287, -733, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1248, -827, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1298, -892, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1222, -861, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1172, -847, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1297, -661, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1382, -719, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1318, -775, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1208, -751, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1519, -679, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1525, -584, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1663, -646, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1568, -561, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1721, -586, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1647, -569, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1587, -408, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1658, -352, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1614, -296, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1686, -308, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1579, -344, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1298, -284, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1308, -197, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1321, -254, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1284, 19, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1284, 99, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1320, 56, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1500, 213, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1527, 398, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1431, 275, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1283, 356, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1359, 547, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1294, 624, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1481, 522, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1345, 461, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1633, 620, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1641, 711, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1713, 798, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1922, 533, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1833, 748, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1944, 603, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1726, 587, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1921, 762, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1176, 727, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1240, 901, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(1335, 886, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-260, 1891, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-298, 1832, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-317, 1885, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-287, 1929, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-233, 1929, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-365, 1507, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-403, 1547, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-279, 1555, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-207, 1483, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-182, 1371, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-231, 1345, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-223, 1265, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-276, 1304, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-329, 1381, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-362, 1472, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-204, 1531, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-142, 1442, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-248, 1398, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-237, 1484, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-237, 1585, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-272, 1246, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-313, 1223, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-211, 1207, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-157, 1543, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-293, 1416, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-273, 868, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-286, 966, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-312, 886, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-378, 479, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-328, 424, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-367, 368, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-383, 251, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-433, 217, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-389, 295, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-443, 321, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-680, 143, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-719, 209, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-642, 247, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-595, 164, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-633, 28, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-700, -240, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-633, -214, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-604, -302, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-663, -342, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-685, -544, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-742, -468, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-650, -483, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-671, -406, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-727, -357, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-602, -351, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-946, -678, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-988, -654, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-960, -592, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-971, -506, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1005, -568, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-949, -466, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1024, -1085, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1157, -1130, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1378, -1204, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1130, -1061, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1496, -1316, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1469, -1231, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1599, -1129, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1590, -1168, 30));
		AddSpawnPoint("d_underfortress_67.Id2", "d_underfortress_67", Rectangle(-1444, -1188, 30));

		// 'Rambear_Bow_Brown' GenType 23 Spawn Points
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-619, 516, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-656, 255, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-664, 120, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-608, 409, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-850, 480, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-473, 225, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-365, 507, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-279, 837, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(359, 601, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(464, 719, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(257, 694, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(899, 449, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(733, 410, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(907, 187, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(1449, 382, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(1453, -291, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(1123, 784, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-1559, -1206, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-1578, -1052, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-919, -550, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-723, -615, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-766, -345, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-579, -249, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(629, -883, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(-14, -1114, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(463, 38, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(923, -795, 30));
		AddSpawnPoint("d_underfortress_67.Id3", "d_underfortress_67", Rectangle(354, -730, 30));

		// 'Rambear_Mage_Brown' GenType 24 Spawn Points
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(560, -1020, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(161, 305, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-1600, -1253, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-1267, -1222, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-706, -658, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-892, -458, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-645, 227, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-605, 584, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-377, 588, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-567, 386, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-909, 513, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-874, 824, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-1377, 687, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-1382, 847, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-1055, 798, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-173, 1411, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-172, 1554, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-301, 989, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-313, 1340, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-320, 1686, 30));
		AddSpawnPoint("d_underfortress_67.Id4", "d_underfortress_67", Rectangle(-715, -134, 30));

		// 'Rootcrystal_03' GenType 30 Spawn Points
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(258, -1359, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(53, -849, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(128, -157, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(420, 702, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(368, 934, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(853, 581, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(552, 385, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(580, -1023, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(1384, -781, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(1744, -1620, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(1658, -605, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(1302, -189, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(1522, 212, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(1417, 667, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(-1335, -1172, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(-860, -737, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(-628, -242, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(-755, 868, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(-1425, 728, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(-350, 330, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(-287, 902, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(-274, 1490, 40));
		AddSpawnPoint("d_underfortress_67.Id5", "d_underfortress_67", Rectangle(-403, 1990, 40));

		// 'Dandel_White' GenType 32 Spawn Points
		AddSpawnPoint("d_underfortress_67.Id6", "d_underfortress_67", Rectangle(1763, -1624, 20));
		AddSpawnPoint("d_underfortress_67.Id6", "d_underfortress_67", Rectangle(1725, -1403, 20));
		AddSpawnPoint("d_underfortress_67.Id6", "d_underfortress_67", Rectangle(1315, -858, 20));
		AddSpawnPoint("d_underfortress_67.Id6", "d_underfortress_67", Rectangle(1609, -1013, 20));
		AddSpawnPoint("d_underfortress_67.Id6", "d_underfortress_67", Rectangle(1320, -164, 20));
		AddSpawnPoint("d_underfortress_67.Id6", "d_underfortress_67", Rectangle(1298, 39, 20));
		AddSpawnPoint("d_underfortress_67.Id6", "d_underfortress_67", Rectangle(1125, 881, 20));
		AddSpawnPoint("d_underfortress_67.Id6", "d_underfortress_67", Rectangle(1263, 703, 20));
	}
}
