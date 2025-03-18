using UnityEngine;

public class Beats : MonoBehaviour
{
    public int range;
    public float rangeScale, scaleMultiplier;
    public bool useBuffer;


    void Update()
    {
        if (useBuffer)
            transform.localScale = new Vector3(transform.localScale.x, (BeatDetection.bandBuffer[range] * scaleMultiplier) * rangeScale, transform.localScale.z);
            
        if (!useBuffer)
            transform.localScale = new Vector3(transform.localScale.x, (BeatDetection.freqBand[range] * scaleMultiplier) * rangeScale, transform.localScale.z);
    }
}
