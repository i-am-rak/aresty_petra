using UnityEngine;
using System.Collections;


public class LoadOnClick : MonoBehaviour {

	//public GameObject loadingImage;

	public void LoadScene(int level)
	{
		//loadingImage.SetActive(true);
		//Application.LoadLevel(level);
		Debug.Log(string.Format("clicked"));
		Application.LoadLevel(level);

	}
}
