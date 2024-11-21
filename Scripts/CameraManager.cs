using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float leftLimit = 0; //左スクロールリミット
    public float rightLimit = 0; //右スクロールリミット
    public float topLimit = 0; //上スクロールリミット
    public float bottomLimit = 0;   //下スクロールリミット
    public GameObject subScreen; //サブスクリーン

    public bool isForceScrollX = false; //xの強制スクロールフラグ
    public float forceScrollSpeedX = 0.5f; //xのスクロールスピード
    public bool isForceScrollY = false; //Y軸強制スクロールフラグ
    public float forceScrollSpeedY = 0.5f; //Yのスクロールスピード



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //プレイヤーを探す playerがnullじゃなければ（playerが存在していれば）
        if (player != null)
        {
            //カメラの更新座標 x,y,zにplayerの座標と同じものを代入
            float x = player.transform.position.x;
            float y = player.transform.position.y;
            float z = transform.position.z;

            if (isForceScrollX)
            {
                //強制スクロールのｘ座標に書き換え
                x = transform.position.x + (forceScrollSpeedX * Time.deltaTime);
            }

            //横同期させる
            //両端に移動制限を付ける （カメラがどこまで移動できるかの話)
            if (x < leftLimit)
            {
                x = leftLimit;
            }
            else if (x > rightLimit)
            {
                x = rightLimit;
            }

            if (isForceScrollY)
            {
                //強制スクロールのｘ座標に書き換え
                y = transform.position.y + (forceScrollSpeedY * Time.deltaTime);
            }
            //縦同期
            //上下に移動制限をつける
            if (y < bottomLimit)
            {
                y = bottomLimit;
            }
            else if (y > topLimit)
            {
                y = topLimit;
            }
            //カメラ位置のVector3を作る
            Vector3 v3 = new Vector3(x, y, z);
            //カメラのポジションを変数v3と同じにする
            transform.position = v3;

            //サブスク
            if (subScreen != null)
            {
                y = subScreen.transform.position.y;
                z = subScreen.transform.position.z;
                Vector3 v = new Vector3(x / 2.0f, y, z);
                subScreen.transform.position = v;
            }
        }
    }
}
