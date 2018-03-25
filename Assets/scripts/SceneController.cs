using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {

	public string sceneToGoTo;
	public Button btn;

	// Use this for initialization
	void Start () {
		Button task = btn.GetComponent<Button> ();
		task.onClick.AddListener (taskOnClick);
	}
	
	void taskOnClick() {
		SceneManager.LoadScene (sceneToGoTo);
	}
}
