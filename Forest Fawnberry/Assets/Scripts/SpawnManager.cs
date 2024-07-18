using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] AnimalPrefab;
    private int animalIndex;
    private float spwanX, spwanZ=20;
    private float spawnInterval=1.5f;
    // Start is called before the first frame update
    private float startDelay=2f;
    void Start()
    {
       //StartCoroutine(spwan());
       InvokeRepeating("Spwan",startDelay,spawnInterval);
    }

    // Update is called once per frame
   // IEnumerator spwan()
   // {
   //     while(true)
   //     {
   //     spwanX=Random.Range(-15f,15f);
   //     spawnInterval=Random.Range(1f,3f);
   //     Vector3 spwanPos= new Vector3(spwanX,0,spwanZ);
  //      int animalIndex= Random.Range(0,AnimalPrefab.Length);
   //     Instantiate(AnimalPrefab[animalIndex],spwanPos,AnimalPrefab[animalIndex].transform.rotation);
   //     yield return new WaitForSeconds(spawnInterval);
   //     } 
   // }
     private void Spwan()
    {
        spwanX=Random.Range(-15f,15f);
        spawnInterval=Random.Range(1f,3f);
        Vector3 spwanPos= new Vector3(spwanX,0,spwanZ);
        int animalIndex= Random.Range(0,AnimalPrefab.Length);
        Instantiate(AnimalPrefab[animalIndex],spwanPos,AnimalPrefab[animalIndex].transform.rotation);
    }
}
