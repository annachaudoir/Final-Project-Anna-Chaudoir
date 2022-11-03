using System;
using System.Xml;

class HauntedHouseEscape
{
    public static void Main(string[] args)
    {
        int room = 1; //This keeps track of what room the player is in. 
        string response = ""; //This keeps track of what the player wants to do
        bool gameFinished = false;
        bool hasCode = false;
        
        
            while (gameFinished == false)
            { 
                    if (room == 1)
                    {
                        Outside();
                    }
                    else if (room == 2)
                    {
                        Entryway();
                    }
                    else if (room == 3)
                    {
                        UpHall();
                    }
                    else if (room == 4)
                    {
                        GhostRoom();
                    }
                    else if (room == 5)
                    {
                        WitchRoom();
                    }
                    else if (room == 6)
                    {
                        DownHall();
                    }
                    else if (room == 7)
                    {
                        VampireRoom();
                    }
                    else if (room == 8)
                    {
                         SpiderRoom();
                    }
                    else if (room == 9)
                    {
                        EscapeHouse();
                    }
             



            }
        
        void Outside() //room 1
        {
            Console.WriteLine("It is a cold, stormy, and dark night. It is the middle of October. You come across a haunted house, and you enter. The  door locks behind you, and now you must find a four digit code to escape. What would you like to do? Hint: type in LOOK.Hint 2: the words you must enter will have all the letters capitalized, but when you type it in please type it in       lowercase.");
            response = Console.ReadLine();
            if (response.Equals("look"))
            {
                room = 2;
            }
        }
        void Entryway() // room 2
        {
            Console.WriteLine("You are in an entryway of a haunted house. There are cobwebs and a black cat runs pasts you. There are two staircases. One leads downstairs and one leads upstairs. Where would you like to go; UP or DOWN?");
            response = Console.ReadLine();
            if (response.Equals("up")) //upstairs
            {
                room = 3;
            }
            else if (response.Equals("down"))//downstairs
            {
                room = 6;
            }

        }
        void UpHall()//room 3
        {
            Console.WriteLine("You run to the upstairs hallway. There is a door to your LEFT and a door to your RIGHT. Which door would you like to go in?");
            response = Console.ReadLine();
            if (response.Equals("right")) //ghosts
            {
                room = 4;  
            }
            else if (response.Equals("left"))
            {
                room = 5;
            }
            
        }
        void GhostRoom() //room 4
        {
            Console.WriteLine("You are in a gray room. It is empty besides a floating table and a chalk board. Suddenly, a chalk piece floats and writes a number 2 on the board. Congrats that is the first digit of the code to get out! What would you like to do; run ACROSS the hall, run DOWN to the basement, or go to the door to ENTER the code?");
            response = Console.ReadLine();
            if (response.Equals("across"))
            {
                room = 5;
            }
            if (response.Equals("down"))
            {
                room = 6;
            }
            else if (response.Equals("enter"))
            {
                EscapeHouse();
            }
        }
        void WitchRoom()//room 5
        {
            Console.WriteLine("You are in a dark purple room. In the center of the room a witch cackles while stiring a bubbling potion. Green smoke rises and forms the number 0 above the cauldron. Congrats that is the second digit of the code to get out! What would you like to do; run ACROSS the hall, run DOWN to the basement, or go to the door to ENTER the code?");
            response = Console.ReadLine();
            if (response.Equals("across"))
            {
                room = 4;
            }
            if (response.Equals("down"))
            {
                room = 6;
            }
            else if (response.Equals("enter"))
            {
                room = 9;
            }
        }
        void DownHall()//room 6
        {
            Console.WriteLine("You run to the basement hallway. There is a door AHEAD and a door BEHIND the stairs. Which door would you like to enter?");
            response = Console.ReadLine();
            if (response.Equals("ahead"))
            {
                room = 7;
            }
            else if (response.Equals("behind"))
            {
                room = 8;
            }
        }
        void VampireRoom() //room 7
        {
            Console.WriteLine("You are in a red room. There is a dark brown coffin in front of you. There is blood on the floor forming of the number 0. Congrats that is the third digit of the code to get out! What would you like to do; run ACROSS the hall, run UP to the 2nd floor, or go to the door to ENTER the code?");
            response = Console.ReadLine();
            if (response.Equals("across"))
            {
                room = 8;
            }
            if (response.Equals("up"))
            {
                room = 3;
            }
            else if (response.Equals("enter"))
            {
                EscapeHouse();
            }
        }
        void SpiderRoom() //room 8
        {
            Console.WriteLine("You are in a dark room. The light flickers and you see spiders scurry across the floor. The light flickers again and in the corneupr of the room there is a spider web forming the number 7. Congrats that is the fourth digit of the code to get out! What would you like to do; run ACROSS the hall, run UP to the 2nd floor, or go to the door to ENTER the code?");
            response = Console.ReadLine();
            if (response.Equals("across"))
            {
                room = 7;
            }
            if (response.Equals("up"))
            {
                room = 3;
            }
            else if (response.Equals("enter"))
            {
                room = 9;
            }
        }
        void EscapeHouse()
        {
            Console.WriteLine("You sprint to the front of the house. You come to the door with the keypad. Please enter the code in the digit order that was told.");
            response = Console.ReadLine();
            if(response.Equals("2007"))
            {
                Console.WriteLine("Congrats! You have escpaed the haunted house! Thank you for playing! Happy Halloween!");
                gameFinished = true;
                hasCode = true;
                for (int i = 0; i < 3; i++)
                {

                    Console.WriteLine("BOO!");
                }
            }
                
        }
    }
}  


