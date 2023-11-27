using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public GameObject aboutScreen;
    public GameObject vehicle;
    public GameObject menu;
    public GameObject howToPlay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchToGameScene()
    {
        //Using the scene manager you can transition from one screen to the next 
        SceneManager.LoadScene("GameScene");
    }

    public void switchToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    //This method is used to make certain objects inactive
    //In this case the UI for some of the screens will be made inactive
    public void switchToAbout()
    {
        aboutScreen.gameObject.SetActive(true);
        vehicle.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
    }

    public void returnToMenu()
    {
        aboutScreen.gameObject.SetActive(false);
        howToPlay.gameObject.SetActive(false);
        vehicle.gameObject.SetActive(true);
        menu.gameObject.SetActive(true);
    }
    public void switchToHowToPlay()
    {
        howToPlay.gameObject.SetActive(true);
        vehicle.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
    }
    //Method to demosntarte if the quit button is clickable
    public void Quit()
    {
        Debug.Log("Quit");
    }
}
