# Logbook
<h1>09/28/23</h1>
<h2>Physics Testing</h2>
I used Unity to create a project and made a sphere and a Platform in a 3D Space. Then I created scripts that would implement velocity functions to launch the sphere
that essentially would calculate what position the ball is supposed to be at in any moment in time then move the ball to that location. The script is also implemented in a way that velocity can be determined by a variable. This means that the variable can be changed in real time within Unity to change the parameters of the test on the fly. Because this physics engine has to ignore Unity's built in engine in order to function, the ball would end up ignoring any colliders and moving straight through the platform, so after some trouble shooting I determined to just have the ball stop in place once it reaches a certain position which coincides with the top of the platform.
<h2>Testing the Ball</h2>

![Alt Text](https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExdTNlNWU2ZHJ6b3BuZnU3cHV1djB5bzdndmY0MDhpYmRlY3MzZDY5NiZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/Z5naT0r0Z1eVyXAFcT/giphy.gif)