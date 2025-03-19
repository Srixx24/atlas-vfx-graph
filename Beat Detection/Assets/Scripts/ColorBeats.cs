using UnityEngine;

public class ColorBeats : MonoBehaviour
{
    public int range;
    Material material;
    public float rangeScale, scaleMultiplier;
    public bool useBuffer;


    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        material = new Material(material);
    }

    void Update()
    {
        if (useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (BeatDetection.bandBuffer[range] * scaleMultiplier) * rangeScale, transform.localScale.z);
            Color color = new Color(BeatDetection.audioBandBuff[range], BeatDetection.audioBandBuff[range], BeatDetection.audioBandBuff[range]);
            material.SetColor("_EmissionColor", color);
            Debug.Log($"Emission Color: {color}");
        }
                
        if (!useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (BeatDetection.freqBand[range] * scaleMultiplier) * rangeScale, transform.localScale.z);
            Color color = new Color(BeatDetection.audioBandBuff[range], BeatDetection.audioBandBuff[range], BeatDetection.audioBandBuff[range]);
            material.SetColor("_EmissionColor", color);
            Debug.Log($"Emission Color: {color}");
        }          
    }
}
