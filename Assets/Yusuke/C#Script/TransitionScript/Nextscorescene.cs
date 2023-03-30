using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextscorescene : MonoBehaviour
{
	public AudioSource Aus_skip;
	public AudioClip Ac_skipscore;

   public void NextScoreSceneButton(){
	Aus_skip.PlayOneShot(Ac_skipscore);
	Invoke("NextScoreSceneSkipTransition",2);
   }
   private void NextScoreSceneSkipTransition()
   {
		 SceneManager.LoadScene("GameClear");
   }
}
