// Copyright (C) 2020 Kathrina Branco,  VFS, All Rights Reserved

using System;

namespace hello
{
    class Program
    {
        // following allong in class broke everything
        static void OldMain(string[] args)
        {
            Game game = New Game();
            game.Run();
        }
        {
            
            Console.WriteLine("Hello, welcome to adventure!");
            
            String location1 = "You wake up in a cold dark room. It smells of dust and alchohol.";
            Console.WriteLine(location1);
            String location1Line2 = "The room is too dark to explore right now.";
            Console.WriteLine(location1Line2);
            String location1Line3 = "There's a lit staircase. You decide to go up.";
            Console.WriteLine(location1Line3);

            String location2 = "You're now in a warm, well lit kitchen. There's a fireplace, a set of glass double doors, and a set of wooden double doors.";
            Console.WriteLine(location2);

            Console.WriteLine("What do you do?");
            Console.WriteLine("a) Go to fireplace and admire fire.");
            Console.WriteLine("b) Jostle locked wooden double doors.");
            Console.WriteLine("c) Go through the unlocked glass double doors.");

            string answer = Console.ReadLine();

            if (answer == "a") {
                //You need a torch to pick up the fire
            }

            if (answer == "b") {
                //You need a key to open these doors
            }

            if (answer == "c") {
                //You entre the greenhouse
            }



            String location3 = "You walk into the green house. It looks old and abandond.";
            Console.WriteLine(location3);
            String location3Line2 = "Theres an old torch on the ground.";
            Console.WriteLine(location3Line2);

            Console.WriteLine("What do you do?");
            Console.WriteLine("a) You pick up the torch.");
            Console.WriteLine("b) You leave the torch where it is.");

            string answer = Console.ReadLine();

            if (answer == "a") {
                //The torch will be added to the inventory
            }

            if (answer == "b") {
                //You leave the torch where it is
            }



            String location3Line3 = "You stand in the old greenhouse. There's nothing left for you to do in here.";
            Console.WriteLine(location3Line3);

            Console.WriteLine("What do you do?");
            Console.WriteLine("a) Go back into kitchen");

            string answer = Console.ReadLine();

            if (answer == "a") {
                //Player walks back into kitchen
            }



            String location2Line2 = "You are back in the kitchen.";
            Console.WriteLine(location2Line2);

            Console.WriteLine("What do you do?");
            Console.WriteLine("a) Go to fireplace and grab fire");
            Console.WriteLine("b) Go to locked wooden double doors");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player puts torch in fire and now lit torch is added to inventory
            }

            if (answer == "b") {
                //Player jostles locked doors. But they still need a key to open
            }



            String location2Line3 = "You remember the dark room you started in.";
            Console.WriteLine(location2Line3);

            Console.WriteLine("What do you do?");
            Console.WriteLine("a) Head back down stairs and explore dark room with torch out");
            Console.WriteLine("b) Go to locked double doors");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player heads down the lit stairway and enters the no longer dark room
            }

            if (answer == "b") {
                //Player jostles locked doors. They still need a key to open
            }



            String location1Line4 = "You are now in the room you woke up in, but it is no longer dark and you notice a key sitting on an old wine crate.";
            Console.WriteLine(location1Line4);

            Console.WriteLine("What do you do?");
            Console.WriteLine("a) Pick up key");
            Console.WriteLine("b) Leave key");

            String answer6 = Console.ReadLine();

            if (answer == "a") {
                //Player picks up the key and it is added to the players inventory
            }

            if (answer == "b") {
                //Player doesn't pick up the key.
            }



            String location1Line5 = "There is nothing left to do in the old wine celler";
            Console.WriteLine(location1Line5);

            Console.WriteLine("Do you want to head back up to the kitchen?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will head back up to the kitchen
            }

            if (answer == "b") {
                //Player will not progress forwards
            }



            String location2Line4 = "You are back in the kitchen.";
            Console.WriteLine(location2Line4);

            Console.WriteLine("Do you want to use your key on the locked double doors?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will loose the key from their inventory and entre new room. The kitchens are now complete
            }

            if (answer == "b") {
                //Player will not progress further
            }



            String location4Line1 = "You enter the grand dining hall. There are multiple doors arround the room. You wonder where they go.";
            Console.WriteLine(location4Line1);

            Console.WriteLine("What do you want to explore now?");
            Console.WriteLine("a) Go into the servants passageway");
            Console.WriteLine("b) Jostle the locked double doors opposite you");
            Console.WriteLine("c) Jostle the locked double doors farthest from you");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player enters the servants passageway
            }

            if (answer == "b") {
                //Player jostles locked double doors. They need a key
            }

            if (answer == "c") {
                //Player jostles locked double doors. They need a key
            }



            String location5Line1 = "You enter the servents passageway. You knowtice a fallen tree has blocked the path the only thing to interact with is a small table with a drawr.";
            Console.WriteLine(location5Line1);

            Console.WriteLine("Do you want to open the drawr?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will open drawr and knowtice a key
            }

            if (answer == "b") {
                //Player will be left standing there with nothing to do
            }



            String location5Line2 = "There is a small key at the bottom of the drawr";
            Console.WriteLine(location5Line2);

            Console.WriteLine("Would you like to put the key is your inventory?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will add the small key to inventory
            }

            if (answer == "b") {
                //Player will not progress
            }



            String location5Line3 = "There is nothing left to do here.";
            Console.WriteLine(location5Line3);

            Console.WriteLine("Leave the servants passageway?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer12 = Console.ReadLine();

            if (answer == "a") {
                //Player will go back to the grand dining hall
            }

            if (answer == "b") {
                //Player will not progress
            }



            String location4Line2 = "You reenter the grand dining hall.";
            Console.WriteLine(location4Line2);

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("a) Try the key on doors closest to you");
            Console.WriteLine("b) Try the key on doors across the room");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will unlock doo and be allowed to enter
            }

            if (answer =="b") {
                //Player will have to try the other door
            }



            String location6Line1 = "You enter the parler, there's a wonky bookcase and another pair of fouble doors";
            Console.WriteLine(location6Line1);

            Console.WriteLine("What do you want to explore?");
            Console.WriteLine("a) The wonky bookcase");
            Console.WriteLine("b) Jostle the double doors");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player knowtices something behind the bookcase
            }

            if (answer == "b") {
                //Player knowtices the lock on the double doors has been coroded. Theres no way these doors will be able to open, even with a key
            }



            String location6Line2 = "The bookcase looks to have something behind it!";
            Console.WriteLine(location6Line2);

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("a) Push the bookcase from the side");
            Console.WriteLine("b) Walk the bookcase towards you and away from the wall.");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will find a secret door
            }

            if (answer == "b") {
                //Player will get crushed to death by the bookcase
            }



            String location6Line3 = "There was a secret door behind the bookcase!";
            Console.WriteLine(location6Line3);

            Console.WriteLine("Do you want to enter the secret room?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will enter the secret room
            }

            if (answer == "b") {
                //Player will not progress further
            }



            String location7Line1 = "You enter the secret room and it's filled with books and a messy desk with a drawr ajar.";
            Console.WriteLine(location7Line1);

            Console.WriteLine("Would you like to pull the ajar drawr open?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will find a key
            }

            if (answer == "b") {
                //Player will not progress
            }



            String location7Line2 = "You open the drawr and find a small key";
            Console.WriteLine(location7Line2);

            Console.WriteLine("Would you like to add the small key to your inventory?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Small key is added to inventory
            }

            if (answer == "b") {
                //Player will not progress
            }



            String location7Line3 = "There's nothing left for you to do in here.";
            Console.WriteLine(location7Line3);

            Console.WriteLine("Exit back into the parlor?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will exit room
            }

            if (answer == "b") {
                //Player will not progress
            }



            String location6Line4 = "You rentered the parlor there is nothing left for you to do here.";
            Console.WriteLine(location6Line4);

            Console.WriteLine("Exit to grand dining room?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will walk into grand dining room
            }

            if (answer == "b") {
                //Player will not progress
            }



            string location4Line3 = "You reenter the grand dining hall.";
            Console.WriteLine(location4Line3);

            Console.WriteLine("Would you like to try opening the last of the double doors with your small key?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will unlock door
            }

            if (answer == "b") {
                //Player will not progress.
            }



            String location8Line1 = "You enter the Entrance hall. The front doors are wide open. You are almoast free!";
            Console.WriteLine(location8Line1);

            Console.WriteLine("What yould you like to do?");
            Console.WriteLine("a) Walk to the doors and admire the massive chanellier");
            Console.WriteLine("b) Run to the entrance, you've had enough of this place");

            String answer = Console.ReadLine();

            if (answer == "a") {
                //Player will notice the chandellier is about to come down and avoids it
            }

            if (answer == "b") {
                //Player will be crushed by falling chandellier
            }



            String location8Line2 = "You make it out alive! You win the game!";
            Console.WriteLine(location8Line2);



        }
    }
}
