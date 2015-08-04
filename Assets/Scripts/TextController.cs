using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
		cell, cell_0, cell_1, cell_2, mirror, mirror_0, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, 
		corridor_0, corridor_0a, corridor_0b, corridor_0c, stairs_0, stairs_1, closet_door, 
		floor, corridor_1, corridor_1a, corridor_2, courtyard, endgame, endgame_0, endgame_1, endgame_2, endgame_3, endgame_4, endgame_5, endgame_6
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
		else if (myState == States.stairs_0) 	{stairs_0();}
		else if (myState == States.stairs_1) 	{stairs_1();}
		else if (myState == States.closet_door) {closet_door();}
		else if (myState == States.floor)	 	{floor();}
		else if (myState == States.corridor_1)	{corridor_1();}
		else if (myState == States.corridor_1a)	{corridor_1a();}
		else if (myState == States.corridor_2)	{corridor_2();}
		else if (myState == States.courtyard)	{courtyard();}
		else if (myState == States.endgame) 	{endgame();}
		else if (myState == States.endgame_0) 	{endgame_0();}
		else if (myState == States.endgame_1) 	{endgame_1();}
		else if (myState == States.endgame_2) 	{endgame_2();}
		else if (myState == States.endgame_3) 	{endgame_3();}
		else if (myState == States.endgame_4) 	{endgame_4();}
		else if (myState == States.endgame_5) 	{endgame_5();}
		else if (myState == States.endgame_6) 	{endgame_6();}
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
					"floor, stairs leading up to ???, and a closed closet door.\n\n" +
					"Press F to look at floor, S to walk upstairs, C to open closed door, or Y to yell for help.";
		if 		(Input.GetKeyDown(KeyCode.F)) 	{myState = States.floor;}
		else if (Input.GetKeyDown(KeyCode.S)) 	{myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.C)) 	{myState = States.closet_door;}
		else if (Input.GetKeyDown(KeyCode.Y)) 	{myState = States.endgame;}
	}
	
	void corridor_0a() {
		text.text = "You could do several things - agian. Maybe stare at floor again, do a Ninja kick to the locked door, " +
					"or down stairs to possible freedom. Either way, you want out - NOW!!!\n\n" +
					"Press F to look at the floor again, K to kick in the locked door, or S to head downstairs.";
		if 		(Input.GetKeyDown (KeyCode.F))	{myState = States.floor;}
		else if (Input.GetKeyDown (KeyCode.K))	{myState = States.endgame_2;}
		else if (Input.GetKeyDown (KeyCode.S))	{myState = States.stairs_0;}
	}
	
	void floor() {
		text.text = "You look at the floor and notice a hairpin with clump of hair still in it. Wonder what happen " +
					"the hairs owner? Looks like the hair was ripped of their head, hairpin and all..." +
					"You quickly try to think what to do with this hairpin.\n\n" +
					"Press P to Pickup hairpin and try to unlock the door, B to brake the hairpin out of rage, or R to return to corridor.";
		if 		(Input.GetKeyDown(KeyCode.P)) 	{myState = States.closet_door;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.corridor_0a;}
		else if (Input.GetKeyDown(KeyCode.B)) 	{myState = States.endgame_3;}
	}
	
	void stairs_0() {
		text.text = "You tip toe up the stairs to the lower level, but notice a guard watching a good game of " +
					"Seattle Seahawks by another cell door. Occasionally you here him cheer and scream, 'GO! GO! GO! - TOUCHDOWN!!!\n\n" +
					"Press C Cheer with him, or R to return to corridor.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.corridor_0a;}
		else if (Input.GetKeyDown(KeyCode.C)) 	{myState = States.endgame_1;}
	}
	
	void stairs_1() {
	
	}
	
	void closet_door() {
		text.text = "As you twist the hairpin into something that looks like a mangled key, you decide to try to slowly " +
					"insert it into the locked closet door. To your surprise, the clank of an unlocked door briefly echoed throughout " +
					"the corridor. You freeze, slowly open the door and see a Seahawks jersey and a janitor jumpsuit.\n\n" +
					"Press S to put on Seahawk Jersey and return to corridor, or J to put on the Janitor jumpsuit and return to corridor.";
		if 		(Input.GetKeyDown(KeyCode.S)) 	{myState = States.corridor_1;}
		else if (Input.GetKeyDown(KeyCode.J)) 	{myState = States.corridor_2;}
	}
	
	void corridor_1() {
		text.text = "After putting on the Seahawks jersey, you start heading downstairs. As you creep down the stairs, you " +
					"hear a guard cheering for the Seahawks! Maybe he'll think that you're a guard coming to cheer with him? " +
					"At halftime you might be able to slip out to FREEDOM?\n\n" +
					"Press T to trick the guard into opening the locked door, or creep back into closet and try Janitor jumpsuit.";
		if 		(Input.GetKeyDown(KeyCode.T)) 	{myState = States.endgame_4;}
		else if (Input.GetKeyDown(KeyCode.J)) 	{myState = States.corridor_1a;}
	}
	
	void corridor_1a() {
		text.text = "You creep back into the closet again. As you get in, you quietly put on the Janitor jumpsuit. " +
					"You feel comfortable and natural in the Acme Janitor Service jumpsute. You think you could possibly " +
					"see if they have any job openings when you escape? Hmmmm... Either way, you have some options.\n\n" +
					"Press S to head downstairs or R to Return to corridor";
		if 		(Input.GetKeyDown(KeyCode.S)) 	{myState = States.endgame_5;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.corridor_2;}
	}
	
	void corridor_2() {
		text.text = "As you return to the corridor, you hear a guard yelling and cursing down the stairs. As you start to " +
					"panic, you hear him yell at you! In fear, you freeze. He yells to you, 'I've spilt my beverage all over myself " +
					"bring the mop bucket and cleanup this mess! While you're cleaning, I'll change out in my uniform.' He opens the " +
					"last locked cell door to his control room. He grab mop and run into the control room. He slammed the cell door " +
					"shut and headed out. Once in the room, you notice a door leading to an open courtyard.\n\n" +
					"Press C to bolt out into the Courtyard or M to start Mopping up the mess.";
		if 		(Input.GetKeyDown(KeyCode.C)) 	{myState = States.endgame_6;}
		else if (Input.GetKeyDown(KeyCode.M)) 	{myState = States.courtyard;}
	}
	
	void courtyard() {
		text.text = "As you stand there in the guards watch cell with a dry mop, you notice you don't have a mop bucket. As you look " +
					"outside, the guard opens the door and said, 'Your mop bucket is outside and ready to be filled with soapy water.' " +
					"He opens the door as you walk out. You hear the door shut as you reach for the bucket. You then look up and see that " +
					"the front gate to the prison is open because it's being serviced. What do you do?!?!?!\n\n" +
					"YOU RUN, that's what you do!!! YOU'RE FREE!!!! You've won!!!";
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
	
	void endgame_1() {
		text.text = "As you start CHEERING for the Hawks, you hear the rush of the guards from all over the place. " +
					"The next thing you know, you're getting maced with pepper spary and you wake up in " +
					"dark cell with padding several hours later.\n\n" +
					"GAME OVER - You're in solitary confinement for 6 months.\n\n" +
					"To play again, press P.";
		if (Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}
	}
	
	void endgame_2() {
		text.text = "You get into your proper Ninja stance to perform the perfect kick to the door... " +
					"BOOM! You kick it with the precision of an unseasoned white belt. Sadly, you lack the Ninja skills " +
					"to open the door with true inteligence.\n\n" +
					"GAME OVER - You sit there day after day, month after month, wondering why you did that.\n\n" +
					"To play again, press P.";
		if (Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}
	}
	
	void endgame_3() {
		text.text = "Out of pure rage, you use all your muscle and snap the hairpin in half. Well...at least " +
					"you tried to. Looks like the hairpin is stronger than you! Through the grunts of trying to" +
					"break the hairpin, the guards heard and rushed in and tackled you.\n\n" +
					"GAME OVER - You sit there day after day, month after month, wondering why you did that.\n\n" +
					"To play again, press P.";
		if (Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}
	}
	
	void endgame_4() {
		text.text = "You start cheering for the Seahawks and the guard looks at you with a confused look... " +
					"He then bacame aware that someone was wearing HIS Seahawk jersey that was hung in the closet to dry " +
					"from a spilt beer... The next thing you know, you're getting maced with pepper spary and you wake up in." +
					"dark cell with padding several hours later." +
					"GAME OVER - You sit there day after day, month after month, wondering why you did that.\n\n" +
					"To play again, press P.";
		if (Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}
	}
	
	void endgame_5() {
		text.text = "As you head downstairs, the guard looks at you with a confused look then surprise... " +
					"The next thing you know, you're getting maced with pepper spary and you wake up in." +
					"dark cell with padding several hours later." +
					"GAME OVER - You sit there day after day, month after month, wondering why you did that.\n\n" +
					"To play again, press P.";
		if (Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}
	}
	
	void endgame_6() {
		text.text = "As you mop up the mess, you realize that this would be a great references for my potential Janitor job " +
					"interview. As you daydream of all the wonders of the job, the guard returns and noticed that your not " +
					"Billy, the well known prison janitor. His lucky mop pale was drying in the sun out in the courtyard! " +
					"The next thing you know, you're getting maced with pepper spary and you wake up in a dark cell with padding several hours later." +
					"GAME OVER - You sit there day after day, month after month, wondering why you did that.\n\n" +
					"To play again, press P.";
		if (Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}
	}
}
