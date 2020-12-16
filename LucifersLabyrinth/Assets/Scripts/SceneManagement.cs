using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    string sceneName;

    private void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    void FixedUpdate()
    {
        // press c for credits
        if (Input.GetKeyDown("c"))
        {
            if (sceneName == "menu")
            {
                SceneManager.LoadScene(sceneName: "credits");
            }
        }

        // press i for instructions
        if (Input.GetKeyDown("i"))
        {
            if (sceneName == "menu")
            {
                SceneManager.LoadScene(sceneName: "instructions");
            }
        }

        // press b to go back
        if (Input.GetKeyDown("b"))
        {
            if (sceneName == "instructions" || sceneName == "credits")
            {
                SceneManager.LoadScene(sceneName: "menu");
            }
        }

        // press enter to begin
        if (Input.GetKeyDown("return"))
        {
            if (sceneName == "menu")
            {
                SceneManager.LoadScene(sceneName: "labyrinth1");
            }
        }

        // press enter to return to menu
        if (Input.GetKeyDown("return"))
        {
            if (sceneName == "gameOver" || sceneName == "winScreen")
            {
                SceneManager.LoadScene(sceneName: "menu");
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "player")
        {
            if (sceneName == "labyrinth1")
            {
                SceneManager.LoadScene(sceneName: "labyrinth2");
            }
            if (sceneName == "labyrinth2")
            {
                SceneManager.LoadScene(sceneName: "labyrinth3");
            }
            if (sceneName == "labyrinth3")
            {
                SceneManager.LoadScene(sceneName: "winScreen");
            }
        }
    }

}
