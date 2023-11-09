# Logbook
<h1>09/28/23</h1>
<h2>Physics Testing</h2>
I used Unity to create a project and made a sphere and a Platform in a 3D Space. Then I created scripts that would implement velocity functions to launch the sphere
that essentially would calculate what position the ball is supposed to be at in any moment in time then move the ball to that location. The script is also implemented in a way that velocity can be determined by a variable. This means that the variable can be changed in real time within Unity to change the parameters of the test on the fly. Because this physics engine has to ignore Unity's built in engine in order to function, the ball would end up ignoring any colliders and moving straight through the platform, so after some trouble shooting I determined to just have the ball stop in place once it reaches a certain position which coincides with the top of the platform.
<h2>Testing the Ball</h2>

![Alt Text](https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExMnk2OHA5aHJkYnlxN2owN2d5b29pcmdlc3Z6MW84anJob2I0NnVjaiZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/f5qyPB2a7vWfZ2Jztv/giphy.gif)

<h1>10/12/23</h1>
<h2>Creating the frisbee Simulation</h2>
I found a 3D model of a frisbee online and imported it into a new project on Unity and created a 100 unit long platform for the frisbee to travel on. I then created lines to section the platform into ten equal length segments of 10 units to easily measure how far the frisbee would travel with each trial and parameter. After that I started adding parameters to the frisbee starting with calculating velocity of the frisbee and adding gravity. Currently it is only moving like how a ball would, but there is currently a bug where the frisbee goes straight through the ground and never stops going down.

<h1>10/15/23</h1>
<h2>Adding More Parameters and Bug Fixing</h2>
I added multiple new parameters which would affect the frisbee and give it a more realistic flight pattern. These parameters included a launch angle which would affect both the initial velocity and direction of the frisbee and an adjustable wind speed which would push the frisbee up or down along with pushing it back. I also fixed the bug with the frisbee flying through the ground. Making your own physics engine means that the engine will force the frisbee to travel where the engine tells it to regardless of everything else around it, so I added a condition that would stop the frisbee if it reaches the y position that corresponds with the ground. Also fixed a bug that would make the frisbee rise infinitely because the lift force would only increase the y velocity. I did this by removing any lift force once the frisbee reaches its maximum x distance travelled.
<h2>Frisbee Test with 40 Units Initial Speed, 5 Units Wind Speed, and 25 Degree Angle</h2>

![Alt Text](https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExZjJ4ZmN2cWxkejlxa3N5d2lnaWJ5NGwzZTEyZm1iY3ZscmF4ZWJ4NiZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/IzZF7wmU4Sn9Gbh4xK/giphy.gif)