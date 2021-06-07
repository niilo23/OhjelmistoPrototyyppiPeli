using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public Text hpText;
    void Update()
    {
        hpText.text = "Health: " + GetComponent<HealthSystem>().health;
    }
}
