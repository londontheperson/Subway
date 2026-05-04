using UnityEngine;

public class JumpscareTrigger : MonoBehaviour
{
    [SerializeField] private JumpscareUI jumpScareUI;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jumpScareUI.Trigger();
        }
    }
}
