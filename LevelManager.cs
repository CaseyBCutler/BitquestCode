using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class LevelManager : MonoBehaviour {
    public Transform mainMenu, loginMenu, createAccMenu, optionsMenu, startMenu, fadePre;

    //can use this for any scene transition
	public void loadScene(string name) { //believe this is done for the future
        SceneManager.LoadScene(name);
    }
    public void loadScene(int num) {
        SceneManager.LoadScene(num);
    }
    public void loadGame() {
        LoadInformation.LoadAccountInformation();
        Debug.Log(GameInformation.SceneAt);
        if(!string.IsNullOrEmpty(GameInformation.SceneAt)) {
            SceneManager.LoadScene(GameInformation.SceneAt);
        }
    }

    //quit no questions asked right now
    public void quitGame() { //will have to do some work to make a menu pop up from anywhere
        Application.Quit();
    }

    private void someMenu(Transform transName, bool clicked) {
        //Fading.Instance.StartFade(name);
        if (clicked) {
            //for network requirment, but later task
            transName.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else {
            transName.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    //The 4 following classes are just changing canvas right now
    public void LoginMenu(bool clicked) { //will have to work on the network side later
        //for network requirment, but later task
        someMenu(loginMenu, clicked);
    }

    public void CreateAccountMenu(bool clicked) { //will work now, but not later for networking
        someMenu(createAccMenu, clicked);
    }
    
    public void StartMenu(bool clicked) { //will need to play with this the further we go
        //mainMenu here is more of the previous menu, which is not correct
        someMenu(startMenu, clicked);
    }

    public void OptionsMenu(bool clicked) { //will need to make this more public, but for now
        someMenu(optionsMenu, clicked);
    }
}
