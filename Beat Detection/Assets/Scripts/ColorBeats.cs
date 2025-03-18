using UnityEngine;

public class ColorBeats : MonoBehaviour
{
    public int range;
    Material material;
    public bool useBuffer;


    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        material = new Material(material);
        material.EnableKeyword("_EMISSION");
    }

    void Update()
    {
        if (useBuffer)
        {
            Color color = new Color(BeatDetection.audioBandBuff[range], BeatDetection.audioBandBuff[range], BeatDetection.audioBandBuff[range]);
            color *= 5f;
            material.SetColor("_EmissionColor", color);
            Debug.Log($"Emission Color: {color}");
        }
    }
}
