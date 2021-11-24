using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;

    Scene_Loader loader;

    private void Start()
    {
        loader = FindObjectOfType<Scene_Loader>();
    }
    public void CountBreakableblocks()
    {
        breakableBlocks++;
    }

    public void RemoveBreakableBlocks()
    {
        breakableBlocks--;
        if(breakableBlocks == 0)
        {
            loader.LoadNextScene();
        }
    }
    
}
