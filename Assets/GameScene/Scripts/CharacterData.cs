[System.SerializableAttribute]
public class CharacterData {

	public string 
		name,
		serifu;
	public int  id,
				role,
				actRole,
				team,
				personality,
				avatarId,
				eatenTurn,
				fortuneTurn,
				guardTurn,
				fakeFortuneTurn,
				fortuneResult,
				fakeFortuneResult,
				csv;
	public bool isLive = true;

	CharacterViewController characterController;

	//キャラクターデータをCSVの何行目に値するかを設定
	public void SetCharaData (string[] data) {
		string da = "";
		foreach (string d in data) {
			da += ( d + ", " );
		}
		UnityEngine.Debug.Log(da);
		id = int.Parse(data[1]);
		name = data[2];
		personality = int.Parse(data[3]);
		role = int.Parse(data[4]);
		actRole = int.Parse(data[5]);
		team = int.Parse(data[6]);
		avatarId = int.Parse(data[7]);
		eatenTurn = int.Parse(data[8]);
		fortuneTurn = int.Parse(data[9]);
		fakeFortuneTurn = int.Parse(data[10]);
		guardTurn = int.Parse(data[11]);
		fortuneResult = int.Parse(data[12]);
		fakeFortuneResult = int.Parse(data[13]);
		//serifu = Resources.Load("WordCSV/" + (int.Parse(data[14])).ToString()) + "CSV") as string;
	}

	//キャラクターが死んだ(投票された)時のメソッド
	public void Dead () {
			isLive = false;
			if(isLive == false) {
				
			}
	}
}
