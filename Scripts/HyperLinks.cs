using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperLinks : MonoBehaviour
{
    public void OpenDiscord()
    {
        Application.OpenURL("https://discord.gg/Fk7vubv9zH");

    }
    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }



}
