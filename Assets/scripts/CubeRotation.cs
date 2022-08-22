using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, Time.deltaTime * 150, 0);
    }
}
