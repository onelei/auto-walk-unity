using UnityEngine;
using System.Collections;

public class Agent : MonoBehaviour {
	[SerializeField] Camera m_Camera;
	private NavMeshAgent agent;
	private RaycastHit hit = new RaycastHit();

	void Awake(){
		agent = GetComponent<NavMeshAgent> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray ray = m_Camera.ScreenPointToRay(Input.mousePosition);
			Physics.Raycast(ray,out hit,100);
			if(null != hit.transform)
			{
				print(hit.point);
				agent.SetDestination (hit.point);
			}
		}
	}
}
