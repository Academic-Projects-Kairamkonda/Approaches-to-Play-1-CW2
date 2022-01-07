using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public HeroKnight heroKnight;

    // Start is called before the first frame update
    void Start()
    {
        KnightDisableControls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KnightDisableControls()
    {
        heroKnight.enabled = false;
    }

    public void KnightEnableControls()
    {
        heroKnight.enabled = true;

    }
}
