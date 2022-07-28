using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public float arrowSpeed;
    public float arrowRange;
    public float arrowDamage;
    public Vector3 arrowDirection;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(arrowDirection * arrowSpeed * Time.deltaTime);
    }
}
