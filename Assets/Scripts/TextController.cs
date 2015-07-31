using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start() {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update() {
		print (myState);
		if (myState == States.cell) {
			state_cell();
		} else if (myState == States.sheets_0) {
			state_sheets_0();
		} else if (myState == States.mirror) {
			state_mirror();
		} else if (myState == States.lock_0) {
			state_lock_0();
		} else if (myState == States.cell_mirror) {
			state_cell_mirror();
		} else if (myState == States.sheets_1) {
			state_sheets_1();
		} else if (myState == States.lock_1) {
			state_lock_1();
		} else if (myState == States.freedom) {
			state_freedom();
		}
	}
	
	void state_cell() {
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, and the door " +
					"is locked from the outside.\n\n" +
					"Press S to view Sheets, M to view Mirror, L to view Lock";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0;
		}
	}
	
	void state_sheets_0() {
		text.text = "You can't believe you sleep in these things. Surely it's " +
					"time somebody changed them. The pleasures of prison life " +
					"I guess.\n\n" +
					"Press R to Return to roaming in your cell.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void state_lock_0() {
		text.text = "A locked door?\n\n" +
					"Press R to Return to roaming in your cell.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}

	void state_mirror() {
		text.text = "A broken mirror?\n\n" +
					"Press R to Return to cell, B to check behind mirror.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.cell_mirror;
		}
	}
	
	void state_cell_mirror() {
		text.text = "Checking behind the mirror, you find a key wraped in another " +
					"sheet with some sort of writing all over it.\n\n" +
					"Press S to read Sheets, Press K to see if key matches the locked door.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown (KeyCode.K)) {
			myState = States.lock_1;
		}
	}
	
	void state_sheets_1() {
		text.text = "A closer look at the sheet didn't reveal writing, it revealed " +
					"old skid marks all over it!!!\n\n" +
					"Press R to Return to broken mirror.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	
	void state_lock_1() {
		text.text = "The key is old and rusty, but looks like the prison guards keys. " +
					"Hmmmm... An idea is coming to mind. \n\n" +
					"Press T to Try to see if key opens the cell door.";
		if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.freedom;
		}
	}
	
	void state_freedom() {
		text.text = "You hear a CLUNK! As you slowly push on the cell door, it opens " +
					"to an empty corridor. What? No guards?!\n\n" +
					"Run!!!! You're FREE!!!";
	}
}
