using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    [Header("Physics Setup")]
    public Rigidbody2D myRigidbody;
    public Vector2 friction = new Vector2(.1f,0);
    public float speed;
    public float speedRun;
    public float forceJump;

    [Header("Animation Setup")]
    public float jumpScaleY = 1.5f;
    public float jumpScaleX = 0.7f;
    public float animationDuration = 0.3f;
    public Ease ease = Ease.OutBack;

    private float _currentSpeed;

    public void Update()
    {
        HandleJump();
        HandleMoviment();
    }

    private void HandleMoviment()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            _currentSpeed = speedRun;
        }
        else
        {
            _currentSpeed = speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //myRigidbody.MovePosition(myRigidbody.position + velocity * Time.deltaTime);
            myRigidbody.velocity = new Vector2(_currentSpeed, myRigidbody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //myRigidbody.MovePosition(myRigidbody.position - velocity * Time.deltaTime);
            myRigidbody.velocity = new Vector2(-_currentSpeed, myRigidbody.velocity.y);
        }

        if(myRigidbody.velocity.x > 0)
        {
            myRigidbody.velocity -= friction;
        }
        else if (myRigidbody.velocity.x < 0)
        {
            myRigidbody.velocity += friction;
        }
    }

    private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * forceJump;
            myRigidbody.transform.localScale = Vector2.one;

            DOTween.Kill(myRigidbody.transform);

            HandleAnimationJump();
        }
    }

    private void HandleAnimationJump()
    {
        myRigidbody.transform.DOScaleY(jumpScaleY, animationDuration).SetLoops(2, LoopType.Yoyo).SetEase(ease);
        myRigidbody.transform.DOScaleX(jumpScaleX, animationDuration).SetLoops(2, LoopType.Yoyo).SetEase(ease);
    }
}
