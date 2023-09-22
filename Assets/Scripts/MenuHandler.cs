using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour 
{
    public string input;
    public static MenuHandler Instance;
    public GameObject piano;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        gameObject.SetActive(false);
        piano.gameObject.SetActive(false);
    }

    public void ReadStringInput ( string s)
    {
        input = s;
        
    }
}
