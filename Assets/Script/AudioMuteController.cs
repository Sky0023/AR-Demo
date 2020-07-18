using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioMuteController : MonoBehaviour, IVirtualButtonEventHandler
{

    public AudioSource aud;
    public AudioClip audClip;

    public int x = 0;

    public GameObject audi;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Start");
        audi = GameObject.Find("MuteBtn");
        audi.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //Stop Audio 
        Debug.Log("BTN Pressed");
        if (vb.VirtualButtonName == "MuteBtn" && x == 0)
        {
            //Play audio
            aud.clip = audClip;
            aud.Play();
            
        }
        else
        {
            //Mute audio
            aud.Pause();
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //Button is released
        Debug.Log("BTN Released");
        if (x == 0)
        {
            x = 1;
        }
        else
        {
            x = 0;
        }

    }

}