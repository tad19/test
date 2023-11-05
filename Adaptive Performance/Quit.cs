using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{

 public void QuitGame (){

    Debug.Log("QUIT");
    Application.Quit();
   }

}