using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [Header("最大移動距離")] public float maxDistance = 2.0f;
    [Header("着弾SE")] public AudioClip fireSE;
    private Rigidbody2D rb;
    private Vector3 defaultPos;
    private int mH;
    private int mV;
    private string playerTag = "Player";
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.parent = null;
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Destroy(this.gameObject);
        }
        Vector3 kero = new Vector3(-0.2690541f,0.26659f,0.2678221f);
        gameObject.transform.localScale = kero;
        defaultPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float d = Vector3.Distance(transform.position,defaultPos);
        //最大移動距離を超えている
        if (d > maxDistance)
        {
            Destroy(this.gameObject);
        }
        else
        {
            transform.position += new Vector3(Time.deltaTime *GManager.instance.speed*1.06f, 0 ,0);
        }
    }    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == playerTag)
        {
           Destroy(this.gameObject);
           if(!GManager.instance.hit&&!GManager.instance.disguiseR){
                if(GManager.instance.currentHp<1){
                    Debug.Log("ゲームオーバー");
                } 
                //現在のHPからダメージを引く
                GManager.instance.currentHp -= 1;
                GManager.instance.hit=true;
                GManager.instance.PlaySE(fireSE);
           }
        }
    }
}
