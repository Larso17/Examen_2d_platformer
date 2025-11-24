using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public GameObject Mainpanel;  // Reference to the main menu panel
   
    public GameObject Aboutpanel;
    // Start is called before the first frame update
    public void StartGame()
    {
        // For example, you can load a new scene or start your game
        SceneManager.LoadScene("Level1");  // Replace with your actual game scene name
    }

    public void OpenAbout()
    {
        Mainpanel.SetActive(false);
        Aboutpanel.SetActive(true);
    }
    // Update is called once per frame
    public void BackToMainMenu()
    {
        Aboutpanel.SetActive(false);
        Mainpanel.SetActive(true);
    }

    public void QuitGame()
    {
        {
            // For standalone builds
            Application.Quit();

            // If you're running from the editor, stop the play mode
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }

    public void ReturnMain()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    void Update()
    {
        
    }
}
