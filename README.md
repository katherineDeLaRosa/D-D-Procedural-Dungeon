# D-D-Procedural-Dungeon
Senior Project Spring 2020  

  Okay so the file DnD Project is the unity file that need to be opened
  
  
  The algorithm to generate the dungeon room is as follows:
  
1.Create a empty grid where the rooms will be saved.

2.Create an initial room and save it in a rooms_to_create list.

3.While the number of rooms is less than a desired number “n”, repeat:

  1.Pick the first room in the rooms_to_create list
  2.Add the room to the grid in the correspondent location
  3.Create a random number of neighbors and add them to rooms_to_create
  
4.Connect the neighbor rooms.


