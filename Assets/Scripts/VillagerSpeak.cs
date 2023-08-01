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
        if (other.CompareTag("Billy")) {
            Debug.Log("Billy: Only one of us will be telling the truth. Giana was heading to the berries carrying a fruit basket.");
        }
        if (other.CompareTag("Lisa")) {
            Debug.Log("Lisa: Giana hates the heat. She would never go to the desert.");
        }
        if (other.CompareTag("Leo")) {
            Debug.Log("Leo: Only one of us are lying. Giana was wearing a snow jacket before she left.");
        }
        if (other.CompareTag("Greg")) {
            Debug.Log("Greg: Billy always tells the truth, and Giana was wearing a tanktop and shorts.");
        }
        if (other.CompareTag("Faith")) {
            Debug.Log("Faith: Lisa never lies. I heard Giana has a vacation home on the other side of Fairy Forest.");
        }
    }
}
