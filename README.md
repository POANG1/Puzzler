<h1>Puzzler</h1>
-- Patrick Camilleri
<br/><br/>

<h3>Introduction</h3>

<br/><h5>Statement of Purpose</h5>
Puzzler is a Virtual Reality application to help users new to VR, get familiar with immersive content using a familiar Simon Says kind of game.


<br/><h5>How it works</h5>
The VR User is shown a start screen which when dismissed, the user is slowly moved towards the inside of a dungeon like environment.  

In here multiple orbs hover in front of the user and these orbs light up in a random order. The user needs to remember the pattern and repeat it by clicking on the orbs individually and in the right order. 

Visual and audio feedback will guide the user according to whether he was successful or not.  If he fails, the pattern is reset. If he succeeds the user is moved outside the dungeon and a restart button becomes visible, to restart the game.

[![Puzzler Video](https://i.imgur.com/561Hvc5.png)](https://www.youtube.com/watch?v=QzhNBb8aeJ8)

<br/><h5>Target Audience (Persona)</h5>

<div style="text-align:center"><img src="./images/user testing.jpg" width=300></div>

<br/>**Name** - Steve Jones
<br/>**Age** - 32
<br/>**Position** - COO of a tech development company. Lawyer by profession.
<br/>**Intro** - Steve is the COO of a tech development company, leading the sales and marketing efforts of the company. He is married with a young child. He enjoys his work but is totally addicted to trying out new things that popup whilst browsing the Internet.  He is a typical tech savvy early adopter, and loves playing games in his spare time. 
<br/>**Quote** - "I love trying out new things, new services and new concepts"
<br/>**VR Experience** - First used VR 6 months ago

<br/><br/><h3>Design Sketches</h3>
	
<br/><h5>Positioning</h5>
Since the Cardboard VR provides a 3DF experience, Puzzler could be played both sitting down or standing up.

<div style="text-align:center"><img src="./images/user positioning.jpg" width=200/></div>

* The green lines above indicate what the user easily sees.
* The blue lines indicate what the user sees if he turns his gaze and head.
* The red lines indicate what the user sees only if he turns his whole body/head.



<br/><h5>Dungeon</h5>
<div style="text-align:center"><img src="./images/dungeon sketch.jpg" width=500/></div>

<br/><h5>Orbs</h5>

<div style="text-align:center"><img src="./images/orbs sketch.jpg" width=500/></div>
<br/><h5>Extra Details</h5>

<div style="text-align:center"><img src="./images/extra items sketch.jpg" width=500/></div>
<br/><h5>UI Menus</h5>

<div style="text-align:center"><img src="./images/UI Panels sketch.jpg" width=500/></div>

<br/><br/><h3>Building and Iterations</h3>
	
<br/><h5>Scaling</h5>
A small exercise was used to scale the dungeon appropriately. The idea was to give the user the feeling of not being small but neither big, and to be situated in an enclosed scary room (not suffocating, but not too large). I started by scaling a gate in line with real-life doors. Everything else followed that scale.

<div style="text-align:center"><img src="./images/Scaling door.png" width=500/></div>

<br/><h5>Building the dungeon</h5>
This stage involved placing all the walls, gates, tiles, floor tiles and roof tiles in the 3D space. Later the Orbs, barrels, chain links and side torches where added as well. A chained up mummy was added to one of the walls for an extra scary effect.  Lastly point lights where added on top of each torch to give some sombre dark scary lighting effect to the environment.

<div style="text-align:center"><img src="./images/dungeon ready v1.png" width=500/></div>

<div style="text-align:center"><img src="./images/dungeon ready v2.png" width=500/></div>

<div style="text-align:center"><img src="./images/Finishing touches.png" width=500/></div>

<br/><h5>Build UI menus</h5>
This stage involved building 2 UI Panels. One of the panels lets the user control the START of the game, whilst the other signifies the END of the game and gives the ability to the user of restarting Puzzler.

<div style="text-align:center"><img src="./images/UI testing.PNG" width=500/></div>

<br/><h5>Add movement</h5>
This stage involved installing iTween and placing Empty game objects in the 3D space to signify where the player should be moved to. The iTween library was used to move the camera (player) from the beginning of the game (in front of the START UI panel) to the PLAY section (in front of the orbs) to the END section (in front of the restart UI panel).

<br/><h5>Add game mechanics</h5>
A script was added to control when and how the orbs light up. The script also controls what happens when the user interacts with the orbs, ensuring that the light up pattern is reset if he loses the game, whilst moving the player forward towards the restart panel, if he wins.

<br/><h5>Add background audio</h5>
2 background clips on a loop where added, one for the outside environment, and one for inside the dungeon.

<br/><h5>Add visual and audio feedback</h5>
Visual and audio feedback was added to the orbs in the following manner:
- The orbs light up when a user gazes towards one of them.
- The orbs give out a distinctive sound when a user clicks one of them.
- If a player loses the game, he will hear a distinctive failure sound.

<br/><br/><h3>User Testing and Iterations</h3>
<br/><h5>Iteration 1</h5>
First Iteration involved building the above parts which worked very well when tested by users.  The dungeon looked good and showed the right type of atmosphere, the lights where good, the orbs where visible and the visual/audio feedback worked well. Game mechanics and movement was also good.  There was one key issue though.

At first I tried placing the orbs in a circle with the user being in the middle. Whilst the idea was interesting, when users (including myself) tested this in VR, one had to move very very rapidly around to catch a glimpse of which ball was lighting up. That fast movement gave the testers a mild case of motion sickness. 

<div style="text-align:center"><img src="./images/wrong layout.PNG" width=500/></div>

<br/><h5>Iteration 2</h5>
In the second iteration I fixed a number of small issues, like some objects where not perfectly aligned. But the biggest fix was the placing of the orbs. The new setup involved viewing the orbs in a semi-circle line in front of the user.  This meant no more sudden movements necessary to play the game, improving the experience considerably.

<div style="text-align:center"><img src="./images/good layout.PNG" width=500/></div>

<br/>The problem that this iteration had was the users did not know what to do when confronted with the orbs (even though the visual and audio feedback was working). They eventually realized on their own after a few seconds that this was a Simon's Says type of game, but by then they had already asked me "what do I do now?".

<br/><h5>Iteration 3</h5>
This iteration introduced a new panel called the "How To Panel" in front of the orbs. This explained what a user needed to do to play the game and provided a button to initiate the lighting up pattern. Another button was added below the user's view (close to where the feet would be). This button moves with the user and provides a restart functionality from anywhere inside the game.


<br/><br/><h3>Conclusion</h3>

The experience and knowledge obtained building this simple game was pretty huge. I learned the basics of VR design, as well as the little intricacies which affect a user's experience. The fact I got my friends to try it out and give me feedback provided a way for me to learn the best design for this particular experience, which could very well be different from other VR experiences.

**Lesson learned: Iteration and User Testing is KEY!**


<br/><br/><h3>Possible Improvements</h3>

* Add mountainous background
* Add scores
* Add more levels
* Add more rooms
* Some walls are not perfectly aligned and are flickering on mobile VR.