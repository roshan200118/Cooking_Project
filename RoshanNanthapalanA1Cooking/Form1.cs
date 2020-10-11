//Roshan Nanthapalan
//Sept.23.2017
/*Unit 1 Assignment
 * A learn to cook game.The player must get the order from the serve station to start making the burger.
 * The player must grill the bun (5- 10 seconds) and patty (60-70 seconds) with over cooking it. 
 * Then, they must put all the toppings including the bun and patty in the prep station for 15 seconds.
 * After 15 seconds the burger is created and they player must deliver the burger to the serve station.
 * The player must not burn the burger or patty and deliver the burger within 150 seconds to win.
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoshanNanthapalanA1Cooking
{
    public partial class Form1 : Form
    {
        // Start playing the StillDRE.wav file
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"StillDRE.wav");

        //Declaring the variable for the player's X and Y coordinates 
        int playerX, playerY;

        //Declaring the variables for the toppings' X and Y coordinates
        int bunX, bunY;
        int pattyX, pattyY;
        int lettuceX, lettuceY;
        int tomatoX, tomatoY;
        int ketchupX, ketchupY;

        //Declaring the variables for the burger's X and Y coordinates
        int burgerX, burgerY;

        //Declaring the variables for the home screen's (pnlHomeScreen) X and Y coordinates
        int homeScreenX, homeScreenY;

        //Declaring the variable to keep track of the bun's time on the grill
        int bunTimeOnGrill;

        //Declaring the variable to keep track of the patty's time on the grill
        int pattyTimeOnGrill;

        //Declaring the variable to keep track of the all the toppings' time on the prep station
        int toppingsTimeOnPrep;

        //Declaring the variable to keep track of time from when the player started
        int gameTime = 150;

        //Declaring the variable for when the toppings are on the prep station
        bool pattyOnPrep, bunOnPrep, tomatoOnPrep, lettuceOnPrep, ketchupOnPrep;

        //Declaring the variable for when the player moves up, down, left and right
        bool moveUp;
        bool moveDown;
        bool moveLeft;
        bool moveRight;
       
        //Declaring the variables for when the player picks up a topping
        bool pickupBun, pickupPatty, pickupLettuce, pickupTomato, pickupKetchup;

        //Declaring the variable for when the player picks up the burger 
        bool pickupBurger;

        //Declaring the variables for when the player drops a topping
        bool dropBun, dropPatty, dropLettuce, dropTomato, dropKetchup;

        //Declaring the variable for when the player drops the burger
        bool dropBurger;
        
        //Declaring the variable to pickup an item when you press "P"
        bool pickupItem;

        //Declaring the variable to drop an item when you press "R"
        bool dropItem;
        
        //Declaring the variable for when a player is holding an item
        bool playerItem;

        //Declaring the variable for when the bun is on the grill
        bool bunOnGrill;

        //Declaring the variable for when the patty is on the grill
        bool pattyOnGrill;

        //Declaring the variable for when the game starts
        bool startGame;

        //Declaring the variable for when the bun and patty are cooked
        bool bunCooked, pattyCooked;

        //Declaring the variable for when the toppings are on the counter 1
        bool ketchupOnCounter1, bunOnCounter1, pattyOnCounter1, lettuceOnCounter1, tomatoOnCounter1;

        //Declaring the variable for when the toppings are on the counter 2
        bool ketchupOnCounter2, bunOnCounter2, pattyOnCounter2, lettuceOnCounter2, tomatoOnCounter2;

        //Declaring the variable for when the toppings are on the counter 3
        bool ketchupOnCounter3, bunOnCounter3, pattyOnCounter3, lettuceOnCounter3, tomatoOnCounter3;

        //Declaring a variable for when there is an item on counter1, counter2 or counter3
        bool itemOnCounter1, itemOnCounter2, itemOnCounter3;

        public Form1()
        {
            InitializeComponent();

            //Starts to play the background music (StillDRE.wav)
            //The background music keeps on looping or replaying
            startSoundPlayer.Play();
            startSoundPlayer.PlayLooping();

            //The player's starts at point (539, 185)
            playerX = 539;
            playerY = 185;

            //Updates the player's location
            picPlayer.Location = new Point(playerX, playerY);

            //The home screen's location is (0,0) when you first start
            homeScreenX = 0;
            homeScreenY = 0;
            pnlHomeScreen.Location = new Point(homeScreenX, homeScreenY);

            //The player is not holding an item
            playerItem = false;

            //The bun's status label is invisible 
            lblBunStatus.Visible = false;

            //The patty's status label is invisible 
            lblPattyStatus.Visible = false;

            //The burger (picBurger) is invisible
            picBurger.Visible = false;

            //The status label tells the player what to do when they first play
            lblGameStatus.Text = "Go to the serve station\r\nand press 'P' to get your order";

            //The prep time label is invisible
            lblPrepTime.Visible = false;

            //The game hasn't started
            startGame = false;

            //The game's timer label is invisible
            lblGameTime.Visible = false;

            //The instructions label is invisible 
            lblInstructions.Visible = false;

            //The block legend is invisible
            picBlockLegend.Visible = false;

            //The game's timer is disabled so the player can't move
            tmrStartGame.Enabled = false;

            //The grills timer is disabled
            tmrGrill.Enabled = false;

            //The bun and patty are not cooked
            pattyCooked = false;
            bunCooked = false;

            //There is nothing on the counter
            itemOnCounter1 = false;
            itemOnCounter2 = false;
            itemOnCounter3 = false;

            //The program knows the toppings are not on the counter 1
            ketchupOnCounter1 = false;
            bunOnCounter1 = false;
            pattyOnCounter1 = false;
            lettuceOnCounter1 = false;
            tomatoOnCounter1 = false;

            //The program knows the toppings are not on the counter 2
            ketchupOnCounter2 = false;
            bunOnCounter2 = false;
            pattyOnCounter2 = false;
            lettuceOnCounter2 = false;
            tomatoOnCounter2 = false;

            //The program knows the toppings are not on the counter 3
            ketchupOnCounter3 = false;
            bunOnCounter3 = false;
            pattyOnCounter3 = false;
            lettuceOnCounter3 = false;
            tomatoOnCounter3 = false;

        }

        private void tmrStartGame_Tick(object sender, EventArgs e)
        {
            //If the "W" key is pressed the player moves up by 5 units and the location is updated
            if (moveUp==true)
            {
                playerY = playerY - 5;
                picPlayer.Location = new Point(playerX, playerY);
            }

            //If the "S" key is pressed the player moves down by 5 units and the location is updated
            if (moveDown == true)
            {
                playerY = playerY + 5;
                picPlayer.Location = new Point(playerX, playerY);
            }

            //If the "A" key is pressed the player moves left by 5 units and the location is updated
            if (moveLeft == true)
            {
                playerX = playerX - 5;
                picPlayer.Location = new Point(playerX, playerY);
            }

            //If the "D" key is pressed the player moves right by 5 units and the location is updated
            if (moveRight == true)
            {
                playerX = playerX + 5;
                picPlayer.Location = new Point(playerX, playerY);
            }

            //The player can't cross the prep table
            if (playerX <= 117)
            {
                playerX = 117;
            }

            //The player can't cross the serving table
            else if (playerX + picPlayer.Width >= 749)
            {
                playerX = 749 - picPlayer.Width;
            }

            //The player can't cross the top
            if (playerY <=0 + pnlStatus.Height)
            {
                playerY = 0 + pnlStatus.Height;
            }

            //The player can't cross the topping table
            else if (playerY >= 320)
            {
                playerY = 320;
            }

            //Updates the players new location
            picPlayer.Location = new Point(playerX, playerY);

            //If the player is in the bun's rectangle and he/she presses "P" and the player isn't holding an item and the bun isn't on the grill or prep station and the game has started and the bun isn't on any of the counters
            if (picPlayer.Bounds.IntersectsWith(rctBun.Bounds) == true && pickupItem == true && playerItem == false && bunOnGrill==false && bunOnPrep==false && startGame==true && bunOnCounter1==false && bunOnCounter2==false && bunOnCounter3==false)
            {
                //The bun doesn't go back to original location
                dropBun = false;
                
                //The player has picked up the top bun
                pickupBun = true;

                //The player is holding an item
                playerItem = true;
            }

            //If the player is in the bun's rectangle and he/she presses "R" and the player is holding an item and the item is a bun and the bun is not on the grill
            if (picPlayer.Bounds.IntersectsWith(rctBun.Bounds) == true && dropItem == true && playerItem == true && pickupBun == true && bunOnGrill == false)
            {
                //The bun goes back to its original location 
                dropBun = true;

                //The player is not holding a top bun 
                pickupBun = false;

                //The player doesn't have an item
                playerItem = false;
            }

            //If the bun is picked up, it follows the player's coordinates and the location is updated
            if (pickupBun == true)
            {
                bunX = playerX;
                bunY = playerY + 30;
                picBun.Location = new Point(bunX, bunY);
            }

            //If the bun is dropped, it goes to its original location
            if (dropBun == true)
            {
                bunX = 457;
                bunY = 434;
                picBun.Location = new Point(bunX, bunY);
            }

            //If the player is in the patty's rectangle and he/she presses "P" and the player isn't holding an item and the patty isn't on the prep or grill station and the patty isn't on the counter's and the game has started
            if (picPlayer.Bounds.IntersectsWith(rctPatty.Bounds) == true && pickupItem == true && playerItem == false && pattyOnGrill == false && pattyOnPrep == false && pattyOnCounter1 == false && pattyOnCounter2 == false && pattyOnCounter3 == false && startGame == true)
            {
                //The patty doesn't go back to its original location 
                dropPatty = false;

                //The player has picked up the patty
                pickupPatty = true;

                //The player is holding an item
                playerItem = true;
            }

            //If the player is in the patty's rectangle and he/she presses "R" and the player is holding an item and the item is a patty and the patty isn't on the grill
            if (picPlayer.Bounds.IntersectsWith(rctPatty.Bounds) == true && dropItem == true && playerItem == true && pickupPatty==true && pattyOnGrill==false)
            {
                //The patty goes back to its original location
                dropPatty = true;

                //The patty doesn't follow the player
                pickupPatty = false;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player has picked up the patty, it follows the player's coordinates and the location is updated
            if (pickupPatty == true)
            {
                pattyX = playerX;
                pattyY = playerY + 30;
                picPatty.Location = new Point(pattyX, pattyY);
            }

            //If the patty is dropped, it goes to its original location
            if (dropPatty == true)
            {
                pattyX = 380;
                pattyY = 435;
                picPatty.Location = new Point(pattyX, pattyY);
            }

            //If the player is in the lettuces rectangle and he/she presses "P" and the player isn't holding an item and the lettuce isn't on the prep station and the game has started and the lettuce isn't on any counter's
            if (picPlayer.Bounds.IntersectsWith(rctLettuce.Bounds) == true && pickupItem == true && playerItem == false && lettuceOnPrep == false && startGame == true && lettuceOnCounter1 == false && lettuceOnCounter2 == false && lettuceOnCounter3 == false)
            {
                //The lettuce doesn't go back to its original location
                dropLettuce = false;

                //The lettuce follows the player
                pickupLettuce = true;

                //The player is holding an item
                playerItem = true;
            }

            //If the player is in the lettuce's rectangle and he/she presses "R" and the player is holding an item and the item is lettuce
            if (picPlayer.Bounds.IntersectsWith(rctLettuce.Bounds) == true && dropItem == true && playerItem == true && pickupLettuce == true)
            {
                //The lettuce goes back to its original location
                dropLettuce = true;

                //The lettuce doesn't follow the player
                pickupLettuce = false;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player has picked up lettuce, it follows the player's coordinates and the location is updated
            if (pickupLettuce == true)
            {
                lettuceX = playerX;
                lettuceY = playerY + 30;
                picLettuce.Location = new Point(lettuceX, lettuceY);
            }

            //If the lettuce is dropped, it goes to its original location
            if (dropLettuce == true)
            {
                lettuceX = 299;
                lettuceY = 436;
                picLettuce.Location = new Point(lettuceX, lettuceY);
            }


            //If the player is in the tomato's rectangle and he/she presses "P" and the player isn't holding an item and the tomato isn't on the prep station and the game has started and the tomato isn't on any counter's
            if (picPlayer.Bounds.IntersectsWith(rctTomato.Bounds) == true && pickupItem == true && playerItem == false && tomatoOnPrep == false && startGame == true && tomatoOnCounter1 == false && tomatoOnCounter2 == false && tomatoOnCounter3 == false)
            {
                //The tomato doesn't go back to its original location
                dropTomato = false;

                //The tomato follows the player
                pickupTomato = true;

                //The player is holding an item
                playerItem = true;
            }

            //If the player is in the tomato's rectangle and he/she presses "R" and the player is holding an item and the item is tomato
            if (picPlayer.Bounds.IntersectsWith(rctTomato.Bounds) == true && dropItem == true && playerItem == true && pickupTomato == true)
            {
                //The tomato goes back to its original location
                dropTomato = true;

                //The tomato doesn't follow the player
                pickupTomato = false;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player has picked up tomato, it follows the player's coordinates and the location is updated
            if (pickupTomato == true)
            {
                tomatoX = playerX;
                tomatoY = playerY + 30;
                picTomato.Location = new Point(tomatoX, tomatoY);
            }

            //If the tomato is dropped, it goes to its original location
            if (dropTomato == true)
            {
                tomatoX = 228;
                tomatoY = 438;
                picTomato.Location = new Point(tomatoX, tomatoY);
            }


            //If the player is in the ketchup's rectangle and he/she presses "P" and the player isn't holding an item and the ketchup isn't on the prep station and the game has started and the ketchup isn't on any counter's
            if (picPlayer.Bounds.IntersectsWith(rctKetchup.Bounds) == true && pickupItem == true && playerItem == false && ketchupOnPrep == false && startGame == true && ketchupOnCounter1 == false && ketchupOnCounter2 == false && ketchupOnCounter3 == false)
            {
                //The ketchup doesn't go back to its original location
                dropKetchup = false;

                //The ketchup follows the player
                pickupKetchup = true;

                //The player is holding an item
                playerItem = true;
            }

            //If the player is in the ketchup's rectangle and he/she presses "R" and the player is holding an item and the item is ketchup and the ketchup isn't on the prep station
            if (picPlayer.Bounds.IntersectsWith(rctKetchup.Bounds) == true && dropItem == true && playerItem == true && pickupKetchup == true && ketchupOnPrep==false)
            {
                //The ketchup goes back to its original location
                dropKetchup = true;

                //The ketchup doesn't follow the player
                pickupKetchup = false;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player has picked up ketchup, it follows the player's coordinates and the location is updated
            if (pickupKetchup == true)
            {
                ketchupX = playerX;
                ketchupY = playerY + 30;
                picKetchup.Location = new Point(ketchupX, ketchupY);
            }

            //If the ketchup is dropped, it goes to its original location
            if (dropKetchup == true)
            {
                ketchupX = 576;
                ketchupY = 433;
                picKetchup.Location = new Point(ketchupX, ketchupY);
            }

            //If the player is in the grills bun's rectangle and he/she presses "R" and the player is holding an item and the item is a bun
            if (picPlayer.Bounds.IntersectsWith(rctBunGrill.Bounds) == true && dropItem == true && playerItem == true && pickupBun == true)
            {
                //The bun is on the grill
                bunX = 355;
                bunY = 131;
                picBun.Location = new Point(bunX, bunY);

                //The bun doesn't follow the player
                pickupBun = false;

                //The program knows the bun is on the grill
                bunOnGrill = true;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player is in the grill bun's rectangle and he/she presses "P" and the player isn't holding an item and the bun is on the grill
            if (picPlayer.Bounds.IntersectsWith(rctBunGrill.Bounds) == true && pickupItem == true && playerItem == false && bunOnGrill == true)
            {
                //The bun doesn't go back to original location
                dropBun = false;

                //The player has picked up the top bun
                pickupBun = true;

                //The player is holding an item
                playerItem = true;

                //The program knows the bun is not on the grill
                bunOnGrill = false;
            }

            //If the player is in the grill patty's rectangle and he/she presses "R" and the player is holding an item and the item is a patty 
            if (picPlayer.Bounds.IntersectsWith(rctPattyGrill.Bounds) == true && dropItem == true && playerItem == true && pickupPatty == true)
            {
                //The patty is on the grill
                pattyX = 462;
                pattyY = 133;
                picPatty.Location = new Point(pattyX, pattyY);

                //The patty doesn't follow the player
                pickupPatty = false;

                //The program knows the patty is on the grill
                pattyOnGrill = true;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player is in the grill patty's rectangle and he/she presses "P" and the player isn't holding an item and the patty is on the grill
            if (picPlayer.Bounds.IntersectsWith(rctPattyGrill.Bounds) == true && pickupItem == true && playerItem == false && pattyOnGrill == true)
            {
                //The patty doesn't go back to original location
                dropPatty = false;

                //The player has picked up the patty
                pickupPatty = true;

                //The player is holding an item
                playerItem = true;

                //The program knows the patty is not on the grill
                pattyOnGrill = false;
            }

            //If the player is in the prep station's rectangle and he/she presses "R" and the player is holding an item and the item is an uncooked bun
            if (picPlayer.Bounds.IntersectsWith(rctPrep.Bounds) == true && dropItem == true && playerItem == true && bunCooked == false && pickupBun==true)
            {
                //The lose subprogram runs
                Lose();

                //The game's status label tells the player they lost
                lblGameStatus.Text = "YOU LOSE\r\nTHE BUN IS UNCOOKED!";
            }

            //If the player is in the prep station's rectangle and he/she presses "R" and the player is holding an item and the item is an uncooked patty
            if (picPlayer.Bounds.IntersectsWith(rctPrep.Bounds) == true && dropItem == true && playerItem == true && pattyCooked == false && pickupPatty==true)
            {
                //The lose subprogram runs
                Lose();

                //The game's status label tells the player they lost
                lblGameStatus.Text = "YOU LOSE\r\nTHE PATTY IS UNCOOKED!";
            }


            //If the player is in the prep station's rectangle and he/she presses "R" and the player is holding an item and the item is a patty 
            if (picPlayer.Bounds.IntersectsWith(rctPrep.Bounds) == true && dropItem == true && playerItem == true && pickupPatty == true)
            {
                //The patty is on the prep table
                pattyX = 64;
                pattyY = 239;
                picPatty.Location = new Point(pattyX, pattyY);

                //The patty doesn't follow the player
                pickupPatty = false;

                //The program knows the patty is on the prep table 
                pattyOnPrep = true;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player is in the prep station's rectangle and he/she presses "R" and the player is holding an item and the item is a bun
            if (picPlayer.Bounds.IntersectsWith(rctPrep.Bounds) == true && dropItem == true && playerItem == true && pickupBun == true)
            {
                //The bun is on the prep station
                bunX = 12;
                bunY = 239;
                picBun.Location = new Point(bunX, bunY);

                //The bun doesn't follow the player
                pickupBun = false;

                //The program knows the bun is on the prep table
                bunOnPrep = true;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player is in the prep station's rectangle and he/she presses "R" and the player is holding an item and the item is ketchup
            if (picPlayer.Bounds.IntersectsWith(rctPrep.Bounds) == true && dropItem == true && playerItem == true && pickupKetchup == true)
            {
                //The ketchup is on the prep station
                ketchupX = 3;
                ketchupY = 315;
                picKetchup.Location = new Point(ketchupX, ketchupY);

                //The ketchup doesn't follow the player
                pickupKetchup = false;

                //The program knows the ketchup is on the prep table
                ketchupOnPrep = true;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player is in the prep station's rectangle and he/she presses "R" and the player is holding an item and the item is tomato
            if (picPlayer.Bounds.IntersectsWith(rctPrep.Bounds) == true && dropItem == true && playerItem == true && pickupTomato == true)
            {
                //The tomato is on the prep table
                tomatoX = 62;
                tomatoY = 166;
                picTomato.Location = new Point(tomatoX, tomatoY);

                //The tomato doesn't follow the player
                pickupTomato = false;

                //The program knows the tomato is on the prep table
                tomatoOnPrep = true;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player is in the prep station's rectangle and he/she presses "R" and the player is holding an item and the item is lettuce
            if (picPlayer.Bounds.IntersectsWith(rctPrep.Bounds) == true && dropItem == true && playerItem == true && pickupLettuce == true)
            {
                //The lettuce is on the prep table
                lettuceX = 62;
                lettuceY = 192;
                picLettuce.Location = new Point(lettuceX, lettuceY);

                //The lettuce doesn't follow the player
                pickupLettuce = false;

                //The programs knows the lettuce is on the prep table 
                lettuceOnPrep = true;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player is in the prep station's rectangle and he/she presses "P" and the player isn't holding an item and the burger is visible
            if (picPlayer.Bounds.IntersectsWith(rctPrep.Bounds) == true && pickupItem == true && playerItem == false && picBurger.Visible==true)
            {
                //The burger doesn't go back to original location
                dropBurger = false;

                //The player has picked up the burger
                pickupBurger = true;

                //The player is holding an item
                playerItem = true;

                //Tells the player to bring the burger to the serve station 
                lblGameStatus.Text = "Well Done!\r\nBring the burger to\r\nthe serve station";
            }

            //If the player is in the prep station's rectangle and he/she presses "R" and the player is holding an item and the item is a burger
            if (picPlayer.Bounds.IntersectsWith(rctPrep.Bounds) == true && dropItem == true && playerItem == true && pickupBurger == true)
            {
                //The burger goes back to its original location
                dropBurger = true;

                //The burger doesn't follow the player
                pickupBurger = false;

                //The player isn't holding an item 
                playerItem = false;
            }

            //If the player is in counter 1's rectangle and he/she presses "R" and the player is holding an item
            if (picPlayer.Bounds.IntersectsWith(rctCounter1.Bounds) == true && dropItem == true && playerItem == true)
            {
                //If the patty is picked up and the patty is not on the grill or prep station and there is no item on the counter 1
                if (pickupPatty == true && pattyOnGrill == false && pattyOnPrep == false && itemOnCounter1==false)
                {
                    //The patty is on counter 1
                    pattyX = 230;
                    pattyY = 114;
                    picPatty.Location = new Point(pattyX, pattyY);

                    //The patty doesn't follow the player
                    pickupPatty = false;

                    //The program knows the patty is on the counter 1
                    pattyOnCounter1 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on the counter 
                    itemOnCounter1 = true;
                }

                //If the bun is picked up and the bun is not on the grill or prep station and there is no item on the counter 1
                if (pickupBun == true && bunOnGrill == false && bunOnPrep == false && itemOnCounter1 == false)
                {
                    //The bun is on counter 1
                    bunX = 230;
                    bunY = 114;
                    picBun.Location = new Point(bunX, bunY);

                    //The bun doesn't follow the player
                    pickupBun = false;

                    //The program knows the bun is on the counter 1
                    bunOnCounter1 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 1
                    itemOnCounter1 = true;
                }

                //If the ketchup is picked up and the ketchup is not on the prep station and there is no item on the counter 1
                if (pickupKetchup == true && ketchupOnPrep == false && itemOnCounter1 == false)
                {
                    //The ketchup is on counter 1
                    ketchupX = 230;
                    ketchupY = 114;
                    picKetchup.Location = new Point(ketchupX, ketchupY);

                    //The ketchup doesn't follow the player
                    pickupKetchup = false;

                    //The program knows the ketchup is on the counter 1
                    ketchupOnCounter1 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 1
                    itemOnCounter1 = true;
                }

                //If the lettuce is picked up and the lettuce is not on the prep station and there is no item on the counter 1
                if (pickupLettuce == true && lettuceOnPrep == false && itemOnCounter1 == false)
                {
                    //The lettuce is on counter 1
                    lettuceX = 230;
                    lettuceY = 114;
                    picLettuce.Location = new Point(lettuceX, lettuceY);

                    //The lettuce doesn't follow the player
                    pickupLettuce = false;

                    //The program knows the lettuce is on the counter 1
                    lettuceOnCounter1 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 1 
                    itemOnCounter1 = true;
                }

                //If the tomato is picked up and the tomato is not on the prep station and there is no item on the counter 1
                if (pickupTomato == true && tomatoOnPrep == false && itemOnCounter1 == false)
                {
                    //The tomato is counter 1
                    tomatoX = 230;
                    tomatoY = 114;
                    picTomato.Location = new Point(tomatoX, tomatoY);

                    //The tomato doesn't follow the player
                    pickupTomato = false;

                    //The program knows the tomato is on the counter 1
                    tomatoOnCounter1 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 1 
                    itemOnCounter1 = true;
                }
            }

            //If the player is in counter 1's rectangle and he/she presses "P" and the player isn't holding an item and there is an item on the counter
            if (picPlayer.Bounds.IntersectsWith(rctCounter1.Bounds) == true && pickupItem == true && playerItem == false && itemOnCounter1==true)
            {
                //If the item is a bun
                if (bunOnCounter1 == true)
                {
                    //The bun follows the player
                    pickupBun = true;

                    //The player is holding an item
                    playerItem = true;

                    //The bun is not on counter 1
                    bunOnCounter1 = false;

                    //There is no item on counter 1
                    itemOnCounter1 = false;
                }

                //If the item is a patty
                if (pattyOnCounter1 == true)
                {
                    //The patty follows the player
                    pickupPatty = true;

                    //The player is holding an item
                    playerItem = true;

                    //The patty is not on counter 1
                    pattyOnCounter1 = false;

                    //There is no item on counter 1
                    itemOnCounter1 = false;
                }

                //If the item is lettuce 
                if (lettuceOnCounter1 == true)
                {
                    //The lettuce follows the player
                    pickupLettuce = true;

                    //The player is holding an item
                    playerItem = true;

                    //The lettuce is not on counter 1
                    lettuceOnCounter1 = false;

                    //There is no item on counter 1
                    itemOnCounter1 = false;
                }

                //If the item is a tomato 
                if (tomatoOnCounter1 == true)
                {
                    //The tomato follows the player
                    pickupTomato = true;

                    //The player is holding an item
                    playerItem = true;

                    //The tomato is not on counter 1
                    tomatoOnCounter1 = false;

                    //There is no item on counter 1
                    itemOnCounter1 = false;
                }

                //If the item is ketchup 
                if (ketchupOnCounter1 == true)
                {
                    //The ketchup follows the player
                    pickupKetchup = true;

                    //The player is holding an item
                    playerItem = true;

                    //The ketchup is not on counter 1
                    ketchupOnCounter1 = false;

                    //There is no item on counter 1
                    itemOnCounter1 = false;
                }
            }

            //If the player is in counter 2's rectangle and he/she presses "R" and the player is holding an item
            if (picPlayer.Bounds.IntersectsWith(rctCounter2.Bounds) == true && dropItem == true && playerItem == true)
            {
                //If the patty is picked up and the patty is not on the grill or prep station and there is no item on the counter 2
                if (pickupPatty == true && pattyOnGrill == false && pattyOnPrep == false && itemOnCounter2 == false)
                {
                    //The patty is on counter 1
                    pattyX = 606;
                    pattyY = 114;
                    picPatty.Location = new Point(pattyX, pattyY);

                    //The patty doesn't follow the player
                    pickupPatty = false;

                    //The program knows the patty is on the counter 2
                    pattyOnCounter2 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 2
                    itemOnCounter2 = true;
                }

                //If the bun is picked up and the bun is not on the grill or prep station and there is no item on the counter 2
                if (pickupBun == true && bunOnGrill == false && bunOnPrep == false && itemOnCounter2 == false)
                {
                    //The bun is on the counter 2
                    bunX = 606;
                    bunY = 114;
                    picBun.Location = new Point(bunX, bunY);

                    //The bun doesn't follow the player
                    pickupBun = false;

                    //The program knows the bun is on the counter 2
                    bunOnCounter2 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 2
                    itemOnCounter2 = true;
                }

                //If the ketchup is picked up and the ketchup is not on the prep station and there is no item on the counter 2
                if (pickupKetchup == true && ketchupOnPrep == false && itemOnCounter2 == false)
                {
                    //The ketchup is on counter 2
                    ketchupX = 606;
                    ketchupY = 114;
                    picKetchup.Location = new Point(ketchupX, ketchupY);

                    //The ketchup doesn't follow the player
                    pickupKetchup = false;

                    //The program knows the ketchup is on the counter 2
                    ketchupOnCounter2 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 2
                    itemOnCounter2 = true;
                }

                //If the lettuce is picked up and the lettuce is not on the prep station and there is no item on the counter 2
                if (pickupLettuce == true && lettuceOnPrep == false && itemOnCounter2 == false)
                {
                    //The lettuce is on counter 2
                    lettuceX = 606;
                    lettuceY = 114;
                    picLettuce.Location = new Point(lettuceX, lettuceY);

                    //The lettuce doesn't follow the player
                    pickupLettuce = false;

                    //The program knows the lettuce is on the counter 2
                    lettuceOnCounter2 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 2 
                    itemOnCounter2 = true;
                }

                //If the tomato is picked up and the tomato is not on the prep station and there is no item on the counter 2
                if (pickupTomato == true && tomatoOnPrep == false && itemOnCounter2 == false)
                {
                    //The tomato is on counter 2
                    tomatoX = 606;
                    tomatoY = 114;
                    picTomato.Location = new Point(tomatoX, tomatoY);

                    //The tomato doesn't follow the player
                    pickupTomato = false;

                    //The program knows the tomato is on the counter 2
                    tomatoOnCounter2 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 2
                    itemOnCounter2 = true;
                }
            }

            //If the player is in counter 2's rectangle and he/she presses "P" and the player isn't holding an item and there is an item on the counter 2
            if (picPlayer.Bounds.IntersectsWith(rctCounter2.Bounds) == true && pickupItem == true && playerItem == false && itemOnCounter2 == true)
            {
                //If the item is a bun
                if (bunOnCounter2 == true)
                {
                    //The bun follows the player
                    pickupBun = true;

                    //The player is holding an item
                    playerItem = true;

                    //The bun is not on counter 2
                    bunOnCounter2 = false;

                    //There is no item on counter 2
                    itemOnCounter2 = false;
                }

                //If the item is a patty
                if (pattyOnCounter2 == true)
                {
                    //The patty follows the player
                    pickupPatty = true;

                    //The player is holding an item
                    playerItem = true;

                    //The patty is not on counter 2
                    pattyOnCounter2 = false;

                    //There is no item on counter 2
                    itemOnCounter2 = false;
                }

                //If the item is lettuce 
                if (lettuceOnCounter2 == true)
                {
                    //The lettuce follows the player
                    pickupLettuce = true;

                    //The player is holding an item
                    playerItem = true;

                    //The lettuce is not on counter 2
                    lettuceOnCounter2 = false;

                    //There is no item on counter 2
                    itemOnCounter2 = false;
                }

                //If the item is a tomato 
                if (tomatoOnCounter2 == true)
                {
                    //The tomato follows the player
                    pickupTomato = true;

                    //The player is holding an item
                    playerItem = true;

                    //The tomato is not on counter 2
                    tomatoOnCounter2 = false;

                    //There is no item on counter 2
                    itemOnCounter2 = false;
                }

                //If the item is ketchup 
                if (ketchupOnCounter2 == true)
                {
                    //The ketchup follows the player
                    pickupKetchup = true;

                    //The player is holding an item
                    playerItem = true;

                    //The ketchup is not on counter 2
                    ketchupOnCounter2 = false;

                    //There is no item on counter 2
                    itemOnCounter2 = false;
                }
            }

            //If the player is in counter 3's rectangle and he/she presses "R" and the player is holding an item
            if (picPlayer.Bounds.IntersectsWith(rctCounter3.Bounds) == true && dropItem == true && playerItem == true)
            {
                //If the patty is picked up and the patty is not on the grill or prep station and there is no item on the counter 3
                if (pickupPatty == true && pattyOnGrill == false && pattyOnPrep == false && itemOnCounter3 == false)
                {
                    //The patty is on counter 3
                    pattyX = 668;
                    pattyY = 441;
                    picPatty.Location = new Point(pattyX, pattyY);

                    //The patty doesn't follow the player
                    pickupPatty = false;

                    //The program knows the patty is on the counter 3
                    pattyOnCounter3 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 3
                    itemOnCounter3 = true;
                }

                //If the bun is picked up and the bun is not on the grill or prep station and there is no item on the counter 3
                if (pickupBun == true && bunOnGrill == false && bunOnPrep == false && itemOnCounter3 == false)
                {
                    //The bun is on the counter 3
                    bunX = 668;
                    bunY = 441;
                    picBun.Location = new Point(bunX, bunY);

                    //The bun doesn't follow the player
                    pickupBun = false;

                    //The program knows the bun is on the counter 3
                    bunOnCounter3 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 3
                    itemOnCounter3 = true;
                }

                //If the ketchup is picked up and the ketchup is not on the prep station and there is no item on the counter 3
                if (pickupKetchup == true && ketchupOnPrep == false && itemOnCounter3 == false)
                {
                    //The ketchup is on counter 3
                    ketchupX = 668;
                    ketchupY = 441;
                    picKetchup.Location = new Point(ketchupX, ketchupY);

                    //The ketchup doesn't follow the player
                    pickupKetchup = false;

                    //The program knows the ketchup is on the counter 3
                    ketchupOnCounter3 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 3
                    itemOnCounter3 = true;
                }

                //If the lettuce is picked up and the lettuce is not on the prep station and there is no item on the counter 3
                if (pickupLettuce == true && lettuceOnPrep == false && itemOnCounter3 == false)
                {
                    //The lettuce is on counter 3
                    lettuceX = 668;
                    lettuceY = 441;
                    picLettuce.Location = new Point(lettuceX, lettuceY);

                    //The lettuce doesn't follow the player
                    pickupLettuce = false;

                    //The program knows the lettuce is on the counter 3
                    lettuceOnCounter3 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 3 
                    itemOnCounter3 = true;
                }

                //If the tomato is picked up and the tomato is not on the prep station and there is no item on the counter 3
                if (pickupTomato == true && tomatoOnPrep == false && itemOnCounter3 == false)
                {
                    //The tomato is on counter 3
                    tomatoX = 668;
                    tomatoY = 441;
                    picTomato.Location = new Point(tomatoX, tomatoY);

                    //The tomato doesn't follow the player
                    pickupTomato = false;

                    //The program knows the tomato is on the counter 3
                    tomatoOnCounter3 = true;

                    //The player isn't holding an item 
                    playerItem = false;

                    //There is an item on counter 3
                    itemOnCounter3 = true;
                }
            }

            //If the player is in counter 3's rectangle and he/she presses "P" and the player isn't holding an item and there is an item on the counter 3
            if (picPlayer.Bounds.IntersectsWith(rctCounter3.Bounds) == true && pickupItem == true && playerItem == false && itemOnCounter3 == true)
            {
                //If the item is a bun
                if (bunOnCounter3 == true)
                {
                    //The bun follows the player
                    pickupBun = true;

                    //The player is holding an item
                    playerItem = true;

                    //The bun is not on counter 3
                    bunOnCounter3 = false;

                    //There is no item on counter 3
                    itemOnCounter3 = false;
                }

                //If the item is a patty
                if (pattyOnCounter3 == true)
                {
                    //The patty follows the player
                    pickupPatty = true;

                    //The player is holding an item
                    playerItem = true;

                    //The patty is not on counter 3
                    pattyOnCounter3 = false;

                    //There is no item on counter 3
                    itemOnCounter3 = false;
                }

                //If the item is lettuce 
                if (lettuceOnCounter3 == true)
                {
                    //The lettuce follows the player
                    pickupLettuce = true;

                    //The player is holding an item
                    playerItem = true;

                    //The lettuce is not on counter 3
                    lettuceOnCounter3 = false;

                    //There is no item on counter 3
                    itemOnCounter3 = false;
                }

                //If the item is a tomato 
                if (tomatoOnCounter3 == true)
                {
                    //The tomato follows the player
                    pickupTomato = true;

                    //The player is holding an item
                    playerItem = true;

                    //The tomato is not on counter 3
                    tomatoOnCounter3 = false;

                    //There is no item on counter 3
                    itemOnCounter3 = false;
                }

                //If the item is ketchup 
                if (ketchupOnCounter3 == true)
                {
                    //The ketchup follows the player
                    pickupKetchup = true;

                    //The player is holding an item
                    playerItem = true;

                    //The ketchup is not on counter 3
                    ketchupOnCounter3 = false;

                    //There is no item on counter 3
                    itemOnCounter3 = false;
                }
            } 

            //If the player has picked up the burger, it follows the player and its location is updated
            if (pickupBurger == true)
            {
                burgerX = playerX;
                burgerY = playerY + 30;
                picBurger.Location = new Point(burgerX, burgerY);
            }

            //If the burger is dropped, it goes to its original location
            if (dropBurger == true)
            {
                burgerX = 49;
                burgerY = 239;
                picBurger.Location = new Point(burgerX, burgerY);
            }

            //If the player is holding item
            if (playerItem == true)
            {
                //The player can't pick up an item
                pickupItem = false;
            }

            //If the player is in the serve rectangle and he/she presses "P" and the player isn't holding an item
            if (picPlayer.Bounds.IntersectsWith(rctServe.Bounds) == true && pickupItem == true && playerItem == false)
            {
                //The order label shows the player what to make
                lblOrder.Text = "Order:Buns (cooked)\r\nKetchup\r\nPatty (cooked)\r\nLettuce\r\nTomatos";

                //Tells the player to start making the burger
                lblGameStatus.Text = "Make the burger!";

                //The game starts
                startGame = true;
            }

            //If the player is in the serve rectangle and he/she presses "R" and the player is holding an item and the item is a burger
            if (picPlayer.Bounds.IntersectsWith(rctServe.Bounds) == true && dropItem == true && playerItem == true && pickupBurger == true)
            {
                //The burger's coordinates is on the plate and the location is updated
                burgerX = 778;
                burgerY = 304;
                picBurger.Location = new Point(burgerX, burgerY);

                //The burger doesn't follow the player
                pickupBurger = false;

                //The player isn't holding an item 
                playerItem = false;

                //The game's status label tells the player they won
                lblGameStatus.Text = "YOU WIN!!";

                //The game's timer is off
                tmrStartGame.Enabled = false;

                //The game is done
                startGame = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //When you press the "W" key, move up is true  (the player moves up)
            if (e.KeyCode == Keys.W)
            {
                moveUp = true;
            }

            //When you press the "S" key, move down is true  (the player moves down)
            else if (e.KeyCode == Keys.S)
            {
                moveDown = true;
            }

            //When you press the "A" key, move left is true  (the player moves left)
            else if (e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }

            //When you press the "D" key, move right is true  (the player moves right)
            else if (e.KeyCode == Keys.D)
            {
                moveRight = true;
            }

            //When you press the "P" key, pickup item is true  (the player picks up an item)
            else if (e.KeyCode == Keys.P)
            {
                pickupItem = true;
            }

            //When you press the "R" key, dropItem is true  (the player drop the item)
            else if (e.KeyCode == Keys.R)
            {
                dropItem = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //If the "W" is not pressed, the player doesn't move up
            if (e.KeyCode == Keys.W)
            {
                moveUp = false;
            }

            //If the "S" is not pressed, the player doesn't move down
            if (e.KeyCode == Keys.S)
            {
                moveDown = false;
            }

            //If the "A" is not pressed, the player doesn't move left
            if (e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }

            //If the "D" is not pressed, the player doesn't move right
            if (e.KeyCode == Keys.D)
            {
                moveRight = false;
            }

            //If the "P" is not pressed, the player doesn't pickup an item
            if (e.KeyCode == Keys.P)
            {
                pickupItem = false;
            }

            //If the "R" is not pressed, the player doesn't drop items
            if (e.KeyCode == Keys.R)
            {
                dropItem = false;
            }
        }

        private void tmrGrill_Tick(object sender, EventArgs e)
        {
            //If the bun is on the gril
            if (bunOnGrill==true)
            {
                //The bun's timer (bunTimeOnGrill) counts by 1 every second
                bunTimeOnGrill = bunTimeOnGrill + 1;

                //The bun's timer label is updated to show the amount of seconds that has passed
                lblBunTimer.Text = "Bun's Time on Grill: " + bunTimeOnGrill.ToString();

                //The bun's status label is visible
                lblBunStatus.Visible = true;

                //The bun's status label says "THE BUN IS COOKING..."
                lblBunStatus.Text = "THE BUN IS COOKING...";
            }

            //If the bun is on the grill between 5 and 10 seconds
            if (bunTimeOnGrill>=5 && bunTimeOnGrill<=10)
            {
                //The picture of the bun (picBun) is changed to a toasted bun
                picBun.Image = RoshanNanthapalanA1Cooking.Properties.Resources.BunNormal;

                //The program knows bun is cooked
                bunCooked = true;

                //The bun's status label alerts the player that the bun is ready by saying "THE BUN IS READY!!"
                lblBunStatus.Text = "THE BUN IS READY!!";
            }

            //If the bun is on the grill for over 10 seconds
            else if (bunTimeOnGrill > 10)
            {
                //The picture of the bun (picBun) is changed to a burnt bun 
                picBun.Image = RoshanNanthapalanA1Cooking.Properties.Resources.BurntBun;

                //The bun's status label is alerts the player that the bun is burnt by saying "THE BUN IS BURNT!!"
                lblBunStatus.Text = "THE BUN IS BURNT!!";

                //The player loses and the lose subprogram runs
                Lose();
            }

            //If the patty is on the grill
            if (pattyOnGrill == true)
            {
                //The patty's timer (pattyTimeOnGrill) counts by 1 every second
                pattyTimeOnGrill = pattyTimeOnGrill + 1;

                //The patty's timer label is updated to show the player how many seconds has passed
                lblPattyTimer.Text = "Patty's Time on Grill: " + pattyTimeOnGrill.ToString();

                //The patty's status label is visible
                lblPattyStatus.Visible = true;

                //The patty's status label says "The patty is getting grilled"
                lblPattyStatus.Text = "The patty is getting grilled";
            }

            //If the patty is on the grill between 60 and 70 seconds 
            if (pattyTimeOnGrill >= 60 && pattyTimeOnGrill <= 70)
            {
                //The picture of the patty (picPatty) is changed to a grilled patty
                picPatty.Image = RoshanNanthapalanA1Cooking.Properties.Resources.GrilledPatty;

                //The program knows the patty is cooked
                pattyCooked = true;

                //The patty's status label is alerts the player that the patty is ready by saying "THE PATTY IS GRILLED!!"
                lblPattyStatus.Text = "THE PATTY IS GRILLED!!";
            }

            //If the patty is on the grill for over 70 seconds
            else if (pattyTimeOnGrill > 70)
            {
                //The picture of the patty (picPatty) is changed to a burnt patty 
                picPatty.Image = RoshanNanthapalanA1Cooking.Properties.Resources.BurnedPatty;

                //The patty's status label is alerts the player that the patty is burnt by saying "THE PATTY IS OVERCOOKED!!"
                lblPattyStatus.Text = "THE PATTY IS OVERCOOKED!!";

                //The player loses and the lose subprogram runs
                Lose();
            }

            //If all the toppings are on the prep station
            if (ketchupOnPrep == true && bunOnPrep == true && pattyOnPrep == true && lettuceOnPrep == true && tomatoOnPrep == true)
            {
                //The toppings timer counts every one second
                toppingsTimeOnPrep = toppingsTimeOnPrep + 1;

                //The prep time label is visible
                lblPrepTime.Visible = true;

                //The time that has passed from when all the toppings are on the prep station is displayed to inform the player
                lblPrepTime.Text = toppingsTimeOnPrep.ToString();
            }

            //If all the toppings are in the prep station for 15 or more seconds
            if (toppingsTimeOnPrep >= 15)
            {
                //The toppings are invisible 
                picKetchup.Visible = false;
                picBun.Visible = false;
                picPatty.Visible = false;
                picLettuce.Visible = false;
                picTomato.Visible = false;

                //The burger (picBurger) is visible
                picBurger.Visible = true;

                //The prep time label tells the player the burger is ready
                lblPrepTime.Text = "READY!";
            }

            //If the game started
            if (startGame == true)
            {
                //The game's timer label is visible
                lblGameTime.Visible = true;

                //The game's timer starts at 150 and subtracts 1 every second
                gameTime = gameTime - 1;

                //Shows the player how much time he/she has
                lblGameTime.Text = "You\r\nhave\r\n" + gameTime.ToString() + "\r\nseconds";
            }

            //If the game's timer is at 0, the player loses
            if (gameTime <= 0)
            {
                Lose();
            }
        }

        //A subprogram for when you lose 
        void Lose()
        {
            //The game's status label tells the player they lose
            lblGameStatus.Text = "YOU LOSE!!";

            //The grills timer is disabled
            tmrGrill.Enabled = false;

            //The game's timer is disabled so the player can't move
            tmrStartGame.Enabled = false;
        }



        /*private void btnReset_Click(object sender, EventArgs e)
        {
           
        }*/

        //A subprogram to reset the game or to give a fresh start
        void Reset()
        {
            //The player's starts off at point (539, 185)
            playerX = 539;
            playerY = 185;

            //Updates the player's location
            picPlayer.Location = new Point(playerX, playerY);

            //The player is not holding an item
            playerItem = false;

            //The bun's status label is invisible 
            lblBunStatus.Visible = false;

            //The patty's status label is invisible 
            lblPattyStatus.Visible = false;

            //The burger (picBurger) is invisible
            picBurger.Visible = false;

            //Tells the player what to do when they first play
            lblGameStatus.Text = "Go to the serve station\r\nand press 'P' to get your order";

            //The prep time label is invisible
            lblPrepTime.Visible = false;

            //The game hasn't started
            startGame = false;

            //The game's timer is invisible
            lblGameTime.Visible = false;

            //The bun is not on the grill
            bunOnGrill = false;

            //The patty is not on the grill
            pattyOnGrill = false;

            //The timer for when the patty is on the grill is 0
            pattyTimeOnGrill = 0;

            //The timer for when the bun is on the grill is 0
            bunTimeOnGrill = 0;

            //No toppings are on the prep station
            ketchupOnPrep = false;
            bunOnPrep = false;
            pattyOnPrep = false;
            lettuceOnPrep = false;
            tomatoOnPrep = false;

            //The burger is invisible 
            picBurger.Visible = false;

            //The burger goes back to its original location
            burgerX = 49;
            burgerY = 239;
            picBurger.Location = new Point(burgerX, burgerY);

            //The toppings time on the prep station is reset to 0 seconds
            toppingsTimeOnPrep = 0;

            //The prep time label is invisible
            lblPrepTime.Visible = false;

            //The time that has passed from when all the toppings are on the prep station is updated
            lblPrepTime.Text = toppingsTimeOnPrep.ToString();

            //The game's timer is at 150 seconds
            gameTime = 150;

            //The bun's grill timer is reset to 0 seconds
            bunTimeOnGrill = 0;

            //The bun's timer label is updated
            lblBunTimer.Text = "Bun's Time on Grill: " + bunTimeOnGrill.ToString();

            //The bun's status label is invisible
            lblBunStatus.Visible = false;

            //The patty's grill timer is reset to 0 seconds
            pattyTimeOnGrill = 0;

            //The patty's timer label is updated
            lblPattyTimer.Text = "Patty's Time on Grill: " + pattyTimeOnGrill.ToString();

            //The patty's status label is invisible
            lblPattyStatus.Visible = false;

            //The toppings don't follow the player
            pickupKetchup = false;
            pickupBun = false;
            pickupPatty = false;
            pickupLettuce = false;
            pickupTomato = false;

            //The bun is at its original location
            bunX = 457;
            bunY = 434;
            picBun.Location = new Point(bunX, bunY);

            //The picture of the bun (picBun) is changed to a normal uncooked bun
            picBun.Image = RoshanNanthapalanA1Cooking.Properties.Resources.BunGood;

            //The patty goes back to its original location
            pattyX = 380;
            pattyY = 435;
            picPatty.Location = new Point(pattyX, pattyY);

            //The picture of the patty (picPatty) is changed to a uncooked patty
            picPatty.Image = RoshanNanthapalanA1Cooking.Properties.Resources.RawMeat2;

            //The lettuce goes back to its original location
            lettuceX = 299;
            lettuceY = 436;
            picLettuce.Location = new Point(lettuceX, lettuceY);

            //The tomato goes back to its original location
            tomatoX = 228;
            tomatoY = 438;
            picTomato.Location = new Point(tomatoX, tomatoY);

            //The ketchup goes back to its original location
            ketchupX = 576;
            ketchupY = 433;
            picKetchup.Location = new Point(ketchupX, ketchupY);
            
            //All the toppings are visible
            picKetchup.Visible = true;
            picBun.Visible = true;
            picPatty.Visible = true;
            picLettuce.Visible = true;
            picTomato.Visible = true;

            //The order label is blank
            lblOrder.Text = "Order:";

            //The game's timer is enabled (the player can move)
            tmrStartGame.Enabled = true;

            //The grills timer is enabled
            tmrGrill.Enabled = true;

            //The instructions label is invisible 
            lblInstructions.Visible = false;

            //The block legend is invisible
            picBlockLegend.Visible = false;

            //The bun and patty are not cooked
            pattyCooked = false;
            bunCooked = false;

            //There is nothing on the counter
            itemOnCounter1 = false;
            itemOnCounter2 = false;
            itemOnCounter3 = false;

            //The program knows the toppings are not on the counter 1
            ketchupOnCounter1 = false;
            bunOnCounter1 = false;
            pattyOnCounter1 = false;
            lettuceOnCounter1 = false;
            tomatoOnCounter1 = false;

            //The program knows the toppings are not on the counter 2
            ketchupOnCounter2 = false;
            bunOnCounter2 = false;
            pattyOnCounter2 = false;
            lettuceOnCounter2 = false;
            tomatoOnCounter2 = false;

            //The program knows the toppings are not on the counter 3
            ketchupOnCounter3 = false;
            bunOnCounter3 = false;
            pattyOnCounter3 = false;
            lettuceOnCounter3 = false;
            tomatoOnCounter3 = false;
        }

        //A button that resets the game
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            //Resets the game
            Reset();
        }

        //A button that shows the instructions
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //Tells the player the story of the game and how to play
            //When you click on the instruction button the label and picturebox (picBlockLegend) is visible, 
            //if you click again it its invisible 
            if (lblInstructions.Visible == true)
            {
                lblInstructions.Visible = false;
                picBlockLegend.Visible = false;
            }

            else
            {
                lblInstructions.Visible = true;
                picBlockLegend.Visible = true;
            }

            //The intructions label tells the player how to play
            lblInstructions.Text = "Snoop Dogg has opened up a new restaruant!!\r\nHe must complete the order in time to get better reviews than McDonalds.\r\nYou have 150 seconds to make and serve the burger.\r\nYou can only hold one item at a time.\r\nThere are also 3 counters to place your food on.\r\nYou can only place one item on a counter at a time.\r\nYou must put the bun and patty on the grill before you put it on the prep station.\r\nThe BUN is baked between 5-10 seconds.\r\nThe PATTY is grilled between 60-70 seconds.\r\nALL the toppings must be in the prep station for 15 seconds to create the burger.\r\nOnce you create the burger, bring it to the serve station to win!\r\nYou lose if the bun or patty is under/overcooked or\r\nits been over 150 seconds after getting the order.\r\nW - move player up\r\nD - move player down\r\nA - move player left\r\nD - move player right\r\nP - pick up corresponding item for block colour\r\nR - drop corresponding item for block colour";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //The homescreen is invisible
            pnlHomeScreen.Visible = false;

            //Runs the reset program so player starts fresh
            Reset();
        }

        private void btnHomeScreen_Click(object sender, EventArgs e)
        {
            //The game is reset to give a fresh start for next time
            Reset();

            //The home screen is visible again
            pnlHomeScreen.Visible = true;
        }
    }
}
