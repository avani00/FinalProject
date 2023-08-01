using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VillagerSpeak : MonoBehaviour
{
    string infoText;
    TMP_Text info;
    bool billy;
    bool lisa;
    bool leo;
    bool greg;
    bool faith;
    
    // Start is called before the first frame update
    void Start()
    {
        infoText = "";
        info = GameObject.Find("Information").GetComponent<TMP_Text>();
        billy = true;
        lisa = true;
        leo = true;
        greg = true;
        faith = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (billy && other.CompareTag("Billy")) {
            infoText += "\n\nBilly: Only one of us will be telling the truth. Giana was heading to the berries carrying a fruit basket";
            billy = false;
        }
        if (lisa && other.CompareTag("Lisa")) {
            infoText += "\n\nLisa: Giana hates the heat. She would never go to the desert.";
            lisa = false;
        }
        if (leo && other.CompareTag("Leo")) {
            infoText += "\n\nLeo: Only one of us are lying. Giana was wearing a snow jacket before she left.";
            leo = false;
        }
        if (greg && other.CompareTag("Greg")) {
            infoText += "\n\nGreg: Billy always tells the truth, and Giana was wearing a tanktop and shorts.";
            greg = false;
        }
        if (faith && other.CompareTag("Faith")) {
            infoText += "\n\nFaith: Lisa never lies. I heard Giana has a vacation home on the other side of Fairy Forest.";
            faith = false;
        }
        info.text = infoText;
    }
}
