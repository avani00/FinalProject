using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerSpeak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {   
    }

    void OnTriggerEnter(Collider other) {
        if (other.name == "Billy") {
            Debug.Log("Only one of us will be telling the truth.\nGiana was heading to the berries carrying a fruit basket.");
        }
        if (other.name == "Lisa") {
            Debug.Log("Giana hates the heat.\nShe would never go to the desert.");
        }
        if (other.name == "Leo") {
            Debug.Log("Only one of us are lying.\nGiana was wearing a snow jacket before she left.");
        }
        if (other.name == "Greg") {
            Debug.Log("Billy always tells the truth, and Giana was wearing a tanktop and shorts.");
        }
        if (other.name == "Faith") {
            Debug.Log("Lisa never lies.\nI heard Giana has a vacation home on the other side of Fairy Forest.");
        }

    }
}
