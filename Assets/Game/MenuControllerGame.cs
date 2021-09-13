using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControllerGame : MonoBehaviour
{



  public void Play(){
    SceneManager.LoadScene("Game");
  }

  public void mainMenu(){
    SceneManager.LoadScene("BasicMenu1");
  }

  public void Exit(){
      Application.Quit();
  }

  public InputField mainInputField;

  public void Submit(){
    Debug.Log(mainInputField.text);

  }
}
