using UnityEngine;

public class DemonAnimatorScript : MonoBehaviour
{
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.Play("HeadBob");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.Play("LArmWave");
        }
    }
}
