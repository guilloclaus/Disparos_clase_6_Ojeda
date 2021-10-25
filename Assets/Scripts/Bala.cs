using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed = 5.0f;
    public Vector3 direction = Vector3.forward;
    public float damage = 5.0f;
    public float duration = 2.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        duration -= Time.deltaTime;

        transform.Translate(speed * Time.deltaTime * direction);

        if (duration <= 0)
            Destroy(gameObject);

        
    }
}
