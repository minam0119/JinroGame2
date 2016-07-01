public static partial class Const {
	
	public enum ActType {
		Villager = 0,
		Augur = 1,
		Mediumship = 2,
		Knight = 3,
		Werewolf = 4,
		Madman = 5
	}
	public static int ToInt(this Const.ActType val) {
		return (int)val;
	}
	
}