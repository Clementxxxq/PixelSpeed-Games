# PixelSpeed-Games

## Introduction
Turbo Rivals est un jeu de course dynamique où les joueurs affrontent des adversaires contrôlés par l'intelligence artificielle (IA) sur différents circuits. Les courses sont enrichies par un système d'objets spéciaux qui peuvent être utilisés stratégiquement pendant la course.

## Hiérarchie des Classes

### Class  A： TurboRivalsGame (Singleton)

| Attribut | Fonctions |
|-----:|---------------|
|circuits|setCircuits(),getCircuits()|
|currentRace|setCurrentRace(),getCurrentRace()|
|player|setPlayer(),getPlayer()|
|AIControllers|setAIControllers(),getAIControllers()|

| Méthodes |
|-----|
|startGame()|
|endGame()|
|loadRace()|


### Class  B： Vehicle (Abstract Factory Pattern)

| Attribut | Fonctions |
|-----:|---------------|
|speed|setSpeed(),getSpeed()|
|position|setPosition(),getPosition()|
|direction|setDirection(),getDirection()|
|boosts|setBoosts(),getBoosts()|

| Méthodes |
|-----|
|accelerate()|
|decelerate()|
|turnLeft()|
|turnRight()|
|useBoost()|


### Class  C： AIController

| Attribut | Fonctions |
|-----:|---------------|
|targetPosition|setTargetPosition(),getTargetPosition()|
|currentVehicle|setCurrentVehicle(),getCurrentVehicle()|

| Méthodes |
|-----|
|avoidObstacles()|


