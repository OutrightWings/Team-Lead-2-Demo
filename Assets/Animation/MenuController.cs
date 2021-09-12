using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{



  public void Play(){
    SceneManager.LoadScene("animation");
  }

  public void mainMenu(){
    SceneManager.LoadScene("BasicMenu");
  }

  public void Exit(){
      Application.Quit();
  }

  public InputField mainInputField;

  public void Submit(){
    Debug.Log(mainInputField.text);

  }
}
