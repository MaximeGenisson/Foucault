using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pendulum : MonoBehaviour
{
    Rigidbody rb;

    HingeJoint hj;

    float maxspeed =0f;


    

    public float ecart = 0.2f; // ecart arbitraire 

    bool firstTime = true; //permet de savoir que c'est le premier passage du pendule

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        hj = GetComponent<HingeJoint>();
    }
    void FixedUpdate()
    {

        Vector3 wphj = transform.TransformPoint(hj.anchor); // donne les coordonnées de l'anchor dans le monde (car de base les coordonnées de l'anchor sont dans le reférentiel la objet)

        Vector3 maposxz = transform.position; // récupère la position du pednule
        maposxz.y = 0; // on met l'y à 0 pour l'aligner avec le hinge joint

        wphj.y = 0;//wp = world pos du hinge joint et on met l'y à 0 pour l'aligner avec le pendule et qu'on puisse comparer juste leur x et z

        float dist = Vector3.Distance(maposxz, wphj); // Distance entre le pendule et l'hinge joint 

        if (dist <= ecart) // si la distance entre le pendule et l'hinge joint est inférieur à un ecart donné
        {
            if (firstTime) // si c'est le premier passage du pendule alors on récuppère la max speed
            {
               maxspeed = rb.velocity.magnitude;
            }  
            else 
            {
               rb.velocity = rb.velocity.normalized * maxspeed; // je met la scale à 1 et je multiplie par 4 pour donner une vitesse de 4
            }
                
            firstTime = false; // on n'est plus dans le premier passage


        }

        //transfor.forward = donne direction de base de l'objet



    }


    //private void OnDrawGizmosSelected()
    //{
    //    Gizmos.DrawSphere(maxPosition, ecart);
    //}
}
