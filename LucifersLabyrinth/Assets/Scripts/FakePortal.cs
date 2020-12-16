using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakePortal : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "player")
        {
            Destroy(coll.gameObject);
            SceneManager.LoadScene(sceneName: "gameOver");
        }
    }
}
