using UnityEngine;
using System.Collections;

public class ChangeTargetScript : MonoBehaviour
{

		public Transform[] Targets;
		private int targetID = 0;
		private AICharacterControl AICOntrolScript;
	    
		void Start ()
		{
				AICOntrolScript = gameObject.GetComponent<AICharacterControl> ();
		}

		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.N)) {
						if (targetID < Targets.Length - 1) {
								++targetID;
						} else {
								targetID = 0;
						}
						AICOntrolScript.target = Targets [targetID];
				}
		}
}
