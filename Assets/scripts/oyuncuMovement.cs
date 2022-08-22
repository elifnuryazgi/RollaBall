using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyuncuMovement : MonoBehaviour
{
    public float hiz = 12f;
    Rigidbody rb;
    float x, z;
    GameObject cam;
    private Vector3 fark;
    public Text ScoreText;
    private int puan=0;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
        rb = GetComponent<Rigidbody>();
        fark =cam.gameObject.transform.position - gameObject.transform.position ;
    }

    private void FixedUpdate()
    {
        PlayerMovement();
        CameraScript();
        
    }
    public void PlayerMovement()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        Vector3 vec = new Vector3(x, 0f, z);
        rb.AddForce(vec*hiz*Time.fixedDeltaTime);
    }
    public void CameraScript()
    {
        cam.gameObject.transform.position = gameObject.transform.position + (fark);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Destroy(other.gameObject);
            puan += 10;
            ScoreText.text = "Score: " + puan.ToString();
        }
    }
}
