using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //SceneManager�N���X���`���Ă��閼�O���

public class ChangeScene : MonoBehaviour
{
    public string SceneName; //�ړI�ƂȂ�V�[����������ϐ�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load()
    {
        SceneManager.LoadScene(SceneName);
    }

}
