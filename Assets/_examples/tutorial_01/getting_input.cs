using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getting_input : MonoBehaviour
{

    // +++ public fields ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++    
    // +++ editor fields ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    [SerializeField] private DebugDisplayManager _debugDisplay;
    // +++ private fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




    // +++ unity callbacks ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
		var h = Input.GetAxisRaw("Horizontal");
		var v = Input.GetAxisRaw("Vertical");

		var debugMessage = string.Format("Input Horizontal: {0:0.00}\nInput Vertical  :{1:0.00}", h, v);
		_debugDisplay.DisplayMessage(debugMessage);
    }




    // +++ event handler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // +++ class methods ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	private void Init(){
		// get references from scene
		_debugDisplay = GameObject.Find("DebugDisplay").GetComponent<DebugDisplayManager>();
	}
}