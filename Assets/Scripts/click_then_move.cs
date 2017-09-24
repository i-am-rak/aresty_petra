using UnityEngine;
using System.Collections;

public class click_then_move : MonoBehaviour {

    private bool selected = false;
    private UnityEngine.AI.NavMeshAgent agent;
    private Vector3 MoveTo;
    private bool move = false;

    public Material normalColor;
    public Material selectedColor;

    void Start()
    {
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        gameObject.GetComponent<Renderer>().material = normalColor;
    }

    void Update()
    {
        if (selected && move)
        {
            agent.SetDestination(MoveTo);
            move = false;
        }
    }

    void Select(int x)
    {
        selected = true;
        gameObject.GetComponent<Renderer>().material = selectedColor;
        // Debug.Log("Selected");
    }

    void Deselect(int x)
    {
        selected = false;
        gameObject.GetComponent<Renderer>().material = normalColor;
        // Debug.Log("Deselected");
    }

    void Destination(Vector3 d)
    {
        MoveTo = d;
        move = true;
    }

    /*
    // Old Script
	private NavMeshAgent agent;
	void Start() {
		agent = GetComponent<NavMeshAgent>();
	}
	void Update() {
		RaycastHit hit;
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
				agent.SetDestination(hit.point);
			
		}
	}
    */
}