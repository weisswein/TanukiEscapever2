using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Talkevent_end : MonoBehaviour
{
        [SerializeField] [Header("メッセージ（キャラ名）")] private string[] msgCaraName;
        [SerializeField] [Header("メッセージ（内容）")] private string[] msgContent;
        [SerializeField] GameObject[] charactersprite;
        [SerializeField] int finalturn;
        public static bool Talkable;
        GameObject objCanvas = null;
        void Start()
        {
           
            objCanvas = gameObject.transform.Find("Canvas").gameObject;
            objCanvas.SetActive(false);
            charactersprite[0].SetActive(true);
            charactersprite[1].SetActive(true);
            charactersprite[2].SetActive(false);
            charactersprite[3].SetActive(true);
            Talkable=true;
        }

        void Update()
        {
            if (Talkable )
            {
                Talkable=false;
                StartCoroutine("ShowLog");
            }
        }

        IEnumerator ShowLog()
        {
            GameObject objCaraName = objCanvas.transform.Find("CaraName").gameObject;
            GameObject objContent = objCanvas.transform.Find("Content").gameObject;

            objCanvas.SetActive(true);


            for (int i = msgCaraName.GetLowerBound(0); i <= msgCaraName.GetUpperBound(0); i++)
            {
                objCaraName.GetComponent<Text>().text = msgCaraName[i];
                objContent.GetComponent<Text>().text = msgContent[i];
                if(finalturn==i){
                    charactersprite[0].SetActive(false);
                    charactersprite[1].SetActive(false);
                    charactersprite[2].SetActive(true);
                    charactersprite[3].SetActive(false);
                }
                yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
                yield return null;
            }
            objCanvas.SetActive(false);
            SceneManager.LoadScene("GameClear");
            
        }
}
