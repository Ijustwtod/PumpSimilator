using UnityEngine;

public class PumpArm : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {

    }
    public void OnMouseDown()
    {
        animator.Play("ArmAnim");
    }
}
