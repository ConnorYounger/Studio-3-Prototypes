using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDCharacterController : MonoBehaviour
{
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.position += new Vector3(x * speed * Time.deltaTime, 0, y * speed * Time.deltaTime);
    }
}
