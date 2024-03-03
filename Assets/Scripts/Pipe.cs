using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    
    public float speed = 1;
    private void Start()
    {
        float randomY = Random.Range(-2f, 2f);
        var x = transform.position.x * randomY;
    }
    
    
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -2.3f)
        {
            Destroy(gameObject);
            
        }
    }
}
