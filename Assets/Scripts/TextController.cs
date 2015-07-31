using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, cell_0, cell_1, cell_2, mirror, mirror_0, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom, endgame, endgame_0};
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
		} else if (myState == States.cell_0) {
			state_cell_0();
		} else if (myState == States.cell_1) {
			state_cell_1();
		} else if (myState == States.cell_2) {
			state_cell_2();
		} else if (myState == States.mirror) {
			state_mirror();
		} else if (myState == States.mirror_0) {
			state_mirror_0();
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
		} else if (myState == States.endgame) {
			state_endgame();
		} else if (myState == States.endgame_0) {
			state_endgame_0();
		}
	}
	
	void state_cell() {
		text.text = "You wake up in a creepy prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, and the cell door " +
					"is locked from the outside.\n\n" +
					"Press S to view Sheets, M to view Mirror, L to view Lock, or Y to yell for help.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0;
		} else if (Input.GetKeyDown(KeyCode.Y)) {
			myState = States.endgame;
		}
	}
	
	void state_sheets_0() {
		text.text = "You can't believe you sleep in those nasty things. Surely it's " +
					"time that somebody change them. The pleasures of prison life " +
					"I guess.\n\n" +
					"Press R to Return to passing around in your cell.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_0;
		}
	}
	
	void state_lock_0() {
		text.text = "Huh? Imagine that (as you rattle the door). Definetly a locked in a cell.\n\n" +
					"Press R to Return to aimlessly roaming in your cell.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_1;
		}
	}
	
	void state_cell_0() {
		text.text = "So now that you've tried checking out those nasty sheets, " +
					"what else do you want to do with all this free time?\n\n" +
					"Press M to view Mirror or I to Inspect the locked cell door.";
		if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.lock_0;
		}
	}
	
	void state_cell_1() {
		text.text = "So now you KONW you're locked in a prison cell! Now what " +
					"does a prisoner do when they want to be FREE? They keep trying!\n\n" +
					"Press M to view Mirror or S to check out those Sheets.";
		if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.cell_0;
		}
	}
	
	void state_cell_2() {
		text.text = "Let's hope your face wasn't the reason for the broken mirror! " +
					"As you aimlessly turn circles in the cell you notice a lock and " +
					"some nasty sheets on the bed. What's a bored prisoner to do now?\n\n" +
					"Press I to Inspect the lock or S to check out those Sheets.";
		if (Input.GetKeyDown(KeyCode.I)) {
			myState = States.lock_0;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		}
	}

	void state_mirror() {
		text.text = "A broken mirror, but it looks like it's about ready to fall off the wall.\n\n" +
					"Press R to Return to cell or B to check Behind mirror.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_2;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.cell_mirror;
		}
	}
	
	void state_cell_mirror() {
		text.text = "As you quietly check behind the mirror, you find a key wrapped in another " +
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
					"old skid marks all over it! Hahaha...\n\n" +
					"Press R to Return to broken mirror.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.mirror_0;
		}
	}
	
	void state_mirror_0() {
		text.text = "After tossing the skid marked infested old dirty sheet out of the cell with rage, you're " +
					"left standing there with a key in your hand. What do want to do now?\n\n" +
					"Press C to Check out the key or press T to toss the key out of the cell too.";
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.lock_1;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.endgame;
		}
	}
	
	void state_lock_1() {
		text.text = "The key is old and rusty, but looks like a typical old barrel key. " +
					"Hmmmm... Wonder why there's an old key behind the mirror?\n\n" +
					"Press U to to see if it unlocks the cell door or T to toss it out of the cell.";
		if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.freedom;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.endgame_0;
		}
	}
	
	void state_freedom() {
		text.text = "You hear a Klick-CLUNK as you turn the key. You slowly push on the cell door it glides opens " +
					"to an empty corridor. As you peek around the corner, you don't see ANY guards?! So you..." +
					"Run!!!!\n\n" +
					"You're FREE!!!";
	}
	
	void state_endgame() {
		text.text = "As you start yelling, you hear the rush of the guards from all over the place. " +
					"The next thing you know, you're getting maced with pepper spary and you wake up in " +
					"dark cell with padding. You're in solitary confinment and you're dreaming of the days " +
					"you were in that other cell.\n\n" +
					"GAME OVER - You're in confinement for 6 months.";
	}
	
	void state_endgame_0() {
		text.text = "Wait! What..?!? Why would through the key out of the cell without " +
					"trying it out on the locked cell door? You need to work on your anger issues.\n\n" +
					"GAME OVER - You sit there day after day, month after month, wondering why you did that.";
	}
}
