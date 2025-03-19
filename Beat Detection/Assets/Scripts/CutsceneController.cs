using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public Animator animator;
    public GameObject CutsceneCamera;
    public GameObject MainCamera;
    public GameObject Player;
    private PlayerController playerController;


    private void Start()
    {
        animator = GetComponent<Animator>();
        playerController = Player.GetComponent<PlayerController>();
        CutsceneCamera.SetActive(true);
    }

    public void Update()
    {
        EndCutScene();
    }

    public void EndCutScene()
    {
        if (animator != null && animator.GetCurrentAnimatorStateInfo(0).IsName($"Beat Jumps"))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                if (MainCamera != null)
                    MainCamera.SetActive(true);

                if (Player != null && Player.GetComponent<PlayerController>() != null)
                    Player.GetComponent<PlayerController>().enabled = true;

                if (CutsceneCamera != null)
                    CutsceneCamera.SetActive(false);
            }
        }
    }
}