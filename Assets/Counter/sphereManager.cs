using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereManager : MonoBehaviour
{

    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(makeSphere());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator makeSphere()
    {
        if(!BoxController.instance.GameOver && BoxController.instance.GameStart)
        {
            yield return new WaitForSeconds(1.0f);
            Instantiate(sphere, new Vector3(transform.position.x, 19.0f, Random.Range(-12f, 12f)), Quaternion.identity);
            StartCoroutine(makeSphere());
        }

    }
}
