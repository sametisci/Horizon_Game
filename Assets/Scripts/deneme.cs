using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    bool isMouseUp;
    public float speed;
    Vector3 target;

    private void Update()
    {
       
        if (Input.GetMouseButton(0))
        {
            isMouseUp = false;
        }
        else
        {
            isMouseUp = true;
        }

        
        if (Vector3.Distance(transform.position, target) > .1f && !isMouseUp)
        {
            //Move our position a step closer to the target.
            float step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target, step);

            //Check if the position of the cube and sphere are approximately equal.
            if (Vector3.Distance(transform.position, target) < 0.001f)
            {
                
            }
        }
    }
}
