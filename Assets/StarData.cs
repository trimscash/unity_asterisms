

public class StarData
{
	public int ID;                    // HIP番号
	public string ConstellationName;    // 星座名
	public string BayerDesignation;     // バイエル符号/フラムスチード番号
	public string ProperNounEn;         // 固有名称
	public string ProperNounJp;         // 固有名称
	public float RightAscension;       // 赤経 1h=15° 1m=0.25° 1s=0.0041666...° 1s=7.27220522E-5[rad]
	public float Declination;           // 赤緯
	public float ApparentMagnitude;    // 見かけの等級
	public string Flaver;                // ネット頼り？　今は無し

	public StarData(int id, string constellationName, string bayerDesignation, string properNounEn, string properNounJp, float rightAscension, float declination, float apparentMagnitude, string flaver)
	{
		ID = id;
		ConstellationName = constellationName;
		BayerDesignation = bayerDesignation;
		ProperNounEn = properNounEn;
		ProperNounJp = properNounJp;
		RightAscension = rightAscension;
		Declination = declination;
		ApparentMagnitude = apparentMagnitude;
		Flaver = flaver;
	}
}
