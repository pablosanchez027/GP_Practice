using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float moveSpeed = 0f;

    Animator anim;
    SpriteRenderer spr;

    float moveX;

    private void Start()
    {
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveX * moveSpeed * Time.deltaTime);

        anim.SetFloat("MoveX", Mathf.Abs(moveX));

        spr.flipX = moveX < 0f ? true : moveX > 0f ? false : spr.flipX;
    }
}
