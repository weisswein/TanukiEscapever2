using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextscorescene : MonoBehaviour
{
   public void NextScoreSceneButton(){
	SceneManager.LoadScene("GameClear");
   }
}
