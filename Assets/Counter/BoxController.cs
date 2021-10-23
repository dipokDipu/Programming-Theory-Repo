using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{

    public float moveSpeed;
    public bool GameOver , GameStart;
    
    public static BoxController instance { get; private set; }
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameOver && GameStart)
        {
            if (transform.position.z > 12)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 12f);
            }
            if (transform.position.z < -12)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -12f);
            }

            float sideMove = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.forward * sideMove * Time.deltaTime * moveSpeed);
        }
    }
}
