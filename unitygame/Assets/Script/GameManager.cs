using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int coinCount = 0;
    public TextMeshProUGUI coinText;

    void GetGold()
    {
        coinCount = coinCount + 3;
        coinText.text = coinCount +" Coin";
    }

    void GetSilver()
    {
        coinCount = coinCount + 2;
        coinText.text = coinCount +" Coin";
    }

        void GetBronze()
    {
        coinCount = coinCount + 1;
        coinText.text = coinCount +" Coin";
    }

    public GameObject CoverImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
