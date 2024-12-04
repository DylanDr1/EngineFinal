# EngineFinal

Number : 1+8+9+8=26 (Even)


## Command 

The implementation for the command provides movement for the character (the gun) as well as the ability to shoot enemies and destroy them. Doing this allowed for the player to be able to play the game. Using this design pattern also allowed for the game to be easily editable, allowing for more possible actions to be put into the game if so desired. In addition the decoy reverses controls (Marked by the blue birds). 

![Command](https://github.com/user-attachments/assets/a8461908-b142-40d2-8618-ebe16d2a3d1f)


## Object Pooling


## Other pattern (DLL/Plugin)

For the additional pattern that has to be implemented I decided to implement some customization into the project in the form of a Plug-in. This plug-in allows for the ground to be changed to 3 different colours, rotating between white, red, and blue. This can be done by pressing the spacebar. Having this not only allows for a little bit of customization which is always a fun thing to have. As for the implementation of it, the reason I decided for it to be a plug-in is because it felt rather easy to implement into the game, this was because with the code being fairly simple, it allowed for easy implementation, all I needed to do after the fact was simply call for it by a script in unity, and putting the DLL file in, combining these together results in a functional implementation of the pattern. 

![DLL Code](https://github.com/user-attachments/assets/fc1a97fb-e2df-475a-87c9-0f13015f66f7)

![DLL Diagram](https://github.com/user-attachments/assets/5a49bf41-1a69-48f7-a274-24591d4b2e0d)

## Sources: 

Background assets: https://assetstore.unity.com/packages/2d/environments/free-stylized-2d-forest-mountains-nature-pack-226551

Gun asset: https://assetstore.unity.com/packages/3d/props/guns/revolver-gun-low-poly-221659

Birds: https://assetstore.unity.com/packages/3d/characters/animals/birds/living-birds-15649
