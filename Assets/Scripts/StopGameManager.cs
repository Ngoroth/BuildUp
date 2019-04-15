
using UnityEngine;

public class StopGameManager : MonoBehaviour {

    private BlockSpawner spawner;

	// Use this for initialization
	void Start () 
	{
	    this.spawner = Camera.main.GetComponent<BlockSpawner>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "BasementBlock")
        {
            this.spawner.GameOver = true;
            Debug.Log("Вы проиграли!");
        }
    }
}
