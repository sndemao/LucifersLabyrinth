using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2Move : MonoBehaviour
{
    /*

    public Transform[] waypoints;
    public float moveSpeed = 0.3f;
    int cur = 0;

    public void FixedUpdate()
    {
        // if waypoint is not reached yet, then move closer
        if (transform.position != waypoints[cur].position)
        {
            // calculate closer point
            Vector2 p = Vector2.MoveTowards(transform.position, waypoints[cur].position, moveSpeed);
            GetComponent<Rigidbody2D>().MovePosition(p);

        } else // if waypoint has been reached, select next one
        {
            cur = (cur + 1) % waypoints.Length;
        }

        // animation
        Vector2 dir = waypoints[cur].position - transform.position;
        GetComponent<Animator>().SetFloat("dirx", dir.x);
        GetComponent<Animator>().SetFloat("diry", dir.y);
    }

    */

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "player")
        {
            Destroy(coll.gameObject);
            SceneManager.LoadScene(sceneName: "gameOver");
        }
    }

}