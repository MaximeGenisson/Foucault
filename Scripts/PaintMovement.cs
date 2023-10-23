using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintMovement : MonoBehaviour
{
    [SerializeField] GameObject pendulum;
    Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 aimPosition = pendulum.transform.position;
        transform.position = new Vector3(aimPosition.x/7,aimPosition.y/7-10,aimPosition.z/7);
        transform.rotation = Quaternion.AngleAxis(Random.Range(0,360),Vector3.up) *  transform.rotation;
        transform.localScale = scale * Random.Range(0.2f,1);
    }
}
