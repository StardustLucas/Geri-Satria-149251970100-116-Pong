using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour 
{ 
    public void PlayGame() 
    { 
        SceneManager.LoadScene("Game");
        Debug.Log("Created By Geri Satria M.P - 149251970100-116"); 
    }
} 
