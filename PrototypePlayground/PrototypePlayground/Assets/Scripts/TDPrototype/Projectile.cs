using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += transform.forward * speed * Time.deltaTime;
        Debug.DrawRay(transform.position, transform.forward, Color.red, 1);
    }
}
