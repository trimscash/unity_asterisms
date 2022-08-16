using System.IO;
using System;
using System.Text;
using System.Collections.Generic;
using UnityEngine;


public static class StarsList
{
	static string Path = Application.dataPath+@"\hip_main.csv";
	public static List<StarData> Stars = new List<StarData>();
    // Start is called before the first frame update

  
	public static void loadCSV()
	{
		Debug.Log("start loading");
		TextAsset csvFile = Resources.Load("hip_main") as TextAsset;
		int count=0;
		using (StringReader stringReader = new StringReader (csvFile.text)) {
			while(stringReader.Peek() != -1&&count<100000) {
				count++;
				string line=stringReader.ReadLine();		
				var rows = line.Split(',');
				if(rows.Length>12){
					Stars.Add(new StarData(
						int.Parse(rows[0]),
						_skimmingToFormal(rows[9])[1],
						rows[10],
						rows[11],
						rows[12],
						rightAscensionToRad(int.Parse(rows[1]),int.Parse(rows[2]),float.Parse(rows[3])),
						declinationToRad(int.Parse(rows[4]),int.Parse(rows[5]),int.Parse(rows[6]),float.Parse(rows[7])),
						float.Parse(rows[8]),
						(13<rows.Length)?rows[13]:""
						));
				}
			}
		}
		Debug.Log("ended");
	}
	static float rightAscensionToRad(int h, int m, float s)
  {
    float rad = Mathf.Round((h + m / 60f + s / 3600) * 15 * 1000000) / 1000000f;
    return ((rad / 180) * Mathf.PI);
  }

	static float declinationToRad(int f, int doo, int hun, float byou)
  {
    float rad = Mathf.Round((doo + hun / 60f + byou / 3600) * 1000000) / 1000000f;
    if (f == 0) rad = -rad;
    return ((rad / 180) * Mathf.PI);
  }


	static List<string> _skimmingToFormal (string str) {
    switch (str) {
      case "And" : return new List<string>{"Andromedae", "アンドロメダ"};
      case "Ant" : return new List<string>{"Antliae", "ポンプ"};
      case "Aps" : return new List<string>{"Apodis", "風鳥"};
      case "Aql" : return new List<string>{"Aquilae", "鷲"};
      case "Aqr" : return new List<string>{"Aquarii", "水瓶"};

      case "Ara" : return new List<string>{"Arae", "祭壇"};
      case "Ari" : return new List<string>{"Arietis", "牡羊"};
      case "Aur" : return new List<string>{"Aurigae", "馭者"};
      case "Boo" : return new List<string>{"Bootis", "牛飼"};
      case "Cae" : return new List<string>{"Caeli", "彫刻具"};

      case "Cam" : return new List<string>{"Camelopardalis", "麒麟"};
      case "Cap" : return new List<string>{"Capricorni", "山羊"};
      case "Car" : return new List<string>{"Capricorni", "竜骨"};
      case "Cas" : return new List<string>{"Cassiopeiae", "カシオペヤ"};
      case "Cen" : return new List<string>{"Centauri", "ケンタウルス"};

      case "Cep" : return new List<string>{"Cephei", "ケフェウス"};
      case "Cet" : return new List<string>{"Ceti", "鯨"};
      case "Cha" : return new List<string>{"Chamaeleontis", "カメレオン"};
      case "Cir" : return new List<string>{"Circini", "コンパス"};
      case "CMa" : return new List<string>{"Canis Majoris", "大犬"};

      case "CMi" : return new List<string>{"Canis Minoris", "小犬"};
      case "Cnc" : return new List<string>{"Cancri", "蟹"};
      case "Col" : return new List<string>{"Columbae", "鳩"};
      case "Com" : return new List<string>{"Comae Berenices", "髪"};
      case "CrA" : return new List<string>{"Coronae Australis", "南冠"};

      case "CrB" : return new List<string>{"Coronae Borealis", "冠"};
      case "Crt" : return new List<string>{"Crateris", "コップ"};
      case "Cru" : return new List<string>{"Crucis", "南十字"};
      case "Crv" : return new List<string>{"Corvi", "烏"};
      case "CVn" : return new List<string>{"Canum Venaticorum", "猟犬"};

      case "Cyg" : return new List<string>{"Cygni", "猟犬"};
      case "Del" : return new List<string>{"Delphini", "海豚"};
      case "Dor" : return new List<string>{"Doradus", "旗魚"};
      case "Dra" : return new List<string>{"Draconis", "竜"};
      case "Equ" : return new List<string>{"Equulei", "小馬"};

      case "Eri" : return new List<string>{"Eridani", "エリダヌス"};
      case "For" : return new List<string>{"Fornacis", "炉"};
      case "Gem" : return new List<string>{"Geminorum", "双子"};
      case "Gru" : return new List<string>{"Gruis", "鶴"};
      case "Her" : return new List<string>{"Herculis", "ヘルクレス"};

      case "Hor" : return new List<string>{"Horologii", "時計"};
      case "Hya" : return new List<string>{"Hydrae", "海蛇"};
      case "Hyi" : return new List<string>{"Hydri", "水蛇"};
      case "Ind" : return new List<string>{"Indi", "インディアン"};
      case "Lac" : return new List<string>{"Lacertae", "蜥蜴"};

      case "Leo" : return new List<string>{"Leonis", "獅子"};
      case "Lep" : return new List<string>{"Leporis", "兎"};
      case "Lib" : return new List<string>{"Librae", "天秤"};
      case "LMi" : return new List<string>{"Leonis Minoris", "小獅子"};
      case "Lup" : return new List<string>{"Lupi", "狼"};

      case "Lyn" : return new List<string>{"Lyncis", "山猫"};
      case "Lyr" : return new List<string>{"Lyrae", "琴"};
      case "Men" : return new List<string>{"Mensae", "テーブル山"};
      case "Mic" : return new List<string>{"Microscopii", "顕微鏡"};
      case "Mon" : return new List<string>{"Monocerotis", "一角獣"};

      case "Mus" : return new List<string>{"Muscae", "蠅"};
      case "Nor" : return new List<string>{"Normae", "定規"};
      case "Oct" : return new List<string>{"Octantis", "八分"};
      case "Oph" : return new List<string>{"Ophiuchi", "蛇遣"};
      case "Ori" : return new List<string>{"Orionis", "オリオン"};

      case "Pav" : return new List<string>{"Pavonis", "孔雀"};
      case "Peg" : return new List<string>{"Pegasi", "ペガスス"};
      case "Per" : return new List<string>{"Persei", "ペルセウス"};
      case "Phe" : return new List<string>{"Phoenicis", "鳳凰"};
      case "Pic" : return new List<string>{"Pictoris", "画架"};

      case "PsA" : return new List<string>{"Piscis Austrini", "南魚"};
      case "Psc" : return new List<string>{"Piscium", "魚"};
      case "Pup" : return new List<string>{"Puppis", "船尾"};
      case "Pyx" : return new List<string>{"Pyxidis", "羅針盤"};
      case "Ret" : return new List<string>{"Reticuli", "レチクル"};

      case "Scl" : return new List<string>{"Sculptoris", "彫刻室"};
      case "Sco" : return new List<string>{"Scorpii", "蠍"};
      case "Sct" : return new List<string>{"Scuti", "楯"};
      case "Ser" : return new List<string>{"Serpentis", "蛇"};

      case "Sex" : return new List<string>{"Sextantis", "六分儀"};
      case "Sge" : return new List<string>{"Sagittae", "矢"};
      case "Sgr" : return new List<string>{"Sagittarii", "射手"};
      case "Tau" : return new List<string>{"Tauri", "牡牛"};
      case "Tel" : return new List<string>{"Telescopii", "望遠鏡"};

      case "TrA" : return new List<string>{"Trianguli Australis	", "南三角"};
      case "Tri" : return new List<string>{"Trianguli", "三角"};
      case "Tuc" : return new List<string>{"Tucanae", "巨嘴鳥"};
      case "UMa" : return new List<string>{"Ursae Majoris	", "大熊"};
      case "UMi" : return new List<string>{"Ursae Minoris	", "小熊"};

      case "Vel" : return new List<string>{"Velorum", "帆"};
      case "Vir" : return new List<string>{"Virginis", "乙女"};
      case "Vol" : return new List<string>{"Volantis", "飛魚"};
      case "Vul" : return new List<string>{"Vulpeculae", "小狐"};
      default : return new List<string>{"", ""};
    }
  }

}




