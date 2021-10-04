using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudio_Controller : MonoBehaviour
{
    public List<AudioSource> allSounds = new List<AudioSource>();
    private int selectedSound;
    private AudioSource audioFile;

    void Start()
    {
         StartCoroutine("CallSound");
    }

    void Update()
    {

    }

    IEnumerator CallSound(){
        while(selectedSound != 200)
        {
        yield return new WaitForSeconds(8f);
        selectedSound = Random.Range(0, 5);
        audioFile = allSounds[selectedSound];
        audioFile.Play();
        }
    }
}
