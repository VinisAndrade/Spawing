using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public GameObject objectSpawn;
    public int xPos;
    public int zPos;
    public int spawnCount;

    void Start () {
        StartCoroutine(EnemyDrop()); //Uma corrotina é utilizada para modelar comportamentos que irão impactar inúmeros quadros simultâneamente.
    }

    IEnumerator EnemyDrop () {
        while (spawnCount < 10) {
            xPos = Random.Range(1, 50); //Minimo e máximo
            zPos = Random.Range (1, 50);
            Instantiate(objectSpawn, new Vector3 (xPos, 0.5f, zPos), Quaternion.identity); 
            //Instantiate criar a instância de um novo objeto
            //Quaternion processa a rotação aleatória dos objetos para que possam ser apresentados em cena
            yield return new WaitForSeconds(0.9f);

            spawnCount++;
        }
    }
    // Update is called once per frame
    void Update () {

    }
}