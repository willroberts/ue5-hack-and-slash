# UE5 Hack & Slash

A third-person hack & slash game developed with Unreal Engine 5.

This is a game I created while taking classes at [The Vertex School](https://www.vertexschool.com/) with instructor Abraham Kim.

The player has melee and ranged attacks, a dash skill, a homing missile ultimate skill, and the ability to use emotes. The level contains several enemies which lead to a final boss encounter.

This necessitated working with many Unreal Engine systems, including dynamic collision with channels, hit detection with component overlap, materials and meshes, animation montages, blend spaces, animation notifies for particle effects and sounds, emitters, the projectile system, AI navigation meshes, AI target detection with pawn sensing, and more.

The game’s logic is implemented in event-driven Blueprints, with performance-sensitive pieces such as Event Tick operations implemented in C++. I first developed the game with Unreal Engine 4, then reimplemented the game in Unreal Engine 5, making use of new features such as IK Rig Retargeting.

Art assets are from Paragon, Epic’s canceled third-person MOBA game.

## Project Setup

In order to run this game, additional content is needed from the Unreal Marketplace:

- Paragon: Minions
- Paragon: Muriel
- Paragon: Revenant
- Soul: Cave
- Starter Content

These will be referenced by the game, and must be present in order to load the
project. They are present in `.gitignore` to reduce the overall repo size.

## On Git LFS and BuiltData

While the game's map is only 9MB, the built level data is 310MB. This is well
above Github's 100MB limit on files, so Git LFS is necessary to clone the repo.