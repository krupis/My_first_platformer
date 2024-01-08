#Lessons learnt

1. When tiles are tearing in 2D game, ensure the tilemaps Filter mode is set to Point (no filter)
2. Gravity OFF for 2d game (unless its platformer)
3. Tilemap collider only for collidable tiles, the floor is static and no colliders.
4. Use composide collider for tilemap colliders to avoid vortex colliders.