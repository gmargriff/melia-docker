//--- Melia Script -----------------------------------------------------------
// Fortress Battlegrounds Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_underfortress_69'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress69MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_underfortress_69", MonsterId.Kepari_Green, Properties("MHP", 319774, "MINPATK", 4613, "MAXPATK", 5572, "MINMATK", 4613, "MAXMATK", 5572, "DEF", 24972, "MDEF", 24972));
		AddPropertyOverrides("d_underfortress_69", MonsterId.Templeslave_Blue, Properties("MHP", 322323, "MINPATK", 4645, "MAXPATK", 5612, "MINMATK", 4645, "MAXMATK", 5612, "DEF", 25445, "MDEF", 25445));
		AddPropertyOverrides("d_underfortress_69", MonsterId.Flask_Blue, Properties("MHP", 324916, "MINPATK", 4679, "MAXPATK", 5653, "MINMATK", 4679, "MAXMATK", 5653, "DEF", 25925, "MDEF", 25925));
		AddPropertyOverrides("d_underfortress_69", MonsterId.Kepari_Mage_Green, Properties("MHP", 327553, "MINPATK", 4713, "MAXPATK", 5695, "MINMATK", 4713, "MAXMATK", 5695, "DEF", 26414, "MDEF", 26414));
		AddPropertyOverrides("d_underfortress_69", MonsterId.Boss_Mandara, Properties("MHP", 2757437, "MINPATK", 14953, "MAXPATK", 18072, "MINMATK", 14953, "MAXMATK", 18072, "DEF", 84770, "MDEF", 84770));

		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_69.Id1", MonsterId.Kepari_Green, min: 60, max: 80, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_69.Id2", MonsterId.Templeslave_Blue, min: 12, max: 16, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_69.Id3", MonsterId.Flask_Blue, min: 64, max: 85, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_69.Id4", MonsterId.Kepari_Mage_Green, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_69.Id5", MonsterId.Rootcrystal_05, min: 20, max: 26, respawn: TimeSpan.FromMilliseconds(20000), tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_69.Id6", MonsterId.Templeslave_Blue, min: 4, max: 5, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Kepari_Green' GenType 28 Spawn Points
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1218, -1737, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1288, -2129, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-174, -2232, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-143, -1563, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(370, -2002, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(680, -2358, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(760, -1847, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1101, -2024, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1582, -2217, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1981, -2184, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1671, -1692, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1750, -1189, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1761, -2226, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1762, 1019, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1702, 1409, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1537, 1194, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(2053, 1356, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1266, 1163, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(939, 1353, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(125, 1404, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(383, 33, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-834, -667, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-591, -60, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-376, 614, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-892, 1632, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-772, 1284, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1508, 89, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(7, -756, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-991, -2221, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-155, -1928, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-667, 882, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-695, 221, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-227, 1414, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(874, 1384, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(619, 786, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(558, 548, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1957, 753, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1843, 722, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1969, -1621, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-970, -2085, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1526, -1983, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1299, -2270, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-874, -2153, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-991, -1914, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-556, -2120, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-242, -2345, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-331, -1931, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(123, -1980, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(44, -1896, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-141, -1382, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-117, -979, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-117, -1166, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(222, -407, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(441, -230, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-230, 236, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-720, -196, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(96, -245, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(635, 1476, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(701, 1712, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(754, 1479, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(449, 1134, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(363, 1217, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(648, 1018, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1188, 1354, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1957, 1213, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1786, -2362, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1766, -2293, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1764, -2169, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1959, -2134, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1882, -2106, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1678, -2079, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1549, -2164, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1590, -2319, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1656, -2283, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1503, -2241, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1727, -2399, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1673, -2350, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1735, -2317, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1695, -2220, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1637, -2151, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1555, -2113, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1736, -2146, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1771, -2080, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1710, -2267, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1500, -2186, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1742, -1721, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1852, -1726, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1754, -1681, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1817, -1741, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1988, -1584, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1939, -1543, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(2022, -1652, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1886, -1498, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1755, -1312, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1697, -1295, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1694, -1388, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1778, -1403, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1728, -1220, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1853, -1242, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1816, -1155, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1899, 739, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1857, 762, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1978, 846, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1895, 888, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1947, 842, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1706, 1023, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1769, 1067, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1716, 1066, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1565, 1141, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1462, 1199, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1458, 1288, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1545, 1277, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1620, 1328, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1567, 1452, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1589, 1393, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1625, 1450, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1706, 1286, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1504, 1427, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1445, 1378, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1508, 1325, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1620, 1250, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1630, 1178, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1697, 1206, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1655, 1109, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1714, 1148, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1988, 1166, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(2161, 1198, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(2178, 1264, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1984, 1323, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(2065, 1202, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(2093, 1270, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1905, 1296, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1895, 1243, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(2023, 1251, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(2138, 1303, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1266, 1218, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1161, 1221, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1117, 1368, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1219, 1320, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1219, 1241, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1271, 1291, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1105, 1314, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1159, 1288, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(754, 1603, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(771, 1524, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(653, 1545, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(608, 1382, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(685, 1408, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(974, 1403, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(930, 1314, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(685, 1258, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(610, 1211, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(631, 1302, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(802, 1323, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(451, 1169, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(507, 1148, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(507, 1228, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(560, 1077, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(617, 1077, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(601, 994, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(645, 832, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(591, 895, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(643, 911, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(661, 746, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(605, 735, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(540, 486, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(475, 419, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(600, 496, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(548, 416, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(363, 85, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(413, 101, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(378, 166, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(459, 194, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-85, 9, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(423, 302, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(563, 346, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(510, 262, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(382, 223, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(502, 320, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(472, 366, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1059, -2022, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1149, -2035, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(1001, -1995, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(885, -1703, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(820, -1656, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(869, -1592, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(917, -1612, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(843, -1693, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(763, -1915, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(729, -1836, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(778, -1805, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(731, -1989, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(727, -1945, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(785, -2013, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(758, -2041, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(640, -2382, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(608, -2331, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(621, -2296, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(549, -2329, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(533, -2263, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(410, -2033, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(330, -1972, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(67, -1933, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(9, -1922, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(2, -1994, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(92, -2006, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(51, -2015, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-33, -1944, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-22, -1880, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-128, -1896, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-231, -2269, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-279, -2270, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-334, -2295, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-324, -2213, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-235, -2211, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-607, -2124, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-666, -2103, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-877, -2224, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-949, -2158, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-886, -2085, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1005, -1952, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1050, -1852, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-998, -1850, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-962, -2006, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1045, -1889, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1300, -2315, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1352, -2293, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1292, -2076, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1344, -2081, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1504, -1996, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1556, -1969, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1211, -1690, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1270, -1648, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1217, -1625, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1260, -1598, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-110, 1448, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-724, 1353, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(115, 1328, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-789, 1169, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-274, 1463, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(32, -205, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-136, -84, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(87, -116, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(165, -167, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(228, -212, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-193, -61, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(530, -187, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-30, -88, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(313, -125, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(371, -292, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(47, -723, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(116, -687, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(38, -677, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(90, -731, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(281, -375, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(197, -466, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(260, -435, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-97, -1036, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-864, -625, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-749, -305, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-802, -634, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-738, -598, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-786, -410, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1455, 102, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1395, 126, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1279, 158, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1280, 193, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-1228, 194, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-996, 272, 30));
		AddSpawnPoint("d_underfortress_69.Id1", "d_underfortress_69", Rectangle(-931, 312, 30));

		// 'Templeslave_Blue' GenType 29 Spawn Points
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(622, 649, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(-180, 1461, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(-1479, -1624, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(1928, 870, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(1616, -2048, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(1722, -1348, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(1786, -2250, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(874, -1655, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(573, -2285, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(-167, -1469, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(47, -1973, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(-1023, -1904, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(-1096, -1466, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(-827, -499, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(-986, 317, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(-798, 1424, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(412, -159, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(1783, -1711, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(778, -1957, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(1590, -2246, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(-353, -2033, 40));
		AddSpawnPoint("d_underfortress_69.Id2", "d_underfortress_69", Rectangle(-802, -2138, 40));

		// 'Flask_Blue' GenType 30 Spawn Points
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(543, 1280, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-938, -2120, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-844, -2030, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-766, -2091, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-781, -2183, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-1335, -2334, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-1284, -2347, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-1257, -2117, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-1462, -2024, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-1467, -1665, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-1436, -1597, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-1122, -1413, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-1078, -1408, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-1005, -1340, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-993, -1288, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-369, -2241, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-273, -2219, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-322, -2160, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-208, -2169, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-188, -2293, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-137, -2193, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-295, -2059, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-371, -1973, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-276, -1989, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-420, -1996, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-285, -1904, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-133, -1974, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-197, -1865, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-139, -1865, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-86, -1950, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-88, -1880, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-133, -1246, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-71, -1279, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-71, -1203, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-122, -1092, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(-60, -1053, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(686, -2296, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(589, -2385, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(721, -1876, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(797, -1693, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(840, -1609, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(1646, -2105, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(1647, -2207, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(1639, -2364, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(1929, -2134, 9999));
		AddSpawnPoint("d_underfortress_69.Id3", "d_underfortress_69", Rectangle(1747, -2104, 9999));

		// 'Kepari_Mage_Green' GenType 32 Spawn Points
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-682, 1423, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-715, -238, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-886, -946, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-1250, -1632, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-1095, -2251, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-772, -2249, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-977, -1998, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-1304, 114, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-1179, 165, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-664, 478, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-550, 674, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-927, 1798, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-712, 1049, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-298, 395, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-126, -1315, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(323, -266, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-196, -1922, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(57, -636, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-1154, -1478, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-954, -1339, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-934, -1308, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-910, -819, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-1472, -1704, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-1571, -1970, 30));
		AddSpawnPoint("d_underfortress_69.Id4", "d_underfortress_69", Rectangle(-1366, -2065, 30));

		// 'Rootcrystal_05' GenType 43 Spawn Points
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(287, -141, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-732, -297, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-373, 568, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-1031, 289, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-703, 1131, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-976, 1785, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-995, 2248, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-77, -1042, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(612, 654, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(601, 1153, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(67, 1418, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(946, 1386, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(1633, 1337, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(1719, 1609, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(2021, 855, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(1894, 20, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(1700, -766, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(1755, -1298, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(1409, -1861, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(1731, -2306, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(811, -1695, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(604, -2367, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-49, -1910, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-656, -2147, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-1304, -2316, 40));
		AddSpawnPoint("d_underfortress_69.Id5", "d_underfortress_69", Rectangle(-1206, -1678, 40));

		// 'Templeslave_Blue' GenType 45 Spawn Points
		AddSpawnPoint("d_underfortress_69.Id6", "d_underfortress_69", Rectangle(446, 1487, 20));
		AddSpawnPoint("d_underfortress_69.Id6", "d_underfortress_69", Rectangle(710, 1319, 20));
		AddSpawnPoint("d_underfortress_69.Id6", "d_underfortress_69", Rectangle(567, 945, 20));
		AddSpawnPoint("d_underfortress_69.Id6", "d_underfortress_69", Rectangle(55, 1353, 20));
		AddSpawnPoint("d_underfortress_69.Id6", "d_underfortress_69", Rectangle(645, 1632, 20));
	}
}