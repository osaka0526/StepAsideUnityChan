using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    // Use this for initialization
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんが通り過ぎたらオブジェクトを破壊
        if (this.transform.position.z <= unitychan.transform.position.z - 7)
        {
            Destroy(this.gameObject);
        }
    }
}