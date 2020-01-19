using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehaviour : MonoBehaviour
{
    //This is the object the lever interacts with
    public playerBehaviour player;

    //Allows access to the animators finite state machine's paramaters 
    public Animator animator;

    int count = 60;

    /// <summary>
    ///  count prevents click spamming
    /// which caused an animation bug where it would get locked in an animation state
    /// because the bool would change before the animation could transition
    /// </summary>
    private void Update()
    {
        count++;
    }

    /// <summary>
    /// If the left mouse button is clicked while it is over the lever object
    /// Call the toggle active bool from the passed gameobject
    /// Toggle the animators isLeft boolean to trigger the animation
    /// Playes the levers Audio Clip
    /// </summary>
    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0) && count > 60)
        {
            if(animator.GetBool("isLeft"))
            {
                animator.SetBool("isLeft", false);
            }
            else
            {
                animator.SetBool("isLeft", true);
            }

            this.GetComponent<AudioSource>().Play();
            player.toggleActive();

            count = 0;
        }
    }
}
