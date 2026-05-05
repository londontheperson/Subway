using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    private Move move;


    void Start()
    {
        animator = GetComponent<Animator>();
        move = GetComponent<Move>();
    }

    void Update()
    {
        if (!move) return;
        if (!animator) return;

        if (move.moveHorizontal == 1.0f || move.moveHorizontal == -1.0f)
        {
            animator.SetBool("isWalking", true);
        }
        else if (move.moveHorizontal == 0.0f)
        {
            animator.SetBool("isWalking", false);
        }
    }
}
