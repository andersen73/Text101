using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
		cell, cell_0, cell_1, cell_2, mirror, mirror_0, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, 
		corridor_0, corridor_0a, corridor_0b, corridor_0c, stairs_0, stairs_1, stairs_2, closet_door, 
		floor, corridor_1, corridor_1a, corridor_1b, in_closet, corridor_2, corridor_2a, corridor_3, 
		corridor_3a, courtyard, endgame, endgame_0, endgame_1, endgame_2, endgame_3, endgame_4, endgame_5
		};
	private States myState;

	// Use this for initialization
	void Start() {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update() {
		print (myState);
		if 		(myState == States.cell) 		{cell();} 
		else if (myState == States.sheets_0) 	{sheets_0();} 
		else if (myState == States.cell_0) 		{cell_0();} 
		else if (myState == States.cell_1) 		{cell_1();}
		else if (myState == States.cell_2) 		{cell_2();}
		else if (myState == States.mirror) 		{mirror();}
		else if (myState == States.mirror_0) 	{mirror_0();}
		else if (myState == States.lock_0) 		{lock_0();}
		else if (myState == States.cell_mirror) {cell_mirror();}
		else if (myState == States.sheets_1) 	{sheets_1();}
		else if (myState == States.lock_1) 		{lock_1();}
		else if (myState == States.corridor_0) 	{corridor_0();}
		else if (myState == States.corridor_0a)	{corridor_0a();}
		else if (myState == States.corridor_0b)	{corridor_0b();}
		else if (myState == States.corridor_0c)	{corridor_0c();}
		else if (myState == States.stairs_0) 	{stairs_0();}
		else if (myState == States.stairs_1) 	{stairs_1();}
		else if (myState == States.stairs_2) 	{stairs_2();}
		else if (myState == States.closet_door) {closet_door();}
		else if (myState == States.floor)	 	{floor();}
		else if (myState == States.corridor_1) 	{corridor_1();}
		else if (myState == States.corridor_1a)	{corridor_1a();}
		else if (myState == States.corridor_1b)	{corridor_1b();}
		else if (myState == States.in_closet)	{in_closet();}
		else if (myState == States.corridor_2)	{corridor_2();}
		else if (myState == States.corridor_2a)	{corridor_2a();}
		else if (myState == States.corridor_3)	{corridor_3();}
		else if (myState == States.corridor_3a)	{corridor_3a();}
		else if (myState == States.courtyard)	{courtyard();}
		else if (myState == States.endgame) 	{endgame();}
		else if (myState == States.endgame_0) 	{endgame_0();}
		else if (myState == States.endgame_1) 	{endgame_1();}
		else if (myState == States.endgame_2) 	{endgame_2();}
		else if (myState == States.endgame_3) 	{endgame_3();}
		else if (myState == States.endgame_4) 	{endgame_4();}
		else if (myState == States.endgame_5) 	{endgame_5();}
	}
	
	void cell() {
		text.text = "You wake up in a creepy prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, and the cell door " +
					"is locked from the outside.\n\n" +
					"Press S to view Sheets, M to view Mirror, L to view Lock, or Y to yell for help.";
		if 		(Input.GetKeyDown(KeyCode.S)) 	{myState = States.sheets_0;}
		else if (Input.GetKeyDown(KeyCode.M)) 	{myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_0;}
		else if (Input.GetKeyDown(KeyCode.Y)) 	{myState = States.endgame;}
	}
	
	void sheets_0() {
		text.text = "You can't believe you sleep in those nasty things. Surely it's " +
					"time that somebody change them. The pleasures of prison life " +
					"I guess.\n\n" +
					"Press R to Return to passing around in your cell.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_0;}
	}
	
	void lock_0() {
		text.text = "Huh? Imagine that (as you rattle the door). Definetly a locked in a cell.\n\n" +
					"Press R to Return to aimlessly roaming in your cell.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_1;}
	}
	
	void cell_0() {
		text.text = "So now that you've tried checking out those nasty sheets, " +
					"what else do you want to do with all this free time?\n\n" +
					"Press M to view Mirror or I to Inspect the locked cell door.";
		if 		(Input.GetKeyDown(KeyCode.M)) 	{myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.I)) 	{myState = States.lock_0;}
	}
	
	void cell_1() {
		text.text = "So now you KONW you're locked in a prison cell! Now what " +
					"does a prisoner do when they want to be FREE? They keep trying!\n\n" +
					"Press M to view Mirror or S to check out those Sheets.";
		if 		(Input.GetKeyDown(KeyCode.M)) 	{myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.S)) 	{myState = States.cell_0;}
	}
	
	void cell_2() {
		text.text = "Let's hope your face wasn't the reason for the broken mirror! " +
					"As you aimlessly turn circles in the cell you notice a lock and " +
					"some nasty sheets on the bed. What's a bored prisoner to do now?\n\n" +
					"Press I to Inspect the lock or S to check out those Sheets.";
		if 		(Input.GetKeyDown(KeyCode.I)) 	{myState = States.lock_0;}
		else if (Input.GetKeyDown(KeyCode.S)) 	{myState = States.sheets_0;}
	}

	void mirror() {
		text.text = "A broken mirror, but it looks like it's about ready to fall off the wall.\n\n" +
					"Press R to Return to cell or B to check Behind mirror.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell_2;}
		else if (Input.GetKeyDown(KeyCode.B)) 	{myState = States.cell_mirror;}
	}
	
	void cell_mirror() {
		text.text = "As you quietly check behind the mirror, you find a key wrapped in another " +
					"sheet with some sort of writing all over it.\n\n" +
					"Press S to read Sheets, Press K to see if key matches the locked door.";
		if 		(Input.GetKeyDown(KeyCode.S)) 	{myState = States.sheets_1;}
		else if (Input.GetKeyDown(KeyCode.K)) 	{myState = States.lock_1;}
	}
	
	void sheets_1() {
		text.text = "A closer look at the sheet didn't reveal writing, it revealed " +
					"old skid marks all over it! Hahaha...\n\n" +
					"Press R to Return to broken mirror.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.mirror_0;}
	}
	
	void mirror_0() {
		text.text = "After tossing the skid marked infested old dirty sheet out of the cell with rage, you're " +
					"left standing there with a key in your hand. What do want to do now?\n\n" +
					"Press C to Check out the key or press T to toss the key out of the cell too.";
		if 		(Input.GetKeyDown(KeyCode.C)) 	{myState = States.lock_1;}
		else if (Input.GetKeyDown(KeyCode.T)) 	{myState = States.endgame;}
	}
	
	void lock_1() {
		text.text = "The key is old and rusty, but looks like a typical old barrel key. " +
					"Hmmmm... Wonder why there's an old key behind the mirror?\n\n" +
					"Press U to to see if it unlocks the cell door or T to toss it out of the cell.";
		if 		(Input.GetKeyDown(KeyCode.U))	{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.T)) 	{myState = States.endgame_0;}
	}
	
	void corridor_0() {
		text.text = "You hear a Klick-CLUNK as you turn the key. You slowly push on the cell door it glides opens " +
					"to an empty corridor. As you peek around the corner, you don't see ANY guards?! So you..." +
					"Run! You're FREE...well...so you thought. You're just in the coridor. You see something on the " +
					"floor, stairs leading up to ???, and a closed closet door.\n\n"; +
					"Press F to look at floor, S to walk upstairs, C to open closed door, or Y to yell for help.";
		if 		(Input.GetKeyDown(KeyCode.F)) 	{myState = States.floor;}
		else if (Input.GetKeyDown(KeyCode.S)) 	{myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.C)) 	{myState = States.closet_door;}
		else if (Input.GetKeyDown(KeyCode.Y)) 	{myState = States.endgame;}
	}
	
	void floor() {
	
	}
	
	void stairs_0() {
	
	}
	
	void closet_door() {
	
	}
	
	void endgame() {
		text.text = "As you start yelling, you hear the rush of the guards from all over the place. " +
					"The next thing you know, you're getting maced with pepper spary and you wake up in " +
					"dark cell with padding several hours later.\n\n" +
					"GAME OVER - You're in solitary confinement for 6 months.\n\n" +
					"To play again, press P.";
		if (Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}
	}
	
	void endgame_0() {
		text.text = "Wait! What..?!? Why would through the key out of the cell without " +
					"trying it out on the locked cell door? You need to work on your anger issues.\n\n" +
					"GAME OVER - You sit there day after day, month after month, wondering why you did that.\n\n" +
					"To play again, press P.";
		if (Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}
	}
}
