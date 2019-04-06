using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour {
    public float speed = 1f;
    void Update()
    {
        Vector3 t_position = gameObject.transform.position;
        t_position.x = t_position.x - (speed * Time.deltaTime);
        gameObject.transform.position = t_position;
    }
}
