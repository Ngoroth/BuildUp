using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{

    public Text BlocksCount;
    public Text GameInfo;

    private BlockSpawner spawner;

	// Use this for initialization
	void Start ()
	{
	    this.spawner = Camera.main.gameObject.GetComponent<BlockSpawner>();
	    //this.BlocksCount = this.gameObject.GetComponent<Canvas>().GetComponent("BlocksCount") as Text;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    this.BlocksCount.text = $"You build {this.spawner.AllBlocks.Count.ToString()} blocks!";
	    if (this.spawner.GameOver)
	    {
	        this.GameInfo.text = "GAME OVER";
	    }
	}
}
