using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    public float deleteTime = 3.0f;　//削除されるまでの時間
    // Start is called before the first frame update
    void Start()
    {
        //第二引数に数字をいれると時間差で消滅
       Destroy(gameObject, deleteTime); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //何かとぶつかったら即消滅
        Destroy(gameObject);  
    }
}
