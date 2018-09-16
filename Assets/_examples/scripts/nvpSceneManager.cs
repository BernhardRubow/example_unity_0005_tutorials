using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nvpSceneManager : MonoBehaviour
{

    // +++ public fields ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++    
    // +++ editor fields ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // +++ private fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	private string _activeScene = null;



    // +++ unity callbacks ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	void Start(){
		SceneManager.sceneLoaded += OnSceneLoaded;
	}




    // +++ event handler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode){
		SceneManager.SetActiveScene(scene);
		_activeScene = scene.name;;
	}



	
    // +++ class methods ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	public void OpenScene(string sceneName){
		
		if(_activeScene != null) SceneManager.UnloadSceneAsync(_activeScene);

		SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);		
	}
}