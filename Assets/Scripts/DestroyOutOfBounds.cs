using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float lowerBound = -30;
    public float Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Timer -= Time.deltaTime;

        if (Timer <= 0f)
        {

            Destroy(this.gameObject);

        }

        if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
