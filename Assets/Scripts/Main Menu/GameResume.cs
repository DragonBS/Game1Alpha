using UnityEngine;
using System.Collections;

public class GameResume : MonoBehaviour {

	private GameObject inGameMenu;
	// Use this for initialization
	public void Resume ()
	{
		inGameMenu = this.transform.parent.gameObject.transform.parent.gameObject;
		Time.timeScale = 1;
		inGameMenu.SetActive(false);
	}
}
