using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    public GameObject bigLight;
    public float spaceTimeOut = 3f;

    private void Start()
    {
        bigLight.SetActive(false);
    }

    private void FixedUpdate()
    {
        // toggle bigLight with space
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(Waiter());
        }
    }
    
    IEnumerator Waiter()
    {
        bigLight.SetActive(true); // show light
        yield return new WaitForSeconds(3); // wait for three seconds
        bigLight.SetActive(false);  // hide light
    }
}
