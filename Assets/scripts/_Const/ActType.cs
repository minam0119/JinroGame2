public static partial class Const {
	
	public enum ActType {
		Werewolf = 1,
		Villager = 2,
		Fortuneteller = 3,
		Mediumship = 4,
		Knight = 5
	}

	public static int ToInt(this Const.ActType val) {
		return (int)val;
	}
}