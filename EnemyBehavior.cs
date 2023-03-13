using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private float speed = 3;
    private float minDist = 7;
    private float hitDist = 1;
    private bool hit;

    GameObject player = GameObject.FindGameObjectWithTag("Player");
    void Start()
    {
    }

    void FixedUpdate()
    {
        if (Vector2.Distance(_enemy.transform.position, player.transform.position) < minDist)
        {
            _enemy.transform.position = Vector2.MoveTowards(_enemy.transform.position, player.transform.position, speed * Time.fixedDeltaTime);
        }


        if (Vector2.Distance(_enemy.transform.position, player.transform.position) < hitDist)
        {
            hit = true;
        }
        else
        {
            hit = false;
        }
    }
}
