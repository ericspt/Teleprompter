using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public static float speed;
    Slider slider;

    private void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        speed = 1f;
        if (PlayerPrefs.HasKey("speed"))
        {
            speed = PlayerPrefs.GetFloat("speed");
            slider.value = speed;
        }
    }

    public void setSpeed()
    {
        speed = slider.value;
        PlayerPrefs.SetFloat("speed", speed);
    }
}
