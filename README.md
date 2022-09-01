# Description
* Dylan Convery
* D14124700
* TU856/4

This project is a scene recreation of the first two minutes of the dogfight scene from Cowboy Bebop: The Movie. It will be done using the Unity Game Engine. There will be a variety of systems at play such as steering behaviours, finite state machines and behaviour trees.

# Source Video
[![Source](https://img.youtube.com/vi/N-nRnddi7Q8/hqdefault.jpg)](https://www.youtube.com/watch?v=N-nRnddi7Q8)

# Video Demonstration
TODO

# Accomplishments
I'm happy I managed to get everything working and understand the steering behaviours, implementing the weighted prioritised truncated sum for the weighted steering behaviours, and just giving a nice feel to the scene.

# Event Summary
1. Swordfish II appears on screen
2. Spike is seen in cockpit
3. Spike noticed enemies on radar
4. Enemies fire missiles
5. Enemy point of view observing missiles take off
6. Reverse cockpit view of enemy in ship
7. Enemy ships bank left and speed up
8. Reverse cockpit view of spike cursing
9. Swordfish II taking evasive action 
10. Swordfish II barrel rolling and turning left while missiles follow
11. Missile 1 explodes
12. Missile 2 explodes and hits ground as Swordfish II speeds away
13. Enemy ship begins shooting
14. Enemy ship POV shooting at Swordfish II
15. Enemy ships pursue Swordfish II from above
16. Swordfish II flies alongside motorway
17. Swordfish II flies underneath motorway avoiding support poles
18. Sideview of enemy shooting at Swordfish II
19. Sideview of swordfish II being shot at
20. Cockpit view of enemy crashing into support pole
21. Sideview of enemy falling and exploding
22. Pan to remaining enemy ships continuing pursuit
23. Cockpit view of spike
24. 3rd person view of Swordfish II flying on above motorway
25. Scene fade out

# How it works
## Behaviours
* Arrive - Decelerate as you get closer to a target
* Boid - Acts as a main class for orchastrating the various steering behaviours
* Flee - Opposite of Seek in that it actively pushes away from a target
* FollowPath - Iterates over a list of waypoints allowing.
* Offset Pursue - Follow a target or leader with a set offset
* Path - Operates the list of waypoints
* Pursue - Follow a target 
* Seek - Actively apply force towards a target
* SteeringBehaviour - Abstract class to allow for a common interface among all steering behaviour types


# How to use
* Load project into Unity
* Press play

# Classes
* Arrive
* Boid
* Flee
* FollowPath
* Offset Pursue
* Path
* Pursue
* Seek
* SteeringBehaviour

# Storyboard
TODO

# Resources
* Swordfish Model: https://www.cgtrader.com/free-3d-models/space/spaceship/swordfish-51f381bd-c7fb-4ca1-a936-274607bef1c8
* Spitfire: https://quaternius.com/packs/ultimatespaceships.html
* 3D Realistic Terrain Free: https://assetstore.unity.com/packages/3d/environments/landscapes/3d-realistic-terrain-free-182593
* Skybox Series Free: https://assetstore.unity.com/packages/2d/textures-materials/sky/skybox-series-free-103633
* New Futuristic Jet Cockpit Wip-2 Version 1 Free 3D model: https://www.cgtrader.com/free-3d-models/aircraft/jet/new-futuristic-jet-cockpit-wip-2-version-1