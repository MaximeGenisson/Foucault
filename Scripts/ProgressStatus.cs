using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgressStatus : MonoBehaviour
{

    private float progression = 0;
    public float totaltime = 120;

    public Transform[] lights;
    // Start is called before the first frame update
    void Start()
    {
        float distance = (lights[0].position - transform.position).magnitude;
        progression = 0;
        float angle = 0;
        foreach(Transform l in lights)
        {
            angle += 360 / lights.Length;
            Vector3 direction = Quaternion.AngleAxis(angle,transform.up) * transform.forward;
            l.position = transform.position + direction * distance + transform.up * 0.4f; ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        totaltime = totaltime - Time.deltaTime;
        progression += 1 / totaltime * Time.deltaTime;

        float angle = 0;
        float agnleProgression = 360 * progression;
        foreach (Transform l in lights)
        {
            angle += 360 / lights.Length;
            if (angle < agnleProgression)
                l.gameObject.SetActive(true);
            else
                l.gameObject.SetActive(false);
        }

    }
}
