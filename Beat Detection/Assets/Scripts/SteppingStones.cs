using UnityEngine;

public class SteppingStones : MonoBehaviour
{
    public GameObject[] activators;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActivateStone(other.gameObject);
            Debug.Log("Player entered stone collider");
        }
    }

    private void ActivateStone(GameObject player)
    {
        foreach (GameObject activator in activators)
        {
            if (activator.CompareTag("Activator") && activator == this.gameObject)
            {
                foreach (Transform child in activator.transform)
                {
                    if (child.CompareTag("Step Stone"))
                    {
                        child.gameObject.SetActive(true);
                    }
                }
                break;
            }
        }
    }
}