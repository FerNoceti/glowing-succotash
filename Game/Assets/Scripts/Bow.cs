using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject arrowPrefab;

    // Start is called before the first frame update
    void Start(){
        //invoke multiple arrows
        InvokeRepeating("SpawnArrow", 0f, 0.5f);
    }

    private void SpawnArrow(){

        Instantiate(arrowPrefab);

    }

    // Update is called once per frame
    void Update(){

    }
}
