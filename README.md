# Project-2-Asteroid-clone-
//Project 2: Ultimate Asteroid Tactical-Control (UAT)

Your game must meet the following criteria:

//Controls//


The player can use the arrow left and right keys to rotate

The player can press the forward key to move forward

The player can press the spacebar to fire a bullet forward.

//Gameplay//

The player starts at the center of the screen.

Asteroids appear at a random spawn point and move towards the player's position at the time of the asteroid spawn (NOT "heat seeking")

There is also a random chance for an enemy ship to appear. 

This ship will attempt to ram the player by rotating towards the player and rushing at him.

No more than 3 enemies (asteroids or ships) exist in the game at one time

If 3 enemies already exist, the next enemy must wait for one to be destroyed before it can spawn

If a bullet collides with an enemy ship or asteroid, that enemy ship or asteroid is destroyed.

If an enemy ship or asteroid collides with the player, the player is destroyed, all enemy asteroids and ships are destroyed, and the 
player loses a life.

When the player has lost all of their lives, the game closes.

//Death before Dishonor//

The player dies if they go out of the boundaries of the game. 

Enemy Ships / Asteroids are destroyed if they go out of the boundaries of the game

Bullets are destroyed after a designer-set number of seconds

//Designer-Friendly Features//

The speed at which the player rotates can be set in the inspector by a designer

The speed at which a bullet moves can be set in the inspector by a designer

The speed at which a player moves can be set in the inspector by a designer

The speed at which asteroids move can be set in the inspector by a designer

The speed at which the enemy ship rotates and moves can be set in the inspector by a designer

The number of lives the player has can be set in the inspector by a designer

The types of "asteroids" spawned by the player are prefabs stored in a list that can be edited by designers. 

Designers can change the chances for an enemy ship to spawn by changing the number of enemy ships and asteroids are in this list -- for example: If there are 9 asteroids and 1 ship in this list, there is a 1 in 10 chance of the alien ship appearing.

The spawn points from which the asteroids can spawn are empty game objects that can be added to a list in the inspector.
