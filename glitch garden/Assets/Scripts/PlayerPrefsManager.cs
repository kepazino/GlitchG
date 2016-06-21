using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY="master_volume";//these explain it
	const string DIFFICULTY_KEY="difficulty";
	const string LEVEL_KEY="level_unlocked_";

	public static void SetMasterVolume(float volume){
		if(volume>=0&&volume<=1){
		PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);//so I can see this method from other
			//scripts easily
		}else{
			Debug.LogError("volumen fuera de rango");//it will tell me the script I am at
		}
	}
	public static float GetMasterVolume(){
		return	PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel(int level){
		//print ( SceneManager.sceneCountInBuildSettings);//not scene count
		//rememeber to check obsolet methods on google to convert to unity 5
		if (level <=  SceneManager.sceneCountInBuildSettings - 1) {//as the build order has n-1 levels starting from 0
			PlayerPrefs.SetInt (LEVEL_KEY+level.ToString (), 1);
		}
		//1 for true as we havent got bool in player prefs!!!
		// it will end up being level_unlocked_3=1 level 3 unlocked!!!
		else {
			Debug.LogError ("nivel fuera del build order");
		}
	}
	//public static bool isLevelUnlocked(int level){
	//	return PlayerPrefs.GetInt (LEVEL_KEY+level.ToString())==1;  
	//}

	public static bool isLevelUnlocked(int level){
		if (PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ()) == 1)
			return true;
		else if (level >= SceneManager.sceneCountInBuildSettings) {
			Debug.LogError ("trying to query level out of index range");
			return false;
		}
		else{
			return false;
		}}
	public static void SetDifficulty(int difficultyLevel){//we are making it a percentage from 0 to 1
		if (difficultyLevel >= 1&&difficultyLevel<=3) {
			PlayerPrefs.SetInt(DIFFICULTY_KEY, difficultyLevel);
		} else {
			Debug.LogError("cant have negative difficulty or bigger than zero man");
		}
	}
	public static int GetDifficulty(){
		return PlayerPrefs.GetInt (DIFFICULTY_KEY);
	}
}
