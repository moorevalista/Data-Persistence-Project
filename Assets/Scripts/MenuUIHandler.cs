using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
    using UnityEditor;
#endif

using UnityEngine.UI;
using TMPro;

[DefaultExecutionOrder(10000)]
public class MenuUIHandler : MonoBehaviour
{
    //private string inputName;
    public TMP_InputField playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartNew() {
        //MainManager.Instance.PlayerName = PlayerName.text.ToString();
        //Debug.Log("MainManager " + MainManager.Instance.PlayerName);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowName() {
        UIMainScene.Instance.newPlayerName = playerName.text;
        Debug.Log("MainManager " + UIMainScene.Instance.newPlayerName);
        //Debug.Log("Print : " + playerName.text);
    }
}
