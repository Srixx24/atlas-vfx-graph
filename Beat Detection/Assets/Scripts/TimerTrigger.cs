using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    private Timer timerScript;
    private bool timerStarted = false;

    private void Start()
    {
        timerScript = GetComponent<Timer>();

        if (timerScript != null)
        {
            timerScript.enabled = false;
            timerScript.TimerText.gameObject.SetActive(false);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            HoldTimer();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartTimer();
            timerScript.TimerText.gameObject.SetActive(true);
        }
    }
    private void StartTimer()
    {
        if (!timerStarted)
        {
            timerScript.enabled = true;
            timerStarted = true;
        }
    }

    private void HoldTimer()
    {
        if (timerStarted && timerScript != null)
        {
            timerScript.enabled = false;
            timerStarted = false;
        }
    }
}
