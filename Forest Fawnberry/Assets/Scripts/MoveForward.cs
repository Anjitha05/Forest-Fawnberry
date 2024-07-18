using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{ 
    [SerializeField] private float speed=5.0f;
    [SerializeField] private float offlimit=30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        if((transform.position.z>offlimit)||(transform.position.z<-offlimit))
        {
            Destroy(gameObject);
        }
    }
}
