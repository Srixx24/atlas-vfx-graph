using System;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class BeatDetection : MonoBehaviour
{
    AudioSource audioSource;
    public static float[] samples = new float[512];
    public static float[] freqBand = new float[8];
    public static float[] bandBuffer = new float[8];
    float[] bufferDecrease = new float[8];
    float[] bandHighest = new float[8];
    public static float[] audioBand = new float[8];
    public static float[] audioBandBuff = new float[8];


    void Start()
    {
        audioSource = GetComponent<AudioSource> ();
    }

    void Update()
    {
        GetAudioSpectrum ();
        MakeBands();
        bandBuff();
        CreateAudioBands();
    }

    private void CreateAudioBands()
    {
        for (int i = 0; i < 8; i++)
        {
            if (freqBand[i] > bandHighest[i])
                bandHighest[i] = freqBand[i];
            audioBand[i] = (freqBand[i] / bandHighest[i]);
            audioBandBuff[i] = (bandBuffer[i] / bandHighest[i]);
        }
    }

    private void bandBuff()
    {
        for (int g = 0; g < 8; g++) 
        {
            if (freqBand[g] > bandBuffer[g])
            {
                bandBuffer[g] = freqBand[g];
                bufferDecrease [g] = 0.005f;
            }
            if (freqBand[g] < bandBuffer[g])
            {
                bandBuffer[g] -= freqBand[g];
                bufferDecrease[g] *= 1.2f;
            }
        }
    }

    private void GetAudioSpectrum()
    {
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }

    public void MakeBands()
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            int sampleCount = (int)Mathf.Pow(2,i) * 2;
            float average = 0;

            if (i == 7)
                sampleCount += 2;
            for (int j = 0; j < sampleCount; j++)
            {
                average += samples[count] * (count + 1);
                count++;
            }
            average /= count;
            freqBand [i] = average * 10;
        }
        
    }
}
