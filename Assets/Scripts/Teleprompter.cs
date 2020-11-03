using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleprompter : MonoBehaviour
{
    public static bool isPaused;
    public Text textToBeDisplayed;
    public GameObject startPanel;
    public static bool wait;
    private void Start()
    {
        Options.speed = 1f;
    }
    public void startTele(InputField text)
    {
        textToBeDisplayed.text = text.text;
        isPaused = false;
        Manage(startPanel, false);
    }
    public static void Manage(GameObject go, bool what)
    {
        if (!what)
        {
            go.transform.localScale -= new Vector3(1f, 1f, 0f);
        }
        else
        {
            go.transform.localScale += new Vector3(1f, 1f, 0f);
        }
    }
}
