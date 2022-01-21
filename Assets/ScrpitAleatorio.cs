using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrpitAleatorio : MonoBehaviour
{
    public GameObject objetoSpawn;
    private int xPos;
    private int zPos;
    private int yPos;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDrop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnDrop(){
        while(count < 100){
            xPos = Random.Range(1,50); //Mínimo e máximo de X e Y
            yPos = Random.Range(0,10);
            zPos = Random.Range(1,50);

            Instantiate(objetoSpawn, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            count++;
        }
    }
}
