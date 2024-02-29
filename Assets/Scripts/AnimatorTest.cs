using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTest : MonoBehaviour
{
    public Animator animator;

    public KeyCode keyToSet = KeyCode.A;
    public string animationName = "FlyBool";

    private void OnValidate()
    {
        if (animator == null) animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToSet))
        {
            animator.SetBool(animationName, !animator.GetBool(animationName));
        }
    }
}
