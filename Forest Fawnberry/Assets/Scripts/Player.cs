using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed=5.0f;
    private float horizontalInput;
    private float XLimit=15f;
    [SerializeField]private GameObject FoodPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        shoot();
        
    }
    private void movement()
    {
        if(transform.position.x<-XLimit)
        {
            transform.position=new Vector3(XLimit,transform.position.y,transform.position.z);
        }
        else if ( transform.position.x>XLimit)
        {
            transform.position= new Vector3(-XLimit,transform.position.y,transform.position.z);
        }
        horizontalInput= Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);

    }
    private void shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space)) // help to fire food when u "space" press the key in keybord down.
        {
            Instantiate(FoodPrefab,transform.position,FoodPrefab.transform.rotation);
        } 

    }
}
