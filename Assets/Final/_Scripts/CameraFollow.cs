using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject target;
    public Vector3 offset;
    public float speed = 5f;

    void FixedUpdate()
    {

        Player player = target.GetComponent<Player>();

        if (player.Dead == false)
        {
            Vector3 targetPosition = new Vector3(player.transform.position.x + offset.x, player.transform.position.y + offset.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}
